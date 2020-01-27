using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.IO;
using System.Linq;
using System.Drawing.Imaging;
using Ghostscript.NET.Rasterizer;
using System.Windows.Forms;
using S22.Imap;
using System.Diagnostics;
using ImageMagick;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;


namespace AttachmentProcessing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GetSettings();
        }

        static string outputFolder = "";
        static string outputFolderNew = "";
        string cropImgIn = "";
        string cropImgOut = "";

        public static void WriteConfig(string key, string val)
        {
            Properties.Settings.Default[key] = val;
            Properties.Settings.Default.Save();
        }

        public void GetSettings()
        {
            txtAddress.Text = ReadConfig("emailAddress");
            txtPassword.Text = Decrypt(ReadConfig("password"));
            txtMailbox.Text = ReadConfig("mailbox");
            txtEmailServer.Text = ReadConfig("server");
            txtDownloadFolder.Text = ReadConfig("download");
            txtProcessFolder.Text = ReadConfig("process");
            txtRenamedFolder.Text = ReadConfig("renamed");
            txtPythonFolder.Text = ReadConfig("python");
            txtFrom.Text = Properties.Settings.Default.fromCrop.X.ToString() + "," + Properties.Settings.Default.fromCrop.Y.ToString();
            txtTo.Text = Properties.Settings.Default.toCrop.X.ToString() + "," + Properties.Settings.Default.toCrop.Y.ToString();
            txtDpi.Text = Properties.Settings.Default.dpi.ToString();

            outputFolder = txtProcessFolder.Text;
            outputFolderNew = txtRenamedFolder.Text;
        }

        public static string ReadConfig(string key)
        {
            //return System.Configuration.ConfigurationManager.UserSettings[key].ToString();
            return Properties.Settings.Default[key].ToString();
        }

        public void UpdateSettings(string configName, string newText, string activityText, bool includeValues)
        {
            string prevText = ReadConfig(configName);
            string values = includeValues ? " [" + prevText + "] to [" + newText + "]" : "";
            WriteConfig(configName, newText);
            WriteActivity(activityText + values);
        }

        public void WriteActivity(string msg)
        {
            var dt = DateTime.Now.ToString("yy-MM-dd HH:mm:ss");
            string[] arr = new string[3];
            ListViewItem itm;
            //add items to ListView
            arr[0] = dt;
            arr[1] = msg;
            itm = new ListViewItem(arr);

            lvProcessing.Items.Add(itm);
        }

        public static string GetTextAfter(string str, char c)
        {
            if (str == null)
            {
                return "";
            }
            var result = str.Substring(str.LastIndexOf(c) + 1);
            return result;
        }

        public string DownloadAttachments()
        {
            string hostname = txtEmailServer.Text,
            username = txtAddress.Text,
            password = txtPassword.Text,
            mailbox = txtMailbox.Text,
            attachmentDirectory = txtDownloadFolder.Text,
            msg_ret = "";
            int att_count = 0;

            try
            {
                using (ImapClient client = new ImapClient(hostname, 993, username, password, AuthMethod.Login, true))
                {
                    WriteActivity("Connected to server '" + hostname + "'");
                    client.DefaultMailbox = mailbox;

                    // Returns a collection of identifiers of all mails matching the specified search criteria.
                    IEnumerable<uint> uids;
                    if (chkDate.Checked)
                    {
                        uids = client.Search(SearchCondition.SentSince(dptDownload.Value.Date));
                    }
                    else
                    {
                        uids = client.Search(SearchCondition.All());
                    }

                    // Download mail messages from the default mailbox.
                    IEnumerable<MailMessage> messages = client.GetMessages(uids);

                    for (int i = 0; i < messages.Count(); i++)
                    {
                        string str1 = messages.ElementAt(i).Subject.ToString();
                        int cnt_attach = messages.ElementAt(i).Attachments.Count;
                        if (cnt_attach > 0)
                        {
                            var att = messages.ElementAt(i).Attachments[0];

                            //string filename = string.Format(@"{0}{1}_{2}{3}", attachmentDirectory,
                            //    Path.GetFileNameWithoutExtension(att.Name), DateTime.Now.AddSeconds(i).ToString("MMddyyyyhhmmss"), Path.GetExtension(att.Name));
                            string filename = string.Format(@"{0}{1}{2}{3}", attachmentDirectory,
                            "DOC", DateTime.Now.AddSeconds(i).ToString("MMddyyyyhhmmss"), Path.GetExtension(att.Name));
                            var file_att = att.ContentStream;
                            using (System.IO.FileStream output = new System.IO.FileStream(filename, FileMode.Create))
                            {
                                file_att.CopyTo(output);
                                WriteActivity(Path.GetFileName(att.Name) + " downloaded to " + attachmentDirectory);
                            }

                        }
                        att_count = i;
                    }
                    msg_ret = att_count.ToString() + " attachment(s) downloaded from mailbox " + mailbox + " to folder " + attachmentDirectory;
                }
            }
            #pragma warning disable CA1031 // Do not catch general exception types


            catch (Exception e)
            #pragma warning restore CA1031 // Do not catch general exception types
            {
                LogError(e.Message);
                MessageBox.Show(e.Message);
            }
            finally
            {
                //write_activity(msg_ret);
            }
            return (msg_ret);
        }

        public void DirectorySearch(string dir)
        {
            try
            {
                foreach (string f in Directory.GetFiles(dir))
                {
                    WriteActivity(Path.GetFileName(f) + "####");
                }
                foreach (string d in Directory.GetDirectories(dir))
                {
                    WriteActivity(Path.GetFileName(d));
                    DirectorySearch(d);
                }
            }
            catch (System.Exception ex)
            {
                LogError(ex.Message);
            }
        }

        void PdfToPng(string inputFile, string outputFileName)
        {
            string msg = "Invalid numeric value";
            int dpi = ParseInt(txtDpi.Text, out bool valid);
            if (!valid)
            {
                LogError(msg);
                return;
            }
            var xDpi = dpi; //set the x DPI
            var yDpi = dpi; //set the y DPI
            var pageNumber = 1; // the pages in a PDF document

            using (var rasterizer = new GhostscriptRasterizer()) //create an instance for GhostscriptRasterizer
            {
                rasterizer.Open(inputFile); //opens the PDF file for rasterizing
                Console.WriteLine("In Path: " + inputFile);
                Console.WriteLine("In Count: " + rasterizer.PageCount.ToString());

                //set the output image(png's) complete path
                var outputPNGPath = Path.Combine(outputFolder, string.Format("{0}.png", outputFileName));
                Console.WriteLine("Out: " + Path.Combine(outputFolder, string.Format("{0}.png", outputFileName)));

                //converts the PDF pages to png's 
                var pdf2PNG = rasterizer.GetPage(xDpi, yDpi, pageNumber);

                //save the png's
                pdf2PNG.Save(outputPNGPath, ImageFormat.Png);

                Console.WriteLine("Saved " + outputPNGPath);
            }
        }

        void PdfToJpg(string inputFile, string outputFileName)
        {
            string msg = "Invalid numeric value";
            int dpi = ParseInt(txtDpi.Text, out bool valid);
            if (!valid)
            {
                LogError(msg);
                return;
            }
            var xDpi = dpi; //set the x DPI
            var yDpi = dpi; //set the y DPI
            var pageNumber = 1; // the pages in a PDF document

            using (var rasterizer = new GhostscriptRasterizer()) //create an instance for GhostscriptRasterizer
            {
                rasterizer.Open(inputFile); //opens the PDF file for rasterizing
                Console.WriteLine("In Path: " + inputFile);
                Console.WriteLine("In Count: " + rasterizer.PageCount.ToString());

                //set the output image(png's) complete path
                var outputPNGPath = Path.Combine(outputFolder, string.Format("{0}.jpg", outputFileName));
                Console.WriteLine("Out: " + Path.Combine(outputFolder, string.Format("{0}.jpg", outputFileName)));

                //converts the PDF pages to png's 
                var pdf2TIF = rasterizer.GetPage(xDpi, yDpi, pageNumber);

                //save the png's
                pdf2TIF.Save(outputPNGPath, ImageFormat.Jpeg);

                Console.WriteLine("Saved " + outputPNGPath);
            }
        }

        public void Crop(string imagePath, string outputPath)
        {
            if (imagePath == null || outputPath == null)
            {
                return;
            }

            bool valx, valy;
            string msg = "Invalid numeric value";
            Point ptFrom = ParsePoint(txtFrom.Text, out valx);
            Point ptTo = ParsePoint(txtTo.Text, out valy);
            if (!valx || !valy)
            {
                LogError(msg);
                return;
            }

            Tuple<int, int> from = new Tuple<int, int>(ptFrom.X,ptFrom.Y);
            Tuple<int, int> to = new Tuple<int, int>(ptTo.X, ptTo.Y);

            using (MagickImage image = new MagickImage(imagePath))
            {
                image.Crop(new MagickGeometry(from.Item1, from.Item2, to.Item1 - from.Item1, to.Item2 - from.Item2));
                image.Grayscale();
                image.Write(outputPath);
            }
        }

        public string TextFromImage(string pth)
        {
            string result = "";
            try 
            {
                ProcessStartInfo start = new ProcessStartInfo();
                start.FileName = txtPythonFolder.Text + @"python.exe";
                //start.Arguments = "r \"" + Application.StartupPath + "\\scripts\\ocr.py\" " + pth ;
                start.Arguments = Application.StartupPath + @"\scripts\ocr.py " + pth;
                //WriteActivity("SP: " + start.Arguments.ToString());
                start.UseShellExecute = false;
                start.WindowStyle = ProcessWindowStyle.Hidden;
                start.CreateNoWindow = true;
                start.RedirectStandardOutput = true;
                using (Process process = Process.Start(start))
                {
                    using (StreamReader reader = process.StandardOutput)
                    {
                        result = reader.ReadToEnd();
                        WriteActivity("Text: "+ result);
                    }
                }
            }
            catch (Exception ex)
            {
                WriteActivity(ex.Message);
                return ("");
            }
            return result;
        }

        public bool CheckNonAlpha(string str)
        {
            if (string.IsNullOrEmpty(str))
                return false;

            for (int i = 0; i < str.Length; i++)
            {
                if (!(char.IsLetter(str[i])) && (!(char.IsNumber(str[i]))))
                    return false;
            }

            return true;
        }
 

    public static Point ParsePoint(string strPt, out bool valid)
        {
            string msg;
            valid = true;
            Point pt = new Point(10000, 10000);
            if (strPt == null)
            {
                valid = false;
                return pt;
            }

            var ptsArr = strPt.Split(',');
            int x, y;
            if (int.TryParse(ptsArr[0], out x))
            {

            }
            else
            {
                msg = "Invalid Size value";
                MessageBox.Show(msg);
                LogError(msg);
                valid = false;
                return pt;
            }

            if (int.TryParse(ptsArr[1], out y))
            {

            }
            else
            {
                msg = "Invalid Size value";
                MessageBox.Show(msg);
                LogError(msg);
                valid = false;
                return pt;
            }

            pt.X = x;
            pt.Y = y;

            return pt;
        }

        public static int ParseInt(string num, out bool valid)
        {
            int x = 0;
            string msg;
            if (int.TryParse(num, out x))
            {
                valid = true;
            }
            else
            {
                msg = "Invalid Size value";
                MessageBox.Show(msg);
                LogError(msg);
                valid = false;
                return x;
            }

            return x;
        }

        public static void LogError(string msg)
        {
            SimpleLogger sl = new SimpleLogger();
            sl.Error(msg);
            //WriteActivity(msg);
        }

        public static string Encrypt(string textToEncrypt)
        {
            try
            {
                string ToReturn = "";
                string _key = "ay$a5%&jwrtmnh;lasjdf98787";
                string _iv = "abc@98797hjkas$&asd(*$%";
                byte[] _ivByte = { };
                _ivByte = System.Text.Encoding.UTF8.GetBytes(_iv.Substring(0, 8));
                byte[] _keybyte = { };
                _keybyte = System.Text.Encoding.UTF8.GetBytes(_key.Substring(0, 8));
                MemoryStream ms = null; CryptoStream cs = null;
                byte[] inputbyteArray = System.Text.Encoding.UTF8.GetBytes(textToEncrypt);
                using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
                {
                    ms = new MemoryStream();
                    cs = new CryptoStream(ms, des.CreateEncryptor(_keybyte, _ivByte), CryptoStreamMode.Write);
                    cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                    cs.FlushFinalBlock();
                    ToReturn = Convert.ToBase64String(ms.ToArray());
                }
                return ToReturn;
            }
            catch (Exception ae)
            {
                throw new Exception(ae.Message, ae.InnerException);
            }
        }

        public static string Decrypt(string textToDecrypt)
        {
            try
            {
                string ToReturn = "";
                string _key = "ay$a5%&jwrtmnh;lasjdf98787";
                string _iv = "abc@98797hjkas$&asd(*$%";
                byte[] _ivByte = { };
                _ivByte = System.Text.Encoding.UTF8.GetBytes(_iv.Substring(0, 8));
                byte[] _keybyte = { };
                _keybyte = System.Text.Encoding.UTF8.GetBytes(_key.Substring(0, 8));
                MemoryStream ms = null; CryptoStream cs = null;
                byte[] inputbyteArray = new byte[textToDecrypt.Replace(" ", "+").Length];
                inputbyteArray = Convert.FromBase64String(textToDecrypt.Replace(" ", "+"));
                using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
                {
                    ms = new MemoryStream();
                    cs = new CryptoStream(ms, des.CreateDecryptor(_keybyte, _ivByte), CryptoStreamMode.Write);
                    cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                    cs.FlushFinalBlock();
                    Encoding encoding = Encoding.UTF8;
                    ToReturn = encoding.GetString(ms.ToArray());
                }
                return ToReturn;
            }
            catch (Exception ae)
            {
                throw new Exception(ae.Message, ae.InnerException);
            }
        }

        private void BtnProcess_Click(object sender, EventArgs e)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            WriteActivity("File renaming started");
            var title = this.Text;
            var txt = "";
            var cnt = 0;
            this.Text = title + " - Renaming...";

            try
            {
                var pdfFiles = Directory.GetFiles(txtProcessFolder.Text, "*.pdf");
                //process each PDF file
                foreach (var pdfFile in pdfFiles)
                {

                    var fileName = Path.GetFileNameWithoutExtension(pdfFile);
                    WriteActivity("Renaming file: " + pdfFile);
                    PdfToJpg(pdfFile, fileName);
                    cropImgIn = outputFolder + fileName + ".jpg";
                    cropImgOut = txtRenamedFolder.Text;

                    Crop(cropImgIn, cropImgIn);
                    var outName = TextFromImage(cropImgIn).Trim();
                    if (string.IsNullOrEmpty(outName))
                    {
                        WriteActivity("No text for file found");
                        continue;
                    }
                    var outPath = outputFolderNew + outName + ".pdf";

                    if (File.Exists(outPath))
                    {
                        var msg = "The file " + outPath + " already exists";
                        //MessageBox.Show(msg, "File Exits", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        WriteActivity(msg);
                        LogError(msg);
                        string fileAppend = DateTime.Now.AddSeconds(cnt).ToString("MMddyyyyhhmmss") + "_";
                        var existingFile = outputFolderNew + fileAppend + outName + ".pdf";
                        File.Copy(pdfFile, existingFile);
                        WriteActivity("File written as: " + existingFile);
                        cnt++;
                        continue;
                    }

                    try
                    {
                        File.Copy(pdfFile, outPath);
                        File.Delete(cropImgIn);
                        WriteActivity("File: " + outPath + " written");
                    }
                    catch(Exception ex)
                    {
                        LogError(ex.Message);
                        WriteActivity(ex.Message);
                        continue;
                    }
                }
                
            }
            catch(Exception ex)
            {
                LogError(ex.Message);
                WriteActivity(ex.Message);
            }
            finally
            {
                this.Text = title;             
            }

            watch.Stop();
            txt = watch.Elapsed.TotalSeconds.ToString();
            WriteActivity("Process Time: " + txt);
        }

        private void BtnDownload_Click(object sender, EventArgs e)
        {
            var msg_ret = DownloadAttachments();
            WriteActivity(msg_ret);
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            var test = txtAttOut.Text.Trim();
            var check = CheckNonAlpha(test);
            MessageBox.Show(check.ToString());
        }

        private void BtnSingleFile_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            var pth = "";
            ofd.Filter = "PDF files|*.pdf";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pth = ofd.FileName;
            }

            var fileName = Path.GetFileNameWithoutExtension(pth);
            PdfToPng(pth, fileName);
            cropImgIn = outputFolder + fileName + ".png";
            cropImgOut = txtRenamedFolder.Text;

            Crop(cropImgIn, cropImgIn);
            TextFromImage(cropImgIn);
            var outName = TextFromImage(cropImgIn);
            var outPath = outputFolderNew + outName + ".pdf";

            if (File.Exists(outPath))
            {
                var msg = "The file " + outPath + " already exists";
                MessageBox.Show(msg, "File Exits", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                WriteActivity(msg);
            }
            File.Copy(pth, outPath);
            File.Delete(cropImgIn);
            WriteActivity("File: " + outPath + " written");

        }

        private void BtnEmail_Click(object sender, EventArgs e)
        {
            try
            {
                var btnName = ((sender as Button).Name);
                (sender as Button).BackColor = Color.Yellow;

                if (MessageBox.Show("Do you want to update the selected value?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }

                switch (btnName)
                {
                    case "btnAddress":
                        UpdateSettings("emailAddress", txtAddress.Text, "Email Address changed from ", true);
                        break;
                    case "btnPassword":
                        UpdateSettings("password", Encrypt(txtPassword.Text), "Email Password changed", false);
                        break;
                    case "btnMailbox":
                        UpdateSettings("mailbox", txtMailbox.Text, "Mailbox changed from ", true);
                        break;
                    case "btnServer":
                        UpdateSettings("server", txtEmailServer.Text, "Email Server changed from ", true);
                        break;
                }
            }
            catch (Exception ex)
            {
                LogError(ex.Message);
                MessageBox.Show(ex.Message);
            }
            finally
            {
                (sender as Button).BackColor = Color.Transparent;
            }

        }

        private void BtnFrom_Click(object sender, EventArgs e)
        {

            try
            {
                var btnName = ((sender as Button).Name);
                bool valid;
                string msg = "Invalid numeric value";
                (sender as Button).BackColor = Color.Yellow;
                Point pt = new Point(10000, 10000);
                if (MessageBox.Show("Do you want to update the selected value?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }

                switch (btnName)
                {
                    case "btnFrom":
                        pt = ParsePoint(txtFrom.Text, out valid);
                        if (!valid)
                        {
                            LogError(msg);
                            return;
                        }
                        Properties.Settings.Default["fromCrop"] = pt;
                        Properties.Settings.Default.Save();
                        WriteActivity("Crop From updated");
                        break;
                    case "btnTo":
                        pt = ParsePoint(txtTo.Text, out valid);
                        if (!valid)
                        {
                            LogError(msg);
                            return;
                        }
                        Properties.Settings.Default["toCrop"] = pt;
                        Properties.Settings.Default.Save();
                        WriteActivity("Crop To updated");
                        break;
                    case "btnDpi":
                        int x = ParseInt(txtDpi.Text, out valid);
                        if (!valid)
                        {
                            LogError(msg);
                            return;
                        }
                        Properties.Settings.Default["dpi"] = x;
                        Properties.Settings.Default.Save();
                        WriteActivity("Image resolution updated");
                        break;
                }
            }
            catch(Exception ex)
            {
                LogError(ex.Message);
                MessageBox.Show(ex.Message);
            }
            finally
            {
                (sender as Button).BackColor = Color.Transparent;
            }
        }

        private void BtnFolder_Click(object sender, EventArgs e)
        {
            try
            {
                var btnName = ((sender as Button).Name);
                (sender as Button).BackColor = Color.Yellow;
                var folder = "";
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    if (string.IsNullOrEmpty(fbd.SelectedPath.ToString()))
                    {
                        return;
                    }

                    folder = fbd.SelectedPath + @"\";
                }
                else
                {
                    return;
                }

                switch (btnName)
                {
                    case "btnDownloadFolder":
                        txtDownloadFolder.Text = folder;
                        WriteConfig("download",folder);
                        WriteActivity("Download folder updated");
                        break;
                    case "btnProcessFolder":
                        txtProcessFolder.Text = folder;
                        WriteConfig("process", folder);
                        WriteActivity("Process folder updated");
                        break;
                    case "btnRenamedFolder":
                        txtRenamedFolder.Text = folder;
                        WriteConfig("renamed", folder);
                        WriteActivity("Renamed folder updated");
                        break;
                    case "btnPythonFolder":
                        txtPythonFolder.Text = folder;
                        WriteConfig("python", folder);
                        WriteActivity("Python folder updated");
                        break;
                }

            }
            catch(Exception ex)
            {
                LogError(ex.Message);
                MessageBox.Show(ex.Message);
            }
            finally
            {
                (sender as Button).BackColor = Color.Transparent;
            }

        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            var pth = "";
            ofd.Filter = "PDF files|*.pdf";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pth = ofd.FileName;
            }

            PdfToPng(pth, pth);
            //cropImgIn = outputFolder + fileName + ".png";
            cropImgIn = pth + ".png";

            Crop(cropImgIn, cropImgIn);
            WriteActivity(cropImgIn);
            txtCheck.Text = cropImgIn;
            pbCheck.Image = Image.FromFile(cropImgIn);
        }

        private void chkDate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDate.CheckState == CheckState.Checked)
            {
                dptDownload.Enabled = true;
            }
            else
            {
                dptDownload.Enabled = false;
            }
        }

        //File End


    }
}
