﻿namespace BlueCentaurea
{
    partial class NetworkForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetworkForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.combBLocalhost = new System.Windows.Forms.ComboBox();
            this.rabtnServer = new System.Windows.Forms.RadioButton();
            this.rabtnClient = new System.Windows.Forms.RadioButton();
            this.raBtnUDP = new System.Windows.Forms.RadioButton();
            this.lblConnectStatus = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.textMultiFunc = new System.Windows.Forms.TextBox();
            this.lblMultiFunc = new System.Windows.Forms.Label();
            this.lblLocalhost = new System.Windows.Forms.Label();
            this.lblProtocol = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonBbk = new System.Windows.Forms.RadioButton();
            this.radioButtonUtf8 = new System.Windows.Forms.RadioButton();
            this.btnRecvClr = new System.Windows.Forms.Button();
            this.chkbPause = new System.Windows.Forms.CheckBox();
            this.chkbRecvTime = new System.Windows.Forms.CheckBox();
            this.chkbHEX = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioBtnHEXSendNo = new System.Windows.Forms.RadioButton();
            this.radioBtnHEXSendYes = new System.Windows.Forms.RadioButton();
            this.chboxDisplaySend = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioBtnSendGBK = new System.Windows.Forms.RadioButton();
            this.radioBtnSendUTF = new System.Windows.Forms.RadioButton();
            this.btnSendLoop = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textSendInterval = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textRecvRegion = new System.Windows.Forms.RichTextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnSendRegion3 = new System.Windows.Forms.Button();
            this.btnSendRegion2 = new System.Windows.Forms.Button();
            this.btnSendRegion1 = new System.Windows.Forms.Button();
            this.btnSend3 = new System.Windows.Forms.Button();
            this.btnSend2 = new System.Windows.Forms.Button();
            this.btnSend1 = new System.Windows.Forms.Button();
            this.checkBoxSend3 = new System.Windows.Forms.CheckBox();
            this.textSendRegion3 = new System.Windows.Forms.RichTextBox();
            this.textSendRegion2 = new System.Windows.Forms.RichTextBox();
            this.checkBoxSend2 = new System.Windows.Forms.CheckBox();
            this.textSendRegion1 = new System.Windows.Forms.RichTextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.checkBoxSend1 = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.listBoxOnline = new System.Windows.Forms.ListBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.richTextBoxTips = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxRecvBytes = new System.Windows.Forms.TextBox();
            this.textBoxSendBytes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.btnCelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.combBLocalhost);
            this.groupBox1.Controls.Add(this.rabtnServer);
            this.groupBox1.Controls.Add(this.rabtnClient);
            this.groupBox1.Controls.Add(this.raBtnUDP);
            this.groupBox1.Controls.Add(this.lblConnectStatus);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.textMultiFunc);
            this.groupBox1.Controls.Add(this.lblMultiFunc);
            this.groupBox1.Controls.Add(this.lblLocalhost);
            this.groupBox1.Controls.Add(this.lblProtocol);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(162, 445);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 106);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "网络设置";
            // 
            // combBLocalhost
            // 
            this.combBLocalhost.DropDownWidth = 106;
            this.combBLocalhost.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combBLocalhost.ForeColor = System.Drawing.Color.Red;
            this.combBLocalhost.FormattingEnabled = true;
            this.combBLocalhost.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.combBLocalhost.IntegralHeight = false;
            this.combBLocalhost.ItemHeight = 15;
            this.combBLocalhost.Location = new System.Drawing.Point(114, 47);
            this.combBLocalhost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.combBLocalhost.MaxDropDownItems = 20;
            this.combBLocalhost.Name = "combBLocalhost";
            this.combBLocalhost.Size = new System.Drawing.Size(112, 23);
            this.combBLocalhost.TabIndex = 15;
            this.combBLocalhost.Text = "127.0.0.1";
            // 
            // rabtnServer
            // 
            this.rabtnServer.AutoSize = true;
            this.rabtnServer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rabtnServer.Location = new System.Drawing.Point(210, 19);
            this.rabtnServer.Name = "rabtnServer";
            this.rabtnServer.Size = new System.Drawing.Size(67, 19);
            this.rabtnServer.TabIndex = 1;
            this.rabtnServer.Text = "Server";
            this.rabtnServer.UseVisualStyleBackColor = true;
            this.rabtnServer.CheckedChanged += new System.EventHandler(this.rabtnServer_CheckedChanged);
            // 
            // rabtnClient
            // 
            this.rabtnClient.AutoSize = true;
            this.rabtnClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rabtnClient.Location = new System.Drawing.Point(135, 20);
            this.rabtnClient.Name = "rabtnClient";
            this.rabtnClient.Size = new System.Drawing.Size(67, 19);
            this.rabtnClient.TabIndex = 1;
            this.rabtnClient.Text = "Client";
            this.rabtnClient.UseVisualStyleBackColor = true;
            this.rabtnClient.CheckedChanged += new System.EventHandler(this.rabtnClient_CheckedChanged);
            // 
            // raBtnUDP
            // 
            this.raBtnUDP.AutoSize = true;
            this.raBtnUDP.Checked = true;
            this.raBtnUDP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.raBtnUDP.Location = new System.Drawing.Point(83, 20);
            this.raBtnUDP.Name = "raBtnUDP";
            this.raBtnUDP.Size = new System.Drawing.Size(46, 19);
            this.raBtnUDP.TabIndex = 1;
            this.raBtnUDP.TabStop = true;
            this.raBtnUDP.Text = "UDP";
            this.raBtnUDP.UseVisualStyleBackColor = true;
            this.raBtnUDP.CheckedChanged += new System.EventHandler(this.raBtnUDP_CheckedChanged);
            // 
            // lblConnectStatus
            // 
            this.lblConnectStatus.AutoSize = true;
            this.lblConnectStatus.BackColor = System.Drawing.Color.SkyBlue;
            this.lblConnectStatus.Image = global::BlueCentaurea.Properties.Resources.LightOff;
            this.lblConnectStatus.Location = new System.Drawing.Point(252, 51);
            this.lblConnectStatus.Name = "lblConnectStatus";
            this.lblConnectStatus.Size = new System.Drawing.Size(14, 15);
            this.lblConnectStatus.TabIndex = 14;
            this.lblConnectStatus.Text = " ";
            // 
            // btnConnect
            // 
            this.btnConnect.ForeColor = System.Drawing.Color.Black;
            this.btnConnect.Location = new System.Drawing.Point(235, 73);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(55, 27);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "连接";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // textMultiFunc
            // 
            this.textMultiFunc.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMultiFunc.ForeColor = System.Drawing.Color.Red;
            this.textMultiFunc.Location = new System.Drawing.Point(114, 78);
            this.textMultiFunc.Name = "textMultiFunc";
            this.textMultiFunc.Size = new System.Drawing.Size(112, 20);
            this.textMultiFunc.TabIndex = 3;
            // 
            // lblMultiFunc
            // 
            this.lblMultiFunc.AutoSize = true;
            this.lblMultiFunc.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.lblMultiFunc.Location = new System.Drawing.Point(7, 79);
            this.lblMultiFunc.Name = "lblMultiFunc";
            this.lblMultiFunc.Size = new System.Drawing.Size(91, 15);
            this.lblMultiFunc.TabIndex = 2;
            this.lblMultiFunc.Text = "本地主机端口";
            // 
            // lblLocalhost
            // 
            this.lblLocalhost.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.lblLocalhost.Location = new System.Drawing.Point(7, 51);
            this.lblLocalhost.Name = "lblLocalhost";
            this.lblLocalhost.Size = new System.Drawing.Size(95, 15);
            this.lblLocalhost.TabIndex = 1;
            this.lblLocalhost.Text = "本地主机地址";
            // 
            // lblProtocol
            // 
            this.lblProtocol.AutoSize = true;
            this.lblProtocol.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.lblProtocol.Location = new System.Drawing.Point(7, 22);
            this.lblProtocol.Name = "lblProtocol";
            this.lblProtocol.Size = new System.Drawing.Size(70, 15);
            this.lblProtocol.TabIndex = 0;
            this.lblProtocol.Text = "协议类型:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.radioButtonBbk);
            this.groupBox2.Controls.Add(this.radioButtonUtf8);
            this.groupBox2.Controls.Add(this.btnRecvClr);
            this.groupBox2.Controls.Add(this.chkbPause);
            this.groupBox2.Controls.Add(this.chkbRecvTime);
            this.groupBox2.Controls.Add(this.chkbHEX);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(472, 445);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(203, 106);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "接收区设置";
            // 
            // radioButtonBbk
            // 
            this.radioButtonBbk.AutoSize = true;
            this.radioButtonBbk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonBbk.Location = new System.Drawing.Point(152, 20);
            this.radioButtonBbk.Name = "radioButtonBbk";
            this.radioButtonBbk.Size = new System.Drawing.Size(46, 19);
            this.radioButtonBbk.TabIndex = 14;
            this.radioButtonBbk.Text = "gbk";
            this.radioButtonBbk.UseVisualStyleBackColor = true;
            // 
            // radioButtonUtf8
            // 
            this.radioButtonUtf8.AutoSize = true;
            this.radioButtonUtf8.Checked = true;
            this.radioButtonUtf8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonUtf8.Location = new System.Drawing.Point(102, 21);
            this.radioButtonUtf8.Name = "radioButtonUtf8";
            this.radioButtonUtf8.Size = new System.Drawing.Size(46, 19);
            this.radioButtonUtf8.TabIndex = 13;
            this.radioButtonUtf8.TabStop = true;
            this.radioButtonUtf8.Text = "utf";
            this.radioButtonUtf8.UseVisualStyleBackColor = true;
            // 
            // btnRecvClr
            // 
            this.btnRecvClr.ForeColor = System.Drawing.Color.Red;
            this.btnRecvClr.Location = new System.Drawing.Point(132, 73);
            this.btnRecvClr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRecvClr.Name = "btnRecvClr";
            this.btnRecvClr.Size = new System.Drawing.Size(55, 27);
            this.btnRecvClr.TabIndex = 12;
            this.btnRecvClr.Text = "清空";
            this.btnRecvClr.UseVisualStyleBackColor = true;
            this.btnRecvClr.Click += new System.EventHandler(this.btnRecvClr_Click);
            // 
            // chkbPause
            // 
            this.chkbPause.AutoSize = true;
            this.chkbPause.Location = new System.Drawing.Point(6, 78);
            this.chkbPause.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkbPause.Name = "chkbPause";
            this.chkbPause.Size = new System.Drawing.Size(110, 19);
            this.chkbPause.TabIndex = 3;
            this.chkbPause.Text = "暂停接收显示";
            this.chkbPause.UseVisualStyleBackColor = true;
            // 
            // chkbRecvTime
            // 
            this.chkbRecvTime.AutoSize = true;
            this.chkbRecvTime.Checked = true;
            this.chkbRecvTime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkbRecvTime.Location = new System.Drawing.Point(6, 49);
            this.chkbRecvTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkbRecvTime.Name = "chkbRecvTime";
            this.chkbRecvTime.Size = new System.Drawing.Size(110, 19);
            this.chkbRecvTime.TabIndex = 2;
            this.chkbRecvTime.Text = "显示接收时间";
            this.chkbRecvTime.UseVisualStyleBackColor = true;
            // 
            // chkbHEX
            // 
            this.chkbHEX.AutoSize = true;
            this.chkbHEX.Location = new System.Drawing.Point(6, 21);
            this.chkbHEX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkbHEX.Name = "chkbHEX";
            this.chkbHEX.Size = new System.Drawing.Size(96, 19);
            this.chkbHEX.TabIndex = 1;
            this.chkbHEX.Text = "16进制显示";
            this.chkbHEX.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.panel2);
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Controls.Add(this.btnSendLoop);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textSendInterval);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(681, 445);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(209, 106);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "发送区设置";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioBtnHEXSendNo);
            this.panel2.Controls.Add(this.radioBtnHEXSendYes);
            this.panel2.Controls.Add(this.chboxDisplaySend);
            this.panel2.Location = new System.Drawing.Point(4, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(198, 28);
            this.panel2.TabIndex = 3;
            // 
            // radioBtnHEXSendNo
            // 
            this.radioBtnHEXSendNo.AutoSize = true;
            this.radioBtnHEXSendNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioBtnHEXSendNo.Location = new System.Drawing.Point(160, 6);
            this.radioBtnHEXSendNo.Name = "radioBtnHEXSendNo";
            this.radioBtnHEXSendNo.Size = new System.Drawing.Size(39, 19);
            this.radioBtnHEXSendNo.TabIndex = 21;
            this.radioBtnHEXSendNo.Text = "否";
            this.radioBtnHEXSendNo.UseVisualStyleBackColor = true;
            // 
            // radioBtnHEXSendYes
            // 
            this.radioBtnHEXSendYes.AutoSize = true;
            this.radioBtnHEXSendYes.Checked = true;
            this.radioBtnHEXSendYes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioBtnHEXSendYes.Location = new System.Drawing.Point(115, 6);
            this.radioBtnHEXSendYes.Name = "radioBtnHEXSendYes";
            this.radioBtnHEXSendYes.Size = new System.Drawing.Size(39, 19);
            this.radioBtnHEXSendYes.TabIndex = 19;
            this.radioBtnHEXSendYes.TabStop = true;
            this.radioBtnHEXSendYes.Text = "是";
            this.radioBtnHEXSendYes.UseVisualStyleBackColor = true;
            // 
            // chboxDisplaySend
            // 
            this.chboxDisplaySend.AutoSize = true;
            this.chboxDisplaySend.Checked = true;
            this.chboxDisplaySend.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chboxDisplaySend.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chboxDisplaySend.Location = new System.Drawing.Point(1, 6);
            this.chboxDisplaySend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chboxDisplaySend.Name = "chboxDisplaySend";
            this.chboxDisplaySend.Size = new System.Drawing.Size(117, 19);
            this.chboxDisplaySend.TabIndex = 20;
            this.chboxDisplaySend.Text = "显示发送  HEX";
            this.chboxDisplaySend.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioBtnSendGBK);
            this.panel1.Controls.Add(this.radioBtnSendUTF);
            this.panel1.Location = new System.Drawing.Point(4, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 26);
            this.panel1.TabIndex = 12;
            // 
            // radioBtnSendGBK
            // 
            this.radioBtnSendGBK.AutoSize = true;
            this.radioBtnSendGBK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioBtnSendGBK.Location = new System.Drawing.Point(111, 3);
            this.radioBtnSendGBK.Name = "radioBtnSendGBK";
            this.radioBtnSendGBK.Size = new System.Drawing.Size(74, 19);
            this.radioBtnSendGBK.TabIndex = 18;
            this.radioBtnSendGBK.Text = "GBK发送";
            this.radioBtnSendGBK.UseVisualStyleBackColor = true;
            // 
            // radioBtnSendUTF
            // 
            this.radioBtnSendUTF.AutoSize = true;
            this.radioBtnSendUTF.Checked = true;
            this.radioBtnSendUTF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioBtnSendUTF.Location = new System.Drawing.Point(0, 4);
            this.radioBtnSendUTF.Name = "radioBtnSendUTF";
            this.radioBtnSendUTF.Size = new System.Drawing.Size(88, 19);
            this.radioBtnSendUTF.TabIndex = 17;
            this.radioBtnSendUTF.TabStop = true;
            this.radioBtnSendUTF.Text = "UTF-8发送";
            this.radioBtnSendUTF.UseVisualStyleBackColor = true;
            // 
            // btnSendLoop
            // 
            this.btnSendLoop.ForeColor = System.Drawing.Color.Green;
            this.btnSendLoop.Location = new System.Drawing.Point(126, 73);
            this.btnSendLoop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSendLoop.Name = "btnSendLoop";
            this.btnSendLoop.Size = new System.Drawing.Size(77, 27);
            this.btnSendLoop.TabIndex = 13;
            this.btnSendLoop.Text = "循环发送";
            this.btnSendLoop.UseVisualStyleBackColor = true;
            this.btnSendLoop.Click += new System.EventHandler(this.btnSendLoop_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 9F);
            this.label4.Location = new System.Drawing.Point(101, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "ms";
            // 
            // textSendInterval
            // 
            this.textSendInterval.BackColor = System.Drawing.Color.SkyBlue;
            this.textSendInterval.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.textSendInterval.ForeColor = System.Drawing.Color.Red;
            this.textSendInterval.Location = new System.Drawing.Point(42, 76);
            this.textSendInterval.Multiline = true;
            this.textSendInterval.Name = "textSendInterval";
            this.textSendInterval.Size = new System.Drawing.Size(48, 22);
            this.textSendInterval.TabIndex = 5;
            this.textSendInterval.Text = "10000";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Consolas", 9F);
            this.label12.Location = new System.Drawing.Point(6, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 14);
            this.label12.TabIndex = 4;
            this.label12.Text = "间隔";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.textRecvRegion);
            this.groupBox4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(3, 2);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(714, 318);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "接收区";
            // 
            // textRecvRegion
            // 
            this.textRecvRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textRecvRegion.HideSelection = false;
            this.textRecvRegion.Location = new System.Drawing.Point(6, 18);
            this.textRecvRegion.Name = "textRecvRegion";
            this.textRecvRegion.Size = new System.Drawing.Size(702, 293);
            this.textRecvRegion.TabIndex = 2;
            this.textRecvRegion.Text = "";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.btnSendRegion3);
            this.groupBox5.Controls.Add(this.btnSendRegion2);
            this.groupBox5.Controls.Add(this.btnSendRegion1);
            this.groupBox5.Controls.Add(this.btnSend3);
            this.groupBox5.Controls.Add(this.btnSend2);
            this.groupBox5.Controls.Add(this.btnSend1);
            this.groupBox5.Controls.Add(this.checkBoxSend3);
            this.groupBox5.Controls.Add(this.textSendRegion3);
            this.groupBox5.Controls.Add(this.textSendRegion2);
            this.groupBox5.Controls.Add(this.checkBoxSend2);
            this.groupBox5.Controls.Add(this.textSendRegion1);
            this.groupBox5.Controls.Add(this.label27);
            this.groupBox5.Controls.Add(this.checkBoxSend1);
            this.groupBox5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(3, 328);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Size = new System.Drawing.Size(887, 110);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "发送区";
            // 
            // btnSendRegion3
            // 
            this.btnSendRegion3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendRegion3.ForeColor = System.Drawing.Color.Red;
            this.btnSendRegion3.Location = new System.Drawing.Point(835, 77);
            this.btnSendRegion3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSendRegion3.Name = "btnSendRegion3";
            this.btnSendRegion3.Size = new System.Drawing.Size(46, 22);
            this.btnSendRegion3.TabIndex = 17;
            this.btnSendRegion3.Text = "清空";
            this.btnSendRegion3.UseVisualStyleBackColor = true;
            this.btnSendRegion3.Click += new System.EventHandler(this.btnSendRegion3_Click);
            // 
            // btnSendRegion2
            // 
            this.btnSendRegion2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendRegion2.ForeColor = System.Drawing.Color.Red;
            this.btnSendRegion2.Location = new System.Drawing.Point(835, 47);
            this.btnSendRegion2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSendRegion2.Name = "btnSendRegion2";
            this.btnSendRegion2.Size = new System.Drawing.Size(46, 22);
            this.btnSendRegion2.TabIndex = 16;
            this.btnSendRegion2.Text = "清空";
            this.btnSendRegion2.UseVisualStyleBackColor = true;
            this.btnSendRegion2.Click += new System.EventHandler(this.btnSendRegion2_Click);
            // 
            // btnSendRegion1
            // 
            this.btnSendRegion1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendRegion1.ForeColor = System.Drawing.Color.Red;
            this.btnSendRegion1.Location = new System.Drawing.Point(835, 17);
            this.btnSendRegion1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSendRegion1.Name = "btnSendRegion1";
            this.btnSendRegion1.Size = new System.Drawing.Size(46, 22);
            this.btnSendRegion1.TabIndex = 15;
            this.btnSendRegion1.Text = "清空";
            this.btnSendRegion1.UseVisualStyleBackColor = true;
            this.btnSendRegion1.Click += new System.EventHandler(this.btnSendRegion1_Click);
            // 
            // btnSend3
            // 
            this.btnSend3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend3.ForeColor = System.Drawing.Color.Green;
            this.btnSend3.Location = new System.Drawing.Point(786, 77);
            this.btnSend3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSend3.Name = "btnSend3";
            this.btnSend3.Size = new System.Drawing.Size(46, 22);
            this.btnSend3.TabIndex = 14;
            this.btnSend3.Text = "发送";
            this.btnSend3.UseVisualStyleBackColor = true;
            this.btnSend3.Click += new System.EventHandler(this.btnSend3_Click);
            // 
            // btnSend2
            // 
            this.btnSend2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend2.ForeColor = System.Drawing.Color.Green;
            this.btnSend2.Location = new System.Drawing.Point(786, 48);
            this.btnSend2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSend2.Name = "btnSend2";
            this.btnSend2.Size = new System.Drawing.Size(46, 22);
            this.btnSend2.TabIndex = 13;
            this.btnSend2.Text = "发送";
            this.btnSend2.UseVisualStyleBackColor = true;
            this.btnSend2.Click += new System.EventHandler(this.btnSend2_Click);
            // 
            // btnSend1
            // 
            this.btnSend1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend1.ForeColor = System.Drawing.Color.Green;
            this.btnSend1.Location = new System.Drawing.Point(786, 17);
            this.btnSend1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSend1.Name = "btnSend1";
            this.btnSend1.Size = new System.Drawing.Size(46, 22);
            this.btnSend1.TabIndex = 12;
            this.btnSend1.Text = "发送";
            this.btnSend1.UseVisualStyleBackColor = true;
            this.btnSend1.Click += new System.EventHandler(this.btnSend1_Click);
            // 
            // checkBoxSend3
            // 
            this.checkBoxSend3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxSend3.AutoSize = true;
            this.checkBoxSend3.Location = new System.Drawing.Point(726, 80);
            this.checkBoxSend3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxSend3.Name = "checkBoxSend3";
            this.checkBoxSend3.Size = new System.Drawing.Size(54, 19);
            this.checkBoxSend3.TabIndex = 8;
            this.checkBoxSend3.Text = "轮发";
            this.checkBoxSend3.UseVisualStyleBackColor = true;
            // 
            // textSendRegion3
            // 
            this.textSendRegion3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textSendRegion3.Location = new System.Drawing.Point(6, 78);
            this.textSendRegion3.Name = "textSendRegion3";
            this.textSendRegion3.Size = new System.Drawing.Size(702, 24);
            this.textSendRegion3.TabIndex = 5;
            this.textSendRegion3.Text = "";
            // 
            // textSendRegion2
            // 
            this.textSendRegion2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textSendRegion2.Location = new System.Drawing.Point(6, 48);
            this.textSendRegion2.Name = "textSendRegion2";
            this.textSendRegion2.Size = new System.Drawing.Size(702, 24);
            this.textSendRegion2.TabIndex = 4;
            this.textSendRegion2.Text = "";
            // 
            // checkBoxSend2
            // 
            this.checkBoxSend2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxSend2.AutoSize = true;
            this.checkBoxSend2.Location = new System.Drawing.Point(726, 50);
            this.checkBoxSend2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxSend2.Name = "checkBoxSend2";
            this.checkBoxSend2.Size = new System.Drawing.Size(54, 19);
            this.checkBoxSend2.TabIndex = 7;
            this.checkBoxSend2.Text = "轮发";
            this.checkBoxSend2.UseVisualStyleBackColor = true;
            // 
            // textSendRegion1
            // 
            this.textSendRegion1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textSendRegion1.Location = new System.Drawing.Point(6, 18);
            this.textSendRegion1.Name = "textSendRegion1";
            this.textSendRegion1.Size = new System.Drawing.Size(702, 24);
            this.textSendRegion1.TabIndex = 3;
            this.textSendRegion1.Text = "";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(566, 153);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(14, 15);
            this.label27.TabIndex = 2;
            this.label27.Text = "l";
            // 
            // checkBoxSend1
            // 
            this.checkBoxSend1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxSend1.AutoSize = true;
            this.checkBoxSend1.Location = new System.Drawing.Point(726, 20);
            this.checkBoxSend1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxSend1.Name = "checkBoxSend1";
            this.checkBoxSend1.Size = new System.Drawing.Size(54, 19);
            this.checkBoxSend1.TabIndex = 6;
            this.checkBoxSend1.Text = "轮发";
            this.checkBoxSend1.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.listBoxOnline);
            this.groupBox6.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(723, 2);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Size = new System.Drawing.Size(167, 163);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "在线列表";
            // 
            // listBoxOnline
            // 
            this.listBoxOnline.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxOnline.FormattingEnabled = true;
            this.listBoxOnline.ItemHeight = 15;
            this.listBoxOnline.Location = new System.Drawing.Point(6, 18);
            this.listBoxOnline.Name = "listBoxOnline";
            this.listBoxOnline.Size = new System.Drawing.Size(155, 139);
            this.listBoxOnline.TabIndex = 13;
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Controls.Add(this.richTextBoxTips);
            this.groupBox7.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(3, 445);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox7.Size = new System.Drawing.Size(153, 106);
            this.groupBox7.TabIndex = 11;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "统计和tips";
            // 
            // richTextBoxTips
            // 
            this.richTextBoxTips.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxTips.Location = new System.Drawing.Point(6, 19);
            this.richTextBoxTips.Name = "richTextBoxTips";
            this.richTextBoxTips.Size = new System.Drawing.Size(141, 81);
            this.richTextBoxTips.TabIndex = 11;
            this.richTextBoxTips.Text = "";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 10F);
            this.label5.Location = new System.Drawing.Point(120, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "字节";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(125, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "字节";
            // 
            // textBoxRecvBytes
            // 
            this.textBoxRecvBytes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRecvBytes.Enabled = false;
            this.textBoxRecvBytes.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRecvBytes.ForeColor = System.Drawing.Color.Red;
            this.textBoxRecvBytes.Location = new System.Drawing.Point(9, 83);
            this.textBoxRecvBytes.Name = "textBoxRecvBytes";
            this.textBoxRecvBytes.Size = new System.Drawing.Size(110, 23);
            this.textBoxRecvBytes.TabIndex = 8;
            this.textBoxRecvBytes.Text = "0";
            this.textBoxRecvBytes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxSendBytes
            // 
            this.textBoxSendBytes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSendBytes.Enabled = false;
            this.textBoxSendBytes.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSendBytes.ForeColor = System.Drawing.Color.Red;
            this.textBoxSendBytes.Location = new System.Drawing.Point(9, 38);
            this.textBoxSendBytes.Name = "textBoxSendBytes";
            this.textBoxSendBytes.Size = new System.Drawing.Size(110, 23);
            this.textBoxSendBytes.TabIndex = 7;
            this.textBoxSendBytes.Text = "0";
            this.textBoxSendBytes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "接收:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "发送：";
            // 
            // groupBox8
            // 
            this.groupBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox8.Controls.Add(this.btnCelar);
            this.groupBox8.Controls.Add(this.label1);
            this.groupBox8.Controls.Add(this.label5);
            this.groupBox8.Controls.Add(this.label2);
            this.groupBox8.Controls.Add(this.label3);
            this.groupBox8.Controls.Add(this.textBoxSendBytes);
            this.groupBox8.Controls.Add(this.textBoxRecvBytes);
            this.groupBox8.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.Location = new System.Drawing.Point(723, 173);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox8.Size = new System.Drawing.Size(167, 147);
            this.groupBox8.TabIndex = 13;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "统计区";
            // 
            // btnCelar
            // 
            this.btnCelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCelar.ForeColor = System.Drawing.Color.Red;
            this.btnCelar.Location = new System.Drawing.Point(32, 110);
            this.btnCelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCelar.Name = "btnCelar";
            this.btnCelar.Size = new System.Drawing.Size(56, 23);
            this.btnCelar.TabIndex = 18;
            this.btnCelar.Text = "清空";
            this.btnCelar.UseVisualStyleBackColor = true;
            this.btnCelar.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // NetworkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(902, 562);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Consolas", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NetworkForm";
            this.Text = "网络调试助手";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NetworkForm_FormClosing);
            this.Load += new System.EventHandler(this.NetworkForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NetworkForm_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMultiFunc;
        private System.Windows.Forms.Label lblLocalhost;
        private System.Windows.Forms.Label lblProtocol;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label lblConnectStatus;
        private System.Windows.Forms.Button btnRecvClr;
        private System.Windows.Forms.CheckBox chkbPause;
        private System.Windows.Forms.CheckBox chkbRecvTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox6;
        internal System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.RadioButton raBtnUDP;
        private System.Windows.Forms.RadioButton rabtnClient;
        private System.Windows.Forms.RadioButton rabtnServer;
        private System.Windows.Forms.Button btnSend1;
        private System.Windows.Forms.Button btnSend3;
        private System.Windows.Forms.Button btnSend2;
        private System.Windows.Forms.Button btnSendRegion3;
        private System.Windows.Forms.Button btnSendRegion2;
        private System.Windows.Forms.Button btnSendRegion1;
        private System.Windows.Forms.Button btnSendLoop;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBoxTips;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button btnCelar;
        internal System.Windows.Forms.ComboBox combBLocalhost;
        internal System.Windows.Forms.TextBox textMultiFunc;
        internal System.Windows.Forms.RichTextBox textRecvRegion;
        internal System.Windows.Forms.RichTextBox textSendRegion1;
        internal System.Windows.Forms.RichTextBox textSendRegion3;
        internal System.Windows.Forms.RichTextBox textSendRegion2;
        internal System.Windows.Forms.ListBox listBoxOnline;
        internal System.Windows.Forms.TextBox textBoxRecvBytes;
        internal System.Windows.Forms.TextBox textBoxSendBytes;
        internal System.Windows.Forms.CheckBox checkBoxSend1;
        internal System.Windows.Forms.TextBox textSendInterval;
        internal System.Windows.Forms.CheckBox checkBoxSend3;
        internal System.Windows.Forms.CheckBox checkBoxSend2;
        internal System.Windows.Forms.RadioButton radioButtonUtf8;
        internal System.Windows.Forms.RadioButton radioButtonBbk;
        internal System.Windows.Forms.CheckBox chkbHEX;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.RadioButton radioBtnSendGBK;
        internal System.Windows.Forms.RadioButton radioBtnSendUTF;
        private System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.RadioButton radioBtnHEXSendNo;
        internal System.Windows.Forms.RadioButton radioBtnHEXSendYes;
        internal System.Windows.Forms.CheckBox chboxDisplaySend;
    }
}