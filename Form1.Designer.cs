namespace AttachmentProcessing
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpProcessing = new System.Windows.Forms.TabPage();
            this.chkDate = new System.Windows.Forms.CheckBox();
            this.dptDownload = new System.Windows.Forms.DateTimePicker();
            this.txtCheck = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.pbCheck = new System.Windows.Forms.PictureBox();
            this.btnSingleFile = new System.Windows.Forms.Button();
            this.txtAttOut = new System.Windows.Forms.TextBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.tpSettings = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnDpi = new System.Windows.Forms.Button();
            this.txtDpi = new System.Windows.Forms.TextBox();
            this.btnTo = new System.Windows.Forms.Button();
            this.btnFrom = new System.Windows.Forms.Button();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPythonFolder = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPythonFolder = new System.Windows.Forms.TextBox();
            this.btnRenamedFolder = new System.Windows.Forms.Button();
            this.btnProcessFolder = new System.Windows.Forms.Button();
            this.btnDownloadFolder = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRenamedFolder = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProcessFolder = new System.Windows.Forms.TextBox();
            this.txtDownloadFolder = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnServer = new System.Windows.Forms.Button();
            this.btnPassword = new System.Windows.Forms.Button();
            this.btnMailbox = new System.Windows.Forms.Button();
            this.btnAddress = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmailServer = new System.Windows.Forms.TextBox();
            this.txtMailbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lvProcessing = new System.Windows.Forms.ListView();
            this.colTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDetails = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tpProcessing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheck)).BeginInit();
            this.tpSettings.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tpProcessing);
            this.tabControl1.Controls.Add(this.tpSettings);
            this.tabControl1.Location = new System.Drawing.Point(1, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(741, 379);
            this.tabControl1.TabIndex = 0;
            // 
            // tpProcessing
            // 
            this.tpProcessing.Controls.Add(this.chkDate);
            this.tpProcessing.Controls.Add(this.dptDownload);
            this.tpProcessing.Controls.Add(this.txtCheck);
            this.tpProcessing.Controls.Add(this.btnCheck);
            this.tpProcessing.Controls.Add(this.pbCheck);
            this.tpProcessing.Controls.Add(this.btnSingleFile);
            this.tpProcessing.Controls.Add(this.txtAttOut);
            this.tpProcessing.Controls.Add(this.btnDownload);
            this.tpProcessing.Controls.Add(this.btnProcess);
            this.tpProcessing.Controls.Add(this.btnTest);
            this.tpProcessing.Location = new System.Drawing.Point(4, 22);
            this.tpProcessing.Name = "tpProcessing";
            this.tpProcessing.Padding = new System.Windows.Forms.Padding(3);
            this.tpProcessing.Size = new System.Drawing.Size(733, 353);
            this.tpProcessing.TabIndex = 0;
            this.tpProcessing.Text = "Processing";
            this.tpProcessing.UseVisualStyleBackColor = true;
            // 
            // chkDate
            // 
            this.chkDate.AutoSize = true;
            this.chkDate.Location = new System.Drawing.Point(114, 65);
            this.chkDate.Name = "chkDate";
            this.chkDate.Size = new System.Drawing.Size(128, 17);
            this.chkDate.TabIndex = 10;
            this.chkDate.Text = "Download On or After";
            this.chkDate.UseVisualStyleBackColor = true;
            this.chkDate.CheckedChanged += new System.EventHandler(this.chkDate_CheckedChanged);
            // 
            // dptDownload
            // 
            this.dptDownload.Enabled = false;
            this.dptDownload.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dptDownload.Location = new System.Drawing.Point(114, 37);
            this.dptDownload.Name = "dptDownload";
            this.dptDownload.Size = new System.Drawing.Size(99, 20);
            this.dptDownload.TabIndex = 9;
            // 
            // txtCheck
            // 
            this.txtCheck.Location = new System.Drawing.Point(280, 70);
            this.txtCheck.Name = "txtCheck";
            this.txtCheck.ReadOnly = true;
            this.txtCheck.Size = new System.Drawing.Size(289, 20);
            this.txtCheck.TabIndex = 8;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(280, 34);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(104, 23);
            this.btnCheck.TabIndex = 7;
            this.btnCheck.Text = "Check Document";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // pbCheck
            // 
            this.pbCheck.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbCheck.Location = new System.Drawing.Point(280, 101);
            this.pbCheck.Name = "pbCheck";
            this.pbCheck.Size = new System.Drawing.Size(289, 137);
            this.pbCheck.TabIndex = 6;
            this.pbCheck.TabStop = false;
            // 
            // btnSingleFile
            // 
            this.btnSingleFile.Location = new System.Drawing.Point(23, 138);
            this.btnSingleFile.Name = "btnSingleFile";
            this.btnSingleFile.Size = new System.Drawing.Size(75, 23);
            this.btnSingleFile.TabIndex = 5;
            this.btnSingleFile.Text = "Single File";
            this.btnSingleFile.UseVisualStyleBackColor = true;
            this.btnSingleFile.Click += new System.EventHandler(this.BtnSingleFile_Click);
            // 
            // txtAttOut
            // 
            this.txtAttOut.Location = new System.Drawing.Point(280, 256);
            this.txtAttOut.Multiline = true;
            this.txtAttOut.Name = "txtAttOut";
            this.txtAttOut.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAttOut.Size = new System.Drawing.Size(289, 85);
            this.txtAttOut.TabIndex = 4;
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(23, 37);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(75, 23);
            this.btnDownload.TabIndex = 3;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.BtnDownload_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(23, 86);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(75, 23);
            this.btnProcess.TabIndex = 2;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.BtnProcess_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(618, 22);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 1;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.BtnTest_Click);
            // 
            // tpSettings
            // 
            this.tpSettings.Controls.Add(this.groupBox3);
            this.tpSettings.Controls.Add(this.groupBox2);
            this.tpSettings.Controls.Add(this.groupBox1);
            this.tpSettings.Location = new System.Drawing.Point(4, 22);
            this.tpSettings.Name = "tpSettings";
            this.tpSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tpSettings.Size = new System.Drawing.Size(733, 353);
            this.tpSettings.TabIndex = 1;
            this.tpSettings.Text = "Settings";
            this.tpSettings.ToolTipText = "Folder / Mailbox";
            this.tpSettings.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.btnDpi);
            this.groupBox3.Controls.Add(this.txtDpi);
            this.groupBox3.Controls.Add(this.btnTo);
            this.groupBox3.Controls.Add(this.btnFrom);
            this.groupBox3.Controls.Add(this.txtTo);
            this.groupBox3.Controls.Add(this.txtFrom);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(7, 224);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(339, 107);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Document Processing";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(244, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Resolution";
            // 
            // btnDpi
            // 
            this.btnDpi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDpi.Location = new System.Drawing.Point(286, 62);
            this.btnDpi.Name = "btnDpi";
            this.btnDpi.Size = new System.Drawing.Size(38, 22);
            this.btnDpi.TabIndex = 15;
            this.btnDpi.Text = ">>>";
            this.btnDpi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDpi.UseVisualStyleBackColor = true;
            this.btnDpi.Click += new System.EventHandler(this.BtnFrom_Click);
            // 
            // txtDpi
            // 
            this.txtDpi.Location = new System.Drawing.Point(229, 62);
            this.txtDpi.Name = "txtDpi";
            this.txtDpi.Size = new System.Drawing.Size(51, 20);
            this.txtDpi.TabIndex = 14;
            // 
            // btnTo
            // 
            this.btnTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTo.Location = new System.Drawing.Point(162, 63);
            this.btnTo.Name = "btnTo";
            this.btnTo.Size = new System.Drawing.Size(38, 22);
            this.btnTo.TabIndex = 13;
            this.btnTo.Text = ">>>";
            this.btnTo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTo.UseVisualStyleBackColor = true;
            this.btnTo.Click += new System.EventHandler(this.BtnFrom_Click);
            // 
            // btnFrom
            // 
            this.btnFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFrom.Location = new System.Drawing.Point(162, 30);
            this.btnFrom.Name = "btnFrom";
            this.btnFrom.Size = new System.Drawing.Size(38, 22);
            this.btnFrom.TabIndex = 12;
            this.btnFrom.Text = ">>>";
            this.btnFrom.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFrom.UseVisualStyleBackColor = true;
            this.btnFrom.Click += new System.EventHandler(this.BtnFrom_Click);
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(75, 64);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(81, 20);
            this.txtTo.TabIndex = 11;
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(75, 30);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(81, 20);
            this.txtFrom.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Crop To";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Crop From";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPythonFolder);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtPythonFolder);
            this.groupBox2.Controls.Add(this.btnRenamedFolder);
            this.groupBox2.Controls.Add(this.btnProcessFolder);
            this.groupBox2.Controls.Add(this.btnDownloadFolder);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtRenamedFolder);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtProcessFolder);
            this.groupBox2.Controls.Add(this.txtDownloadFolder);
            this.groupBox2.Location = new System.Drawing.Point(372, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 189);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Local Folders";
            // 
            // btnPythonFolder
            // 
            this.btnPythonFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPythonFolder.Location = new System.Drawing.Point(295, 147);
            this.btnPythonFolder.Name = "btnPythonFolder";
            this.btnPythonFolder.Size = new System.Drawing.Size(38, 22);
            this.btnPythonFolder.TabIndex = 18;
            this.btnPythonFolder.Text = ">>>";
            this.btnPythonFolder.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPythonFolder.UseVisualStyleBackColor = true;
            this.btnPythonFolder.Click += new System.EventHandler(this.BtnFolder_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Python";
            // 
            // txtPythonFolder
            // 
            this.txtPythonFolder.Location = new System.Drawing.Point(77, 147);
            this.txtPythonFolder.Name = "txtPythonFolder";
            this.txtPythonFolder.Size = new System.Drawing.Size(212, 20);
            this.txtPythonFolder.TabIndex = 16;
            // 
            // btnRenamedFolder
            // 
            this.btnRenamedFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenamedFolder.Location = new System.Drawing.Point(295, 110);
            this.btnRenamedFolder.Name = "btnRenamedFolder";
            this.btnRenamedFolder.Size = new System.Drawing.Size(38, 22);
            this.btnRenamedFolder.TabIndex = 15;
            this.btnRenamedFolder.Text = ">>>";
            this.btnRenamedFolder.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRenamedFolder.UseVisualStyleBackColor = true;
            this.btnRenamedFolder.Click += new System.EventHandler(this.BtnFolder_Click);
            // 
            // btnProcessFolder
            // 
            this.btnProcessFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessFolder.Location = new System.Drawing.Point(295, 70);
            this.btnProcessFolder.Name = "btnProcessFolder";
            this.btnProcessFolder.Size = new System.Drawing.Size(38, 22);
            this.btnProcessFolder.TabIndex = 14;
            this.btnProcessFolder.Text = ">>>";
            this.btnProcessFolder.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProcessFolder.UseVisualStyleBackColor = true;
            this.btnProcessFolder.Click += new System.EventHandler(this.BtnFolder_Click);
            // 
            // btnDownloadFolder
            // 
            this.btnDownloadFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownloadFolder.Location = new System.Drawing.Point(295, 30);
            this.btnDownloadFolder.Name = "btnDownloadFolder";
            this.btnDownloadFolder.Size = new System.Drawing.Size(38, 22);
            this.btnDownloadFolder.TabIndex = 13;
            this.btnDownloadFolder.Text = ">>>";
            this.btnDownloadFolder.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDownloadFolder.UseVisualStyleBackColor = true;
            this.btnDownloadFolder.Click += new System.EventHandler(this.BtnFolder_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Renamed";
            // 
            // txtRenamedFolder
            // 
            this.txtRenamedFolder.Location = new System.Drawing.Point(77, 110);
            this.txtRenamedFolder.Name = "txtRenamedFolder";
            this.txtRenamedFolder.Size = new System.Drawing.Size(212, 20);
            this.txtRenamedFolder.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Process";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Download";
            // 
            // txtProcessFolder
            // 
            this.txtProcessFolder.Location = new System.Drawing.Point(77, 71);
            this.txtProcessFolder.Name = "txtProcessFolder";
            this.txtProcessFolder.Size = new System.Drawing.Size(212, 20);
            this.txtProcessFolder.TabIndex = 1;
            // 
            // txtDownloadFolder
            // 
            this.txtDownloadFolder.Location = new System.Drawing.Point(77, 31);
            this.txtDownloadFolder.Name = "txtDownloadFolder";
            this.txtDownloadFolder.Size = new System.Drawing.Size(212, 20);
            this.txtDownloadFolder.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnServer);
            this.groupBox1.Controls.Add(this.btnPassword);
            this.groupBox1.Controls.Add(this.btnMailbox);
            this.groupBox1.Controls.Add(this.btnAddress);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtEmailServer);
            this.groupBox1.Controls.Add(this.txtMailbox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Location = new System.Drawing.Point(6, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 189);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Email";
            // 
            // btnServer
            // 
            this.btnServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServer.Location = new System.Drawing.Point(287, 144);
            this.btnServer.Name = "btnServer";
            this.btnServer.Size = new System.Drawing.Size(38, 22);
            this.btnServer.TabIndex = 10;
            this.btnServer.Text = ">>>";
            this.btnServer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnServer.UseVisualStyleBackColor = true;
            this.btnServer.Click += new System.EventHandler(this.BtnEmail_Click);
            // 
            // btnPassword
            // 
            this.btnPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPassword.Location = new System.Drawing.Point(287, 68);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Size = new System.Drawing.Size(38, 22);
            this.btnPassword.TabIndex = 9;
            this.btnPassword.Text = ">>>";
            this.btnPassword.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPassword.UseVisualStyleBackColor = true;
            this.btnPassword.Click += new System.EventHandler(this.BtnEmail_Click);
            // 
            // btnMailbox
            // 
            this.btnMailbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMailbox.Location = new System.Drawing.Point(287, 104);
            this.btnMailbox.Name = "btnMailbox";
            this.btnMailbox.Size = new System.Drawing.Size(38, 22);
            this.btnMailbox.TabIndex = 8;
            this.btnMailbox.Text = ">>>";
            this.btnMailbox.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMailbox.UseVisualStyleBackColor = true;
            this.btnMailbox.Click += new System.EventHandler(this.BtnEmail_Click);
            // 
            // btnAddress
            // 
            this.btnAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddress.Location = new System.Drawing.Point(287, 30);
            this.btnAddress.Name = "btnAddress";
            this.btnAddress.Size = new System.Drawing.Size(38, 22);
            this.btnAddress.TabIndex = 2;
            this.btnAddress.Text = ">>>";
            this.btnAddress.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddress.UseVisualStyleBackColor = true;
            this.btnAddress.Click += new System.EventHandler(this.BtnEmail_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Server";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mailbox";
            // 
            // txtEmailServer
            // 
            this.txtEmailServer.Location = new System.Drawing.Point(69, 145);
            this.txtEmailServer.Name = "txtEmailServer";
            this.txtEmailServer.Size = new System.Drawing.Size(212, 20);
            this.txtEmailServer.TabIndex = 6;
            // 
            // txtMailbox
            // 
            this.txtMailbox.Location = new System.Drawing.Point(69, 105);
            this.txtMailbox.Name = "txtMailbox";
            this.txtMailbox.Size = new System.Drawing.Size(212, 20);
            this.txtMailbox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Address";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(69, 68);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(212, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(69, 31);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(212, 20);
            this.txtAddress.TabIndex = 0;
            // 
            // lvProcessing
            // 
            this.lvProcessing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvProcessing.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTime,
            this.colDetails});
            this.lvProcessing.FullRowSelect = true;
            this.lvProcessing.GridLines = true;
            this.lvProcessing.HideSelection = false;
            this.lvProcessing.Location = new System.Drawing.Point(5, 384);
            this.lvProcessing.Name = "lvProcessing";
            this.lvProcessing.Size = new System.Drawing.Size(733, 140);
            this.lvProcessing.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.lvProcessing.TabIndex = 0;
            this.lvProcessing.UseCompatibleStateImageBehavior = false;
            this.lvProcessing.View = System.Windows.Forms.View.Details;
            // 
            // colTime
            // 
            this.colTime.Text = "Time";
            this.colTime.Width = 100;
            // 
            // colDetails
            // 
            this.colDetails.Text = "Details";
            this.colDetails.Width = 800;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 520);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lvProcessing);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attachment Processing";
            this.tabControl1.ResumeLayout(false);
            this.tpProcessing.ResumeLayout(false);
            this.tpProcessing.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheck)).EndInit();
            this.tpSettings.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpProcessing;
        private System.Windows.Forms.TabPage tpSettings;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProcessFolder;
        private System.Windows.Forms.TextBox txtDownloadFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMailbox;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.ListView lvProcessing;
        private System.Windows.Forms.ColumnHeader colTime;
        private System.Windows.Forms.ColumnHeader colDetails;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmailServer;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.TextBox txtAttOut;
        private System.Windows.Forms.Button btnSingleFile;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRenamedFolder;
        private System.Windows.Forms.Button btnAddress;
        private System.Windows.Forms.Button btnMailbox;
        private System.Windows.Forms.Button btnServer;
        private System.Windows.Forms.Button btnPassword;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Button btnTo;
        private System.Windows.Forms.Button btnFrom;
        private System.Windows.Forms.Button btnRenamedFolder;
        private System.Windows.Forms.Button btnProcessFolder;
        private System.Windows.Forms.Button btnDownloadFolder;
        private System.Windows.Forms.TextBox txtCheck;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.PictureBox pbCheck;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnDpi;
        private System.Windows.Forms.TextBox txtDpi;
        private System.Windows.Forms.DateTimePicker dptDownload;
        private System.Windows.Forms.CheckBox chkDate;
        private System.Windows.Forms.Button btnPythonFolder;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPythonFolder;
    }
}

