namespace Maintain
{
   partial class FilePanelControl
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
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.filePathTabControlEX = new Dotnetrix.Controls.TabControlEX();
         this.tabPageEX1 = new Dotnetrix.Controls.TabPageEX();
         this.tabPageEX2 = new Dotnetrix.Controls.TabPageEX();
         this.groupBox2 = new System.Windows.Forms.GroupBox();
         this.showCommErrorCheckBox = new System.Windows.Forms.CheckBox();
         this.groupBox3 = new System.Windows.Forms.GroupBox();
         this.label6 = new System.Windows.Forms.Label();
         this.autoDeleteDays = new System.Windows.Forms.NumericUpDown();
         this.autoDeleteLocalFileCheckBox = new System.Windows.Forms.CheckBox();
         this.groupBox4 = new System.Windows.Forms.GroupBox();
         this.label9 = new System.Windows.Forms.Label();
         this.label10 = new System.Windows.Forms.Label();
         this.label17 = new System.Windows.Forms.Label();
         this.warningHDDLimit = new System.Windows.Forms.NumericUpDown();
         this.label8 = new System.Windows.Forms.Label();
         this.label7 = new System.Windows.Forms.Label();
         this.cautionHDDLimit = new System.Windows.Forms.NumericUpDown();
         this.groupBox5 = new System.Windows.Forms.GroupBox();
         this.panel2 = new System.Windows.Forms.Panel();
         this.textBox15 = new System.Windows.Forms.TextBox();
         this.checkBox5 = new System.Windows.Forms.CheckBox();
         this.label13 = new System.Windows.Forms.Label();
         this.comboBox1 = new System.Windows.Forms.ComboBox();
         this.button13 = new System.Windows.Forms.Button();
         this.button14 = new System.Windows.Forms.Button();
         this.textBox12 = new System.Windows.Forms.TextBox();
         this.label16 = new System.Windows.Forms.Label();
         this.ipAddressControl2 = new IPAddressControlLib.IPAddressControl();
         this.label11 = new System.Windows.Forms.Label();
         this.textBox13 = new System.Windows.Forms.TextBox();
         this.label15 = new System.Windows.Forms.Label();
         this.textBox14 = new System.Windows.Forms.TextBox();
         this.label12 = new System.Windows.Forms.Label();
         this.label14 = new System.Windows.Forms.Label();
         this.dataGridView1 = new System.Windows.Forms.DataGridView();
         this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
         this.Column2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
         this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.groupBox1.SuspendLayout();
         this.filePathTabControlEX.SuspendLayout();
         this.groupBox2.SuspendLayout();
         this.groupBox3.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.autoDeleteDays)).BeginInit();
         this.groupBox4.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.warningHDDLimit)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.cautionHDDLimit)).BeginInit();
         this.groupBox5.SuspendLayout();
         this.panel2.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
         this.SuspendLayout();
         // 
         // groupBox1
         // 
         this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                     | System.Windows.Forms.AnchorStyles.Right)));
         this.groupBox1.Controls.Add(this.filePathTabControlEX);
         this.groupBox1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.groupBox1.Location = new System.Drawing.Point(16, 13);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(1078, 312);
         this.groupBox1.TabIndex = 0;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Data saving directory";
         // 
         // filePathTabControlEX
         // 
         this.filePathTabControlEX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                     | System.Windows.Forms.AnchorStyles.Right)));
         this.filePathTabControlEX.Appearance = Dotnetrix.Controls.TabAppearanceEX.Button;
         this.filePathTabControlEX.Controls.Add(this.tabPageEX1);
         this.filePathTabControlEX.Controls.Add(this.tabPageEX2);
         this.filePathTabControlEX.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.filePathTabControlEX.Location = new System.Drawing.Point(6, 23);
         this.filePathTabControlEX.Name = "filePathTabControlEX";
         this.filePathTabControlEX.SelectedIndex = 0;
         this.filePathTabControlEX.Size = new System.Drawing.Size(1066, 282);
         this.filePathTabControlEX.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
         this.filePathTabControlEX.TabIndex = 6;
         this.filePathTabControlEX.UseVisualStyles = false;
         // 
         // tabPageEX1
         // 
         this.tabPageEX1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
         this.tabPageEX1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.tabPageEX1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.tabPageEX1.Location = new System.Drawing.Point(4, 25);
         this.tabPageEX1.Name = "tabPageEX1";
         this.tabPageEX1.Size = new System.Drawing.Size(1058, 253);
         this.tabPageEX1.TabIndex = 0;
         this.tabPageEX1.Text = "Server";
         // 
         // tabPageEX2
         // 
         this.tabPageEX2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.tabPageEX2.Location = new System.Drawing.Point(4, 25);
         this.tabPageEX2.Name = "tabPageEX2";
         this.tabPageEX2.Size = new System.Drawing.Size(1058, 253);
         this.tabPageEX2.TabIndex = 1;
         this.tabPageEX2.Text = "Local";
         // 
         // groupBox2
         // 
         this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                     | System.Windows.Forms.AnchorStyles.Right)));
         this.groupBox2.Controls.Add(this.showCommErrorCheckBox);
         this.groupBox2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.groupBox2.Location = new System.Drawing.Point(16, 331);
         this.groupBox2.Name = "groupBox2";
         this.groupBox2.Size = new System.Drawing.Size(533, 66);
         this.groupBox2.TabIndex = 3;
         this.groupBox2.TabStop = false;
         this.groupBox2.Text = "Server setting";
         // 
         // showCommErrorCheckBox
         // 
         this.showCommErrorCheckBox.AutoSize = true;
         this.showCommErrorCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.showCommErrorCheckBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.showCommErrorCheckBox.Location = new System.Drawing.Point(17, 22);
         this.showCommErrorCheckBox.Name = "showCommErrorCheckBox";
         this.showCommErrorCheckBox.Size = new System.Drawing.Size(480, 20);
         this.showCommErrorCheckBox.TabIndex = 2;
         this.showCommErrorCheckBox.Text = "Show error message, when communication was interrupted to server";
         this.showCommErrorCheckBox.UseVisualStyleBackColor = true;
         this.showCommErrorCheckBox.CheckedChanged += new System.EventHandler(this.para_ValueChanged);
         // 
         // groupBox3
         // 
         this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                     | System.Windows.Forms.AnchorStyles.Right)));
         this.groupBox3.Controls.Add(this.label6);
         this.groupBox3.Controls.Add(this.autoDeleteDays);
         this.groupBox3.Controls.Add(this.autoDeleteLocalFileCheckBox);
         this.groupBox3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.groupBox3.Location = new System.Drawing.Point(551, 331);
         this.groupBox3.Name = "groupBox3";
         this.groupBox3.Size = new System.Drawing.Size(543, 66);
         this.groupBox3.TabIndex = 4;
         this.groupBox3.TabStop = false;
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(157, 28);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(86, 16);
         this.label6.TabIndex = 3;
         this.label6.Text = "days before";
         // 
         // autoDeleteDays
         // 
         this.autoDeleteDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.autoDeleteDays.Location = new System.Drawing.Point(31, 26);
         this.autoDeleteDays.Name = "autoDeleteDays";
         this.autoDeleteDays.Size = new System.Drawing.Size(120, 23);
         this.autoDeleteDays.TabIndex = 2;
         this.autoDeleteDays.ValueChanged += new System.EventHandler(this.para_ValueChanged);
         // 
         // autoDeleteLocalFileCheckBox
         // 
         this.autoDeleteLocalFileCheckBox.AutoSize = true;
         this.autoDeleteLocalFileCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.autoDeleteLocalFileCheckBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.autoDeleteLocalFileCheckBox.Location = new System.Drawing.Point(17, 0);
         this.autoDeleteLocalFileCheckBox.Name = "autoDeleteLocalFileCheckBox";
         this.autoDeleteLocalFileCheckBox.Size = new System.Drawing.Size(160, 20);
         this.autoDeleteLocalFileCheckBox.TabIndex = 0;
         this.autoDeleteLocalFileCheckBox.Text = "Auto delete local file";
         this.autoDeleteLocalFileCheckBox.UseVisualStyleBackColor = true;
         this.autoDeleteLocalFileCheckBox.CheckedChanged += new System.EventHandler(this.para_ValueChanged);
         // 
         // groupBox4
         // 
         this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                     | System.Windows.Forms.AnchorStyles.Right)));
         this.groupBox4.Controls.Add(this.label9);
         this.groupBox4.Controls.Add(this.label10);
         this.groupBox4.Controls.Add(this.label17);
         this.groupBox4.Controls.Add(this.warningHDDLimit);
         this.groupBox4.Controls.Add(this.label8);
         this.groupBox4.Controls.Add(this.label7);
         this.groupBox4.Controls.Add(this.cautionHDDLimit);
         this.groupBox4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.groupBox4.Location = new System.Drawing.Point(16, 403);
         this.groupBox4.Name = "groupBox4";
         this.groupBox4.Size = new System.Drawing.Size(1078, 90);
         this.groupBox4.TabIndex = 5;
         this.groupBox4.TabStop = false;
         this.groupBox4.Text = "Free space of local HDD check";
         // 
         // label9
         // 
         this.label9.AutoSize = true;
         this.label9.Location = new System.Drawing.Point(28, 55);
         this.label9.Name = "label9";
         this.label9.Size = new System.Drawing.Size(409, 16);
         this.label9.TabIndex = 7;
         this.label9.Text = "Display \"WARNING\" when remainder capacity of HDD is under";
         // 
         // label10
         // 
         this.label10.AutoSize = true;
         this.label10.Location = new System.Drawing.Point(567, 55);
         this.label10.Name = "label10";
         this.label10.Size = new System.Drawing.Size(32, 16);
         this.label10.TabIndex = 6;
         this.label10.Text = "MB.";
         // 
         // label17
         // 
         this.label17.AutoSize = true;
         this.label17.Location = new System.Drawing.Point(650, 29);
         this.label17.Name = "label17";
         this.label17.Size = new System.Drawing.Size(128, 16);
         this.label17.TabIndex = 22;
         this.label17.Text = "Ex. \\\\server\\share";
         this.label17.Visible = false;
         // 
         // warningHDDLimit
         // 
         this.warningHDDLimit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.warningHDDLimit.Location = new System.Drawing.Point(441, 53);
         this.warningHDDLimit.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
         this.warningHDDLimit.Name = "warningHDDLimit";
         this.warningHDDLimit.Size = new System.Drawing.Size(120, 23);
         this.warningHDDLimit.TabIndex = 5;
         this.warningHDDLimit.ValueChanged += new System.EventHandler(this.para_ValueChanged);
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.Location = new System.Drawing.Point(28, 26);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(407, 16);
         this.label8.TabIndex = 4;
         this.label8.Text = "Display \"CAUTION\" when remainder capacity of HDD is under";
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Location = new System.Drawing.Point(567, 26);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(32, 16);
         this.label7.TabIndex = 3;
         this.label7.Text = "MB.";
         // 
         // cautionHDDLimit
         // 
         this.cautionHDDLimit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.cautionHDDLimit.Location = new System.Drawing.Point(441, 24);
         this.cautionHDDLimit.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
         this.cautionHDDLimit.Name = "cautionHDDLimit";
         this.cautionHDDLimit.Size = new System.Drawing.Size(120, 23);
         this.cautionHDDLimit.TabIndex = 2;
         this.cautionHDDLimit.ValueChanged += new System.EventHandler(this.para_ValueChanged);
         // 
         // groupBox5
         // 
         this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                     | System.Windows.Forms.AnchorStyles.Right)));
         this.groupBox5.Controls.Add(this.panel2);
         this.groupBox5.Controls.Add(this.dataGridView1);
         this.groupBox5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.groupBox5.Location = new System.Drawing.Point(16, 499);
         this.groupBox5.Name = "groupBox5";
         this.groupBox5.Size = new System.Drawing.Size(1078, 266);
         this.groupBox5.TabIndex = 6;
         this.groupBox5.TabStop = false;
         this.groupBox5.Text = "Network Drives Connections";
         // 
         // panel2
         // 
         this.panel2.BackColor = System.Drawing.Color.Gainsboro;
         this.panel2.Controls.Add(this.textBox15);
         this.panel2.Controls.Add(this.checkBox5);
         this.panel2.Controls.Add(this.label13);
         this.panel2.Controls.Add(this.comboBox1);
         this.panel2.Controls.Add(this.button13);
         this.panel2.Controls.Add(this.button14);
         this.panel2.Controls.Add(this.textBox12);
         this.panel2.Controls.Add(this.label16);
         this.panel2.Controls.Add(this.ipAddressControl2);
         this.panel2.Controls.Add(this.label11);
         this.panel2.Controls.Add(this.textBox13);
         this.panel2.Controls.Add(this.label15);
         this.panel2.Controls.Add(this.textBox14);
         this.panel2.Controls.Add(this.label12);
         this.panel2.Controls.Add(this.label14);
         this.panel2.Location = new System.Drawing.Point(802, 22);
         this.panel2.Name = "panel2";
         this.panel2.Size = new System.Drawing.Size(266, 234);
         this.panel2.TabIndex = 25;
         // 
         // textBox15
         // 
         this.textBox15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.textBox15.Location = new System.Drawing.Point(98, 147);
         this.textBox15.Name = "textBox15";
         this.textBox15.Size = new System.Drawing.Size(153, 23);
         this.textBox15.TabIndex = 19;
         // 
         // checkBox5
         // 
         this.checkBox5.AutoSize = true;
         this.checkBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.checkBox5.Location = new System.Drawing.Point(13, 13);
         this.checkBox5.Name = "checkBox5";
         this.checkBox5.Size = new System.Drawing.Size(67, 20);
         this.checkBox5.TabIndex = 23;
         this.checkBox5.Text = "Enable";
         this.checkBox5.UseVisualStyleBackColor = true;
         // 
         // label13
         // 
         this.label13.AutoSize = true;
         this.label13.Location = new System.Drawing.Point(11, 150);
         this.label13.Name = "label13";
         this.label13.Size = new System.Drawing.Size(81, 16);
         this.label13.TabIndex = 18;
         this.label13.Text = "Description";
         // 
         // comboBox1
         // 
         this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.comboBox1.FormattingEnabled = true;
         this.comboBox1.Location = new System.Drawing.Point(184, 9);
         this.comboBox1.Name = "comboBox1";
         this.comboBox1.Size = new System.Drawing.Size(67, 24);
         this.comboBox1.TabIndex = 12;
         // 
         // button13
         // 
         this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
         this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.button13.Location = new System.Drawing.Point(14, 176);
         this.button13.Name = "button13";
         this.button13.Size = new System.Drawing.Size(100, 35);
         this.button13.TabIndex = 9;
         this.button13.Text = "Connect";
         this.button13.UseVisualStyleBackColor = false;
         // 
         // button14
         // 
         this.button14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
         this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.button14.Location = new System.Drawing.Point(151, 176);
         this.button14.Name = "button14";
         this.button14.Size = new System.Drawing.Size(100, 35);
         this.button14.TabIndex = 10;
         this.button14.Text = "Disconnect";
         this.button14.UseVisualStyleBackColor = false;
         // 
         // textBox12
         // 
         this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.textBox12.Location = new System.Drawing.Point(98, 93);
         this.textBox12.MaxLength = 20;
         this.textBox12.Name = "textBox12";
         this.textBox12.Size = new System.Drawing.Size(153, 23);
         this.textBox12.TabIndex = 6;
         this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
         // 
         // label16
         // 
         this.label16.AutoSize = true;
         this.label16.Location = new System.Drawing.Point(11, 69);
         this.label16.Name = "label16";
         this.label16.Size = new System.Drawing.Size(86, 16);
         this.label16.TabIndex = 20;
         this.label16.Text = "Server Path";
         // 
         // ipAddressControl2
         // 
         this.ipAddressControl2.AllowInternalTab = false;
         this.ipAddressControl2.AutoHeight = true;
         this.ipAddressControl2.BackColor = System.Drawing.SystemColors.Window;
         this.ipAddressControl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.ipAddressControl2.Cursor = System.Windows.Forms.Cursors.IBeam;
         this.ipAddressControl2.Location = new System.Drawing.Point(98, 39);
         this.ipAddressControl2.MinimumSize = new System.Drawing.Size(115, 23);
         this.ipAddressControl2.Name = "ipAddressControl2";
         this.ipAddressControl2.ReadOnly = false;
         this.ipAddressControl2.Size = new System.Drawing.Size(153, 23);
         this.ipAddressControl2.TabIndex = 8;
         this.ipAddressControl2.Text = "...";
         // 
         // label11
         // 
         this.label11.AutoSize = true;
         this.label11.Location = new System.Drawing.Point(11, 42);
         this.label11.Name = "label11";
         this.label11.Size = new System.Drawing.Size(78, 16);
         this.label11.TabIndex = 11;
         this.label11.Text = "IP Address";
         // 
         // textBox13
         // 
         this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.textBox13.Location = new System.Drawing.Point(98, 120);
         this.textBox13.MaxLength = 20;
         this.textBox13.Name = "textBox13";
         this.textBox13.PasswordChar = '*';
         this.textBox13.Size = new System.Drawing.Size(153, 23);
         this.textBox13.TabIndex = 14;
         this.textBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
         // 
         // label15
         // 
         this.label15.AutoSize = true;
         this.label15.Location = new System.Drawing.Point(137, 14);
         this.label15.Name = "label15";
         this.label15.Size = new System.Drawing.Size(41, 16);
         this.label15.TabIndex = 16;
         this.label15.Text = "Drive";
         // 
         // textBox14
         // 
         this.textBox14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.textBox14.Location = new System.Drawing.Point(98, 66);
         this.textBox14.Name = "textBox14";
         this.textBox14.Size = new System.Drawing.Size(153, 23);
         this.textBox14.TabIndex = 21;
         // 
         // label12
         // 
         this.label12.AutoSize = true;
         this.label12.Location = new System.Drawing.Point(11, 96);
         this.label12.Name = "label12";
         this.label12.Size = new System.Drawing.Size(61, 16);
         this.label12.TabIndex = 13;
         this.label12.Text = "Login ID";
         // 
         // label14
         // 
         this.label14.AutoSize = true;
         this.label14.Location = new System.Drawing.Point(11, 123);
         this.label14.Name = "label14";
         this.label14.Size = new System.Drawing.Size(70, 16);
         this.label14.TabIndex = 15;
         this.label14.Text = "Password";
         // 
         // dataGridView1
         // 
         this.dataGridView1.AllowUserToAddRows = false;
         this.dataGridView1.AllowUserToDeleteRows = false;
         this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
         dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
         dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(196)))), ((int)(((byte)(221)))));
         dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
         dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
         dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
         this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
         this.dataGridView1.ColumnHeadersHeight = 30;
         this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
         this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column4,
            this.Column6});
         this.dataGridView1.Location = new System.Drawing.Point(11, 22);
         this.dataGridView1.MultiSelect = false;
         this.dataGridView1.Name = "dataGridView1";
         this.dataGridView1.RowHeadersVisible = false;
         this.dataGridView1.RowTemplate.Height = 24;
         this.dataGridView1.Size = new System.Drawing.Size(785, 234);
         this.dataGridView1.TabIndex = 5;
         // 
         // Column1
         // 
         this.Column1.HeaderText = "Enable";
         this.Column1.Name = "Column1";
         this.Column1.ReadOnly = true;
         this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
         this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
         this.Column1.Width = 50;
         // 
         // Column2
         // 
         this.Column2.HeaderText = "Drive";
         this.Column2.Name = "Column2";
         this.Column2.ReadOnly = true;
         this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
         this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
         this.Column2.Width = 70;
         // 
         // Column3
         // 
         this.Column3.HeaderText = "IP Address";
         this.Column3.Name = "Column3";
         this.Column3.Width = 150;
         // 
         // Column5
         // 
         this.Column5.HeaderText = "Server Path";
         this.Column5.Name = "Column5";
         this.Column5.Width = 200;
         // 
         // Column4
         // 
         this.Column4.HeaderText = "Login ID";
         this.Column4.Name = "Column4";
         this.Column4.Width = 120;
         // 
         // Column6
         // 
         this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
         this.Column6.HeaderText = "Description";
         this.Column6.Name = "Column6";
         // 
         // FilePanelControl
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.AutoScroll = true;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
         this.Controls.Add(this.groupBox5);
         this.Controls.Add(this.groupBox4);
         this.Controls.Add(this.groupBox3);
         this.Controls.Add(this.groupBox2);
         this.Controls.Add(this.groupBox1);
         this.Name = "FilePanelControl";
         this.Size = new System.Drawing.Size(1109, 843);
         this.groupBox1.ResumeLayout(false);
         this.filePathTabControlEX.ResumeLayout(false);
         this.groupBox2.ResumeLayout(false);
         this.groupBox2.PerformLayout();
         this.groupBox3.ResumeLayout(false);
         this.groupBox3.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.autoDeleteDays)).EndInit();
         this.groupBox4.ResumeLayout(false);
         this.groupBox4.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.warningHDDLimit)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.cautionHDDLimit)).EndInit();
         this.groupBox5.ResumeLayout(false);
         this.panel2.ResumeLayout(false);
         this.panel2.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.GroupBox groupBox2;
      private System.Windows.Forms.CheckBox showCommErrorCheckBox;
      private System.Windows.Forms.GroupBox groupBox3;
      private System.Windows.Forms.CheckBox autoDeleteLocalFileCheckBox;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.NumericUpDown autoDeleteDays;
      private System.Windows.Forms.GroupBox groupBox4;
      private System.Windows.Forms.Label label9;
      private System.Windows.Forms.Label label10;
      private System.Windows.Forms.NumericUpDown warningHDDLimit;
      private System.Windows.Forms.Label label8;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.NumericUpDown cautionHDDLimit;
      private Dotnetrix.Controls.TabControlEX filePathTabControlEX;
      private Dotnetrix.Controls.TabPageEX tabPageEX1;
      private Dotnetrix.Controls.TabPageEX tabPageEX2;
      private System.Windows.Forms.GroupBox groupBox5;
      private System.Windows.Forms.DataGridView dataGridView1;
      private System.Windows.Forms.TextBox textBox12;
      private IPAddressControlLib.IPAddressControl ipAddressControl2;
      private System.Windows.Forms.Button button14;
      private System.Windows.Forms.Button button13;
      private System.Windows.Forms.ComboBox comboBox1;
      private System.Windows.Forms.Label label11;
      private System.Windows.Forms.Label label14;
      private System.Windows.Forms.TextBox textBox13;
      private System.Windows.Forms.Label label12;
      private System.Windows.Forms.Label label13;
      private System.Windows.Forms.TextBox textBox15;
      private System.Windows.Forms.TextBox textBox14;
      private System.Windows.Forms.Label label16;
      private System.Windows.Forms.Label label17;
      private System.Windows.Forms.CheckBox checkBox5;
      private System.Windows.Forms.Panel panel2;
      private System.Windows.Forms.Label label15;
      private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
      private System.Windows.Forms.DataGridViewComboBoxColumn Column2;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
   }
}
