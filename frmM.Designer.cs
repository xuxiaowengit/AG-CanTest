using System.Windows.Forms;

namespace ECanTest
{
    partial class frmM
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmM));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labInfo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbBaudrates2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbBaudrates = new System.Windows.Forms.ComboBox();
            this.btnInit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.chbRemote = new System.Windows.Forms.CheckBox();
            this.chbExtended = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnWrite = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtData7 = new System.Windows.Forms.TextBox();
            this.txtData6 = new System.Windows.Forms.TextBox();
            this.txtData5 = new System.Windows.Forms.TextBox();
            this.txtData4 = new System.Windows.Forms.TextBox();
            this.txtData3 = new System.Windows.Forms.TextBox();
            this.txtData2 = new System.Windows.Forms.TextBox();
            this.txtData1 = new System.Windows.Forms.TextBox();
            this.txtData0 = new System.Windows.Forms.TextBox();
            this.nudLength = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbxInfo = new System.Windows.Forms.ListBox();
            this.btnInfoClear = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbxRec = new System.Windows.Forms.ListBox();
            this.btnMsgClear = new System.Windows.Forms.Button();
            this.tmrRead = new System.Windows.Forms.Timer(this.components);
            this.tmrDisplay = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.labTx = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labRx = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labErrInfo1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.labErrInfo2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chbRemote2 = new System.Windows.Forms.CheckBox();
            this.chbExtended2 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnWrite2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtID2 = new System.Windows.Forms.TextBox();
            this.txtData27 = new System.Windows.Forms.TextBox();
            this.txtData26 = new System.Windows.Forms.TextBox();
            this.txtData25 = new System.Windows.Forms.TextBox();
            this.txtData24 = new System.Windows.Forms.TextBox();
            this.txtData23 = new System.Windows.Forms.TextBox();
            this.txtData22 = new System.Windows.Forms.TextBox();
            this.txtData21 = new System.Windows.Forms.TextBox();
            this.txtData20 = new System.Windows.Forms.TextBox();
            this.nudLength2 = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbxInfo2 = new System.Windows.Forms.ListBox();
            this.btnInfoClear2 = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lbxRec2 = new System.Windows.Forms.ListBox();
            this.btnMsgClear2 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblCommStatus = new System.Windows.Forms.Label();
            this.lblBatteryStatus = new System.Windows.Forms.Label();
            this.lblSOC = new System.Windows.Forms.Label();
            this.lblSOH = new System.Windows.Forms.Label();
            this.lblTotalVoltage = new System.Windows.Forms.Label();
            this.lblMinCellVoltage = new System.Windows.Forms.Label();
            this.lblMaxCellVoltage = new System.Windows.Forms.Label();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.lblMaxTemperature = new System.Windows.Forms.Label();
            this.lblChargeMOSStatus = new System.Windows.Forms.Label();
            this.lblDischargeMOSStatus = new System.Windows.Forms.Label();
            this.lblCurrentState = new System.Windows.Forms.Label();
            this.lbxProcessedData = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLength)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLength2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labInfo);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbbBaudrates2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbbBaudrates);
            this.groupBox1.Controls.Add(this.btnInit);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Location = new System.Drawing.Point(16, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(916, 99);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "设置";
            // 
            // labInfo
            // 
            this.labInfo.AutoSize = true;
            this.labInfo.Location = new System.Drawing.Point(651, 50);
            this.labInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labInfo.Name = "labInfo";
            this.labInfo.Size = new System.Drawing.Size(15, 15);
            this.labInfo.TabIndex = 56;
            this.labInfo.Text = " ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(674, 43);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 28);
            this.button1.TabIndex = 43;
            this.button1.Text = "ReadInfo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 42;
            this.label2.Text = "CAN2 波特率";
            // 
            // cbbBaudrates2
            // 
            this.cbbBaudrates2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBaudrates2.Items.AddRange(new object[] {
            "1 MBit/sec",
            "800 kBit/sec",
            "666 kBit/sec",
            "500 kBit/sec",
            "400 kBit/sec",
            "250 kBit/sec",
            "200 kBit/sec",
            "125 kBit/sec",
            "100 kBit/sec",
            "80 kBit/sec",
            "50 kBit/sec"});
            this.cbbBaudrates2.Location = new System.Drawing.Point(139, 54);
            this.cbbBaudrates2.Margin = new System.Windows.Forms.Padding(4);
            this.cbbBaudrates2.Name = "cbbBaudrates2";
            this.cbbBaudrates2.Size = new System.Drawing.Size(128, 23);
            this.cbbBaudrates2.TabIndex = 41;
            this.cbbBaudrates2.SelectedIndexChanged += new System.EventHandler(this.cbbBaudrates2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 40;
            this.label1.Text = "CAN1 波特率";
            // 
            // cbbBaudrates
            // 
            this.cbbBaudrates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBaudrates.Items.AddRange(new object[] {
            "1 MBit/sec",
            "800 kBit/sec",
            "666 kBit/sec",
            "500 kBit/sec",
            "400 kBit/sec",
            "250 kBit/sec",
            "200 kBit/sec",
            "125 kBit/sec",
            "100 kBit/sec",
            "80 kBit/sec",
            "50 kBit/sec"});
            this.cbbBaudrates.Location = new System.Drawing.Point(139, 21);
            this.cbbBaudrates.Margin = new System.Windows.Forms.Padding(4);
            this.cbbBaudrates.Name = "cbbBaudrates";
            this.cbbBaudrates.Size = new System.Drawing.Size(128, 23);
            this.cbbBaudrates.TabIndex = 39;
            this.cbbBaudrates.SelectedIndexChanged += new System.EventHandler(this.cbbBaudrates_SelectedIndexChanged);
            // 
            // btnInit
            // 
            this.btnInit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnInit.Location = new System.Drawing.Point(412, 45);
            this.btnInit.Margin = new System.Windows.Forms.Padding(4);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(87, 26);
            this.btnInit.TabIndex = 37;
            this.btnInit.Text = "打开设备";
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.Enabled = false;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnReset.Location = new System.Drawing.Point(537, 45);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(87, 26);
            this.btnReset.TabIndex = 38;
            this.btnReset.Text = "复位";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.chbRemote);
            this.groupBox6.Controls.Add(this.chbExtended);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.btnWrite);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.txtID);
            this.groupBox6.Controls.Add(this.txtData7);
            this.groupBox6.Controls.Add(this.txtData6);
            this.groupBox6.Controls.Add(this.txtData5);
            this.groupBox6.Controls.Add(this.txtData4);
            this.groupBox6.Controls.Add(this.txtData3);
            this.groupBox6.Controls.Add(this.txtData2);
            this.groupBox6.Controls.Add(this.txtData1);
            this.groupBox6.Controls.Add(this.txtData0);
            this.groupBox6.Controls.Add(this.nudLength);
            this.groupBox6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox6.Location = new System.Drawing.Point(8, 32);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(1055, 99);
            this.groupBox6.TabIndex = 52;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Write Messages";
            // 
            // chbRemote
            // 
            this.chbRemote.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chbRemote.Location = new System.Drawing.Point(360, 38);
            this.chbRemote.Margin = new System.Windows.Forms.Padding(4);
            this.chbRemote.Name = "chbRemote";
            this.chbRemote.Size = new System.Drawing.Size(59, 28);
            this.chbRemote.TabIndex = 33;
            this.chbRemote.Text = "RTR";
            // 
            // chbExtended
            // 
            this.chbExtended.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chbExtended.Location = new System.Drawing.Point(125, 38);
            this.chbExtended.Margin = new System.Windows.Forms.Padding(4);
            this.chbExtended.Name = "chbExtended";
            this.chbExtended.Size = new System.Drawing.Size(107, 28);
            this.chbExtended.TabIndex = 34;
            this.chbExtended.Text = "Extended";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(356, 20);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 15);
            this.label11.TabIndex = 32;
            this.label11.Text = "Data (0..7):";
            // 
            // btnWrite
            // 
            this.btnWrite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWrite.Enabled = false;
            this.btnWrite.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnWrite.Location = new System.Drawing.Point(921, 39);
            this.btnWrite.Margin = new System.Windows.Forms.Padding(4);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(87, 26);
            this.btnWrite.TabIndex = 36;
            this.btnWrite.Text = "Send";
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(232, 20);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 15);
            this.label12.TabIndex = 31;
            this.label12.Text = "Length:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 20);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 15);
            this.label13.TabIndex = 30;
            this.label13.Text = "ID (Hex):";
            // 
            // txtID
            // 
            this.txtID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtID.Location = new System.Drawing.Point(8, 39);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.MaxLength = 3;
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(105, 25);
            this.txtID.TabIndex = 20;
            this.txtID.Text = "1";
            // 
            // txtData7
            // 
            this.txtData7.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtData7.Location = new System.Drawing.Point(725, 39);
            this.txtData7.Margin = new System.Windows.Forms.Padding(4);
            this.txtData7.MaxLength = 2;
            this.txtData7.Name = "txtData7";
            this.txtData7.Size = new System.Drawing.Size(31, 25);
            this.txtData7.TabIndex = 29;
            this.txtData7.Text = "00";
            this.txtData7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtData6
            // 
            this.txtData6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtData6.Location = new System.Drawing.Point(683, 39);
            this.txtData6.Margin = new System.Windows.Forms.Padding(4);
            this.txtData6.MaxLength = 2;
            this.txtData6.Name = "txtData6";
            this.txtData6.Size = new System.Drawing.Size(31, 25);
            this.txtData6.TabIndex = 28;
            this.txtData6.Text = "00";
            this.txtData6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtData5
            // 
            this.txtData5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtData5.Location = new System.Drawing.Point(640, 39);
            this.txtData5.Margin = new System.Windows.Forms.Padding(4);
            this.txtData5.MaxLength = 2;
            this.txtData5.Name = "txtData5";
            this.txtData5.Size = new System.Drawing.Size(31, 25);
            this.txtData5.TabIndex = 27;
            this.txtData5.Text = "00";
            this.txtData5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtData4
            // 
            this.txtData4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtData4.Location = new System.Drawing.Point(597, 39);
            this.txtData4.Margin = new System.Windows.Forms.Padding(4);
            this.txtData4.MaxLength = 2;
            this.txtData4.Name = "txtData4";
            this.txtData4.Size = new System.Drawing.Size(31, 25);
            this.txtData4.TabIndex = 26;
            this.txtData4.Text = "00";
            this.txtData4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtData3
            // 
            this.txtData3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtData3.Location = new System.Drawing.Point(555, 39);
            this.txtData3.Margin = new System.Windows.Forms.Padding(4);
            this.txtData3.MaxLength = 2;
            this.txtData3.Name = "txtData3";
            this.txtData3.Size = new System.Drawing.Size(31, 25);
            this.txtData3.TabIndex = 25;
            this.txtData3.Text = "01";
            this.txtData3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtData2
            // 
            this.txtData2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtData2.Location = new System.Drawing.Point(512, 39);
            this.txtData2.Margin = new System.Windows.Forms.Padding(4);
            this.txtData2.MaxLength = 2;
            this.txtData2.Name = "txtData2";
            this.txtData2.Size = new System.Drawing.Size(31, 25);
            this.txtData2.TabIndex = 24;
            this.txtData2.Text = "01";
            this.txtData2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtData1
            // 
            this.txtData1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtData1.Location = new System.Drawing.Point(469, 39);
            this.txtData1.Margin = new System.Windows.Forms.Padding(4);
            this.txtData1.MaxLength = 2;
            this.txtData1.Name = "txtData1";
            this.txtData1.Size = new System.Drawing.Size(31, 25);
            this.txtData1.TabIndex = 23;
            this.txtData1.Text = "01";
            this.txtData1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtData0
            // 
            this.txtData0.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtData0.Location = new System.Drawing.Point(427, 39);
            this.txtData0.Margin = new System.Windows.Forms.Padding(4);
            this.txtData0.MaxLength = 2;
            this.txtData0.Name = "txtData0";
            this.txtData0.Size = new System.Drawing.Size(31, 25);
            this.txtData0.TabIndex = 22;
            this.txtData0.Text = "01";
            this.txtData0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudLength
            // 
            this.nudLength.BackColor = System.Drawing.Color.White;
            this.nudLength.Location = new System.Drawing.Point(236, 39);
            this.nudLength.Margin = new System.Windows.Forms.Padding(4);
            this.nudLength.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudLength.Name = "nudLength";
            this.nudLength.ReadOnly = true;
            this.nudLength.Size = new System.Drawing.Size(67, 25);
            this.nudLength.TabIndex = 21;
            this.nudLength.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.lbxInfo);
            this.groupBox4.Controls.Add(this.btnInfoClear);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox4.Location = new System.Drawing.Point(8, 294);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(1055, 156);
            this.groupBox4.TabIndex = 53;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Information";
            // 
            // lbxInfo
            // 
            this.lbxInfo.FormattingEnabled = true;
            this.lbxInfo.ItemHeight = 15;
            this.lbxInfo.Location = new System.Drawing.Point(8, 22);
            this.lbxInfo.Margin = new System.Windows.Forms.Padding(4);
            this.lbxInfo.Name = "lbxInfo";
            this.lbxInfo.ScrollAlwaysVisible = true;
            this.lbxInfo.Size = new System.Drawing.Size(896, 124);
            this.lbxInfo.TabIndex = 56;
            // 
            // btnInfoClear
            // 
            this.btnInfoClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInfoClear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnInfoClear.Location = new System.Drawing.Point(921, 22);
            this.btnInfoClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnInfoClear.Name = "btnInfoClear";
            this.btnInfoClear.Size = new System.Drawing.Size(87, 26);
            this.btnInfoClear.TabIndex = 52;
            this.btnInfoClear.Text = "Clear";
            this.btnInfoClear.UseVisualStyleBackColor = true;
            this.btnInfoClear.Click += new System.EventHandler(this.btnInfoClear_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.lbxRec);
            this.groupBox5.Controls.Add(this.btnMsgClear);
            this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox5.Location = new System.Drawing.Point(8, 131);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(1055, 161);
            this.groupBox5.TabIndex = 54;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = " Messages Reading ";
            // 
            // lbxRec
            // 
            this.lbxRec.FormattingEnabled = true;
            this.lbxRec.ItemHeight = 15;
            this.lbxRec.Location = new System.Drawing.Point(8, 25);
            this.lbxRec.Margin = new System.Windows.Forms.Padding(4);
            this.lbxRec.Name = "lbxRec";
            this.lbxRec.ScrollAlwaysVisible = true;
            this.lbxRec.Size = new System.Drawing.Size(896, 124);
            this.lbxRec.TabIndex = 57;
            this.lbxRec.SelectionMode = System.Windows.Forms.SelectionMode.One; // 允许单选
            this.lbxRec.KeyDown += lbxRec_KeyDown; // 添加 KeyDown 事件处理程序
            // 
            // btnMsgClear
            // 
            this.btnMsgClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMsgClear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnMsgClear.Location = new System.Drawing.Point(921, 26);
            this.btnMsgClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnMsgClear.Name = "btnMsgClear";
            this.btnMsgClear.Size = new System.Drawing.Size(87, 26);
            this.btnMsgClear.TabIndex = 50;
            this.btnMsgClear.Text = "Clear";
            this.btnMsgClear.UseVisualStyleBackColor = true;
            this.btnMsgClear.Click += new System.EventHandler(this.btnMsgClear_Click);
            // 
            // tmrRead
            // 
            this.tmrRead.Interval = 50;
            this.tmrRead.Tick += new System.EventHandler(this.tmrRead_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(16, 109);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1082, 496);
            this.tabControl1.TabIndex = 55;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.labTx);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.labRx);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.labErrInfo1);
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1074, 467);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CAN1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(307, 11);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 15);
            this.label9.TabIndex = 60;
            this.label9.Text = "TxCount:";
            // 
            // labTx
            // 
            this.labTx.AutoSize = true;
            this.labTx.Location = new System.Drawing.Point(385, 11);
            this.labTx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labTx.Name = "labTx";
            this.labTx.Size = new System.Drawing.Size(55, 15);
            this.labTx.TabIndex = 59;
            this.labTx.Text = "label2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(159, 11);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 15);
            this.label8.TabIndex = 58;
            this.label8.Text = "RxCount:";
            // 
            // labRx
            // 
            this.labRx.AutoSize = true;
            this.labRx.Location = new System.Drawing.Point(237, 11);
            this.labRx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labRx.Name = "labRx";
            this.labRx.Size = new System.Drawing.Size(55, 15);
            this.labRx.TabIndex = 57;
            this.labRx.Text = "label2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 56;
            this.label6.Text = "Error:";
            // 
            // labErrInfo1
            // 
            this.labErrInfo1.AutoSize = true;
            this.labErrInfo1.Location = new System.Drawing.Point(77, 11);
            this.labErrInfo1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labErrInfo1.Name = "labErrInfo1";
            this.labErrInfo1.Size = new System.Drawing.Size(55, 15);
            this.labErrInfo1.TabIndex = 55;
            this.labErrInfo1.Text = "label2";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.labErrInfo2);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox7);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1074, 467);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "CAN2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 11);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 15);
            this.label7.TabIndex = 59;
            this.label7.Text = "Error:";
            // 
            // labErrInfo2
            // 
            this.labErrInfo2.AutoSize = true;
            this.labErrInfo2.Location = new System.Drawing.Point(80, 11);
            this.labErrInfo2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labErrInfo2.Name = "labErrInfo2";
            this.labErrInfo2.Size = new System.Drawing.Size(55, 15);
            this.labErrInfo2.TabIndex = 58;
            this.labErrInfo2.Text = "label2";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.chbRemote2);
            this.groupBox2.Controls.Add(this.chbExtended2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnWrite2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtID2);
            this.groupBox2.Controls.Add(this.txtData27);
            this.groupBox2.Controls.Add(this.txtData26);
            this.groupBox2.Controls.Add(this.txtData25);
            this.groupBox2.Controls.Add(this.txtData24);
            this.groupBox2.Controls.Add(this.txtData23);
            this.groupBox2.Controls.Add(this.txtData22);
            this.groupBox2.Controls.Add(this.txtData21);
            this.groupBox2.Controls.Add(this.txtData20);
            this.groupBox2.Controls.Add(this.nudLength2);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Location = new System.Drawing.Point(8, 31);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1055, 99);
            this.groupBox2.TabIndex = 55;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Write Messages";
            // 
            // chbRemote2
            // 
            this.chbRemote2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chbRemote2.Location = new System.Drawing.Point(360, 38);
            this.chbRemote2.Margin = new System.Windows.Forms.Padding(4);
            this.chbRemote2.Name = "chbRemote2";
            this.chbRemote2.Size = new System.Drawing.Size(59, 28);
            this.chbRemote2.TabIndex = 33;
            this.chbRemote2.Text = "RTR";
            // 
            // chbExtended2
            // 
            this.chbExtended2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chbExtended2.Location = new System.Drawing.Point(125, 38);
            this.chbExtended2.Margin = new System.Windows.Forms.Padding(4);
            this.chbExtended2.Name = "chbExtended2";
            this.chbExtended2.Size = new System.Drawing.Size(107, 28);
            this.chbExtended2.TabIndex = 34;
            this.chbExtended2.Text = "Extended";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(356, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 15);
            this.label3.TabIndex = 32;
            this.label3.Text = "Data (0..7):";
            // 
            // btnWrite2
            // 
            this.btnWrite2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWrite2.Enabled = false;
            this.btnWrite2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnWrite2.Location = new System.Drawing.Point(938, 39);
            this.btnWrite2.Margin = new System.Windows.Forms.Padding(4);
            this.btnWrite2.Name = "btnWrite2";
            this.btnWrite2.Size = new System.Drawing.Size(87, 26);
            this.btnWrite2.TabIndex = 36;
            this.btnWrite2.Text = "Send";
            this.btnWrite2.Click += new System.EventHandler(this.btnWrite2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 31;
            this.label4.Text = "Length:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 30;
            this.label5.Text = "ID (Hex):";
            // 
            // txtID2
            // 
            this.txtID2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtID2.Location = new System.Drawing.Point(8, 39);
            this.txtID2.Margin = new System.Windows.Forms.Padding(4);
            this.txtID2.MaxLength = 3;
            this.txtID2.Name = "txtID2";
            this.txtID2.Size = new System.Drawing.Size(105, 25);
            this.txtID2.TabIndex = 20;
            this.txtID2.Text = "2";
            // 
            // txtData27
            // 
            this.txtData27.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtData27.Location = new System.Drawing.Point(725, 39);
            this.txtData27.Margin = new System.Windows.Forms.Padding(4);
            this.txtData27.MaxLength = 2;
            this.txtData27.Name = "txtData27";
            this.txtData27.Size = new System.Drawing.Size(31, 25);
            this.txtData27.TabIndex = 29;
            this.txtData27.Text = "00";
            this.txtData27.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtData26
            // 
            this.txtData26.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtData26.Location = new System.Drawing.Point(683, 39);
            this.txtData26.Margin = new System.Windows.Forms.Padding(4);
            this.txtData26.MaxLength = 2;
            this.txtData26.Name = "txtData26";
            this.txtData26.Size = new System.Drawing.Size(31, 25);
            this.txtData26.TabIndex = 28;
            this.txtData26.Text = "00";
            this.txtData26.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtData25
            // 
            this.txtData25.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtData25.Location = new System.Drawing.Point(640, 39);
            this.txtData25.Margin = new System.Windows.Forms.Padding(4);
            this.txtData25.MaxLength = 2;
            this.txtData25.Name = "txtData25";
            this.txtData25.Size = new System.Drawing.Size(31, 25);
            this.txtData25.TabIndex = 27;
            this.txtData25.Text = "00";
            this.txtData25.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtData24
            // 
            this.txtData24.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtData24.Location = new System.Drawing.Point(597, 39);
            this.txtData24.Margin = new System.Windows.Forms.Padding(4);
            this.txtData24.MaxLength = 2;
            this.txtData24.Name = "txtData24";
            this.txtData24.Size = new System.Drawing.Size(31, 25);
            this.txtData24.TabIndex = 26;
            this.txtData24.Text = "00";
            this.txtData24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtData23
            // 
            this.txtData23.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtData23.Location = new System.Drawing.Point(555, 39);
            this.txtData23.Margin = new System.Windows.Forms.Padding(4);
            this.txtData23.MaxLength = 2;
            this.txtData23.Name = "txtData23";
            this.txtData23.Size = new System.Drawing.Size(31, 25);
            this.txtData23.TabIndex = 25;
            this.txtData23.Text = "00";
            this.txtData23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtData22
            // 
            this.txtData22.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtData22.Location = new System.Drawing.Point(512, 39);
            this.txtData22.Margin = new System.Windows.Forms.Padding(4);
            this.txtData22.MaxLength = 2;
            this.txtData22.Name = "txtData22";
            this.txtData22.Size = new System.Drawing.Size(31, 25);
            this.txtData22.TabIndex = 24;
            this.txtData22.Text = "02";
            this.txtData22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtData21
            // 
            this.txtData21.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtData21.Location = new System.Drawing.Point(469, 39);
            this.txtData21.Margin = new System.Windows.Forms.Padding(4);
            this.txtData21.MaxLength = 2;
            this.txtData21.Name = "txtData21";
            this.txtData21.Size = new System.Drawing.Size(31, 25);
            this.txtData21.TabIndex = 23;
            this.txtData21.Text = "02";
            this.txtData21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtData20
            // 
            this.txtData20.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtData20.Location = new System.Drawing.Point(427, 39);
            this.txtData20.Margin = new System.Windows.Forms.Padding(4);
            this.txtData20.MaxLength = 2;
            this.txtData20.Name = "txtData20";
            this.txtData20.Size = new System.Drawing.Size(31, 25);
            this.txtData20.TabIndex = 22;
            this.txtData20.Text = "02";
            this.txtData20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudLength2
            // 
            this.nudLength2.BackColor = System.Drawing.Color.White;
            this.nudLength2.Location = new System.Drawing.Point(236, 39);
            this.nudLength2.Margin = new System.Windows.Forms.Padding(4);
            this.nudLength2.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudLength2.Name = "nudLength2";
            this.nudLength2.ReadOnly = true;
            this.nudLength2.Size = new System.Drawing.Size(67, 25);
            this.nudLength2.TabIndex = 21;
            this.nudLength2.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.lbxInfo2);
            this.groupBox3.Controls.Add(this.btnInfoClear2);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox3.Location = new System.Drawing.Point(8, 292);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(1055, 156);
            this.groupBox3.TabIndex = 56;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Information";
            // 
            // lbxInfo2
            // 
            this.lbxInfo2.FormattingEnabled = true;
            this.lbxInfo2.ItemHeight = 15;
            this.lbxInfo2.Location = new System.Drawing.Point(8, 22);
            this.lbxInfo2.Margin = new System.Windows.Forms.Padding(4);
            this.lbxInfo2.Name = "lbxInfo2";
            this.lbxInfo2.ScrollAlwaysVisible = true;
            this.lbxInfo2.Size = new System.Drawing.Size(905, 124);
            this.lbxInfo2.TabIndex = 56;
            // 
            // btnInfoClear2
            // 
            this.btnInfoClear2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInfoClear2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnInfoClear2.Location = new System.Drawing.Point(938, 25);
            this.btnInfoClear2.Margin = new System.Windows.Forms.Padding(4);
            this.btnInfoClear2.Name = "btnInfoClear2";
            this.btnInfoClear2.Size = new System.Drawing.Size(87, 26);
            this.btnInfoClear2.TabIndex = 52;
            this.btnInfoClear2.Text = "Clear";
            this.btnInfoClear2.UseVisualStyleBackColor = true;
            this.btnInfoClear2.Click += new System.EventHandler(this.btnInfoClear2_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Controls.Add(this.lbxRec2);
            this.groupBox7.Controls.Add(this.btnMsgClear2);
            this.groupBox7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox7.Location = new System.Drawing.Point(8, 130);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox7.Size = new System.Drawing.Size(1055, 161);
            this.groupBox7.TabIndex = 57;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = " Messages Reading ";
            // 
            // lbxRec2
            // 
            this.lbxRec2.FormattingEnabled = true;
            this.lbxRec2.ItemHeight = 15;
            this.lbxRec2.Location = new System.Drawing.Point(8, 25);
            this.lbxRec2.Margin = new System.Windows.Forms.Padding(4);
            this.lbxRec2.Name = "lbxRec2";
            this.lbxRec2.ScrollAlwaysVisible = true;
            this.lbxRec2.Size = new System.Drawing.Size(905, 124);
            this.lbxRec2.TabIndex = 57;
            // 
            // btnMsgClear2
            // 
            this.btnMsgClear2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMsgClear2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnMsgClear2.Location = new System.Drawing.Point(921, 38);
            this.btnMsgClear2.Margin = new System.Windows.Forms.Padding(4);
            this.btnMsgClear2.Name = "btnMsgClear2";
            this.btnMsgClear2.Size = new System.Drawing.Size(87, 26);
            this.btnMsgClear2.TabIndex = 50;
            this.btnMsgClear2.Text = "Clear";
            this.btnMsgClear2.UseVisualStyleBackColor = true;
            this.btnMsgClear2.Click += new System.EventHandler(this.btnMsgClear2_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lblCommStatus);
            this.tabPage3.Controls.Add(this.lblBatteryStatus);
            this.tabPage3.Controls.Add(this.lblSOC);
            this.tabPage3.Controls.Add(this.lblSOH);
            this.tabPage3.Controls.Add(this.lblTotalVoltage);
            this.tabPage3.Controls.Add(this.lblMinCellVoltage);
            this.tabPage3.Controls.Add(this.lblMaxCellVoltage);
            this.tabPage3.Controls.Add(this.lblCurrent);
            this.tabPage3.Controls.Add(this.lblMaxTemperature);
            this.tabPage3.Controls.Add(this.lblChargeMOSStatus);
            this.tabPage3.Controls.Add(this.lblDischargeMOSStatus);
            this.tabPage3.Controls.Add(this.lblCurrentState);
            this.tabPage3.Controls.Add(this.lbxProcessedData);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(1074, 467);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "AG_Chcek";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lblCommStatus
            // 
            this.lblCommStatus.AutoSize = true;
            this.lblCommStatus.Location = new System.Drawing.Point(20, 20);
            this.lblCommStatus.Name = "lblCommStatus";
            this.lblCommStatus.Size = new System.Drawing.Size(113, 15);
            this.lblCommStatus.TabIndex = 0;
            this.lblCommStatus.Text = "通讯状态: 未知";
            // 
            // lblBatteryStatus
            // 
            this.lblBatteryStatus.AutoSize = true;
            this.lblBatteryStatus.Location = new System.Drawing.Point(20, 50);
            this.lblBatteryStatus.Name = "lblBatteryStatus";
            this.lblBatteryStatus.Size = new System.Drawing.Size(113, 15);
            this.lblBatteryStatus.TabIndex = 1;
            this.lblBatteryStatus.Text = "电池状态: 未知";
            // 
            // lblSOC
            // 
            this.lblSOC.AutoSize = true;
            this.lblSOC.Location = new System.Drawing.Point(20, 80);
            this.lblSOC.Name = "lblSOC";
            this.lblSOC.Size = new System.Drawing.Size(63, 15);
            this.lblSOC.TabIndex = 2;
            this.lblSOC.Text = "SOC: 0%";
            // 
            // lblSOH
            // 
            this.lblSOH.AutoSize = true;
            this.lblSOH.Location = new System.Drawing.Point(20, 110);
            this.lblSOH.Name = "lblSOH";
            this.lblSOH.Size = new System.Drawing.Size(63, 15);
            this.lblSOH.TabIndex = 3;
            this.lblSOH.Text = "SOH: 0%";
            // 
            // lblTotalVoltage
            // 
            this.lblTotalVoltage.AutoSize = true;
            this.lblTotalVoltage.Location = new System.Drawing.Point(20, 140);
            this.lblTotalVoltage.Name = "lblTotalVoltage";
            this.lblTotalVoltage.Size = new System.Drawing.Size(84, 15);
            this.lblTotalVoltage.TabIndex = 4;
            this.lblTotalVoltage.Text = "总电压: 0V";
            // 
            // lblMinCellVoltage
            // 
            this.lblMinCellVoltage.AutoSize = true;
            this.lblMinCellVoltage.Location = new System.Drawing.Point(20, 170);
            this.lblMinCellVoltage.Name = "lblMinCellVoltage";
            this.lblMinCellVoltage.Size = new System.Drawing.Size(129, 15);
            this.lblMinCellVoltage.TabIndex = 5;
            this.lblMinCellVoltage.Text = "单体最低电压: 0V";
            // 
            // lblMaxCellVoltage
            // 
            this.lblMaxCellVoltage.AutoSize = true;
            this.lblMaxCellVoltage.Location = new System.Drawing.Point(20, 200);
            this.lblMaxCellVoltage.Name = "lblMaxCellVoltage";
            this.lblMaxCellVoltage.Size = new System.Drawing.Size(129, 15);
            this.lblMaxCellVoltage.TabIndex = 6;
            this.lblMaxCellVoltage.Text = "单体最高电压: 0V";
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Location = new System.Drawing.Point(20, 230);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(69, 15);
            this.lblCurrent.TabIndex = 7;
            this.lblCurrent.Text = "电流: 0A";
            // 
            // lblMaxTemperature
            // 
            this.lblMaxTemperature.AutoSize = true;
            this.lblMaxTemperature.Location = new System.Drawing.Point(20, 260);
            this.lblMaxTemperature.Name = "lblMaxTemperature";
            this.lblMaxTemperature.Size = new System.Drawing.Size(114, 15);
            this.lblMaxTemperature.TabIndex = 8;
            this.lblMaxTemperature.Text = "最高温度: 0°C";
            // 
            // lblChargeMOSStatus
            // 
            this.lblChargeMOSStatus.AutoSize = true;
            this.lblChargeMOSStatus.Location = new System.Drawing.Point(20, 290);
            this.lblChargeMOSStatus.Name = "lblChargeMOSStatus";
            this.lblChargeMOSStatus.Size = new System.Drawing.Size(137, 15);
            this.lblChargeMOSStatus.TabIndex = 9;
            this.lblChargeMOSStatus.Text = "充电MOS状态: 未知";
            // 
            // lblDischargeMOSStatus
            // 
            this.lblDischargeMOSStatus.AutoSize = true;
            this.lblDischargeMOSStatus.Location = new System.Drawing.Point(20, 320);
            this.lblDischargeMOSStatus.Name = "lblDischargeMOSStatus";
            this.lblDischargeMOSStatus.Size = new System.Drawing.Size(137, 15);
            this.lblDischargeMOSStatus.TabIndex = 10;
            this.lblDischargeMOSStatus.Text = "放电MOS状态: 未知";
            // 
            // lblCurrentState
            // 
            this.lblCurrentState.AutoSize = true;
            this.lblCurrentState.Location = new System.Drawing.Point(20, 350);
            this.lblCurrentState.Name = "lblCurrentState";
            this.lblCurrentState.Size = new System.Drawing.Size(113, 15);
            this.lblCurrentState.TabIndex = 11;
            this.lblCurrentState.Text = "当前状态: 正常";
            // 
            // lbxProcessedData
            // 
            this.lbxProcessedData.ItemHeight = 15;
            this.lbxProcessedData.Location = new System.Drawing.Point(8, 8);
            this.lbxProcessedData.Name = "lbxProcessedData";
            this.lbxProcessedData.Size = new System.Drawing.Size(1059, 454);
            this.lbxProcessedData.TabIndex = 0;
            // 
            // frmM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 619);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmM";
            this.Text = "AG_CAN_TETS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLength)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLength2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbBaudrates;
        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox chbRemote;
        private System.Windows.Forms.CheckBox chbExtended;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtData7;
        private System.Windows.Forms.TextBox txtData6;
        private System.Windows.Forms.TextBox txtData5;
        private System.Windows.Forms.TextBox txtData4;
        private System.Windows.Forms.TextBox txtData3;
        private System.Windows.Forms.TextBox txtData2;
        private System.Windows.Forms.TextBox txtData1;
        private System.Windows.Forms.TextBox txtData0;
        private System.Windows.Forms.NumericUpDown nudLength;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lbxInfo;
        private System.Windows.Forms.Button btnInfoClear;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnMsgClear;
        private System.Windows.Forms.Timer tmrRead;
        private System.Windows.Forms.Timer tmrDisplay;
        private System.Windows.Forms.ListBox lbxRec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbBaudrates2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chbRemote2;
        private System.Windows.Forms.CheckBox chbExtended2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnWrite2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtID2;
        private System.Windows.Forms.TextBox txtData27;
        private System.Windows.Forms.TextBox txtData26;
        private System.Windows.Forms.TextBox txtData25;
        private System.Windows.Forms.TextBox txtData24;
        private System.Windows.Forms.TextBox txtData23;
        private System.Windows.Forms.TextBox txtData22;
        private System.Windows.Forms.TextBox txtData21;
        private System.Windows.Forms.TextBox txtData20;
        private System.Windows.Forms.NumericUpDown nudLength2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lbxInfo2;
        private System.Windows.Forms.Button btnInfoClear2;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ListBox lbxRec2;
        private System.Windows.Forms.Button btnMsgClear2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labErrInfo1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labErrInfo2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labTx;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labRx;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labInfo;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox lbxProcessedData;
        private System.Windows.Forms.Label lblCommStatus;
        private System.Windows.Forms.Label lblBatteryStatus;
        private System.Windows.Forms.Label lblSOC;
        private System.Windows.Forms.Label lblSOH;
        private System.Windows.Forms.Label lblTotalVoltage;
        private System.Windows.Forms.Label lblMinCellVoltage;
        private System.Windows.Forms.Label lblMaxCellVoltage;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.Label lblMaxTemperature;
        private System.Windows.Forms.Label lblChargeMOSStatus;
        private System.Windows.Forms.Label lblDischargeMOSStatus;
        private System.Windows.Forms.Label lblCurrentState;
    }
}

