namespace JustScan
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
            this.EMail = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.IPScan = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ScanType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.IPMenu = new System.Windows.Forms.ComboBox();
            this.prgIPScanning = new System.Windows.Forms.ProgressBar();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnUse = new System.Windows.Forms.Button();
            this.ipTo = new System.Windows.Forms.TextBox();
            this.hostName = new System.Windows.Forms.TextBox();
            this.ipFrom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.wifi = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.numEnd = new System.Windows.Forms.NumericUpDown();
            this.numStart = new System.Windows.Forms.NumericUpDown();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblIP = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.btnScan = new System.Windows.Forms.Button();
            this.prgScanning = new System.Windows.Forms.ProgressBar();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.txtxResponse = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbServer = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnLookUp = new System.Windows.Forms.Button();
            this.txtHostName = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.To = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.UsrName = new System.Windows.Forms.TextBox();
            this.Pass = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.SaveFile = new System.Windows.Forms.Button();
            this.EMail.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStart)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage7.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // EMail
            // 
            this.EMail.Controls.Add(this.tabPage1);
            this.EMail.Controls.Add(this.tabPage2);
            this.EMail.Controls.Add(this.tabPage3);
            this.EMail.Controls.Add(this.tabPage5);
            this.EMail.Controls.Add(this.tabPage7);
            this.EMail.Controls.Add(this.tabPage4);
            this.EMail.Location = new System.Drawing.Point(-3, -1);
            this.EMail.Name = "EMail";
            this.EMail.SelectedIndex = 0;
            this.EMail.Size = new System.Drawing.Size(578, 335);
            this.EMail.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::JustScan.Properties.Resources.Geek;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.IPScan);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.ScanType);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.IPMenu);
            this.tabPage1.Controls.Add(this.prgIPScanning);
            this.tabPage1.Controls.Add(this.btnStart);
            this.tabPage1.Controls.Add(this.btnUse);
            this.tabPage1.Controls.Add(this.ipTo);
            this.tabPage1.Controls.Add(this.hostName);
            this.tabPage1.Controls.Add(this.ipFrom);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(570, 309);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "IP Scanner";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // IPScan
            // 
            this.IPScan.BackColor = System.Drawing.Color.White;
            this.IPScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPScan.ForeColor = System.Drawing.Color.Navy;
            this.IPScan.Location = new System.Drawing.Point(6, 70);
            this.IPScan.Multiline = true;
            this.IPScan.Name = "IPScan";
            this.IPScan.ReadOnly = true;
            this.IPScan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.IPScan.Size = new System.Drawing.Size(556, 184);
            this.IPScan.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Lime;
            this.label13.Location = new System.Drawing.Point(338, 34);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 15);
            this.label13.TabIndex = 1;
            this.label13.Text = "Scan Type:";
            // 
            // ScanType
            // 
            this.ScanType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ScanType.FormattingEnabled = true;
            this.ScanType.Items.AddRange(new object[] {
            "Ping Scan",
            "Dns Entries"});
            this.ScanType.Location = new System.Drawing.Point(431, 32);
            this.ScanType.Name = "ScanType";
            this.ScanType.Size = new System.Drawing.Size(121, 21);
            this.ScanType.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Lime;
            this.label6.Location = new System.Drawing.Point(339, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Choose IP:";
            // 
            // IPMenu
            // 
            this.IPMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IPMenu.FormattingEnabled = true;
            this.IPMenu.Location = new System.Drawing.Point(431, 2);
            this.IPMenu.Name = "IPMenu";
            this.IPMenu.Size = new System.Drawing.Size(121, 21);
            this.IPMenu.TabIndex = 10;
            // 
            // prgIPScanning
            // 
            this.prgIPScanning.Location = new System.Drawing.Point(6, 260);
            this.prgIPScanning.Name = "prgIPScanning";
            this.prgIPScanning.Size = new System.Drawing.Size(556, 23);
            this.prgIPScanning.TabIndex = 9;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Green;
            this.btnStart.Font = new System.Drawing.Font("Neuropol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStart.Location = new System.Drawing.Point(253, 30);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(69, 27);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnUse
            // 
            this.btnUse.BackColor = System.Drawing.Color.Green;
            this.btnUse.Font = new System.Drawing.Font("Neuropol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUse.Location = new System.Drawing.Point(176, 30);
            this.btnUse.Name = "btnUse";
            this.btnUse.Size = new System.Drawing.Size(71, 26);
            this.btnUse.TabIndex = 6;
            this.btnUse.Text = "Use";
            this.btnUse.UseVisualStyleBackColor = false;
            this.btnUse.Click += new System.EventHandler(this.btnUse_Click);
            // 
            // ipTo
            // 
            this.ipTo.Location = new System.Drawing.Point(199, 2);
            this.ipTo.Name = "ipTo";
            this.ipTo.Size = new System.Drawing.Size(100, 20);
            this.ipTo.TabIndex = 5;
            this.ipTo.MouseEnter += new System.EventHandler(this.ipTo_MouseEnter);
            this.ipTo.MouseLeave += new System.EventHandler(this.ipTo_MouseLeave);
            // 
            // hostName
            // 
            this.hostName.Location = new System.Drawing.Point(67, 33);
            this.hostName.Name = "hostName";
            this.hostName.Size = new System.Drawing.Size(100, 20);
            this.hostName.TabIndex = 4;
            this.hostName.MouseEnter += new System.EventHandler(this.hostName_MouseEnter);
            this.hostName.MouseLeave += new System.EventHandler(this.hostName_MouseLeave);
            // 
            // ipFrom
            // 
            this.ipFrom.Location = new System.Drawing.Point(67, 5);
            this.ipFrom.Name = "ipFrom";
            this.ipFrom.Size = new System.Drawing.Size(100, 20);
            this.ipFrom.TabIndex = 3;
            this.ipFrom.MouseEnter += new System.EventHandler(this.ipFrom_MouseEnter);
            this.ipFrom.MouseLeave += new System.EventHandler(this.ipFrom_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "IP Range :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Host :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(173, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "To";
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::JustScan.Properties.Resources.Geek;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.wifi);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(570, 306);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Wifi HotSpot";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // wifi
            // 
            this.wifi.BackColor = System.Drawing.Color.Green;
            this.wifi.Font = new System.Drawing.Font("Neuropol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wifi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.wifi.Location = new System.Drawing.Point(155, 131);
            this.wifi.Name = "wifi";
            this.wifi.Size = new System.Drawing.Size(240, 52);
            this.wifi.TabIndex = 4;
            this.wifi.Text = "Start HotSpot";
            this.wifi.UseVisualStyleBackColor = false;
            this.wifi.Click += new System.EventHandler(this.wifi_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(169, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "KEY :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(163, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "SSID :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(216, 94);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(123, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.MouseEnter += new System.EventHandler(this.textBox2_MouseEnter);
            this.textBox2.MouseLeave += new System.EventHandler(this.textBox2_MouseLeave);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(216, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.MouseEnter += new System.EventHandler(this.textBox1_MouseEnter);
            this.textBox1.MouseLeave += new System.EventHandler(this.textBox1_MouseLeave);
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = global::JustScan.Properties.Resources.Geek;
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage3.Controls.Add(this.txtLog);
            this.tabPage3.Controls.Add(this.numEnd);
            this.tabPage3.Controls.Add(this.numStart);
            this.tabPage3.Controls.Add(this.lblEnd);
            this.tabPage3.Controls.Add(this.lblStart);
            this.tabPage3.Controls.Add(this.lblIP);
            this.tabPage3.Controls.Add(this.txtIP);
            this.tabPage3.Controls.Add(this.btnScan);
            this.tabPage3.Controls.Add(this.prgScanning);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(570, 309);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Port Scanner";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.Color.White;
            this.txtLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtLog.Location = new System.Drawing.Point(198, 7);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(300, 166);
            this.txtLog.TabIndex = 17;
            // 
            // numEnd
            // 
            this.numEnd.Location = new System.Drawing.Point(129, 34);
            this.numEnd.Name = "numEnd";
            this.numEnd.Size = new System.Drawing.Size(50, 20);
            this.numEnd.TabIndex = 16;
            this.numEnd.Enter += new System.EventHandler(this.numEnd_Enter);
            this.numEnd.Leave += new System.EventHandler(this.numEnd_Leave);
            // 
            // numStart
            // 
            this.numStart.Location = new System.Drawing.Point(55, 34);
            this.numStart.Name = "numStart";
            this.numStart.Size = new System.Drawing.Size(50, 20);
            this.numStart.TabIndex = 15;
            this.numStart.Enter += new System.EventHandler(this.numStart_Enter);
            this.numStart.Leave += new System.EventHandler(this.numStart_Leave);
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnd.ForeColor = System.Drawing.Color.Lime;
            this.lblEnd.Location = new System.Drawing.Point(111, 38);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(19, 15);
            this.lblEnd.TabIndex = 14;
            this.lblEnd.Text = "to";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.ForeColor = System.Drawing.Color.Lime;
            this.lblStart.Location = new System.Drawing.Point(8, 39);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(44, 15);
            this.lblStart.TabIndex = 13;
            this.lblStart.Text = "From:";
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIP.ForeColor = System.Drawing.Color.Lime;
            this.lblIP.Location = new System.Drawing.Point(21, 9);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(24, 15);
            this.lblIP.TabIndex = 12;
            this.lblIP.Text = "IP:";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(55, 7);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(124, 20);
            this.txtIP.TabIndex = 11;
            this.txtIP.MouseEnter += new System.EventHandler(this.txtIP_MouseEnter);
            this.txtIP.MouseLeave += new System.EventHandler(this.txtIP_MouseLeave);
            // 
            // btnScan
            // 
            this.btnScan.BackColor = System.Drawing.Color.Green;
            this.btnScan.Font = new System.Drawing.Font("Neuropol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnScan.Location = new System.Drawing.Point(55, 74);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(124, 37);
            this.btnScan.TabIndex = 10;
            this.btnScan.Text = "Start Scan";
            this.btnScan.UseVisualStyleBackColor = false;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // prgScanning
            // 
            this.prgScanning.Location = new System.Drawing.Point(198, 179);
            this.prgScanning.Name = "prgScanning";
            this.prgScanning.Size = new System.Drawing.Size(300, 23);
            this.prgScanning.Step = 1;
            this.prgScanning.TabIndex = 7;
            // 
            // tabPage5
            // 
            this.tabPage5.BackgroundImage = global::JustScan.Properties.Resources.Geek;
            this.tabPage5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage5.Controls.Add(this.txtxResponse);
            this.tabPage5.Controls.Add(this.label9);
            this.tabPage5.Controls.Add(this.groupBox1);
            this.tabPage5.Controls.Add(this.progressBar1);
            this.tabPage5.Controls.Add(this.label11);
            this.tabPage5.Controls.Add(this.label12);
            this.tabPage5.Controls.Add(this.pictureBox1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(570, 306);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "WhoIS";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // txtxResponse
            // 
            this.txtxResponse.BackColor = System.Drawing.Color.White;
            this.txtxResponse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtxResponse.Location = new System.Drawing.Point(230, 36);
            this.txtxResponse.Multiline = true;
            this.txtxResponse.Name = "txtxResponse";
            this.txtxResponse.ReadOnly = true;
            this.txtxResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtxResponse.Size = new System.Drawing.Size(252, 195);
            this.txtxResponse.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Lime;
            this.label9.Location = new System.Drawing.Point(226, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "WHOIS Details";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cmbServer);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnLookUp);
            this.groupBox1.Controls.Add(this.txtHostName);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(21, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 140);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "I Want To Know About";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(81, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Provide Hostname *";
            this.label10.Visible = false;
            // 
            // cmbServer
            // 
            this.cmbServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServer.FormattingEnabled = true;
            this.cmbServer.Items.AddRange(new object[] {
            "whois.internic.net",
            "whois.ripe.net",
            "whois.arin.net"});
            this.cmbServer.Location = new System.Drawing.Point(79, 16);
            this.cmbServer.Name = "cmbServer";
            this.cmbServer.Size = new System.Drawing.Size(121, 21);
            this.cmbServer.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Lime;
            this.label7.Location = new System.Drawing.Point(-3, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Host Name";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Lime;
            this.label8.Location = new System.Drawing.Point(6, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Server";
            // 
            // btnLookUp
            // 
            this.btnLookUp.BackColor = System.Drawing.Color.Green;
            this.btnLookUp.Font = new System.Drawing.Font("Neuropol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLookUp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLookUp.Location = new System.Drawing.Point(9, 100);
            this.btnLookUp.Name = "btnLookUp";
            this.btnLookUp.Size = new System.Drawing.Size(185, 23);
            this.btnLookUp.TabIndex = 5;
            this.btnLookUp.Text = "Look Up";
            this.btnLookUp.UseVisualStyleBackColor = false;
            this.btnLookUp.Click += new System.EventHandler(this.btnLookUp_Click);
            // 
            // txtHostName
            // 
            this.txtHostName.Location = new System.Drawing.Point(79, 53);
            this.txtHostName.Name = "txtHostName";
            this.txtHostName.Size = new System.Drawing.Size(121, 20);
            this.txtHostName.TabIndex = 4;
            this.txtHostName.MouseEnter += new System.EventHandler(this.txtHostName_MouseEnter);
            this.txtHostName.MouseLeave += new System.EventHandler(this.txtHostName_MouseLeave);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(230, 237);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(252, 23);
            this.progressBar1.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Lime;
            this.label11.Location = new System.Drawing.Point(99, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Get Your Domain Info";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Perpetua Titling MT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(95, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 34);
            this.label12.TabIndex = 17;
            this.label12.Text = "WhoIS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JustScan.Properties.Resources._1377639655_Connected;
            this.pictureBox1.Location = new System.Drawing.Point(21, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage7
            // 
            this.tabPage7.BackgroundImage = global::JustScan.Properties.Resources.Geek;
            this.tabPage7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage7.Controls.Add(this.To);
            this.tabPage7.Controls.Add(this.label16);
            this.tabPage7.Controls.Add(this.label15);
            this.tabPage7.Controls.Add(this.UsrName);
            this.tabPage7.Controls.Add(this.Pass);
            this.tabPage7.Controls.Add(this.label14);
            this.tabPage7.Controls.Add(this.button1);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(570, 306);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "E-Mail Report";
            this.tabPage7.UseVisualStyleBackColor = true;
            this.tabPage7.Click += new System.EventHandler(this.tabPage7_Click);
            // 
            // To
            // 
            this.To.Location = new System.Drawing.Point(174, 108);
            this.To.Multiline = true;
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(209, 110);
            this.To.TabIndex = 7;
            this.To.MouseEnter += new System.EventHandler(this.To_MouseEnter);
            this.To.MouseLeave += new System.EventHandler(this.To_MouseLeave);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Lime;
            this.label16.Location = new System.Drawing.Point(124, 109);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 15);
            this.label16.TabIndex = 6;
            this.label16.Text = "To :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Lime;
            this.label15.Location = new System.Drawing.Point(124, 84);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 15);
            this.label15.TabIndex = 4;
            this.label15.Text = "Pass :";
            // 
            // UsrName
            // 
            this.UsrName.Location = new System.Drawing.Point(174, 43);
            this.UsrName.Name = "UsrName";
            this.UsrName.Size = new System.Drawing.Size(209, 20);
            this.UsrName.TabIndex = 3;
            this.UsrName.MouseEnter += new System.EventHandler(this.UsrName_MouseEnter);
            this.UsrName.MouseLeave += new System.EventHandler(this.UsrName_MouseLeave);
            // 
            // Pass
            // 
            this.Pass.Location = new System.Drawing.Point(174, 79);
            this.Pass.Name = "Pass";
            this.Pass.PasswordChar = '●';
            this.Pass.Size = new System.Drawing.Size(209, 20);
            this.Pass.TabIndex = 2;
            this.Pass.MouseEnter += new System.EventHandler(this.Pass_MouseEnter);
            this.Pass.MouseLeave += new System.EventHandler(this.Pass_MouseLeave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Lime;
            this.label14.Location = new System.Drawing.Point(114, 46);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 15);
            this.label14.TabIndex = 1;
            this.label14.Text = "E-Mail :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Font = new System.Drawing.Font("Neuropol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(174, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackgroundImage = global::JustScan.Properties.Resources.Geek;
            this.tabPage4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage4.Controls.Add(this.SaveFile);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(570, 309);
            this.tabPage4.TabIndex = 7;
            this.tabPage4.Text = "Save Report";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // SaveFile
            // 
            this.SaveFile.BackColor = System.Drawing.Color.Green;
            this.SaveFile.Font = new System.Drawing.Font("Neuropol", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveFile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SaveFile.Location = new System.Drawing.Point(159, 103);
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(271, 84);
            this.SaveFile.TabIndex = 1;
            this.SaveFile.Text = "Save Report";
            this.SaveFile.UseVisualStyleBackColor = false;
            this.SaveFile.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 322);
            this.Controls.Add(this.EMail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "#SharpScan :-Basic Network Tools Suite";
            this.EMail.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStart)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl EMail;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnUse;
        private System.Windows.Forms.TextBox ipTo;
        private System.Windows.Forms.TextBox hostName;
        private System.Windows.Forms.TextBox ipFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button wifi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.NumericUpDown numEnd;
        private System.Windows.Forms.NumericUpDown numStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.ProgressBar prgScanning;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.ProgressBar prgIPScanning;
        private System.Windows.Forms.ComboBox IPMenu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtxResponse;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbServer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnLookUp;
        private System.Windows.Forms.TextBox txtHostName;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox ScanType;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TextBox UsrName;
        private System.Windows.Forms.TextBox Pass;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox To;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox IPScan;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button SaveFile;
    }
}

