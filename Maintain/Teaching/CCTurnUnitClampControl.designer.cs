namespace Maintain.Teaching
{
    partial class CCTurnUnitClampControl
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
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.m_tbxAbsPosition = new System.Windows.Forms.TextBox();
            this.m_btnAbsoluteMove = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.m_txbSpeedPercentage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.m_btnIncrease = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.m_tbxAxisDistance = new System.Windows.Forms.TextBox();
            this.m_btnDecrease = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.m_btnAxisSave = new System.Windows.Forms.Button();
            this.m_cbAxis = new System.Windows.Forms.ComboBox();
            this.m_tbxCurrentPos = new System.Windows.Forms.TextBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.m_btnStop = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.m_btnYAutoClamp = new System.Windows.Forms.Button();
            this.m_btnXAutoClamp = new System.Windows.Forms.Button();
            this.m_btnUnclamp = new System.Windows.Forms.Button();
            this.m_btnClamp = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.m_btnHome = new System.Windows.Forms.Button();
            this.m_UITimer = new System.Windows.Forms.Timer(this.components);
            this.m_SubheaderPanel.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_subtitleLabel
            // 
            this.m_subtitleLabel.Text = "設定翻轉機構Clamp夾片位置";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.groupBox8);
            this.groupBox7.Controls.Add(this.groupBox12);
            this.groupBox7.Location = new System.Drawing.Point(5, 66);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(469, 645);
            this.groupBox7.TabIndex = 8;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "移動操作";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.groupBox9);
            this.groupBox8.Controls.Add(this.groupBox10);
            this.groupBox8.Controls.Add(this.groupBox11);
            this.groupBox8.Location = new System.Drawing.Point(10, 150);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(453, 489);
            this.groupBox8.TabIndex = 4;
            this.groupBox8.TabStop = false;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.label10);
            this.groupBox9.Controls.Add(this.m_tbxAbsPosition);
            this.groupBox9.Controls.Add(this.m_btnAbsoluteMove);
            this.groupBox9.Controls.Add(this.label4);
            this.groupBox9.Location = new System.Drawing.Point(15, 261);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(432, 79);
            this.groupBox9.TabIndex = 5;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "絕對移動操作";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(247, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 19);
            this.label10.TabIndex = 10;
            this.label10.Text = "(um)";
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
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.m_txbSpeedPercentage);
            this.groupBox10.Controls.Add(this.label3);
            this.groupBox10.Enabled = false;
            this.groupBox10.Location = new System.Drawing.Point(15, 21);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(432, 100);
            this.groupBox10.TabIndex = 4;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "移動速度設定";
            this.groupBox10.Visible = false;
            // 
            // m_txbSpeedPercentage
            // 
            this.m_txbSpeedPercentage.Location = new System.Drawing.Point(140, 38);
            this.m_txbSpeedPercentage.Name = "m_txbSpeedPercentage";
            this.m_txbSpeedPercentage.Size = new System.Drawing.Size(85, 22);
            this.m_txbSpeedPercentage.TabIndex = 6;
            this.m_txbSpeedPercentage.Text = "100";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(15, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "速度設定(%)：";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.label9);
            this.groupBox11.Controls.Add(this.m_btnIncrease);
            this.groupBox11.Controls.Add(this.button1);
            this.groupBox11.Controls.Add(this.m_tbxAxisDistance);
            this.groupBox11.Controls.Add(this.m_btnDecrease);
            this.groupBox11.Controls.Add(this.label5);
            this.groupBox11.Location = new System.Drawing.Point(15, 127);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(432, 128);
            this.groupBox11.TabIndex = 3;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "相對移動操作";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(284, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 19);
            this.label9.TabIndex = 9;
            this.label9.Text = "(um)";
            // 
            // m_btnIncrease
            // 
            this.m_btnIncrease.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_btnIncrease.Image = global::Maintain.Properties.Resources.Button_Forward_icon;
            this.m_btnIncrease.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.m_btnIncrease.Location = new System.Drawing.Point(220, 66);
            this.m_btnIncrease.Name = "m_btnIncrease";
            this.m_btnIncrease.Size = new System.Drawing.Size(113, 42);
            this.m_btnIncrease.TabIndex = 7;
            this.m_btnIncrease.Text = "夾緊微調";
            this.m_btnIncrease.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_btnIncrease.UseVisualStyleBackColor = true;
            this.m_btnIncrease.Click += new System.EventHandler(this.m_btnIncrease_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Image = global::Maintain.Properties.Resources.Button_Delete_icon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(138, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "Stop";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
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
            this.m_btnDecrease.Image = global::Maintain.Properties.Resources.Button_Rewind_icon;
            this.m_btnDecrease.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_btnDecrease.Location = new System.Drawing.Point(19, 66);
            this.m_btnDecrease.Name = "m_btnDecrease";
            this.m_btnDecrease.Size = new System.Drawing.Size(113, 42);
            this.m_btnDecrease.TabIndex = 2;
            this.m_btnDecrease.Text = "放鬆微調";
            this.m_btnDecrease.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.m_btnDecrease.UseVisualStyleBackColor = true;
            this.m_btnDecrease.Click += new System.EventHandler(this.m_btnDecrease_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(15, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "相對移動距離：";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.label1);
            this.groupBox12.Controls.Add(this.label11);
            this.groupBox12.Controls.Add(this.m_btnAxisSave);
            this.groupBox12.Controls.Add(this.m_cbAxis);
            this.groupBox12.Controls.Add(this.m_tbxCurrentPos);
            this.groupBox12.Location = new System.Drawing.Point(10, 34);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(453, 100);
            this.groupBox12.TabIndex = 3;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "目前位置";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(107, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "軸";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(262, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 19);
            this.label11.TabIndex = 9;
            this.label11.Text = "(um)";
            // 
            // m_btnAxisSave
            // 
            this.m_btnAxisSave.BackColor = System.Drawing.Color.DodgerBlue;
            this.m_btnAxisSave.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_btnAxisSave.Location = new System.Drawing.Point(312, 23);
            this.m_btnAxisSave.Name = "m_btnAxisSave";
            this.m_btnAxisSave.Size = new System.Drawing.Size(93, 52);
            this.m_btnAxisSave.TabIndex = 8;
            this.m_btnAxisSave.Text = "Save";
            this.m_btnAxisSave.UseVisualStyleBackColor = false;
            this.m_btnAxisSave.Click += new System.EventHandler(this.m_btnAxisSave_Click);
            // 
            // m_cbAxis
            // 
            this.m_cbAxis.FormattingEnabled = true;
            this.m_cbAxis.Items.AddRange(new object[] {
            "TS",
            "TG"});
            this.m_cbAxis.Location = new System.Drawing.Point(15, 34);
            this.m_cbAxis.Name = "m_cbAxis";
            this.m_cbAxis.Size = new System.Drawing.Size(86, 20);
            this.m_cbAxis.TabIndex = 4;
            this.m_cbAxis.SelectedIndexChanged += new System.EventHandler(this.m_cbAxis_SelectedIndexChanged);
            // 
            // m_tbxCurrentPos
            // 
            this.m_tbxCurrentPos.Location = new System.Drawing.Point(156, 33);
            this.m_tbxCurrentPos.Name = "m_tbxCurrentPos";
            this.m_tbxCurrentPos.ReadOnly = true;
            this.m_tbxCurrentPos.Size = new System.Drawing.Size(100, 22);
            this.m_tbxCurrentPos.TabIndex = 3;
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.groupBox2);
            this.groupBox13.Controls.Add(this.groupBox4);
            this.groupBox13.Controls.Add(this.groupBox1);
            this.groupBox13.Location = new System.Drawing.Point(480, 66);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(456, 645);
            this.groupBox13.TabIndex = 9;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "功能操作";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.m_btnStop);
            this.groupBox2.Location = new System.Drawing.Point(6, 432);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(444, 155);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "緊急停止";
            // 
            // m_btnStop
            // 
            this.m_btnStop.Image = global::Maintain.Properties.Resources.Button_Delete_icon;
            this.m_btnStop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_btnStop.Location = new System.Drawing.Point(46, 22);
            this.m_btnStop.Name = "m_btnStop";
            this.m_btnStop.Size = new System.Drawing.Size(98, 57);
            this.m_btnStop.TabIndex = 2;
            this.m_btnStop.Text = "緊急停止";
            this.m_btnStop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.m_btnStop.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.m_btnYAutoClamp);
            this.groupBox4.Controls.Add(this.m_btnXAutoClamp);
            this.groupBox4.Controls.Add(this.m_btnUnclamp);
            this.groupBox4.Controls.Add(this.m_btnClamp);
            this.groupBox4.Location = new System.Drawing.Point(6, 171);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(444, 247);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "翻轉機構夾片動作測試";
            // 
            // m_btnYAutoClamp
            // 
            this.m_btnYAutoClamp.Location = new System.Drawing.Point(140, 106);
            this.m_btnYAutoClamp.Name = "m_btnYAutoClamp";
            this.m_btnYAutoClamp.Size = new System.Drawing.Size(109, 57);
            this.m_btnYAutoClamp.TabIndex = 6;
            this.m_btnYAutoClamp.Text = "Y軸向自動夾緊";
            this.m_btnYAutoClamp.UseVisualStyleBackColor = true;
            // 
            // m_btnXAutoClamp
            // 
            this.m_btnXAutoClamp.Location = new System.Drawing.Point(25, 106);
            this.m_btnXAutoClamp.Name = "m_btnXAutoClamp";
            this.m_btnXAutoClamp.Size = new System.Drawing.Size(109, 57);
            this.m_btnXAutoClamp.TabIndex = 3;
            this.m_btnXAutoClamp.Text = "X軸向自動夾緊";
            this.m_btnXAutoClamp.UseVisualStyleBackColor = true;
            // 
            // m_btnUnclamp
            // 
            this.m_btnUnclamp.Location = new System.Drawing.Point(140, 35);
            this.m_btnUnclamp.Name = "m_btnUnclamp";
            this.m_btnUnclamp.Size = new System.Drawing.Size(109, 57);
            this.m_btnUnclamp.TabIndex = 2;
            this.m_btnUnclamp.Text = "放鬆";
            this.m_btnUnclamp.UseVisualStyleBackColor = true;
            this.m_btnUnclamp.Click += new System.EventHandler(this.m_btnUnclamp_Click);
            // 
            // m_btnClamp
            // 
            this.m_btnClamp.Location = new System.Drawing.Point(25, 35);
            this.m_btnClamp.Name = "m_btnClamp";
            this.m_btnClamp.Size = new System.Drawing.Size(109, 57);
            this.m_btnClamp.TabIndex = 1;
            this.m_btnClamp.Text = "夾緊";
            this.m_btnClamp.UseVisualStyleBackColor = true;
            this.m_btnClamp.Click += new System.EventHandler(this.m_btnClamp_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.m_btnHome);
            this.groupBox1.Location = new System.Drawing.Point(6, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 141);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "翻轉機構原點復歸";
            // 
            // m_btnHome
            // 
            this.m_btnHome.Location = new System.Drawing.Point(25, 31);
            this.m_btnHome.Name = "m_btnHome";
            this.m_btnHome.Size = new System.Drawing.Size(109, 57);
            this.m_btnHome.TabIndex = 0;
            this.m_btnHome.Text = "原點復歸";
            this.m_btnHome.UseVisualStyleBackColor = true;
            this.m_btnHome.Click += new System.EventHandler(this.m_btnHome_Click);
            // 
            // m_UITimer
            // 
            this.m_UITimer.Enabled = true;
            this.m_UITimer.Interval = 500;
            this.m_UITimer.Tick += new System.EventHandler(this.m_UITimer_Tick);
            // 
            // CCTurnUnitClampControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox13);
            this.Name = "CCTurnUnitClampControl";
            this.Controls.SetChildIndex(this.m_SubheaderPanel, 0);
            this.Controls.SetChildIndex(this.groupBox13, 0);
            this.Controls.SetChildIndex(this.groupBox7, 0);
            this.m_SubheaderPanel.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox m_tbxAbsPosition;
        private System.Windows.Forms.Button m_btnAbsoluteMove;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TextBox m_txbSpeedPercentage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button m_btnIncrease;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox m_tbxAxisDistance;
        private System.Windows.Forms.Button m_btnDecrease;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button m_btnAxisSave;
        private System.Windows.Forms.ComboBox m_cbAxis;
        private System.Windows.Forms.TextBox m_tbxCurrentPos;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button m_btnStop;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button m_btnYAutoClamp;
        private System.Windows.Forms.Button m_btnXAutoClamp;
        private System.Windows.Forms.Button m_btnUnclamp;
        private System.Windows.Forms.Button m_btnClamp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button m_btnHome;
        private System.Windows.Forms.Timer m_UITimer;
    }
}
