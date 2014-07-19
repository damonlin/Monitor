namespace Maintain.Teaching
{
    partial class CCLaserPathTeachControl
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

            // TODO: 測試用，要改回來
            Maintain.TestZone.CCLaserTriggerInterface.getSingleton().Destroy();
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改這個方法的內容。
        ///
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.m_txbZOffset = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.m_txbPolarize = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.m_txbDec = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.m_txbSpeed = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.m_txbAcc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.m_txbLaserPower = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.m_btnLoad = new System.Windows.Forms.Button();
            this.m_btnSave = new System.Windows.Forms.Button();
            this.m_btnDelete = new System.Windows.Forms.Button();
            this.m_lbLaserPara = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.m_btnLen50X = new System.Windows.Forms.RadioButton();
            this.m_btnLen20X = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.m_btnLineMeasure = new System.Windows.Forms.RadioButton();
            this.m_btnDeletePoint = new System.Windows.Forms.RadioButton();
            this.m_btnAddPoint = new System.Windows.Forms.RadioButton();
            this.m_btnMovePoint = new System.Windows.Forms.RadioButton();
            this.m_btnMovePath = new System.Windows.Forms.RadioButton();
            this.m_btnDrawPath = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.m_radioYStartDown = new System.Windows.Forms.RadioButton();
            this.m_radioYStartUp = new System.Windows.Forms.RadioButton();
            this.m_btnAutoDrawPath = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.m_txbPitchY = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.m_txbPitchX = new System.Windows.Forms.TextBox();
            this.lable = new System.Windows.Forms.Label();
            this.m_txbHeight = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.m_txbWidth = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.m_radioXStartLeft = new System.Windows.Forms.RadioButton();
            this.m_radioXStartRight = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.m_radioBottonLeft = new System.Windows.Forms.RadioButton();
            this.m_radioLeft = new System.Windows.Forms.RadioButton();
            this.m_radioTopLeft = new System.Windows.Forms.RadioButton();
            this.m_radioBotton = new System.Windows.Forms.RadioButton();
            this.m_radioBottonRight = new System.Windows.Forms.RadioButton();
            this.m_radioRight = new System.Windows.Forms.RadioButton();
            this.m_radioTopRight = new System.Windows.Forms.RadioButton();
            this.m_radioTop = new System.Windows.Forms.RadioButton();
            this.m_txbAngle = new System.Windows.Forms.TextBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.ccd1 = new Vision.CCD();
            this.m_SubheaderPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_subtitleLabel
            // 
            this.m_subtitleLabel.Text = "設定雷射路徑與雷射參數等功能";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.m_txbZOffset);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.m_txbPolarize);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.m_txbDec);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.m_txbSpeed);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.m_txbAcc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.m_txbLaserPower);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(399, 549);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 162);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "雷射參數設定";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Enabled = false;
            this.label11.Location = new System.Drawing.Point(185, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 12);
            this.label11.TabIndex = 38;
            this.label11.Text = "μm";
            // 
            // m_txbZOffset
            // 
            this.m_txbZOffset.Enabled = false;
            this.m_txbZOffset.Location = new System.Drawing.Point(79, 131);
            this.m_txbZOffset.Name = "m_txbZOffset";
            this.m_txbZOffset.Size = new System.Drawing.Size(100, 22);
            this.m_txbZOffset.TabIndex = 37;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Enabled = false;
            this.label12.Location = new System.Drawing.Point(15, 136);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 12);
            this.label12.TabIndex = 36;
            this.label12.Text = "Z軸Offset：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Enabled = false;
            this.label9.Location = new System.Drawing.Point(185, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 35;
            this.label9.Text = "0~45度";
            // 
            // m_txbPolarize
            // 
            this.m_txbPolarize.Enabled = false;
            this.m_txbPolarize.Location = new System.Drawing.Point(79, 109);
            this.m_txbPolarize.Name = "m_txbPolarize";
            this.m_txbPolarize.Size = new System.Drawing.Size(100, 22);
            this.m_txbPolarize.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Enabled = false;
            this.label10.Location = new System.Drawing.Point(15, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 33;
            this.label10.Text = "偏振方向：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(185, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 12);
            this.label7.TabIndex = 32;
            this.label7.Text = "μm";
            // 
            // m_txbDec
            // 
            this.m_txbDec.Location = new System.Drawing.Point(79, 87);
            this.m_txbDec.Name = "m_txbDec";
            this.m_txbDec.Size = new System.Drawing.Size(100, 22);
            this.m_txbDec.TabIndex = 31;
            this.m_txbDec.Text = "500";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 30;
            this.label8.Text = "減速度：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(185, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 12);
            this.label5.TabIndex = 29;
            this.label5.Text = "μm";
            // 
            // m_txbSpeed
            // 
            this.m_txbSpeed.Location = new System.Drawing.Point(79, 65);
            this.m_txbSpeed.Name = "m_txbSpeed";
            this.m_txbSpeed.Size = new System.Drawing.Size(100, 22);
            this.m_txbSpeed.TabIndex = 28;
            this.m_txbSpeed.Text = "500";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 27;
            this.label6.Text = "速度：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 12);
            this.label3.TabIndex = 26;
            this.label3.Text = "μm";
            // 
            // m_txbAcc
            // 
            this.m_txbAcc.Location = new System.Drawing.Point(79, 43);
            this.m_txbAcc.Name = "m_txbAcc";
            this.m_txbAcc.Size = new System.Drawing.Size(100, 22);
            this.m_txbAcc.TabIndex = 25;
            this.m_txbAcc.Text = "500";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 24;
            this.label4.Text = "加速度：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 23;
            this.label2.Text = "％";
            // 
            // m_txbLaserPower
            // 
            this.m_txbLaserPower.Location = new System.Drawing.Point(79, 21);
            this.m_txbLaserPower.Name = "m_txbLaserPower";
            this.m_txbLaserPower.Size = new System.Drawing.Size(100, 22);
            this.m_txbLaserPower.TabIndex = 22;
            this.m_txbLaserPower.Text = "100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 21;
            this.label1.Text = "雷射能量：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.m_btnLoad);
            this.groupBox2.Controls.Add(this.m_btnSave);
            this.groupBox2.Controls.Add(this.m_btnDelete);
            this.groupBox2.Controls.Add(this.m_lbLaserPara);
            this.groupBox2.Location = new System.Drawing.Point(649, 528);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(448, 183);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "雷射路徑參數列表";
            // 
            // m_btnLoad
            // 
            this.m_btnLoad.Location = new System.Drawing.Point(303, 106);
            this.m_btnLoad.Name = "m_btnLoad";
            this.m_btnLoad.Size = new System.Drawing.Size(118, 36);
            this.m_btnLoad.TabIndex = 3;
            this.m_btnLoad.Text = "Load";
            this.m_btnLoad.UseVisualStyleBackColor = true;
            this.m_btnLoad.Click += new System.EventHandler(this.m_btnLoad_Click);
            // 
            // m_btnSave
            // 
            this.m_btnSave.Location = new System.Drawing.Point(303, 22);
            this.m_btnSave.Name = "m_btnSave";
            this.m_btnSave.Size = new System.Drawing.Size(118, 36);
            this.m_btnSave.TabIndex = 2;
            this.m_btnSave.Text = "Save";
            this.m_btnSave.UseVisualStyleBackColor = true;
            this.m_btnSave.Click += new System.EventHandler(this.m_btnSave_Click);
            // 
            // m_btnDelete
            // 
            this.m_btnDelete.Location = new System.Drawing.Point(304, 64);
            this.m_btnDelete.Name = "m_btnDelete";
            this.m_btnDelete.Size = new System.Drawing.Size(118, 36);
            this.m_btnDelete.TabIndex = 1;
            this.m_btnDelete.Text = "Delete";
            this.m_btnDelete.UseVisualStyleBackColor = true;
            this.m_btnDelete.Click += new System.EventHandler(this.m_btnDelete_Click);
            // 
            // m_lbLaserPara
            // 
            this.m_lbLaserPara.FormattingEnabled = true;
            this.m_lbLaserPara.ItemHeight = 12;
            this.m_lbLaserPara.Location = new System.Drawing.Point(12, 21);
            this.m_lbLaserPara.Name = "m_lbLaserPara";
            this.m_lbLaserPara.Size = new System.Drawing.Size(269, 160);
            this.m_lbLaserPara.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.m_btnLen50X);
            this.groupBox3.Controls.Add(this.m_btnLen20X);
            this.groupBox3.Location = new System.Drawing.Point(287, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(156, 100);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "鏡頭選擇";
            // 
            // m_btnLen50X
            // 
            this.m_btnLen50X.Appearance = System.Windows.Forms.Appearance.Button;
            this.m_btnLen50X.Location = new System.Drawing.Point(79, 39);
            this.m_btnLen50X.Name = "m_btnLen50X";
            this.m_btnLen50X.Size = new System.Drawing.Size(67, 44);
            this.m_btnLen50X.TabIndex = 1;
            this.m_btnLen50X.Text = "50倍鏡頭";
            this.m_btnLen50X.UseVisualStyleBackColor = true;
            this.m_btnLen50X.Click += new System.EventHandler(this.m_btnLen50X_Click);
            // 
            // m_btnLen20X
            // 
            this.m_btnLen20X.Appearance = System.Windows.Forms.Appearance.Button;
            this.m_btnLen20X.Checked = true;
            this.m_btnLen20X.Location = new System.Drawing.Point(10, 39);
            this.m_btnLen20X.Name = "m_btnLen20X";
            this.m_btnLen20X.Size = new System.Drawing.Size(63, 44);
            this.m_btnLen20X.TabIndex = 0;
            this.m_btnLen20X.TabStop = true;
            this.m_btnLen20X.Text = "20倍鏡頭";
            this.m_btnLen20X.UseVisualStyleBackColor = true;
            this.m_btnLen20X.Click += new System.EventHandler(this.m_btnLen50X_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.m_btnLineMeasure);
            this.groupBox4.Controls.Add(this.m_btnDeletePoint);
            this.groupBox4.Controls.Add(this.m_btnAddPoint);
            this.groupBox4.Controls.Add(this.m_btnMovePoint);
            this.groupBox4.Controls.Add(this.m_btnMovePath);
            this.groupBox4.Controls.Add(this.m_btnDrawPath);
            this.groupBox4.Location = new System.Drawing.Point(287, 124);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(156, 330);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "手動繪製工具";
            // 
            // m_btnLineMeasure
            // 
            this.m_btnLineMeasure.Appearance = System.Windows.Forms.Appearance.Button;
            this.m_btnLineMeasure.Location = new System.Drawing.Point(17, 234);
            this.m_btnLineMeasure.Name = "m_btnLineMeasure";
            this.m_btnLineMeasure.Size = new System.Drawing.Size(118, 36);
            this.m_btnLineMeasure.TabIndex = 33;
            this.m_btnLineMeasure.TabStop = true;
            this.m_btnLineMeasure.Text = "線段量測";
            this.m_btnLineMeasure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m_btnLineMeasure.UseVisualStyleBackColor = true;
            // 
            // m_btnDeletePoint
            // 
            this.m_btnDeletePoint.Appearance = System.Windows.Forms.Appearance.Button;
            this.m_btnDeletePoint.Location = new System.Drawing.Point(17, 191);
            this.m_btnDeletePoint.Name = "m_btnDeletePoint";
            this.m_btnDeletePoint.Size = new System.Drawing.Size(118, 36);
            this.m_btnDeletePoint.TabIndex = 32;
            this.m_btnDeletePoint.TabStop = true;
            this.m_btnDeletePoint.Text = "刪除節點";
            this.m_btnDeletePoint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m_btnDeletePoint.UseVisualStyleBackColor = true;
            // 
            // m_btnAddPoint
            // 
            this.m_btnAddPoint.Appearance = System.Windows.Forms.Appearance.Button;
            this.m_btnAddPoint.Location = new System.Drawing.Point(17, 148);
            this.m_btnAddPoint.Name = "m_btnAddPoint";
            this.m_btnAddPoint.Size = new System.Drawing.Size(118, 36);
            this.m_btnAddPoint.TabIndex = 31;
            this.m_btnAddPoint.TabStop = true;
            this.m_btnAddPoint.Text = "新增節點";
            this.m_btnAddPoint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m_btnAddPoint.UseVisualStyleBackColor = true;
            // 
            // m_btnMovePoint
            // 
            this.m_btnMovePoint.Appearance = System.Windows.Forms.Appearance.Button;
            this.m_btnMovePoint.Location = new System.Drawing.Point(17, 106);
            this.m_btnMovePoint.Name = "m_btnMovePoint";
            this.m_btnMovePoint.Size = new System.Drawing.Size(118, 36);
            this.m_btnMovePoint.TabIndex = 30;
            this.m_btnMovePoint.TabStop = true;
            this.m_btnMovePoint.Text = "節點移動";
            this.m_btnMovePoint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m_btnMovePoint.UseVisualStyleBackColor = true;
            // 
            // m_btnMovePath
            // 
            this.m_btnMovePath.Appearance = System.Windows.Forms.Appearance.Button;
            this.m_btnMovePath.Location = new System.Drawing.Point(17, 64);
            this.m_btnMovePath.Name = "m_btnMovePath";
            this.m_btnMovePath.Size = new System.Drawing.Size(118, 36);
            this.m_btnMovePath.TabIndex = 29;
            this.m_btnMovePath.TabStop = true;
            this.m_btnMovePath.Text = "路徑移動";
            this.m_btnMovePath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m_btnMovePath.UseVisualStyleBackColor = true;
            // 
            // m_btnDrawPath
            // 
            this.m_btnDrawPath.Appearance = System.Windows.Forms.Appearance.Button;
            this.m_btnDrawPath.Location = new System.Drawing.Point(17, 22);
            this.m_btnDrawPath.Name = "m_btnDrawPath";
            this.m_btnDrawPath.Size = new System.Drawing.Size(118, 36);
            this.m_btnDrawPath.TabIndex = 28;
            this.m_btnDrawPath.TabStop = true;
            this.m_btnDrawPath.Text = "繪製路徑";
            this.m_btnDrawPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m_btnDrawPath.UseVisualStyleBackColor = true;
            this.m_btnDrawPath.CheckedChanged += new System.EventHandler(this.m_btnDrawPath_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox8);
            this.groupBox5.Controls.Add(this.m_btnAutoDrawPath);
            this.groupBox5.Controls.Add(this.groupBox9);
            this.groupBox5.Controls.Add(this.groupBox7);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Location = new System.Drawing.Point(6, 18);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(275, 436);
            this.groupBox5.TabIndex = 24;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "自動繪製參數";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.m_radioYStartDown);
            this.groupBox8.Controls.Add(this.m_radioYStartUp);
            this.groupBox8.Location = new System.Drawing.Point(6, 220);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(263, 67);
            this.groupBox8.TabIndex = 6;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "設定Y移動方向";
            // 
            // m_radioYStartDown
            // 
            this.m_radioYStartDown.Appearance = System.Windows.Forms.Appearance.Button;
            this.m_radioYStartDown.AutoSize = true;
            this.m_radioYStartDown.Image = global::Maintain.Properties.Resources.Button_Download_icon;
            this.m_radioYStartDown.Location = new System.Drawing.Point(134, 21);
            this.m_radioYStartDown.Name = "m_radioYStartDown";
            this.m_radioYStartDown.Size = new System.Drawing.Size(38, 38);
            this.m_radioYStartDown.TabIndex = 5;
            this.m_radioYStartDown.UseVisualStyleBackColor = true;
            this.m_radioYStartDown.Click += new System.EventHandler(this.m_radioYStart_Click);
            // 
            // m_radioYStartUp
            // 
            this.m_radioYStartUp.Appearance = System.Windows.Forms.Appearance.Button;
            this.m_radioYStartUp.AutoSize = true;
            this.m_radioYStartUp.Checked = true;
            this.m_radioYStartUp.Image = global::Maintain.Properties.Resources.Button_Upload_icon;
            this.m_radioYStartUp.Location = new System.Drawing.Point(90, 21);
            this.m_radioYStartUp.Name = "m_radioYStartUp";
            this.m_radioYStartUp.Size = new System.Drawing.Size(38, 38);
            this.m_radioYStartUp.TabIndex = 4;
            this.m_radioYStartUp.TabStop = true;
            this.m_radioYStartUp.UseVisualStyleBackColor = true;
            this.m_radioYStartUp.Click += new System.EventHandler(this.m_radioYStart_Click);
            // 
            // m_btnAutoDrawPath
            // 
            this.m_btnAutoDrawPath.Location = new System.Drawing.Point(65, 398);
            this.m_btnAutoDrawPath.Name = "m_btnAutoDrawPath";
            this.m_btnAutoDrawPath.Size = new System.Drawing.Size(145, 31);
            this.m_btnAutoDrawPath.TabIndex = 4;
            this.m_btnAutoDrawPath.Text = "自動繪製路徑";
            this.m_btnAutoDrawPath.UseVisualStyleBackColor = true;
            this.m_btnAutoDrawPath.Click += new System.EventHandler(this.m_btnAutoDrawPath_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.label15);
            this.groupBox9.Controls.Add(this.m_txbPitchY);
            this.groupBox9.Controls.Add(this.label14);
            this.groupBox9.Controls.Add(this.m_txbPitchX);
            this.groupBox9.Controls.Add(this.lable);
            this.groupBox9.Controls.Add(this.m_txbHeight);
            this.groupBox9.Controls.Add(this.label13);
            this.groupBox9.Controls.Add(this.m_txbWidth);
            this.groupBox9.Location = new System.Drawing.Point(6, 293);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(263, 101);
            this.groupBox9.TabIndex = 3;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "輸入擊發區塊資料(μm)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(146, 55);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 12);
            this.label15.TabIndex = 7;
            this.label15.Text = "Pitch Y";
            // 
            // m_txbPitchY
            // 
            this.m_txbPitchY.Location = new System.Drawing.Point(137, 70);
            this.m_txbPitchY.Name = "m_txbPitchY";
            this.m_txbPitchY.Size = new System.Drawing.Size(64, 22);
            this.m_txbPitchY.TabIndex = 6;
            this.m_txbPitchY.Text = "10";
            this.m_txbPitchY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(70, 55);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 12);
            this.label14.TabIndex = 5;
            this.label14.Text = "Pitch X";
            // 
            // m_txbPitchX
            // 
            this.m_txbPitchX.Location = new System.Drawing.Point(61, 70);
            this.m_txbPitchX.Name = "m_txbPitchX";
            this.m_txbPitchX.Size = new System.Drawing.Size(64, 22);
            this.m_txbPitchX.TabIndex = 4;
            this.m_txbPitchX.Text = "10";
            this.m_txbPitchX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Location = new System.Drawing.Point(146, 15);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(36, 12);
            this.lable.TabIndex = 3;
            this.lable.Text = "Height";
            // 
            // m_txbHeight
            // 
            this.m_txbHeight.Location = new System.Drawing.Point(137, 30);
            this.m_txbHeight.Name = "m_txbHeight";
            this.m_txbHeight.Size = new System.Drawing.Size(64, 22);
            this.m_txbHeight.TabIndex = 2;
            this.m_txbHeight.Text = "100";
            this.m_txbHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(70, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 12);
            this.label13.TabIndex = 1;
            this.label13.Text = "Width";
            // 
            // m_txbWidth
            // 
            this.m_txbWidth.Location = new System.Drawing.Point(61, 30);
            this.m_txbWidth.Name = "m_txbWidth";
            this.m_txbWidth.Size = new System.Drawing.Size(64, 22);
            this.m_txbWidth.TabIndex = 0;
            this.m_txbWidth.Text = "100";
            this.m_txbWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.m_radioXStartLeft);
            this.groupBox7.Controls.Add(this.m_radioXStartRight);
            this.groupBox7.Location = new System.Drawing.Point(6, 147);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(263, 67);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "設定X移動方向";
            // 
            // m_radioXStartLeft
            // 
            this.m_radioXStartLeft.Appearance = System.Windows.Forms.Appearance.Button;
            this.m_radioXStartLeft.AutoSize = true;
            this.m_radioXStartLeft.Checked = true;
            this.m_radioXStartLeft.Image = global::Maintain.Properties.Resources.Button_Previous_icon;
            this.m_radioXStartLeft.Location = new System.Drawing.Point(90, 21);
            this.m_radioXStartLeft.Name = "m_radioXStartLeft";
            this.m_radioXStartLeft.Size = new System.Drawing.Size(38, 38);
            this.m_radioXStartLeft.TabIndex = 25;
            this.m_radioXStartLeft.TabStop = true;
            this.m_radioXStartLeft.UseVisualStyleBackColor = true;
            this.m_radioXStartLeft.Click += new System.EventHandler(this.m_radioXStart_Click);
            // 
            // m_radioXStartRight
            // 
            this.m_radioXStartRight.Appearance = System.Windows.Forms.Appearance.Button;
            this.m_radioXStartRight.AutoSize = true;
            this.m_radioXStartRight.Image = global::Maintain.Properties.Resources.Button_Next_icon;
            this.m_radioXStartRight.Location = new System.Drawing.Point(134, 21);
            this.m_radioXStartRight.Name = "m_radioXStartRight";
            this.m_radioXStartRight.Size = new System.Drawing.Size(38, 38);
            this.m_radioXStartRight.TabIndex = 26;
            this.m_radioXStartRight.UseVisualStyleBackColor = true;
            this.m_radioXStartRight.Click += new System.EventHandler(this.m_radioXStart_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.m_radioBottonLeft);
            this.groupBox6.Controls.Add(this.m_radioLeft);
            this.groupBox6.Controls.Add(this.m_radioTopLeft);
            this.groupBox6.Controls.Add(this.m_radioBotton);
            this.groupBox6.Controls.Add(this.m_radioBottonRight);
            this.groupBox6.Controls.Add(this.m_radioRight);
            this.groupBox6.Controls.Add(this.m_radioTopRight);
            this.groupBox6.Controls.Add(this.m_radioTop);
            this.groupBox6.Controls.Add(this.m_txbAngle);
            this.groupBox6.Location = new System.Drawing.Point(6, 21);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(263, 120);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "設定起始移動方向";
            // 
            // m_radioBottonLeft
            // 
            this.m_radioBottonLeft.Appearance = System.Windows.Forms.Appearance.Button;
            this.m_radioBottonLeft.Location = new System.Drawing.Point(60, 81);
            this.m_radioBottonLeft.Name = "m_radioBottonLeft";
            this.m_radioBottonLeft.Size = new System.Drawing.Size(45, 32);
            this.m_radioBottonLeft.TabIndex = 16;
            this.m_radioBottonLeft.Text = "↙";
            this.m_radioBottonLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m_radioBottonLeft.UseVisualStyleBackColor = true;
            this.m_radioBottonLeft.Click += new System.EventHandler(this.m_radio_Click);
            // 
            // m_radioLeft
            // 
            this.m_radioLeft.Appearance = System.Windows.Forms.Appearance.Button;
            this.m_radioLeft.Location = new System.Drawing.Point(60, 48);
            this.m_radioLeft.Name = "m_radioLeft";
            this.m_radioLeft.Size = new System.Drawing.Size(45, 32);
            this.m_radioLeft.TabIndex = 15;
            this.m_radioLeft.Text = "←";
            this.m_radioLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m_radioLeft.UseVisualStyleBackColor = true;
            this.m_radioLeft.Click += new System.EventHandler(this.m_radio_Click);
            // 
            // m_radioTopLeft
            // 
            this.m_radioTopLeft.Appearance = System.Windows.Forms.Appearance.Button;
            this.m_radioTopLeft.Location = new System.Drawing.Point(60, 15);
            this.m_radioTopLeft.Name = "m_radioTopLeft";
            this.m_radioTopLeft.Size = new System.Drawing.Size(45, 32);
            this.m_radioTopLeft.TabIndex = 14;
            this.m_radioTopLeft.Text = "↖";
            this.m_radioTopLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m_radioTopLeft.UseVisualStyleBackColor = true;
            this.m_radioTopLeft.Click += new System.EventHandler(this.m_radio_Click);
            // 
            // m_radioBotton
            // 
            this.m_radioBotton.Appearance = System.Windows.Forms.Appearance.Button;
            this.m_radioBotton.Location = new System.Drawing.Point(109, 81);
            this.m_radioBotton.Name = "m_radioBotton";
            this.m_radioBotton.Size = new System.Drawing.Size(45, 32);
            this.m_radioBotton.TabIndex = 13;
            this.m_radioBotton.Text = "↓";
            this.m_radioBotton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m_radioBotton.UseVisualStyleBackColor = true;
            this.m_radioBotton.Click += new System.EventHandler(this.m_radio_Click);
            // 
            // m_radioBottonRight
            // 
            this.m_radioBottonRight.Appearance = System.Windows.Forms.Appearance.Button;
            this.m_radioBottonRight.Location = new System.Drawing.Point(158, 81);
            this.m_radioBottonRight.Name = "m_radioBottonRight";
            this.m_radioBottonRight.Size = new System.Drawing.Size(45, 32);
            this.m_radioBottonRight.TabIndex = 12;
            this.m_radioBottonRight.Text = "↘";
            this.m_radioBottonRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m_radioBottonRight.UseVisualStyleBackColor = true;
            this.m_radioBottonRight.Click += new System.EventHandler(this.m_radio_Click);
            // 
            // m_radioRight
            // 
            this.m_radioRight.Appearance = System.Windows.Forms.Appearance.Button;
            this.m_radioRight.Location = new System.Drawing.Point(158, 48);
            this.m_radioRight.Name = "m_radioRight";
            this.m_radioRight.Size = new System.Drawing.Size(45, 32);
            this.m_radioRight.TabIndex = 11;
            this.m_radioRight.Text = "→";
            this.m_radioRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m_radioRight.UseVisualStyleBackColor = true;
            this.m_radioRight.Click += new System.EventHandler(this.m_radio_Click);
            // 
            // m_radioTopRight
            // 
            this.m_radioTopRight.Appearance = System.Windows.Forms.Appearance.Button;
            this.m_radioTopRight.Location = new System.Drawing.Point(158, 15);
            this.m_radioTopRight.Name = "m_radioTopRight";
            this.m_radioTopRight.Size = new System.Drawing.Size(45, 32);
            this.m_radioTopRight.TabIndex = 10;
            this.m_radioTopRight.Text = "↗";
            this.m_radioTopRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m_radioTopRight.UseVisualStyleBackColor = true;
            this.m_radioTopRight.Click += new System.EventHandler(this.m_radio_Click);
            // 
            // m_radioTop
            // 
            this.m_radioTop.Appearance = System.Windows.Forms.Appearance.Button;
            this.m_radioTop.Checked = true;
            this.m_radioTop.Location = new System.Drawing.Point(109, 15);
            this.m_radioTop.Name = "m_radioTop";
            this.m_radioTop.Size = new System.Drawing.Size(45, 32);
            this.m_radioTop.TabIndex = 9;
            this.m_radioTop.TabStop = true;
            this.m_radioTop.Text = "↑";
            this.m_radioTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m_radioTop.UseVisualStyleBackColor = true;
            this.m_radioTop.Click += new System.EventHandler(this.m_radio_Click);
            // 
            // m_txbAngle
            // 
            this.m_txbAngle.Location = new System.Drawing.Point(109, 52);
            this.m_txbAngle.Name = "m_txbAngle";
            this.m_txbAngle.Size = new System.Drawing.Size(45, 22);
            this.m_txbAngle.TabIndex = 8;
            this.m_txbAngle.Text = "0";
            this.m_txbAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.groupBox5);
            this.groupBox10.Controls.Add(this.groupBox4);
            this.groupBox10.Controls.Add(this.groupBox3);
            this.groupBox10.Location = new System.Drawing.Point(649, 64);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(449, 458);
            this.groupBox10.TabIndex = 23;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "路徑工具";
            // 
            // ccd1
            // 
            this.ccd1.BackColor = System.Drawing.Color.Black;
            this.ccd1.CCDEnabled = true;
            this.ccd1.Location = new System.Drawing.Point(3, 63);
            this.ccd1.Name = "ccd1";
            this.ccd1.Size = new System.Drawing.Size(640, 480);
            this.ccd1.TabIndex = 24;
            // 
            // CCLaserPathTeachControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.ccd1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CCLaserPathTeachControl";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.ccd1, 0);
            this.Controls.SetChildIndex(this.groupBox10, 0);
            this.Controls.SetChildIndex(this.m_SubheaderPanel, 0);
            this.m_SubheaderPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox m_txbAcc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox m_txbLaserPower;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox m_txbZOffset;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox m_txbPolarize;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox m_txbDec;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox m_txbSpeed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox m_lbLaserPara;
        private System.Windows.Forms.Button m_btnDelete;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton m_btnLen50X;
        private System.Windows.Forms.RadioButton m_btnLen20X;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox m_txbAngle;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.RadioButton m_radioYStartDown;
        private System.Windows.Forms.RadioButton m_radioYStartUp;
        private System.Windows.Forms.Button m_btnAutoDrawPath;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.RadioButton m_radioXStartLeft;
        private System.Windows.Forms.RadioButton m_radioXStartRight;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox m_txbPitchY;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox m_txbPitchX;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.TextBox m_txbHeight;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox m_txbWidth;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Button m_btnSave;
        private System.Windows.Forms.Button m_btnLoad;
        private System.Windows.Forms.RadioButton m_btnDrawPath;
        private System.Windows.Forms.RadioButton m_btnMovePath;
        private System.Windows.Forms.RadioButton m_btnMovePoint;
        private System.Windows.Forms.RadioButton m_btnAddPoint;
        private System.Windows.Forms.RadioButton m_btnDeletePoint;
        private System.Windows.Forms.RadioButton m_btnLineMeasure;
        private System.Windows.Forms.RadioButton m_radioBottonLeft;
        private System.Windows.Forms.RadioButton m_radioLeft;
        private System.Windows.Forms.RadioButton m_radioTopLeft;
        private System.Windows.Forms.RadioButton m_radioBotton;
        private System.Windows.Forms.RadioButton m_radioBottonRight;
        private System.Windows.Forms.RadioButton m_radioRight;
        private System.Windows.Forms.RadioButton m_radioTopRight;
        private System.Windows.Forms.RadioButton m_radioTop;
        private Vision.CCD ccd1;
    }
}
