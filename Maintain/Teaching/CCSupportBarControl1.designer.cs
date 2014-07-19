namespace Maintain.Teaching
{
    partial class CCSupportBarControl1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.temp = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.m_btnBar1EndPosMove = new System.Windows.Forms.Button();
            this.m_tbxBar1End = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.m_btnBar1StartPosMove = new System.Windows.Forms.Button();
            this.m_btnGlassBar1Save = new System.Windows.Forms.Button();
            this.m_tbxBar1Start = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.m_btnBar2EndPosMove = new System.Windows.Forms.Button();
            this.m_tbxBar2End = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.m_btnBar2StartPosMove = new System.Windows.Forms.Button();
            this.m_btnGlassBar2Save = new System.Windows.Forms.Button();
            this.m_tbxBar2Start = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.temp.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_subtitleLabel
            // 
            this.m_subtitleLabel.Text = "設定閃避支撐Bar位置";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(3, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(479, 1065);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.temp);
            this.groupBox1.Location = new System.Drawing.Point(488, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(609, 258);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "避Glass Bar 位置設定";
            // 
            // temp
            // 
            this.temp.Controls.Add(this.tabPage1);
            this.temp.Controls.Add(this.tabPage2);
            this.temp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.temp.Location = new System.Drawing.Point(3, 18);
            this.temp.Name = "temp";
            this.temp.SelectedIndex = 0;
            this.temp.Size = new System.Drawing.Size(603, 237);
            this.temp.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox8);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(595, 212);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Glass Bar1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox8.Controls.Add(this.m_btnBar1EndPosMove);
            this.groupBox8.Controls.Add(this.m_tbxBar1End);
            this.groupBox8.Controls.Add(this.label1);
            this.groupBox8.Controls.Add(this.m_btnBar1StartPosMove);
            this.groupBox8.Controls.Add(this.m_btnGlassBar1Save);
            this.groupBox8.Controls.Add(this.m_tbxBar1Start);
            this.groupBox8.Controls.Add(this.label2);
            this.groupBox8.Location = new System.Drawing.Point(3, 3);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(589, 203);
            this.groupBox8.TabIndex = 3;
            this.groupBox8.TabStop = false;
            // 
            // m_btnBar1EndPosMove
            // 
            this.m_btnBar1EndPosMove.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_btnBar1EndPosMove.Location = new System.Drawing.Point(344, 47);
            this.m_btnBar1EndPosMove.Name = "m_btnBar1EndPosMove";
            this.m_btnBar1EndPosMove.Size = new System.Drawing.Size(75, 23);
            this.m_btnBar1EndPosMove.TabIndex = 7;
            this.m_btnBar1EndPosMove.Text = "Go";
            this.m_btnBar1EndPosMove.UseVisualStyleBackColor = true;
            this.m_btnBar1EndPosMove.Click += new System.EventHandler(this.m_btnBar1EndPosMove_Click);
            // 
            // m_tbxBar1End
            // 
            this.m_tbxBar1End.Location = new System.Drawing.Point(122, 46);
            this.m_tbxBar1End.Name = "m_tbxBar1End";
            this.m_tbxBar1End.Size = new System.Drawing.Size(117, 22);
            this.m_tbxBar1End.TabIndex = 5;
            this.m_tbxBar1End.Text = "100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(6, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "遮蔽結束位置";
            // 
            // m_btnBar1StartPosMove
            // 
            this.m_btnBar1StartPosMove.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_btnBar1StartPosMove.Location = new System.Drawing.Point(344, 12);
            this.m_btnBar1StartPosMove.Name = "m_btnBar1StartPosMove";
            this.m_btnBar1StartPosMove.Size = new System.Drawing.Size(75, 23);
            this.m_btnBar1StartPosMove.TabIndex = 3;
            this.m_btnBar1StartPosMove.Text = "Go";
            this.m_btnBar1StartPosMove.UseVisualStyleBackColor = true;
            this.m_btnBar1StartPosMove.Click += new System.EventHandler(this.m_btnBar1StartPosMove_Click);
            // 
            // m_btnGlassBar1Save
            // 
            this.m_btnGlassBar1Save.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_btnGlassBar1Save.Location = new System.Drawing.Point(246, 13);
            this.m_btnGlassBar1Save.Name = "m_btnGlassBar1Save";
            this.m_btnGlassBar1Save.Size = new System.Drawing.Size(75, 55);
            this.m_btnGlassBar1Save.TabIndex = 2;
            this.m_btnGlassBar1Save.Text = "Set";
            this.m_btnGlassBar1Save.UseVisualStyleBackColor = true;
            this.m_btnGlassBar1Save.Click += new System.EventHandler(this.m_btnGlassBar1Save_Click_1);
            // 
            // m_tbxBar1Start
            // 
            this.m_tbxBar1Start.Location = new System.Drawing.Point(123, 13);
            this.m_tbxBar1Start.Name = "m_tbxBar1Start";
            this.m_tbxBar1Start.Size = new System.Drawing.Size(117, 22);
            this.m_tbxBar1Start.TabIndex = 1;
            this.m_tbxBar1Start.Text = "100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "遮蔽開始位置";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 21);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(595, 212);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Glass Bar2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.m_btnBar2EndPosMove);
            this.groupBox3.Controls.Add(this.m_tbxBar2End);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.m_btnBar2StartPosMove);
            this.groupBox3.Controls.Add(this.m_btnGlassBar2Save);
            this.groupBox3.Controls.Add(this.m_tbxBar2Start);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(589, 206);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // m_btnBar2EndPosMove
            // 
            this.m_btnBar2EndPosMove.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_btnBar2EndPosMove.Location = new System.Drawing.Point(344, 47);
            this.m_btnBar2EndPosMove.Name = "m_btnBar2EndPosMove";
            this.m_btnBar2EndPosMove.Size = new System.Drawing.Size(75, 23);
            this.m_btnBar2EndPosMove.TabIndex = 7;
            this.m_btnBar2EndPosMove.Text = "Go";
            this.m_btnBar2EndPosMove.UseVisualStyleBackColor = true;
            this.m_btnBar2EndPosMove.Click += new System.EventHandler(this.m_btnBar1EndPosMove_Click);
            // 
            // m_tbxBar2End
            // 
            this.m_tbxBar2End.Location = new System.Drawing.Point(122, 46);
            this.m_tbxBar2End.Name = "m_tbxBar2End";
            this.m_tbxBar2End.Size = new System.Drawing.Size(117, 22);
            this.m_tbxBar2End.TabIndex = 5;
            this.m_tbxBar2End.Text = "100";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(6, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "遮蔽結束位置";
            // 
            // m_btnBar2StartPosMove
            // 
            this.m_btnBar2StartPosMove.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_btnBar2StartPosMove.Location = new System.Drawing.Point(344, 12);
            this.m_btnBar2StartPosMove.Name = "m_btnBar2StartPosMove";
            this.m_btnBar2StartPosMove.Size = new System.Drawing.Size(75, 23);
            this.m_btnBar2StartPosMove.TabIndex = 3;
            this.m_btnBar2StartPosMove.Text = "Go";
            this.m_btnBar2StartPosMove.UseVisualStyleBackColor = true;
            this.m_btnBar2StartPosMove.Click += new System.EventHandler(this.m_btnBar1StartPosMove_Click);
            // 
            // m_btnGlassBar2Save
            // 
            this.m_btnGlassBar2Save.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_btnGlassBar2Save.Location = new System.Drawing.Point(246, 13);
            this.m_btnGlassBar2Save.Name = "m_btnGlassBar2Save";
            this.m_btnGlassBar2Save.Size = new System.Drawing.Size(75, 55);
            this.m_btnGlassBar2Save.TabIndex = 2;
            this.m_btnGlassBar2Save.Text = "Set";
            this.m_btnGlassBar2Save.UseVisualStyleBackColor = true;
            this.m_btnGlassBar2Save.Click += new System.EventHandler(this.m_btnGlassBar1Save_Click_1);
            // 
            // m_tbxBar2Start
            // 
            this.m_tbxBar2Start.Location = new System.Drawing.Point(123, 13);
            this.m_tbxBar2Start.Name = "m_tbxBar2Start";
            this.m_tbxBar2Start.Size = new System.Drawing.Size(117, 22);
            this.m_tbxBar2Start.TabIndex = 1;
            this.m_tbxBar2Start.Text = "100";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(6, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "遮蔽開始位置";
            // 
            // CCSupportBarControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CCSupportBarControl1";
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.temp.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl temp;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button m_btnBar1EndPosMove;
        private System.Windows.Forms.TextBox m_tbxBar1End;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button m_btnBar1StartPosMove;
        private System.Windows.Forms.Button m_btnGlassBar1Save;
        private System.Windows.Forms.TextBox m_tbxBar1Start;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button m_btnBar2EndPosMove;
        private System.Windows.Forms.TextBox m_tbxBar2End;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button m_btnBar2StartPosMove;
        private System.Windows.Forms.Button m_btnGlassBar2Save;
        private System.Windows.Forms.TextBox m_tbxBar2Start;
        private System.Windows.Forms.Label label4;
    }
}
