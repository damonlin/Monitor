﻿namespace Monitor
{
    partial class CTAP
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
            ShareMemory.CCShareData.GetSingleton().ShareMemory_DeleteDIOObject();
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改這個方法的內容。
        ///
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CTAP));
            this.baseStatusStrip = new System.Windows.Forms.StatusStrip();
            this.displayDateLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.displayTimeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.baseTimer = new System.Windows.Forms.Timer(this.components);
            this.viewPanel = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.signalTowerUnitControl1 = new Maintain.SignalTowerUnitControl();
            this.label2 = new System.Windows.Forms.Label();
            this.operatorIDButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ShutdownRadioButton = new System.Windows.Forms.RadioButton();
            this.AlarmlistRadioButton = new System.Windows.Forms.RadioButton();
            this.InspectRadioButton = new System.Windows.Forms.RadioButton();
            this.OperationRadioButton = new System.Windows.Forms.RadioButton();
            this.DatalogRadioButton = new System.Windows.Forms.RadioButton();
            this.CIMRadioButton = new System.Windows.Forms.RadioButton();
            this.MaintainRadioButton = new System.Windows.Forms.RadioButton();
            this.RecipeRadioButton = new System.Windows.Forms.RadioButton();
            this.btnDecPanel = new System.Windows.Forms.Panel();
            this.baseStatusStrip.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // baseStatusStrip
            // 
            this.baseStatusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
            this.baseStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayDateLabel,
            this.displayTimeLabel});
            resources.ApplyResources(this.baseStatusStrip, "baseStatusStrip");
            this.baseStatusStrip.Name = "baseStatusStrip";
            // 
            // displayDateLabel
            // 
            this.displayDateLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.displayDateLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.displayDateLabel.Name = "displayDateLabel";
            resources.ApplyResources(this.displayDateLabel, "displayDateLabel");
            // 
            // displayTimeLabel
            // 
            this.displayTimeLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.displayTimeLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.displayTimeLabel.Name = "displayTimeLabel";
            resources.ApplyResources(this.displayTimeLabel, "displayTimeLabel");
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Tag = "";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(195)))), ((int)(((byte)(222)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Name = "label1";
            // 
            // baseTimer
            // 
            this.baseTimer.Enabled = true;
            this.baseTimer.Interval = 1000;
            this.baseTimer.Tick += new System.EventHandler(this.baseTimer_Tick);
            // 
            // viewPanel
            // 
            resources.ApplyResources(this.viewPanel, "viewPanel");
            this.viewPanel.BackColor = System.Drawing.Color.White;
            this.viewPanel.Name = "viewPanel";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.signalTowerUnitControl1);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.operatorIDButton);
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.textBox1);
            resources.ApplyResources(this.panel6, "panel6");
            this.panel6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel6.Name = "panel6";
            // 
            // signalTowerUnitControl1
            // 
            resources.ApplyResources(this.signalTowerUnitControl1, "signalTowerUnitControl1");
            this.signalTowerUnitControl1.BackColor = System.Drawing.Color.Black;
            this.signalTowerUnitControl1.Name = "signalTowerUnitControl1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(195)))), ((int)(((byte)(222)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Name = "label2";
            // 
            // operatorIDButton
            // 
            resources.ApplyResources(this.operatorIDButton, "operatorIDButton");
            this.operatorIDButton.BackColor = System.Drawing.Color.Gainsboro;
            this.operatorIDButton.Name = "operatorIDButton";
            this.operatorIDButton.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.ShutdownRadioButton);
            this.panel3.Controls.Add(this.AlarmlistRadioButton);
            this.panel3.Controls.Add(this.InspectRadioButton);
            this.panel3.Controls.Add(this.OperationRadioButton);
            this.panel3.Controls.Add(this.DatalogRadioButton);
            this.panel3.Controls.Add(this.CIMRadioButton);
            this.panel3.Controls.Add(this.MaintainRadioButton);
            this.panel3.Controls.Add(this.RecipeRadioButton);
            this.panel3.Controls.Add(this.btnDecPanel);
            this.panel3.Name = "panel3";
            // 
            // ShutdownRadioButton
            // 
            resources.ApplyResources(this.ShutdownRadioButton, "ShutdownRadioButton");
            this.ShutdownRadioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.ShutdownRadioButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ShutdownRadioButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.ShutdownRadioButton.Image = global::Monitor.Properties.Resources.Windows_Close_Program_icon;
            this.ShutdownRadioButton.Name = "ShutdownRadioButton";
            this.ShutdownRadioButton.TabStop = true;
            this.ShutdownRadioButton.UseVisualStyleBackColor = false;
            this.ShutdownRadioButton.Click += new System.EventHandler(this.Shutdown_Click);
            // 
            // AlarmlistRadioButton
            // 
            resources.ApplyResources(this.AlarmlistRadioButton, "AlarmlistRadioButton");
            this.AlarmlistRadioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.AlarmlistRadioButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AlarmlistRadioButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.AlarmlistRadioButton.Image = global::Monitor.Properties.Resources.Button_Warning_icon;
            this.AlarmlistRadioButton.Name = "AlarmlistRadioButton";
            this.AlarmlistRadioButton.TabStop = true;
            this.AlarmlistRadioButton.UseVisualStyleBackColor = false;
            this.AlarmlistRadioButton.Click += new System.EventHandler(this.Alarmlist_Click);
            // 
            // InspectRadioButton
            // 
            resources.ApplyResources(this.InspectRadioButton, "InspectRadioButton");
            this.InspectRadioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.InspectRadioButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.InspectRadioButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.InspectRadioButton.Image = global::Monitor.Properties.Resources.Zoom_icon;
            this.InspectRadioButton.Name = "InspectRadioButton";
            this.InspectRadioButton.TabStop = true;
            this.InspectRadioButton.UseVisualStyleBackColor = false;
            this.InspectRadioButton.CheckedChanged += new System.EventHandler(this.navigatorBtn_CheckedChanged);
            // 
            // OperationRadioButton
            // 
            resources.ApplyResources(this.OperationRadioButton, "OperationRadioButton");
            this.OperationRadioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.OperationRadioButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.OperationRadioButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.OperationRadioButton.Name = "OperationRadioButton";
            this.OperationRadioButton.TabStop = true;
            this.OperationRadioButton.UseVisualStyleBackColor = false;
            this.OperationRadioButton.CheckedChanged += new System.EventHandler(this.navigatorBtn_CheckedChanged);
            // 
            // DatalogRadioButton
            // 
            resources.ApplyResources(this.DatalogRadioButton, "DatalogRadioButton");
            this.DatalogRadioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.DatalogRadioButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DatalogRadioButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.DatalogRadioButton.Image = global::Monitor.Properties.Resources.Clipboard_icon;
            this.DatalogRadioButton.Name = "DatalogRadioButton";
            this.DatalogRadioButton.TabStop = true;
            this.DatalogRadioButton.UseVisualStyleBackColor = false;
            this.DatalogRadioButton.CheckedChanged += new System.EventHandler(this.navigatorBtn_CheckedChanged);
            // 
            // CIMRadioButton
            // 
            resources.ApplyResources(this.CIMRadioButton, "CIMRadioButton");
            this.CIMRadioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.CIMRadioButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CIMRadioButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.CIMRadioButton.Image = global::Monitor.Properties.Resources.Computer_Network_icon;
            this.CIMRadioButton.Name = "CIMRadioButton";
            this.CIMRadioButton.TabStop = true;
            this.CIMRadioButton.UseVisualStyleBackColor = false;
            this.CIMRadioButton.CheckedChanged += new System.EventHandler(this.navigatorBtn_CheckedChanged);
            // 
            // MaintainRadioButton
            // 
            resources.ApplyResources(this.MaintainRadioButton, "MaintainRadioButton");
            this.MaintainRadioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.MaintainRadioButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.MaintainRadioButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.MaintainRadioButton.Image = global::Monitor.Properties.Resources.Gear_icon;
            this.MaintainRadioButton.Name = "MaintainRadioButton";
            this.MaintainRadioButton.TabStop = true;
            this.MaintainRadioButton.UseVisualStyleBackColor = false;
            this.MaintainRadioButton.CheckedChanged += new System.EventHandler(this.navigatorBtn_CheckedChanged);
            // 
            // RecipeRadioButton
            // 
            resources.ApplyResources(this.RecipeRadioButton, "RecipeRadioButton");
            this.RecipeRadioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.RecipeRadioButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.RecipeRadioButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.RecipeRadioButton.Image = global::Monitor.Properties.Resources.Text_Edit_icon;
            this.RecipeRadioButton.Name = "RecipeRadioButton";
            this.RecipeRadioButton.TabStop = true;
            this.RecipeRadioButton.UseVisualStyleBackColor = false;
            this.RecipeRadioButton.CheckedChanged += new System.EventHandler(this.navigatorBtn_CheckedChanged);
            // 
            // btnDecPanel
            // 
            this.btnDecPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(217)))));
            resources.ApplyResources(this.btnDecPanel, "btnDecPanel");
            this.btnDecPanel.Name = "btnDecPanel";
            // 
            // CTAP
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.viewPanel);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.baseStatusStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CTAP";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.baseStatusStrip.ResumeLayout(false);
            this.baseStatusStrip.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip baseStatusStrip;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripStatusLabel displayDateLabel;
        private System.Windows.Forms.ToolStripStatusLabel displayTimeLabel;
        private System.Windows.Forms.Timer baseTimer;
        private System.Windows.Forms.Panel viewPanel;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton MaintainRadioButton;
        private System.Windows.Forms.RadioButton DatalogRadioButton;
        private System.Windows.Forms.RadioButton OperationRadioButton;
        private System.Windows.Forms.RadioButton RecipeRadioButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button operatorIDButton;
        private Maintain.SignalTowerUnitControl signalTowerUnitControl1;
        private System.Windows.Forms.RadioButton CIMRadioButton;
        private System.Windows.Forms.RadioButton InspectRadioButton;
        private System.Windows.Forms.Panel btnDecPanel;
        private System.Windows.Forms.RadioButton ShutdownRadioButton;
        private System.Windows.Forms.RadioButton AlarmlistRadioButton;
    }
}

