namespace Maintain.Teaching
{
    partial class CCClampTeachControl1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.m_tbxAbsPosition = new System.Windows.Forms.TextBox();
            this.m_btnAbsoluteMove = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.m_txbSpeedPercentage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.m_btnIncrease = new System.Windows.Forms.Button();
            this.m_btnStop = new System.Windows.Forms.Button();
            this.m_tbxAxisDistance = new System.Windows.Forms.TextBox();
            this.m_btnDecrease = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.m_btnAxisSave = new System.Windows.Forms.Button();
            this.m_cbAxis = new System.Windows.Forms.ComboBox();
            this.m_tbxCurrentPos = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.m_tbxBar1Distance = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.m_btnBar1LeftAdjust = new System.Windows.Forms.Button();
            this.m_btnBar1RightAdjust = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.m_tbxBar2Distance = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.m_btnBar2LeftAdjust = new System.Windows.Forms.Button();
            this.m_btnBar2RightAdjust = new System.Windows.Forms.Button();
            this.m_UITimer = new System.Windows.Forms.Timer(this.components);
            this.m_SubheaderPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_subtitleLabel
            // 
            this.m_subtitleLabel.Size = new System.Drawing.Size(1097, 81);
            this.m_subtitleLabel.Text = "設定機台修補區域內之Clamp設定，設定完後可微調支撐Bar，或是直接紀錄目前位置。";
            // 
            // m_SubheaderPanel
            // 
            this.m_SubheaderPanel.Location = new System.Drawing.Point(0, 721);
            this.m_SubheaderPanel.Size = new System.Drawing.Size(1101, 85);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(2, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 645);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "移動操作";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(10, 150);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(453, 346);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.m_tbxAbsPosition);
            this.groupBox6.Controls.Add(this.m_btnAbsoluteMove);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Location = new System.Drawing.Point(15, 261);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(432, 79);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "絕對移動操作";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(247, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 19);
            this.label10.TabIndex = 10;
            this.label10.Text = "(mn)";
            // 
            // m_tbxAbsPosition
            // 
            this.m_tbxAbsPosition.Location = new System.Drawing.Point(126, 35);
            this.m_tbxAbsPosition.Name = "m_tbxAbsPosition";
            this.m_tbxAbsPosition.Size = new System.Drawing.Size(115, 22);
            this.m_tbxAbsPosition.TabIndex = 5;
            this.m_tbxAbsPosition.Text = "100";
            // 
            // m_btnAbsoluteMove
            // 
            this.m_btnAbsoluteMove.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_btnAbsoluteMove.Location = new System.Drawing.Point(297, 26);
            this.m_btnAbsoluteMove.Name = "m_btnAbsoluteMove";
            this.m_btnAbsoluteMove.Size = new System.Drawing.Size(108, 36);
            this.m_btnAbsoluteMove.TabIndex = 2;
            this.m_btnAbsoluteMove.Text = "絕對移動";
            this.m_btnAbsoluteMove.UseVisualStyleBackColor = true;
            this.m_btnAbsoluteMove.Click += new System.EventHandler(this.m_btnAbsoluteMove_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(15, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "絕對位置：";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.m_txbSpeedPercentage);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Location = new System.Drawing.Point(15, 21);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(432, 100);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "移動速度設定";
            // 
            // m_txbSpeedPercentage
            // 
            this.m_txbSpeedPercentage.Location = new System.Drawing.Point(140, 38);
            this.m_txbSpeedPercentage.Name = "m_txbSpeedPercentage";
            this.m_txbSpeedPercentage.Size = new System.Drawing.Size(85, 22);
            this.m_txbSpeedPercentage.TabIndex = 6;
            this.m_txbSpeedPercentage.Text = "100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(15, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "速度設定(%)：";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.m_btnIncrease);
            this.groupBox4.Controls.Add(this.m_btnStop);
            this.groupBox4.Controls.Add(this.m_tbxAxisDistance);
            this.groupBox4.Controls.Add(this.m_btnDecrease);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(15, 127);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(432, 128);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "相對移動操作";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(284, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 19);
            this.label9.TabIndex = 9;
            this.label9.Text = "(mn)";
            // 
            // m_btnIncrease
            // 
            this.m_btnIncrease.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_btnIncrease.Location = new System.Drawing.Point(225, 72);
            this.m_btnIncrease.Name = "m_btnIncrease";
            this.m_btnIncrease.Size = new System.Drawing.Size(83, 36);
            this.m_btnIncrease.TabIndex = 7;
            this.m_btnIncrease.Text = "夾緊微調";
            this.m_btnIncrease.UseVisualStyleBackColor = true;
            this.m_btnIncrease.Click += new System.EventHandler(this.m_btnIncrease_Click);
            // 
            // m_btnStop
            // 
            this.m_btnStop.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_btnStop.Location = new System.Drawing.Point(126, 72);
            this.m_btnStop.Name = "m_btnStop";
            this.m_btnStop.Size = new System.Drawing.Size(78, 36);
            this.m_btnStop.TabIndex = 6;
            this.m_btnStop.Text = "Stop";
            this.m_btnStop.UseVisualStyleBackColor = true;
            // 
            // m_tbxAxisDistance
            // 
            this.m_tbxAxisDistance.Location = new System.Drawing.Point(163, 32);
            this.m_tbxAxisDistance.Name = "m_tbxAxisDistance";
            this.m_tbxAxisDistance.Size = new System.Drawing.Size(115, 22);
            this.m_tbxAxisDistance.TabIndex = 5;
            this.m_tbxAxisDistance.Text = "100";
            // 
            // m_btnDecrease
            // 
            this.m_btnDecrease.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_btnDecrease.Location = new System.Drawing.Point(19, 72);
            this.m_btnDecrease.Name = "m_btnDecrease";
            this.m_btnDecrease.Size = new System.Drawing.Size(86, 36);
            this.m_btnDecrease.TabIndex = 2;
            this.m_btnDecrease.Text = "放鬆微調";
            this.m_btnDecrease.UseVisualStyleBackColor = true;
            this.m_btnDecrease.Click += new System.EventHandler(this.m_btnDecrease_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(15, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "相對移動距離：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.m_btnAxisSave);
            this.groupBox2.Controls.Add(this.m_cbAxis);
            this.groupBox2.Controls.Add(this.m_tbxCurrentPos);
            this.groupBox2.Location = new System.Drawing.Point(10, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(453, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "目前位置";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(262, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 19);
            this.label11.TabIndex = 9;
            this.label11.Text = "(mn)";
            // 
            // m_btnAxisSave
            // 
            this.m_btnAxisSave.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_btnAxisSave.Location = new System.Drawing.Point(312, 23);
            this.m_btnAxisSave.Name = "m_btnAxisSave";
            this.m_btnAxisSave.Size = new System.Drawing.Size(75, 36);
            this.m_btnAxisSave.TabIndex = 8;
            this.m_btnAxisSave.Text = "Save";
            this.m_btnAxisSave.UseVisualStyleBackColor = true;
            this.m_btnAxisSave.Click += new System.EventHandler(this.m_btnAxisSave_Click);
            // 
            // m_cbAxis
            // 
            this.m_cbAxis.FormattingEnabled = true;
            this.m_cbAxis.Items.AddRange(new object[] {
            "C1C2",
            "SA1&SA2"});
            this.m_cbAxis.Location = new System.Drawing.Point(15, 34);
            this.m_cbAxis.Name = "m_cbAxis";
            this.m_cbAxis.Size = new System.Drawing.Size(121, 20);
            this.m_cbAxis.TabIndex = 4;
            // 
            // m_tbxCurrentPos
            // 
            this.m_tbxCurrentPos.Location = new System.Drawing.Point(156, 33);
            this.m_tbxCurrentPos.Name = "m_tbxCurrentPos";
            this.m_tbxCurrentPos.ReadOnly = true;
            this.m_tbxCurrentPos.Size = new System.Drawing.Size(100, 22);
            this.m_tbxCurrentPos.TabIndex = 3;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.tabControl1);
            this.groupBox7.Location = new System.Drawing.Point(601, 66);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(515, 645);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "支撐Bar微調";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(6, 21);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(496, 475);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.groupBox9);
            this.tabPage1.Controls.Add(this.groupBox8);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(488, 450);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "支撐 Bar1";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.button4);
            this.groupBox9.Controls.Add(this.textBox1);
            this.groupBox9.Controls.Add(this.label6);
            this.groupBox9.Location = new System.Drawing.Point(6, 6);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(469, 100);
            this.groupBox9.TabIndex = 10;
            this.groupBox9.TabStop = false;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button4.Location = new System.Drawing.Point(231, 29);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 43);
            this.button4.TabIndex = 7;
            this.button4.Text = "Save";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.m_btnAxisSave_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(115, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(21, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "目前位置：";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.m_tbxBar1Distance);
            this.groupBox8.Controls.Add(this.label3);
            this.groupBox8.Controls.Add(this.m_btnBar1LeftAdjust);
            this.groupBox8.Controls.Add(this.m_btnBar1RightAdjust);
            this.groupBox8.Location = new System.Drawing.Point(6, 117);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(469, 160);
            this.groupBox8.TabIndex = 9;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "移動操作";
            // 
            // m_tbxBar1Distance
            // 
            this.m_tbxBar1Distance.Location = new System.Drawing.Point(167, 35);
            this.m_tbxBar1Distance.Name = "m_tbxBar1Distance";
            this.m_tbxBar1Distance.Size = new System.Drawing.Size(115, 22);
            this.m_tbxBar1Distance.TabIndex = 7;
            this.m_tbxBar1Distance.Text = "100";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(19, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "相對移動距離：";
            // 
            // m_btnBar1LeftAdjust
            // 
            this.m_btnBar1LeftAdjust.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_btnBar1LeftAdjust.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.m_btnBar1LeftAdjust.Location = new System.Drawing.Point(49, 77);
            this.m_btnBar1LeftAdjust.Name = "m_btnBar1LeftAdjust";
            this.m_btnBar1LeftAdjust.Size = new System.Drawing.Size(85, 38);
            this.m_btnBar1LeftAdjust.TabIndex = 4;
            this.m_btnBar1LeftAdjust.Text = "往左調整";
            this.m_btnBar1LeftAdjust.UseVisualStyleBackColor = true;
            this.m_btnBar1LeftAdjust.Click += new System.EventHandler(this.m_btnBar1LeftAdjust_Click);
            // 
            // m_btnBar1RightAdjust
            // 
            this.m_btnBar1RightAdjust.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_btnBar1RightAdjust.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.m_btnBar1RightAdjust.Location = new System.Drawing.Point(167, 77);
            this.m_btnBar1RightAdjust.Name = "m_btnBar1RightAdjust";
            this.m_btnBar1RightAdjust.Size = new System.Drawing.Size(90, 38);
            this.m_btnBar1RightAdjust.TabIndex = 3;
            this.m_btnBar1RightAdjust.Text = "往右調整";
            this.m_btnBar1RightAdjust.UseVisualStyleBackColor = true;
            this.m_btnBar1RightAdjust.Click += new System.EventHandler(this.m_btnBar1RightAdjust_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.groupBox10);
            this.tabPage2.Controls.Add(this.groupBox11);
            this.tabPage2.Location = new System.Drawing.Point(4, 21);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(488, 450);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "支撐 Bar2";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.label12);
            this.groupBox10.Controls.Add(this.button3);
            this.groupBox10.Controls.Add(this.textBox3);
            this.groupBox10.Controls.Add(this.label5);
            this.groupBox10.Location = new System.Drawing.Point(6, 6);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(469, 100);
            this.groupBox10.TabIndex = 12;
            this.groupBox10.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(221, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 19);
            this.label12.TabIndex = 9;
            this.label12.Text = "(mn)";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button3.Location = new System.Drawing.Point(282, 29);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 43);
            this.button3.TabIndex = 7;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.m_btnAxisSave_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(115, 36);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(21, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "目前位置：";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.label8);
            this.groupBox11.Controls.Add(this.m_tbxBar2Distance);
            this.groupBox11.Controls.Add(this.label7);
            this.groupBox11.Controls.Add(this.m_btnBar2LeftAdjust);
            this.groupBox11.Controls.Add(this.m_btnBar2RightAdjust);
            this.groupBox11.Location = new System.Drawing.Point(6, 117);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(469, 160);
            this.groupBox11.TabIndex = 11;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "移動操作";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(288, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 19);
            this.label8.TabIndex = 8;
            this.label8.Text = "(mn)";
            // 
            // m_tbxBar2Distance
            // 
            this.m_tbxBar2Distance.Location = new System.Drawing.Point(167, 35);
            this.m_tbxBar2Distance.Name = "m_tbxBar2Distance";
            this.m_tbxBar2Distance.Size = new System.Drawing.Size(115, 22);
            this.m_tbxBar2Distance.TabIndex = 7;
            this.m_tbxBar2Distance.Text = "100";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(19, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "相對移動距離：";
            // 
            // m_btnBar2LeftAdjust
            // 
            this.m_btnBar2LeftAdjust.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_btnBar2LeftAdjust.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.m_btnBar2LeftAdjust.Location = new System.Drawing.Point(49, 77);
            this.m_btnBar2LeftAdjust.Name = "m_btnBar2LeftAdjust";
            this.m_btnBar2LeftAdjust.Size = new System.Drawing.Size(85, 38);
            this.m_btnBar2LeftAdjust.TabIndex = 4;
            this.m_btnBar2LeftAdjust.Text = "往左調整";
            this.m_btnBar2LeftAdjust.UseVisualStyleBackColor = true;
            this.m_btnBar2LeftAdjust.Click += new System.EventHandler(this.m_btnBar1LeftAdjust_Click);
            // 
            // m_btnBar2RightAdjust
            // 
            this.m_btnBar2RightAdjust.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_btnBar2RightAdjust.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.m_btnBar2RightAdjust.Location = new System.Drawing.Point(167, 77);
            this.m_btnBar2RightAdjust.Name = "m_btnBar2RightAdjust";
            this.m_btnBar2RightAdjust.Size = new System.Drawing.Size(90, 38);
            this.m_btnBar2RightAdjust.TabIndex = 3;
            this.m_btnBar2RightAdjust.Text = "往右調整";
            this.m_btnBar2RightAdjust.UseVisualStyleBackColor = true;
            // 
            // m_UITimer
            // 
            this.m_UITimer.Enabled = true;
            this.m_UITimer.Tick += new System.EventHandler(this.m_UITimer_Tick);
            // 
            // CCClampTeachControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox1);
            this.Name = "CCClampTeachControl1";
            this.Controls.SetChildIndex(this.m_SubheaderPanel, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox7, 0);
            this.m_SubheaderPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox m_cbAxis;
        private System.Windows.Forms.TextBox m_tbxCurrentPos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button m_btnIncrease;
        private System.Windows.Forms.Button m_btnStop;
        private System.Windows.Forms.TextBox m_tbxAxisDistance;
        private System.Windows.Forms.Button m_btnDecrease;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox m_tbxAbsPosition;
        private System.Windows.Forms.Button m_btnAbsoluteMove;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox m_txbSpeedPercentage;
        private System.Windows.Forms.Button m_btnAxisSave;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button m_btnBar1LeftAdjust;
        private System.Windows.Forms.Button m_btnBar1RightAdjust;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox m_tbxBar1Distance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.TextBox m_tbxBar2Distance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button m_btnBar2LeftAdjust;
        private System.Windows.Forms.Button m_btnBar2RightAdjust;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Timer m_UITimer;
    }
}
