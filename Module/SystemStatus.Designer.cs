namespace ContrelModule
{
    partial class SystemStatus
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.LLLoadCompCheckBox = new System.Windows.Forms.CheckBox();
            this.LLLoadReadyCheckBox = new System.Windows.Forms.CheckBox();
            this.LLAutoOperationCheckBox = new System.Windows.Forms.CheckBox();
            this.LLDeliveringCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.LELoadReqCheckBox = new System.Windows.Forms.CheckBox();
            this.LEGlassSensorCheckBox = new System.Windows.Forms.CheckBox();
            this.LEAutoOperationCheckBox = new System.Windows.Forms.CheckBox();
            this.LELoadOkCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ELExchangeCompCheckBox = new System.Windows.Forms.CheckBox();
            this.ELExchangeReadyCheckBox = new System.Windows.Forms.CheckBox();
            this.ELAutoOperationCheckBox = new System.Windows.Forms.CheckBox();
            this.ELDeliveringCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.EEExchangeReqCheckBox = new System.Windows.Forms.CheckBox();
            this.EEGlassSensorCheckBox = new System.Windows.Forms.CheckBox();
            this.EEAutoOperationCheckBox = new System.Windows.Forms.CheckBox();
            this.EEExchangeOkCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.ULUnloadCompCheckBox = new System.Windows.Forms.CheckBox();
            this.ULUnloadReadyCheckBox = new System.Windows.Forms.CheckBox();
            this.ULAutoOperationCheckBox = new System.Windows.Forms.CheckBox();
            this.ULDeliveringCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.UEUnloadReqCheckBox = new System.Windows.Forms.CheckBox();
            this.UEGlassSensorCheckBox = new System.Windows.Forms.CheckBox();
            this.UEAutoOperationCheckBox = new System.Windows.Forms.CheckBox();
            this.UEUnloadOkCheckBox = new System.Windows.Forms.CheckBox();
            this.RefreshTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "==========Defect Code==========";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 244);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(624, 233);
            this.dataGridView1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 66);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // radioButton4
            // 
            this.radioButton4.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton4.BackColor = System.Drawing.Color.Red;
            this.radioButton4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.radioButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton4.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButton4.ForeColor = System.Drawing.Color.White;
            this.radioButton4.ImageIndex = 0;
            this.radioButton4.Location = new System.Drawing.Point(136, 21);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(65, 38);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.Text = "Stop";
            this.radioButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radioButton4.UseVisualStyleBackColor = false;
            // 
            // radioButton3
            // 
            this.radioButton3.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton3.BackColor = System.Drawing.Color.Red;
            this.radioButton3.Checked = true;
            this.radioButton3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.radioButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton3.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButton3.ForeColor = System.Drawing.Color.White;
            this.radioButton3.ImageIndex = 1;
            this.radioButton3.Location = new System.Drawing.Point(201, 21);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(65, 38);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Down";
            this.radioButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radioButton3.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            this.radioButton2.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton2.BackColor = System.Drawing.Color.Red;
            this.radioButton2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton2.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.ImageIndex = 0;
            this.radioButton2.Location = new System.Drawing.Point(71, 21);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(65, 38);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Idle";
            this.radioButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            this.radioButton1.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton1.BackColor = System.Drawing.Color.Red;
            this.radioButton1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton1.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.ImageIndex = 0;
            this.radioButton1.Location = new System.Drawing.Point(6, 21);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(65, 38);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "Run";
            this.radioButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(3, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(202, 151);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Load";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.LLLoadCompCheckBox);
            this.groupBox6.Controls.Add(this.LLLoadReadyCheckBox);
            this.groupBox6.Controls.Add(this.LLAutoOperationCheckBox);
            this.groupBox6.Controls.Add(this.LLDeliveringCheckBox);
            this.groupBox6.Location = new System.Drawing.Point(103, 13);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(95, 132);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Loader";
            // 
            // LLLoadCompCheckBox
            // 
            this.LLLoadCompCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.LLLoadCompCheckBox.AutoCheck = false;
            this.LLLoadCompCheckBox.BackColor = System.Drawing.SystemColors.Control;
            this.LLLoadCompCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.LLLoadCompCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LLLoadCompCheckBox.ForeColor = System.Drawing.Color.Black;
            this.LLLoadCompCheckBox.Location = new System.Drawing.Point(4, 105);
            this.LLLoadCompCheckBox.Name = "LLLoadCompCheckBox";
            this.LLLoadCompCheckBox.Size = new System.Drawing.Size(87, 22);
            this.LLLoadCompCheckBox.TabIndex = 7;
            this.LLLoadCompCheckBox.Text = "Load Comp.";
            this.LLLoadCompCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LLLoadCompCheckBox.UseVisualStyleBackColor = false;
            // 
            // LLLoadReadyCheckBox
            // 
            this.LLLoadReadyCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.LLLoadReadyCheckBox.AutoCheck = false;
            this.LLLoadReadyCheckBox.BackColor = System.Drawing.SystemColors.Control;
            this.LLLoadReadyCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.LLLoadReadyCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LLLoadReadyCheckBox.ForeColor = System.Drawing.Color.Black;
            this.LLLoadReadyCheckBox.Location = new System.Drawing.Point(4, 49);
            this.LLLoadReadyCheckBox.Name = "LLLoadReadyCheckBox";
            this.LLLoadReadyCheckBox.Size = new System.Drawing.Size(87, 22);
            this.LLLoadReadyCheckBox.TabIndex = 5;
            this.LLLoadReadyCheckBox.Text = "Load Ready";
            this.LLLoadReadyCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LLLoadReadyCheckBox.UseVisualStyleBackColor = false;
            // 
            // LLAutoOperationCheckBox
            // 
            this.LLAutoOperationCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.LLAutoOperationCheckBox.AutoCheck = false;
            this.LLAutoOperationCheckBox.BackColor = System.Drawing.SystemColors.Control;
            this.LLAutoOperationCheckBox.Checked = true;
            this.LLAutoOperationCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LLAutoOperationCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.LLAutoOperationCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LLAutoOperationCheckBox.ForeColor = System.Drawing.Color.Black;
            this.LLAutoOperationCheckBox.Location = new System.Drawing.Point(4, 21);
            this.LLAutoOperationCheckBox.Name = "LLAutoOperationCheckBox";
            this.LLAutoOperationCheckBox.Size = new System.Drawing.Size(87, 22);
            this.LLAutoOperationCheckBox.TabIndex = 4;
            this.LLAutoOperationCheckBox.Text = "Auto Operation Status";
            this.LLAutoOperationCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LLAutoOperationCheckBox.UseVisualStyleBackColor = false;
            // 
            // LLDeliveringCheckBox
            // 
            this.LLDeliveringCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.LLDeliveringCheckBox.AutoCheck = false;
            this.LLDeliveringCheckBox.BackColor = System.Drawing.SystemColors.Control;
            this.LLDeliveringCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.LLDeliveringCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LLDeliveringCheckBox.ForeColor = System.Drawing.Color.Black;
            this.LLDeliveringCheckBox.Location = new System.Drawing.Point(4, 77);
            this.LLDeliveringCheckBox.Name = "LLDeliveringCheckBox";
            this.LLDeliveringCheckBox.Size = new System.Drawing.Size(87, 22);
            this.LLDeliveringCheckBox.TabIndex = 6;
            this.LLDeliveringCheckBox.Text = "Delivering";
            this.LLDeliveringCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LLDeliveringCheckBox.UseVisualStyleBackColor = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.LELoadReqCheckBox);
            this.groupBox5.Controls.Add(this.LEGlassSensorCheckBox);
            this.groupBox5.Controls.Add(this.LEAutoOperationCheckBox);
            this.groupBox5.Controls.Add(this.LELoadOkCheckBox);
            this.groupBox5.Location = new System.Drawing.Point(4, 13);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(95, 132);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "EQ";
            // 
            // LELoadReqCheckBox
            // 
            this.LELoadReqCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.LELoadReqCheckBox.AutoCheck = false;
            this.LELoadReqCheckBox.BackColor = System.Drawing.SystemColors.Control;
            this.LELoadReqCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.LELoadReqCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LELoadReqCheckBox.ForeColor = System.Drawing.Color.Black;
            this.LELoadReqCheckBox.Location = new System.Drawing.Point(4, 49);
            this.LELoadReqCheckBox.Name = "LELoadReqCheckBox";
            this.LELoadReqCheckBox.Size = new System.Drawing.Size(87, 22);
            this.LELoadReqCheckBox.TabIndex = 1;
            this.LELoadReqCheckBox.Text = "Load Req.";
            this.LELoadReqCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LELoadReqCheckBox.UseVisualStyleBackColor = false;
            // 
            // LEGlassSensorCheckBox
            // 
            this.LEGlassSensorCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.LEGlassSensorCheckBox.AutoCheck = false;
            this.LEGlassSensorCheckBox.BackColor = System.Drawing.SystemColors.Control;
            this.LEGlassSensorCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.LEGlassSensorCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LEGlassSensorCheckBox.ForeColor = System.Drawing.Color.Black;
            this.LEGlassSensorCheckBox.Location = new System.Drawing.Point(4, 105);
            this.LEGlassSensorCheckBox.Name = "LEGlassSensorCheckBox";
            this.LEGlassSensorCheckBox.Size = new System.Drawing.Size(87, 22);
            this.LEGlassSensorCheckBox.TabIndex = 3;
            this.LEGlassSensorCheckBox.Text = "Glass Sensor";
            this.LEGlassSensorCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LEGlassSensorCheckBox.UseVisualStyleBackColor = false;
            // 
            // LEAutoOperationCheckBox
            // 
            this.LEAutoOperationCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.LEAutoOperationCheckBox.AutoCheck = false;
            this.LEAutoOperationCheckBox.BackColor = System.Drawing.SystemColors.Control;
            this.LEAutoOperationCheckBox.Checked = true;
            this.LEAutoOperationCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LEAutoOperationCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.LEAutoOperationCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LEAutoOperationCheckBox.ForeColor = System.Drawing.Color.Black;
            this.LEAutoOperationCheckBox.Location = new System.Drawing.Point(4, 21);
            this.LEAutoOperationCheckBox.Name = "LEAutoOperationCheckBox";
            this.LEAutoOperationCheckBox.Size = new System.Drawing.Size(87, 22);
            this.LEAutoOperationCheckBox.TabIndex = 0;
            this.LEAutoOperationCheckBox.Text = "Auto Operation";
            this.LEAutoOperationCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LEAutoOperationCheckBox.UseVisualStyleBackColor = false;
            // 
            // LELoadOkCheckBox
            // 
            this.LELoadOkCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.LELoadOkCheckBox.AutoCheck = false;
            this.LELoadOkCheckBox.BackColor = System.Drawing.SystemColors.Control;
            this.LELoadOkCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.LELoadOkCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LELoadOkCheckBox.ForeColor = System.Drawing.Color.Black;
            this.LELoadOkCheckBox.Location = new System.Drawing.Point(4, 77);
            this.LELoadOkCheckBox.Name = "LELoadOkCheckBox";
            this.LELoadOkCheckBox.Size = new System.Drawing.Size(87, 22);
            this.LELoadOkCheckBox.TabIndex = 2;
            this.LELoadOkCheckBox.Text = "Load OK";
            this.LELoadOkCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LELoadOkCheckBox.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.groupBox7);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(217, 75);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(202, 151);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Exchange";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ELExchangeCompCheckBox);
            this.groupBox4.Controls.Add(this.ELExchangeReadyCheckBox);
            this.groupBox4.Controls.Add(this.ELAutoOperationCheckBox);
            this.groupBox4.Controls.Add(this.ELDeliveringCheckBox);
            this.groupBox4.Location = new System.Drawing.Point(103, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(95, 132);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Loader";
            // 
            // ELExchangeCompCheckBox
            // 
            this.ELExchangeCompCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.ELExchangeCompCheckBox.AutoCheck = false;
            this.ELExchangeCompCheckBox.BackColor = System.Drawing.SystemColors.Control;
            this.ELExchangeCompCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.ELExchangeCompCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ELExchangeCompCheckBox.ForeColor = System.Drawing.Color.Black;
            this.ELExchangeCompCheckBox.Location = new System.Drawing.Point(4, 105);
            this.ELExchangeCompCheckBox.Name = "ELExchangeCompCheckBox";
            this.ELExchangeCompCheckBox.Size = new System.Drawing.Size(87, 22);
            this.ELExchangeCompCheckBox.TabIndex = 7;
            this.ELExchangeCompCheckBox.Text = "Ex. Complete";
            this.ELExchangeCompCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ELExchangeCompCheckBox.UseVisualStyleBackColor = false;
            // 
            // ELExchangeReadyCheckBox
            // 
            this.ELExchangeReadyCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.ELExchangeReadyCheckBox.AutoCheck = false;
            this.ELExchangeReadyCheckBox.BackColor = System.Drawing.SystemColors.Control;
            this.ELExchangeReadyCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.ELExchangeReadyCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ELExchangeReadyCheckBox.ForeColor = System.Drawing.Color.Black;
            this.ELExchangeReadyCheckBox.Location = new System.Drawing.Point(4, 49);
            this.ELExchangeReadyCheckBox.Name = "ELExchangeReadyCheckBox";
            this.ELExchangeReadyCheckBox.Size = new System.Drawing.Size(87, 22);
            this.ELExchangeReadyCheckBox.TabIndex = 5;
            this.ELExchangeReadyCheckBox.Text = "Ex. Ready";
            this.ELExchangeReadyCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ELExchangeReadyCheckBox.UseVisualStyleBackColor = false;
            // 
            // ELAutoOperationCheckBox
            // 
            this.ELAutoOperationCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.ELAutoOperationCheckBox.AutoCheck = false;
            this.ELAutoOperationCheckBox.BackColor = System.Drawing.SystemColors.Control;
            this.ELAutoOperationCheckBox.Checked = true;
            this.ELAutoOperationCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ELAutoOperationCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.ELAutoOperationCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ELAutoOperationCheckBox.ForeColor = System.Drawing.Color.Black;
            this.ELAutoOperationCheckBox.Location = new System.Drawing.Point(4, 21);
            this.ELAutoOperationCheckBox.Name = "ELAutoOperationCheckBox";
            this.ELAutoOperationCheckBox.Size = new System.Drawing.Size(87, 22);
            this.ELAutoOperationCheckBox.TabIndex = 4;
            this.ELAutoOperationCheckBox.Text = "Auto Operation Status";
            this.ELAutoOperationCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ELAutoOperationCheckBox.UseVisualStyleBackColor = false;
            // 
            // ELDeliveringCheckBox
            // 
            this.ELDeliveringCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.ELDeliveringCheckBox.AutoCheck = false;
            this.ELDeliveringCheckBox.BackColor = System.Drawing.SystemColors.Control;
            this.ELDeliveringCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.ELDeliveringCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ELDeliveringCheckBox.ForeColor = System.Drawing.Color.Black;
            this.ELDeliveringCheckBox.Location = new System.Drawing.Point(4, 77);
            this.ELDeliveringCheckBox.Name = "ELDeliveringCheckBox";
            this.ELDeliveringCheckBox.Size = new System.Drawing.Size(87, 22);
            this.ELDeliveringCheckBox.TabIndex = 6;
            this.ELDeliveringCheckBox.Text = "Delivering";
            this.ELDeliveringCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ELDeliveringCheckBox.UseVisualStyleBackColor = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.EEExchangeReqCheckBox);
            this.groupBox7.Controls.Add(this.EEGlassSensorCheckBox);
            this.groupBox7.Controls.Add(this.EEAutoOperationCheckBox);
            this.groupBox7.Controls.Add(this.EEExchangeOkCheckBox);
            this.groupBox7.Location = new System.Drawing.Point(4, 13);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(95, 132);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "EQ";
            // 
            // EEExchangeReqCheckBox
            // 
            this.EEExchangeReqCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.EEExchangeReqCheckBox.AutoCheck = false;
            this.EEExchangeReqCheckBox.BackColor = System.Drawing.SystemColors.Control;
            this.EEExchangeReqCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.EEExchangeReqCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EEExchangeReqCheckBox.ForeColor = System.Drawing.Color.Black;
            this.EEExchangeReqCheckBox.Location = new System.Drawing.Point(4, 49);
            this.EEExchangeReqCheckBox.Name = "EEExchangeReqCheckBox";
            this.EEExchangeReqCheckBox.Size = new System.Drawing.Size(87, 22);
            this.EEExchangeReqCheckBox.TabIndex = 1;
            this.EEExchangeReqCheckBox.Text = "Ex. Req.";
            this.EEExchangeReqCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EEExchangeReqCheckBox.UseVisualStyleBackColor = false;
            // 
            // EEGlassSensorCheckBox
            // 
            this.EEGlassSensorCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.EEGlassSensorCheckBox.AutoCheck = false;
            this.EEGlassSensorCheckBox.BackColor = System.Drawing.SystemColors.Control;
            this.EEGlassSensorCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.EEGlassSensorCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EEGlassSensorCheckBox.ForeColor = System.Drawing.Color.Black;
            this.EEGlassSensorCheckBox.Location = new System.Drawing.Point(4, 105);
            this.EEGlassSensorCheckBox.Name = "EEGlassSensorCheckBox";
            this.EEGlassSensorCheckBox.Size = new System.Drawing.Size(87, 22);
            this.EEGlassSensorCheckBox.TabIndex = 3;
            this.EEGlassSensorCheckBox.Text = "Glass Sensor";
            this.EEGlassSensorCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EEGlassSensorCheckBox.UseVisualStyleBackColor = false;
            // 
            // EEAutoOperationCheckBox
            // 
            this.EEAutoOperationCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.EEAutoOperationCheckBox.AutoCheck = false;
            this.EEAutoOperationCheckBox.BackColor = System.Drawing.SystemColors.Control;
            this.EEAutoOperationCheckBox.Checked = true;
            this.EEAutoOperationCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.EEAutoOperationCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.EEAutoOperationCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EEAutoOperationCheckBox.ForeColor = System.Drawing.Color.Black;
            this.EEAutoOperationCheckBox.Location = new System.Drawing.Point(4, 21);
            this.EEAutoOperationCheckBox.Name = "EEAutoOperationCheckBox";
            this.EEAutoOperationCheckBox.Size = new System.Drawing.Size(87, 22);
            this.EEAutoOperationCheckBox.TabIndex = 0;
            this.EEAutoOperationCheckBox.Text = "Auto Operation";
            this.EEAutoOperationCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EEAutoOperationCheckBox.UseVisualStyleBackColor = false;
            // 
            // EEExchangeOkCheckBox
            // 
            this.EEExchangeOkCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.EEExchangeOkCheckBox.AutoCheck = false;
            this.EEExchangeOkCheckBox.BackColor = System.Drawing.SystemColors.Control;
            this.EEExchangeOkCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.EEExchangeOkCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EEExchangeOkCheckBox.ForeColor = System.Drawing.Color.Black;
            this.EEExchangeOkCheckBox.Location = new System.Drawing.Point(4, 77);
            this.EEExchangeOkCheckBox.Name = "EEExchangeOkCheckBox";
            this.EEExchangeOkCheckBox.Size = new System.Drawing.Size(87, 22);
            this.EEExchangeOkCheckBox.TabIndex = 2;
            this.EEExchangeOkCheckBox.Text = "Ex. OK";
            this.EEExchangeOkCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EEExchangeOkCheckBox.UseVisualStyleBackColor = false;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.groupBox9);
            this.groupBox8.Controls.Add(this.groupBox10);
            this.groupBox8.Enabled = false;
            this.groupBox8.Location = new System.Drawing.Point(429, 75);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(202, 151);
            this.groupBox8.TabIndex = 7;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Unload";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.ULUnloadCompCheckBox);
            this.groupBox9.Controls.Add(this.ULUnloadReadyCheckBox);
            this.groupBox9.Controls.Add(this.ULAutoOperationCheckBox);
            this.groupBox9.Controls.Add(this.ULDeliveringCheckBox);
            this.groupBox9.Location = new System.Drawing.Point(103, 13);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(95, 132);
            this.groupBox9.TabIndex = 5;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Loader";
            // 
            // ULUnloadCompCheckBox
            // 
            this.ULUnloadCompCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.ULUnloadCompCheckBox.AutoCheck = false;
            this.ULUnloadCompCheckBox.BackColor = System.Drawing.SystemColors.Control;
            this.ULUnloadCompCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.ULUnloadCompCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ULUnloadCompCheckBox.ForeColor = System.Drawing.Color.Black;
            this.ULUnloadCompCheckBox.Location = new System.Drawing.Point(4, 105);
            this.ULUnloadCompCheckBox.Name = "ULUnloadCompCheckBox";
            this.ULUnloadCompCheckBox.Size = new System.Drawing.Size(87, 22);
            this.ULUnloadCompCheckBox.TabIndex = 7;
            this.ULUnloadCompCheckBox.Text = "Unload Comp.";
            this.ULUnloadCompCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ULUnloadCompCheckBox.UseVisualStyleBackColor = false;
            // 
            // ULUnloadReadyCheckBox
            // 
            this.ULUnloadReadyCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.ULUnloadReadyCheckBox.AutoCheck = false;
            this.ULUnloadReadyCheckBox.BackColor = System.Drawing.SystemColors.Control;
            this.ULUnloadReadyCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.ULUnloadReadyCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ULUnloadReadyCheckBox.ForeColor = System.Drawing.Color.Black;
            this.ULUnloadReadyCheckBox.Location = new System.Drawing.Point(4, 49);
            this.ULUnloadReadyCheckBox.Name = "ULUnloadReadyCheckBox";
            this.ULUnloadReadyCheckBox.Size = new System.Drawing.Size(87, 22);
            this.ULUnloadReadyCheckBox.TabIndex = 5;
            this.ULUnloadReadyCheckBox.Text = "Unload Ready";
            this.ULUnloadReadyCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ULUnloadReadyCheckBox.UseVisualStyleBackColor = false;
            // 
            // ULAutoOperationCheckBox
            // 
            this.ULAutoOperationCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.ULAutoOperationCheckBox.AutoCheck = false;
            this.ULAutoOperationCheckBox.BackColor = System.Drawing.SystemColors.Control;
            this.ULAutoOperationCheckBox.Checked = true;
            this.ULAutoOperationCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ULAutoOperationCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.ULAutoOperationCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ULAutoOperationCheckBox.ForeColor = System.Drawing.Color.Black;
            this.ULAutoOperationCheckBox.Location = new System.Drawing.Point(4, 21);
            this.ULAutoOperationCheckBox.Name = "ULAutoOperationCheckBox";
            this.ULAutoOperationCheckBox.Size = new System.Drawing.Size(87, 22);
            this.ULAutoOperationCheckBox.TabIndex = 4;
            this.ULAutoOperationCheckBox.Text = "Auto Operation Status";
            this.ULAutoOperationCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ULAutoOperationCheckBox.UseVisualStyleBackColor = false;
            // 
            // ULDeliveringCheckBox
            // 
            this.ULDeliveringCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.ULDeliveringCheckBox.AutoCheck = false;
            this.ULDeliveringCheckBox.BackColor = System.Drawing.SystemColors.Control;
            this.ULDeliveringCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.ULDeliveringCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ULDeliveringCheckBox.ForeColor = System.Drawing.Color.Black;
            this.ULDeliveringCheckBox.Location = new System.Drawing.Point(4, 77);
            this.ULDeliveringCheckBox.Name = "ULDeliveringCheckBox";
            this.ULDeliveringCheckBox.Size = new System.Drawing.Size(87, 22);
            this.ULDeliveringCheckBox.TabIndex = 6;
            this.ULDeliveringCheckBox.Text = "Delivering";
            this.ULDeliveringCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ULDeliveringCheckBox.UseVisualStyleBackColor = false;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.UEUnloadReqCheckBox);
            this.groupBox10.Controls.Add(this.UEGlassSensorCheckBox);
            this.groupBox10.Controls.Add(this.UEAutoOperationCheckBox);
            this.groupBox10.Controls.Add(this.UEUnloadOkCheckBox);
            this.groupBox10.Location = new System.Drawing.Point(4, 13);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(95, 132);
            this.groupBox10.TabIndex = 4;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "EQ";
            // 
            // UEUnloadReqCheckBox
            // 
            this.UEUnloadReqCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.UEUnloadReqCheckBox.AutoCheck = false;
            this.UEUnloadReqCheckBox.BackColor = System.Drawing.SystemColors.Control;
            this.UEUnloadReqCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.UEUnloadReqCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UEUnloadReqCheckBox.ForeColor = System.Drawing.Color.Black;
            this.UEUnloadReqCheckBox.Location = new System.Drawing.Point(4, 49);
            this.UEUnloadReqCheckBox.Name = "UEUnloadReqCheckBox";
            this.UEUnloadReqCheckBox.Size = new System.Drawing.Size(87, 22);
            this.UEUnloadReqCheckBox.TabIndex = 1;
            this.UEUnloadReqCheckBox.Text = "Unload Req.";
            this.UEUnloadReqCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UEUnloadReqCheckBox.UseVisualStyleBackColor = false;
            // 
            // UEGlassSensorCheckBox
            // 
            this.UEGlassSensorCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.UEGlassSensorCheckBox.AutoCheck = false;
            this.UEGlassSensorCheckBox.BackColor = System.Drawing.SystemColors.Control;
            this.UEGlassSensorCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.UEGlassSensorCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UEGlassSensorCheckBox.ForeColor = System.Drawing.Color.Black;
            this.UEGlassSensorCheckBox.Location = new System.Drawing.Point(4, 105);
            this.UEGlassSensorCheckBox.Name = "UEGlassSensorCheckBox";
            this.UEGlassSensorCheckBox.Size = new System.Drawing.Size(87, 22);
            this.UEGlassSensorCheckBox.TabIndex = 3;
            this.UEGlassSensorCheckBox.Text = "Glass Sensor";
            this.UEGlassSensorCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UEGlassSensorCheckBox.UseVisualStyleBackColor = false;
            // 
            // UEAutoOperationCheckBox
            // 
            this.UEAutoOperationCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.UEAutoOperationCheckBox.AutoCheck = false;
            this.UEAutoOperationCheckBox.BackColor = System.Drawing.SystemColors.Control;
            this.UEAutoOperationCheckBox.Checked = true;
            this.UEAutoOperationCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.UEAutoOperationCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.UEAutoOperationCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UEAutoOperationCheckBox.ForeColor = System.Drawing.Color.Black;
            this.UEAutoOperationCheckBox.Location = new System.Drawing.Point(4, 21);
            this.UEAutoOperationCheckBox.Name = "UEAutoOperationCheckBox";
            this.UEAutoOperationCheckBox.Size = new System.Drawing.Size(87, 22);
            this.UEAutoOperationCheckBox.TabIndex = 0;
            this.UEAutoOperationCheckBox.Text = "Auto Operation";
            this.UEAutoOperationCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UEAutoOperationCheckBox.UseVisualStyleBackColor = false;
            // 
            // UEUnloadOkCheckBox
            // 
            this.UEUnloadOkCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.UEUnloadOkCheckBox.AutoCheck = false;
            this.UEUnloadOkCheckBox.BackColor = System.Drawing.SystemColors.Control;
            this.UEUnloadOkCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.UEUnloadOkCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UEUnloadOkCheckBox.ForeColor = System.Drawing.Color.Black;
            this.UEUnloadOkCheckBox.Location = new System.Drawing.Point(4, 77);
            this.UEUnloadOkCheckBox.Name = "UEUnloadOkCheckBox";
            this.UEUnloadOkCheckBox.Size = new System.Drawing.Size(87, 22);
            this.UEUnloadOkCheckBox.TabIndex = 2;
            this.UEUnloadOkCheckBox.Text = "Unload OK";
            this.UEUnloadOkCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UEUnloadOkCheckBox.UseVisualStyleBackColor = false;
            // 
            // RefreshTimer
            // 
            this.RefreshTimer.Tick += new System.EventHandler(this.RefreshTimer_Tick);
            // 
            // SystemStatus
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "SystemStatus";
            this.Size = new System.Drawing.Size(630, 480);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox LLLoadCompCheckBox;
        private System.Windows.Forms.CheckBox LLDeliveringCheckBox;
        private System.Windows.Forms.CheckBox LLLoadReadyCheckBox;
        private System.Windows.Forms.CheckBox LLAutoOperationCheckBox;
        private System.Windows.Forms.CheckBox LEGlassSensorCheckBox;
        private System.Windows.Forms.CheckBox LELoadOkCheckBox;
        private System.Windows.Forms.CheckBox LELoadReqCheckBox;
        private System.Windows.Forms.CheckBox LEAutoOperationCheckBox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox ELExchangeCompCheckBox;
        private System.Windows.Forms.CheckBox ELExchangeReadyCheckBox;
        private System.Windows.Forms.CheckBox ELAutoOperationCheckBox;
        private System.Windows.Forms.CheckBox ELDeliveringCheckBox;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.CheckBox EEExchangeReqCheckBox;
        private System.Windows.Forms.CheckBox EEGlassSensorCheckBox;
        private System.Windows.Forms.CheckBox EEAutoOperationCheckBox;
        private System.Windows.Forms.CheckBox EEExchangeOkCheckBox;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.CheckBox ULUnloadCompCheckBox;
        private System.Windows.Forms.CheckBox ULUnloadReadyCheckBox;
        private System.Windows.Forms.CheckBox ULAutoOperationCheckBox;
        private System.Windows.Forms.CheckBox ULDeliveringCheckBox;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.CheckBox UEUnloadReqCheckBox;
        private System.Windows.Forms.CheckBox UEGlassSensorCheckBox;
        private System.Windows.Forms.CheckBox UEAutoOperationCheckBox;
        private System.Windows.Forms.CheckBox UEUnloadOkCheckBox;
        private System.Windows.Forms.Timer RefreshTimer;
    }
}
