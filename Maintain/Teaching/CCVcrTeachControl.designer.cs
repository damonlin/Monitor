namespace Maintain.Teaching
{
    partial class CCVcrTeachControl
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該公開 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改這個方法的內容。
        ///
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            ContrelModule.RS232Info rS232Info1 = new ContrelModule.RS232Info();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.m_btnZAxisGet = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.m_tbxZAxis = new System.Windows.Forms.TextBox();
            this.m_btnSAxisGet = new System.Windows.Forms.Button();
            this.m_btnGAxisGet = new System.Windows.Forms.Button();
            this.m_btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.m_tbxSAxis = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.m_tbxGAxis = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.m_tbxZAxisPos = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.m_btnRight = new System.Windows.Forms.Button();
            this.m_btnDown = new System.Windows.Forms.Button();
            this.m_btnLeft = new System.Windows.Forms.Button();
            this.m_btnUp = new System.Windows.Forms.Button();
            this.m_txbSpeedPercentage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.m_tbxSAxisPos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.m_tbxAxisDistance = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.m_tbxGAxisPos = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.m_chkContiousVCR = new System.Windows.Forms.CheckBox();
            this.m_btnVCRReadPosition = new System.Windows.Forms.Button();
            this.m_btnVCRReadTest = new System.Windows.Forms.Button();
            this.m_UITimer = new System.Windows.Forms.Timer(this.components);
            this.m_UIerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.zMotionControl1 = new ContrelModule.ZMotionControl();
            this.m_SubheaderPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_UIerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // m_subtitleLabel
            // 
            this.m_subtitleLabel.Text = "設定VCR讀取位置功能";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.m_btnZAxisGet);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.m_tbxZAxis);
            this.groupBox1.Controls.Add(this.m_btnSAxisGet);
            this.groupBox1.Controls.Add(this.m_btnGAxisGet);
            this.groupBox1.Controls.Add(this.m_btnSave);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.m_tbxSAxis);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.m_tbxGAxis);
            this.groupBox1.Location = new System.Drawing.Point(651, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 201);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "VCR 讀取設定位置設定";
            // 
            // m_btnZAxisGet
            // 
            this.m_btnZAxisGet.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_btnZAxisGet.Location = new System.Drawing.Point(216, 127);
            this.m_btnZAxisGet.Name = "m_btnZAxisGet";
            this.m_btnZAxisGet.Size = new System.Drawing.Size(75, 33);
            this.m_btnZAxisGet.TabIndex = 16;
            this.m_btnZAxisGet.Text = "Get";
            this.m_btnZAxisGet.UseVisualStyleBackColor = true;
            this.m_btnZAxisGet.Click += new System.EventHandler(this.m_btnZAxisGet_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(53, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Z軸：";
            // 
            // m_tbxZAxis
            // 
            this.m_tbxZAxis.Location = new System.Drawing.Point(110, 135);
            this.m_tbxZAxis.Name = "m_tbxZAxis";
            this.m_tbxZAxis.ReadOnly = true;
            this.m_tbxZAxis.Size = new System.Drawing.Size(100, 22);
            this.m_tbxZAxis.TabIndex = 15;
            this.m_tbxZAxis.Text = "1000";
            // 
            // m_btnSAxisGet
            // 
            this.m_btnSAxisGet.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_btnSAxisGet.Location = new System.Drawing.Point(216, 77);
            this.m_btnSAxisGet.Name = "m_btnSAxisGet";
            this.m_btnSAxisGet.Size = new System.Drawing.Size(75, 33);
            this.m_btnSAxisGet.TabIndex = 13;
            this.m_btnSAxisGet.Text = "Get";
            this.m_btnSAxisGet.UseVisualStyleBackColor = true;
            this.m_btnSAxisGet.Click += new System.EventHandler(this.m_btnSAxisGet_Click);
            // 
            // m_btnGAxisGet
            // 
            this.m_btnGAxisGet.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_btnGAxisGet.Location = new System.Drawing.Point(216, 33);
            this.m_btnGAxisGet.Name = "m_btnGAxisGet";
            this.m_btnGAxisGet.Size = new System.Drawing.Size(75, 32);
            this.m_btnGAxisGet.TabIndex = 12;
            this.m_btnGAxisGet.Text = "Get";
            this.m_btnGAxisGet.UseVisualStyleBackColor = true;
            this.m_btnGAxisGet.Click += new System.EventHandler(this.m_btnGAxisGet_Click);
            // 
            // m_btnSave
            // 
            this.m_btnSave.BackColor = System.Drawing.Color.DodgerBlue;
            this.m_btnSave.Location = new System.Drawing.Point(297, 60);
            this.m_btnSave.Name = "m_btnSave";
            this.m_btnSave.Size = new System.Drawing.Size(79, 80);
            this.m_btnSave.TabIndex = 11;
            this.m_btnSave.Text = "Save";
            this.m_btnSave.UseVisualStyleBackColor = false;
            this.m_btnSave.Click += new System.EventHandler(this.m_btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(53, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "S軸：";
            // 
            // m_tbxSAxis
            // 
            this.m_tbxSAxis.Location = new System.Drawing.Point(110, 85);
            this.m_tbxSAxis.Name = "m_tbxSAxis";
            this.m_tbxSAxis.ReadOnly = true;
            this.m_tbxSAxis.Size = new System.Drawing.Size(100, 22);
            this.m_tbxSAxis.TabIndex = 10;
            this.m_tbxSAxis.Text = "1000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(53, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "G軸：";
            // 
            // m_tbxGAxis
            // 
            this.m_tbxGAxis.Location = new System.Drawing.Point(110, 33);
            this.m_tbxGAxis.Name = "m_tbxGAxis";
            this.m_tbxGAxis.ReadOnly = true;
            this.m_tbxGAxis.Size = new System.Drawing.Size(100, 22);
            this.m_tbxGAxis.TabIndex = 8;
            this.m_tbxGAxis.Text = "1000";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.zMotionControl1);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.m_tbxZAxisPos);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.m_txbSpeedPercentage);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.m_tbxSAxisPos);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.m_tbxAxisDistance);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.m_tbxGAxisPos);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(651, 270);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(439, 342);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "VCR 微調工具";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(333, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 16);
            this.label11.TabIndex = 29;
            this.label11.Text = "(um)";
            // 
            // m_tbxZAxisPos
            // 
            this.m_tbxZAxisPos.Location = new System.Drawing.Point(212, 69);
            this.m_tbxZAxisPos.Name = "m_tbxZAxisPos";
            this.m_tbxZAxisPos.ReadOnly = true;
            this.m_tbxZAxisPos.Size = new System.Drawing.Size(115, 22);
            this.m_tbxZAxisPos.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(69, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 16);
            this.label12.TabIndex = 27;
            this.label12.Text = "Z軸目前位置：";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.m_btnRight);
            this.groupBox4.Controls.Add(this.m_btnDown);
            this.groupBox4.Controls.Add(this.m_btnLeft);
            this.groupBox4.Controls.Add(this.m_btnUp);
            this.groupBox4.ForeColor = System.Drawing.Color.Red;
            this.groupBox4.Location = new System.Drawing.Point(4, 147);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(168, 189);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            // 
            // m_btnRight
            // 
            this.m_btnRight.Image = global::Maintain.Properties.Resources.Button_Next_icon;
            this.m_btnRight.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.m_btnRight.Location = new System.Drawing.Point(89, 76);
            this.m_btnRight.Name = "m_btnRight";
            this.m_btnRight.Size = new System.Drawing.Size(77, 49);
            this.m_btnRight.TabIndex = 7;
            this.m_btnRight.Text = "RIGHT";
            this.m_btnRight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_btnRight.UseVisualStyleBackColor = true;
            this.m_btnRight.Click += new System.EventHandler(this.m_btnRight_Click);
            // 
            // m_btnDown
            // 
            this.m_btnDown.Image = global::Maintain.Properties.Resources.Button_Download_icon;
            this.m_btnDown.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_btnDown.Location = new System.Drawing.Point(50, 131);
            this.m_btnDown.Name = "m_btnDown";
            this.m_btnDown.Size = new System.Drawing.Size(86, 49);
            this.m_btnDown.TabIndex = 6;
            this.m_btnDown.Text = "DOWN";
            this.m_btnDown.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.m_btnDown.UseVisualStyleBackColor = true;
            this.m_btnDown.Click += new System.EventHandler(this.m_btnDown_Click);
            // 
            // m_btnLeft
            // 
            this.m_btnLeft.Image = global::Maintain.Properties.Resources.Button_Previous_icon;
            this.m_btnLeft.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_btnLeft.Location = new System.Drawing.Point(6, 76);
            this.m_btnLeft.Name = "m_btnLeft";
            this.m_btnLeft.Size = new System.Drawing.Size(77, 49);
            this.m_btnLeft.TabIndex = 5;
            this.m_btnLeft.Text = "LEFT";
            this.m_btnLeft.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.m_btnLeft.UseVisualStyleBackColor = true;
            this.m_btnLeft.Click += new System.EventHandler(this.m_btnLeft_Click);
            // 
            // m_btnUp
            // 
            this.m_btnUp.Image = global::Maintain.Properties.Resources.Button_Upload_icon;
            this.m_btnUp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_btnUp.Location = new System.Drawing.Point(50, 21);
            this.m_btnUp.Name = "m_btnUp";
            this.m_btnUp.Size = new System.Drawing.Size(77, 49);
            this.m_btnUp.TabIndex = 4;
            this.m_btnUp.Text = "UP";
            this.m_btnUp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.m_btnUp.UseVisualStyleBackColor = true;
            this.m_btnUp.Click += new System.EventHandler(this.m_btnUp_Click);
            // 
            // m_txbSpeedPercentage
            // 
            this.m_txbSpeedPercentage.Location = new System.Drawing.Point(212, 123);
            this.m_txbSpeedPercentage.Name = "m_txbSpeedPercentage";
            this.m_txbSpeedPercentage.Size = new System.Drawing.Size(115, 22);
            this.m_txbSpeedPercentage.TabIndex = 25;
            this.m_txbSpeedPercentage.Text = "100";
            this.m_txbSpeedPercentage.Validated += new System.EventHandler(this.m_txbSpeedPercentage_Validated);
            this.m_txbSpeedPercentage.Validating += new System.ComponentModel.CancelEventHandler(this.m_txbSpeedPercentage_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(73, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "速度設定(%)：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(333, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "(um)";
            // 
            // m_tbxSAxisPos
            // 
            this.m_tbxSAxisPos.Location = new System.Drawing.Point(212, 43);
            this.m_tbxSAxisPos.Name = "m_tbxSAxisPos";
            this.m_tbxSAxisPos.ReadOnly = true;
            this.m_tbxSAxisPos.Size = new System.Drawing.Size(115, 22);
            this.m_tbxSAxisPos.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(69, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "S軸目前位置：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(333, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "(um)";
            // 
            // m_tbxAxisDistance
            // 
            this.m_tbxAxisDistance.Location = new System.Drawing.Point(212, 97);
            this.m_tbxAxisDistance.Name = "m_tbxAxisDistance";
            this.m_tbxAxisDistance.Size = new System.Drawing.Size(115, 22);
            this.m_tbxAxisDistance.TabIndex = 19;
            this.m_tbxAxisDistance.Text = "100";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(64, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "相對移動距離：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(333, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "(um)";
            // 
            // m_tbxGAxisPos
            // 
            this.m_tbxGAxisPos.Location = new System.Drawing.Point(212, 14);
            this.m_tbxGAxisPos.Name = "m_tbxGAxisPos";
            this.m_tbxGAxisPos.ReadOnly = true;
            this.m_tbxGAxisPos.Size = new System.Drawing.Size(115, 22);
            this.m_tbxGAxisPos.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(69, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "G軸目前位置：";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.m_chkContiousVCR);
            this.groupBox3.Controls.Add(this.m_btnVCRReadPosition);
            this.groupBox3.Controls.Add(this.m_btnVCRReadTest);
            this.groupBox3.Location = new System.Drawing.Point(651, 618);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(439, 92);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "VCR 測試";
            // 
            // m_chkContiousVCR
            // 
            this.m_chkContiousVCR.AutoSize = true;
            this.m_chkContiousVCR.Location = new System.Drawing.Point(294, 30);
            this.m_chkContiousVCR.Name = "m_chkContiousVCR";
            this.m_chkContiousVCR.Size = new System.Drawing.Size(96, 16);
            this.m_chkContiousVCR.TabIndex = 2;
            this.m_chkContiousVCR.Text = "連續讀取VCR";
            this.m_chkContiousVCR.UseVisualStyleBackColor = true;
            this.m_chkContiousVCR.CheckedChanged += new System.EventHandler(this.m_chkContiousVCR_CheckedChanged);
            // 
            // m_btnVCRReadPosition
            // 
            this.m_btnVCRReadPosition.Location = new System.Drawing.Point(30, 18);
            this.m_btnVCRReadPosition.Name = "m_btnVCRReadPosition";
            this.m_btnVCRReadPosition.Size = new System.Drawing.Size(119, 57);
            this.m_btnVCRReadPosition.TabIndex = 1;
            this.m_btnVCRReadPosition.Text = "VCR 讀取位置";
            this.m_btnVCRReadPosition.UseVisualStyleBackColor = true;
            this.m_btnVCRReadPosition.Click += new System.EventHandler(this.m_btnVCRReadPosition_Click);
            // 
            // m_btnVCRReadTest
            // 
            this.m_btnVCRReadTest.Location = new System.Drawing.Point(169, 18);
            this.m_btnVCRReadTest.Name = "m_btnVCRReadTest";
            this.m_btnVCRReadTest.Size = new System.Drawing.Size(119, 57);
            this.m_btnVCRReadTest.TabIndex = 0;
            this.m_btnVCRReadTest.Text = "VCR 讀取測試";
            this.m_btnVCRReadTest.UseVisualStyleBackColor = true;
            this.m_btnVCRReadTest.Click += new System.EventHandler(this.m_btnVCRReadTest_Click);
            // 
            // m_UITimer
            // 
            this.m_UITimer.Enabled = true;
            this.m_UITimer.Interval = 500;
            this.m_UITimer.Tick += new System.EventHandler(this.m_UITimer_Tick);
            // 
            // m_UIerrorProvider
            // 
            this.m_UIerrorProvider.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(3, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 480);
            this.panel1.TabIndex = 18;
            // 
            // zMotionControl1
            // 
            rS232Info1.PortBoudrate = 9600;
            rS232Info1.PortDataBits = 8;
            rS232Info1.PortNumber = 2;
            rS232Info1.PortParity = System.IO.Ports.Parity.None;
            rS232Info1.PortStopBits = System.IO.Ports.StopBits.One;
            rS232Info1.ReteyTimes = 3;
            this.zMotionControl1._0_Info = rS232Info1;
            this.zMotionControl1.Enable = false;
            this.zMotionControl1.Location = new System.Drawing.Point(176, 154);
            this.zMotionControl1.Name = "zMotionControl1";
            this.zMotionControl1.Size = new System.Drawing.Size(262, 72);
            this.zMotionControl1.TabIndex = 19;
            // 
            // CCVcrTeachControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CCVcrTeachControl";
            this.Controls.SetChildIndex(this.m_SubheaderPanel, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.m_SubheaderPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_UIerrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button m_btnSAxisGet;
        private System.Windows.Forms.Button m_btnGAxisGet;
        private System.Windows.Forms.Button m_btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox m_tbxSAxis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox m_tbxGAxis;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox m_txbSpeedPercentage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox m_tbxSAxisPos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox m_tbxAxisDistance;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox m_tbxGAxisPos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button m_btnVCRReadPosition;
        private System.Windows.Forms.Button m_btnVCRReadTest;
        private System.Windows.Forms.Timer m_UITimer;
        private System.Windows.Forms.ErrorProvider m_UIerrorProvider;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button m_btnRight;
        private System.Windows.Forms.Button m_btnDown;
        private System.Windows.Forms.Button m_btnLeft;
        private System.Windows.Forms.Button m_btnUp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox m_chkContiousVCR;
        private System.Windows.Forms.Button m_btnZAxisGet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox m_tbxZAxis;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox m_tbxZAxisPos;
        private System.Windows.Forms.Label label12;
        private ContrelModule.ZMotionControl zMotionControl1;
    }
}
