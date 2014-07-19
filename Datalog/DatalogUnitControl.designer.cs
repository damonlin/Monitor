namespace Datalog
{
   partial class DatalogUnitControl
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
          this.tabControlEX1 = new Dotnetrix.Controls.TabControlEX();
          this.tabPageEX1 = new Dotnetrix.Controls.TabPageEX();
          this.showLastLogCheckBox = new System.Windows.Forms.CheckBox();
          this.todayLogListBox = new System.Windows.Forms.ListBox();
          this.realTimeUpdateCheckBox = new System.Windows.Forms.CheckBox();
          this.tabPageEX2 = new Dotnetrix.Controls.TabPageEX();
          this.panel4 = new System.Windows.Forms.Panel();
          this.groupBox4 = new System.Windows.Forms.GroupBox();
          this.showLastMonthLogButton = new System.Windows.Forms.RadioButton();
          this.showLastWeekLogButton = new System.Windows.Forms.RadioButton();
          this.showAllDaysLogButton = new System.Windows.Forms.RadioButton();
          this.showSearchLogButton = new System.Windows.Forms.RadioButton();
          this.showYesterdayLogButton = new System.Windows.Forms.RadioButton();
          this.searchEndDatePicker = new System.Windows.Forms.DateTimePicker();
          this.showTodayLogButton = new System.Windows.Forms.RadioButton();
          this.searchStartDatePicker = new System.Windows.Forms.DateTimePicker();
          this.label4 = new System.Windows.Forms.Label();
          this.searchStartTimePicker = new System.Windows.Forms.DateTimePicker();
          this.label3 = new System.Windows.Forms.Label();
          this.searchEndTimePicker = new System.Windows.Forms.DateTimePicker();
          this.groupBox2 = new System.Windows.Forms.GroupBox();
          this.findWhatButton = new System.Windows.Forms.Button();
          this.searchWhatTextBox = new System.Windows.Forms.TextBox();
          this.historyLogTextBox = new System.Windows.Forms.TextBox();
          this.groupBox1 = new System.Windows.Forms.GroupBox();
          this.selectLogFileFolderButton = new System.Windows.Forms.Button();
          this.logFolderTextBox = new System.Windows.Forms.TextBox();
          this.groupBox3 = new System.Windows.Forms.GroupBox();
          this.label6 = new System.Windows.Forms.Label();
          this.autoDeleteDaysNumeric = new System.Windows.Forms.NumericUpDown();
          this.autoDeleteLogCheckBox = new System.Windows.Forms.CheckBox();
          this.deleteAllLogsButton = new System.Windows.Forms.Button();
          this.logFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
          this.tabControlEX1.SuspendLayout();
          this.tabPageEX1.SuspendLayout();
          this.tabPageEX2.SuspendLayout();
          this.panel4.SuspendLayout();
          this.groupBox4.SuspendLayout();
          this.groupBox2.SuspendLayout();
          this.groupBox1.SuspendLayout();
          this.groupBox3.SuspendLayout();
          ((System.ComponentModel.ISupportInitialize)(this.autoDeleteDaysNumeric)).BeginInit();
          this.SuspendLayout();
          // 
          // tabControlEX1
          // 
          this.tabControlEX1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
          this.tabControlEX1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                      | System.Windows.Forms.AnchorStyles.Left)
                      | System.Windows.Forms.AnchorStyles.Right)));
          this.tabControlEX1.Appearance = Dotnetrix.Controls.TabAppearanceEX.FlatTab;
          this.tabControlEX1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
          this.tabControlEX1.Controls.Add(this.tabPageEX1);
          this.tabControlEX1.Controls.Add(this.tabPageEX2);
          this.tabControlEX1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.tabControlEX1.Location = new System.Drawing.Point(3, 66);
          this.tabControlEX1.Multiline = true;
          this.tabControlEX1.Name = "tabControlEX1";
          this.tabControlEX1.SelectedIndex = 1;
          this.tabControlEX1.SelectedTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
          this.tabControlEX1.SelectedTabFontStyle = System.Drawing.FontStyle.Bold;
          this.tabControlEX1.Size = new System.Drawing.Size(1105, 767);
          this.tabControlEX1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
          this.tabControlEX1.TabColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
          this.tabControlEX1.TabIndex = 39;
          this.tabControlEX1.UseVisualStyles = false;
          // 
          // tabPageEX1
          // 
          this.tabPageEX1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
          this.tabPageEX1.Controls.Add(this.showLastLogCheckBox);
          this.tabPageEX1.Controls.Add(this.todayLogListBox);
          this.tabPageEX1.Controls.Add(this.realTimeUpdateCheckBox);
          this.tabPageEX1.Font = new System.Drawing.Font("Verdana", 9.936297F);
          this.tabPageEX1.Location = new System.Drawing.Point(4, 4);
          this.tabPageEX1.Name = "tabPageEX1";
          this.tabPageEX1.Size = new System.Drawing.Size(1097, 644);
          this.tabPageEX1.TabIndex = 0;
          this.tabPageEX1.Text = "Today";
          // 
          // showLastLogCheckBox
          // 
          this.showLastLogCheckBox.AutoSize = true;
          this.showLastLogCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
          this.showLastLogCheckBox.Checked = true;
          this.showLastLogCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
          this.showLastLogCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
          this.showLastLogCheckBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.showLastLogCheckBox.Location = new System.Drawing.Point(133, 3);
          this.showLastLogCheckBox.Name = "showLastLogCheckBox";
          this.showLastLogCheckBox.Size = new System.Drawing.Size(164, 19);
          this.showLastLogCheckBox.TabIndex = 47;
          this.showLastLogCheckBox.Text = "Auto Show Last Log Item";
          this.showLastLogCheckBox.UseVisualStyleBackColor = false;
          // 
          // todayLogListBox
          // 
          this.todayLogListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                      | System.Windows.Forms.AnchorStyles.Left)
                      | System.Windows.Forms.AnchorStyles.Right)));
          this.todayLogListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
          this.todayLogListBox.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.todayLogListBox.FormattingEnabled = true;
          this.todayLogListBox.ItemHeight = 16;
          this.todayLogListBox.Location = new System.Drawing.Point(4, 28);
          this.todayLogListBox.Margin = new System.Windows.Forms.Padding(5);
          this.todayLogListBox.Name = "todayLogListBox";
          this.todayLogListBox.Size = new System.Drawing.Size(1073, 658);
          this.todayLogListBox.TabIndex = 46;
          // 
          // realTimeUpdateCheckBox
          // 
          this.realTimeUpdateCheckBox.AutoSize = true;
          this.realTimeUpdateCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
          this.realTimeUpdateCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
          this.realTimeUpdateCheckBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.realTimeUpdateCheckBox.Location = new System.Drawing.Point(5, 3);
          this.realTimeUpdateCheckBox.Name = "realTimeUpdateCheckBox";
          this.realTimeUpdateCheckBox.Size = new System.Drawing.Size(122, 19);
          this.realTimeUpdateCheckBox.TabIndex = 45;
          this.realTimeUpdateCheckBox.Text = "Real Time Update";
          this.realTimeUpdateCheckBox.UseVisualStyleBackColor = false;
          this.realTimeUpdateCheckBox.CheckedChanged += new System.EventHandler(this.realTimeUpdateCheckBox_CheckedChanged);
          // 
          // tabPageEX2
          // 
          this.tabPageEX2.Controls.Add(this.panel4);
          this.tabPageEX2.Controls.Add(this.historyLogTextBox);
          this.tabPageEX2.Font = new System.Drawing.Font("Verdana", 9.936297F);
          this.tabPageEX2.Location = new System.Drawing.Point(4, 4);
          this.tabPageEX2.Name = "tabPageEX2";
          this.tabPageEX2.Size = new System.Drawing.Size(1097, 738);
          this.tabPageEX2.TabIndex = 1;
          this.tabPageEX2.Text = "History";
          // 
          // panel4
          // 
          this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                      | System.Windows.Forms.AnchorStyles.Right)));
          this.panel4.BackColor = System.Drawing.Color.Silver;
          this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
          this.panel4.Controls.Add(this.groupBox4);
          this.panel4.Controls.Add(this.groupBox2);
          this.panel4.Location = new System.Drawing.Point(4, 610);
          this.panel4.Name = "panel4";
          this.panel4.Size = new System.Drawing.Size(1069, 104);
          this.panel4.TabIndex = 51;
          // 
          // groupBox4
          // 
          this.groupBox4.Controls.Add(this.showLastMonthLogButton);
          this.groupBox4.Controls.Add(this.showLastWeekLogButton);
          this.groupBox4.Controls.Add(this.showAllDaysLogButton);
          this.groupBox4.Controls.Add(this.showSearchLogButton);
          this.groupBox4.Controls.Add(this.showYesterdayLogButton);
          this.groupBox4.Controls.Add(this.searchEndDatePicker);
          this.groupBox4.Controls.Add(this.showTodayLogButton);
          this.groupBox4.Controls.Add(this.searchStartDatePicker);
          this.groupBox4.Controls.Add(this.label4);
          this.groupBox4.Controls.Add(this.searchStartTimePicker);
          this.groupBox4.Controls.Add(this.label3);
          this.groupBox4.Controls.Add(this.searchEndTimePicker);
          this.groupBox4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.groupBox4.Location = new System.Drawing.Point(9, 6);
          this.groupBox4.Name = "groupBox4";
          this.groupBox4.Size = new System.Drawing.Size(672, 86);
          this.groupBox4.TabIndex = 52;
          this.groupBox4.TabStop = false;
          this.groupBox4.Text = "Range";
          // 
          // showLastMonthLogButton
          // 
          this.showLastMonthLogButton.Appearance = System.Windows.Forms.Appearance.Button;
          this.showLastMonthLogButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
          this.showLastMonthLogButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Orange;
          this.showLastMonthLogButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
          this.showLastMonthLogButton.Location = new System.Drawing.Point(456, 49);
          this.showLastMonthLogButton.Name = "showLastMonthLogButton";
          this.showLastMonthLogButton.Size = new System.Drawing.Size(96, 25);
          this.showLastMonthLogButton.TabIndex = 48;
          this.showLastMonthLogButton.Text = "Last Month";
          this.showLastMonthLogButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
          this.showLastMonthLogButton.UseVisualStyleBackColor = false;
          this.showLastMonthLogButton.Click += new System.EventHandler(this.searchLogButton_CheckedChanged);
          // 
          // showLastWeekLogButton
          // 
          this.showLastWeekLogButton.Appearance = System.Windows.Forms.Appearance.Button;
          this.showLastWeekLogButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
          this.showLastWeekLogButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Orange;
          this.showLastWeekLogButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
          this.showLastWeekLogButton.Location = new System.Drawing.Point(456, 22);
          this.showLastWeekLogButton.Name = "showLastWeekLogButton";
          this.showLastWeekLogButton.Size = new System.Drawing.Size(96, 25);
          this.showLastWeekLogButton.TabIndex = 47;
          this.showLastWeekLogButton.Text = "Last Week";
          this.showLastWeekLogButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
          this.showLastWeekLogButton.UseVisualStyleBackColor = false;
          this.showLastWeekLogButton.Click += new System.EventHandler(this.searchLogButton_CheckedChanged);
          // 
          // showAllDaysLogButton
          // 
          this.showAllDaysLogButton.Appearance = System.Windows.Forms.Appearance.Button;
          this.showAllDaysLogButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
          this.showAllDaysLogButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Orange;
          this.showAllDaysLogButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
          this.showAllDaysLogButton.Location = new System.Drawing.Point(558, 22);
          this.showAllDaysLogButton.Name = "showAllDaysLogButton";
          this.showAllDaysLogButton.Size = new System.Drawing.Size(96, 52);
          this.showAllDaysLogButton.TabIndex = 45;
          this.showAllDaysLogButton.Text = "All Days";
          this.showAllDaysLogButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
          this.showAllDaysLogButton.UseVisualStyleBackColor = false;
          this.showAllDaysLogButton.Click += new System.EventHandler(this.searchLogButton_CheckedChanged);
          // 
          // showSearchLogButton
          // 
          this.showSearchLogButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
          this.showSearchLogButton.Appearance = System.Windows.Forms.Appearance.Button;
          this.showSearchLogButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
          this.showSearchLogButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Orange;
          this.showSearchLogButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
          this.showSearchLogButton.Location = new System.Drawing.Point(252, 22);
          this.showSearchLogButton.Name = "showSearchLogButton";
          this.showSearchLogButton.Size = new System.Drawing.Size(96, 52);
          this.showSearchLogButton.TabIndex = 46;
          this.showSearchLogButton.Text = "Search";
          this.showSearchLogButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
          this.showSearchLogButton.UseVisualStyleBackColor = false;
          this.showSearchLogButton.Click += new System.EventHandler(this.searchLogButton_CheckedChanged);
          // 
          // showYesterdayLogButton
          // 
          this.showYesterdayLogButton.Appearance = System.Windows.Forms.Appearance.Button;
          this.showYesterdayLogButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
          this.showYesterdayLogButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Orange;
          this.showYesterdayLogButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
          this.showYesterdayLogButton.Location = new System.Drawing.Point(354, 49);
          this.showYesterdayLogButton.Name = "showYesterdayLogButton";
          this.showYesterdayLogButton.Size = new System.Drawing.Size(96, 25);
          this.showYesterdayLogButton.TabIndex = 44;
          this.showYesterdayLogButton.Text = "Yesterday";
          this.showYesterdayLogButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
          this.showYesterdayLogButton.UseVisualStyleBackColor = false;
          this.showYesterdayLogButton.Click += new System.EventHandler(this.searchLogButton_CheckedChanged);
          // 
          // searchEndDatePicker
          // 
          this.searchEndDatePicker.CalendarFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.searchEndDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
          this.searchEndDatePicker.Location = new System.Drawing.Point(56, 51);
          this.searchEndDatePicker.Name = "searchEndDatePicker";
          this.searchEndDatePicker.Size = new System.Drawing.Size(89, 21);
          this.searchEndDatePicker.TabIndex = 39;
          // 
          // showTodayLogButton
          // 
          this.showTodayLogButton.Appearance = System.Windows.Forms.Appearance.Button;
          this.showTodayLogButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
          this.showTodayLogButton.Checked = true;
          this.showTodayLogButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Orange;
          this.showTodayLogButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
          this.showTodayLogButton.Location = new System.Drawing.Point(354, 22);
          this.showTodayLogButton.Name = "showTodayLogButton";
          this.showTodayLogButton.Size = new System.Drawing.Size(96, 25);
          this.showTodayLogButton.TabIndex = 43;
          this.showTodayLogButton.TabStop = true;
          this.showTodayLogButton.Text = "Today";
          this.showTodayLogButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
          this.showTodayLogButton.UseVisualStyleBackColor = false;
          this.showTodayLogButton.Click += new System.EventHandler(this.searchLogButton_CheckedChanged);
          // 
          // searchStartDatePicker
          // 
          this.searchStartDatePicker.CalendarFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.searchStartDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
          this.searchStartDatePicker.Location = new System.Drawing.Point(56, 22);
          this.searchStartDatePicker.Name = "searchStartDatePicker";
          this.searchStartDatePicker.Size = new System.Drawing.Size(89, 21);
          this.searchStartDatePicker.TabIndex = 33;
          // 
          // label4
          // 
          this.label4.AutoSize = true;
          this.label4.Location = new System.Drawing.Point(33, 54);
          this.label4.Name = "label4";
          this.label4.Size = new System.Drawing.Size(21, 15);
          this.label4.TabIndex = 40;
          this.label4.Text = "To";
          // 
          // searchStartTimePicker
          // 
          this.searchStartTimePicker.CalendarFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.searchStartTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
          this.searchStartTimePicker.Location = new System.Drawing.Point(146, 22);
          this.searchStartTimePicker.Name = "searchStartTimePicker";
          this.searchStartTimePicker.ShowUpDown = true;
          this.searchStartTimePicker.Size = new System.Drawing.Size(101, 21);
          this.searchStartTimePicker.TabIndex = 41;
          // 
          // label3
          // 
          this.label3.Location = new System.Drawing.Point(19, 25);
          this.label3.Name = "label3";
          this.label3.Size = new System.Drawing.Size(41, 15);
          this.label3.TabIndex = 0;
          this.label3.Text = "From";
          // 
          // searchEndTimePicker
          // 
          this.searchEndTimePicker.CalendarFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.searchEndTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
          this.searchEndTimePicker.Location = new System.Drawing.Point(145, 51);
          this.searchEndTimePicker.Name = "searchEndTimePicker";
          this.searchEndTimePicker.ShowUpDown = true;
          this.searchEndTimePicker.Size = new System.Drawing.Size(101, 21);
          this.searchEndTimePicker.TabIndex = 42;
          // 
          // groupBox2
          // 
          this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                      | System.Windows.Forms.AnchorStyles.Right)));
          this.groupBox2.Controls.Add(this.findWhatButton);
          this.groupBox2.Controls.Add(this.searchWhatTextBox);
          this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
          this.groupBox2.Location = new System.Drawing.Point(687, 6);
          this.groupBox2.Name = "groupBox2";
          this.groupBox2.Size = new System.Drawing.Size(372, 86);
          this.groupBox2.TabIndex = 52;
          this.groupBox2.TabStop = false;
          this.groupBox2.Text = "Find what";
          // 
          // findWhatButton
          // 
          this.findWhatButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
          this.findWhatButton.BackColor = System.Drawing.Color.Khaki;
          this.findWhatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
          this.findWhatButton.Location = new System.Drawing.Point(297, 35);
          this.findWhatButton.Margin = new System.Windows.Forms.Padding(0);
          this.findWhatButton.Name = "findWhatButton";
          this.findWhatButton.Size = new System.Drawing.Size(62, 39);
          this.findWhatButton.TabIndex = 53;
          this.findWhatButton.Text = "Find";
          this.findWhatButton.UseVisualStyleBackColor = false;
          this.findWhatButton.Click += new System.EventHandler(this.findWhatButton_Click);
          // 
          // searchWhatTextBox
          // 
          this.searchWhatTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                      | System.Windows.Forms.AnchorStyles.Right)));
          this.searchWhatTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
          this.searchWhatTextBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.searchWhatTextBox.Location = new System.Drawing.Point(12, 35);
          this.searchWhatTextBox.Multiline = true;
          this.searchWhatTextBox.Name = "searchWhatTextBox";
          this.searchWhatTextBox.Size = new System.Drawing.Size(282, 39);
          this.searchWhatTextBox.TabIndex = 34;
          this.searchWhatTextBox.WordWrap = false;
          // 
          // historyLogTextBox
          // 
          this.historyLogTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                      | System.Windows.Forms.AnchorStyles.Left)
                      | System.Windows.Forms.AnchorStyles.Right)));
          this.historyLogTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
          this.historyLogTextBox.BackColor = System.Drawing.Color.White;
          this.historyLogTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
          this.historyLogTextBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.historyLogTextBox.Location = new System.Drawing.Point(3, 4);
          this.historyLogTextBox.Margin = new System.Windows.Forms.Padding(5);
          this.historyLogTextBox.Multiline = true;
          this.historyLogTextBox.Name = "historyLogTextBox";
          this.historyLogTextBox.ReadOnly = true;
          this.historyLogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
          this.historyLogTextBox.Size = new System.Drawing.Size(1069, 605);
          this.historyLogTextBox.TabIndex = 38;
          this.historyLogTextBox.WordWrap = false;
          this.historyLogTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.historyLogTextBox_KeyDown);
          // 
          // groupBox1
          // 
          this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                      | System.Windows.Forms.AnchorStyles.Right)));
          this.groupBox1.Controls.Add(this.selectLogFileFolderButton);
          this.groupBox1.Controls.Add(this.logFolderTextBox);
          this.groupBox1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.groupBox1.Location = new System.Drawing.Point(8, 3);
          this.groupBox1.Name = "groupBox1";
          this.groupBox1.Size = new System.Drawing.Size(754, 57);
          this.groupBox1.TabIndex = 40;
          this.groupBox1.TabStop = false;
          this.groupBox1.Text = "Log file directory";
          // 
          // selectLogFileFolderButton
          // 
          this.selectLogFileFolderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
          this.selectLogFileFolderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
          this.selectLogFileFolderButton.Font = new System.Drawing.Font("Verdana", 9.171968F);
          this.selectLogFileFolderButton.Location = new System.Drawing.Point(700, 22);
          this.selectLogFileFolderButton.Name = "selectLogFileFolderButton";
          this.selectLogFileFolderButton.Size = new System.Drawing.Size(33, 23);
          this.selectLogFileFolderButton.TabIndex = 8;
          this.selectLogFileFolderButton.Text = "...";
          this.selectLogFileFolderButton.UseVisualStyleBackColor = true;
          this.selectLogFileFolderButton.Click += new System.EventHandler(this.selectLogFileFolderButton_Click);
          // 
          // logFolderTextBox
          // 
          this.logFolderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                      | System.Windows.Forms.AnchorStyles.Right)));
          this.logFolderTextBox.BackColor = System.Drawing.Color.White;
          this.logFolderTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
          this.logFolderTextBox.Font = new System.Drawing.Font("Verdana", 9.936297F);
          this.logFolderTextBox.Location = new System.Drawing.Point(17, 22);
          this.logFolderTextBox.Name = "logFolderTextBox";
          this.logFolderTextBox.ReadOnly = true;
          this.logFolderTextBox.Size = new System.Drawing.Size(682, 24);
          this.logFolderTextBox.TabIndex = 0;
          // 
          // groupBox3
          // 
          this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
          this.groupBox3.Controls.Add(this.label6);
          this.groupBox3.Controls.Add(this.autoDeleteDaysNumeric);
          this.groupBox3.Controls.Add(this.autoDeleteLogCheckBox);
          this.groupBox3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.groupBox3.Location = new System.Drawing.Point(768, 3);
          this.groupBox3.Name = "groupBox3";
          this.groupBox3.Size = new System.Drawing.Size(257, 56);
          this.groupBox3.TabIndex = 5;
          this.groupBox3.TabStop = false;
          // 
          // label6
          // 
          this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                      | System.Windows.Forms.AnchorStyles.Right)));
          this.label6.AutoSize = true;
          this.label6.Font = new System.Drawing.Font("Verdana", 9.936297F);
          this.label6.Location = new System.Drawing.Point(150, 24);
          this.label6.Name = "label6";
          this.label6.Size = new System.Drawing.Size(91, 17);
          this.label6.TabIndex = 3;
          this.label6.Text = "days before";
          // 
          // autoDeleteDaysNumeric
          // 
          this.autoDeleteDaysNumeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
          this.autoDeleteDaysNumeric.Font = new System.Drawing.Font("Verdana", 9.936297F);
          this.autoDeleteDaysNumeric.Location = new System.Drawing.Point(21, 22);
          this.autoDeleteDaysNumeric.Name = "autoDeleteDaysNumeric";
          this.autoDeleteDaysNumeric.Size = new System.Drawing.Size(122, 24);
          this.autoDeleteDaysNumeric.TabIndex = 2;
          this.autoDeleteDaysNumeric.ValueChanged += new System.EventHandler(this.autoDeleteDaysNumeric_ValueChanged);
          // 
          // autoDeleteLogCheckBox
          // 
          this.autoDeleteLogCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
          this.autoDeleteLogCheckBox.AutoSize = true;
          this.autoDeleteLogCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
          this.autoDeleteLogCheckBox.Font = new System.Drawing.Font("Verdana", 9.936297F);
          this.autoDeleteLogCheckBox.Location = new System.Drawing.Point(9, -2);
          this.autoDeleteLogCheckBox.Name = "autoDeleteLogCheckBox";
          this.autoDeleteLogCheckBox.Size = new System.Drawing.Size(164, 21);
          this.autoDeleteLogCheckBox.TabIndex = 0;
          this.autoDeleteLogCheckBox.Text = "Auto delete local file";
          this.autoDeleteLogCheckBox.UseVisualStyleBackColor = true;
          this.autoDeleteLogCheckBox.CheckedChanged += new System.EventHandler(this.autoDeleteLogCheckBox_CheckedChanged);
          // 
          // deleteAllLogsButton
          // 
          this.deleteAllLogsButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                      | System.Windows.Forms.AnchorStyles.Right)));
          this.deleteAllLogsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
          this.deleteAllLogsButton.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.deleteAllLogsButton.Location = new System.Drawing.Point(1031, 11);
          this.deleteAllLogsButton.Name = "deleteAllLogsButton";
          this.deleteAllLogsButton.Size = new System.Drawing.Size(77, 48);
          this.deleteAllLogsButton.TabIndex = 6;
          this.deleteAllLogsButton.Text = "Delete All Logs";
          this.deleteAllLogsButton.UseVisualStyleBackColor = true;
          this.deleteAllLogsButton.Click += new System.EventHandler(this.deleteAllLogsButton_Click);
          // 
          // logFolderBrowserDialog
          // 
          this.logFolderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
          // 
          // DatalogUnitControl
          // 
          this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
          this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
          this.Controls.Add(this.deleteAllLogsButton);
          this.Controls.Add(this.groupBox1);
          this.Controls.Add(this.groupBox3);
          this.Controls.Add(this.tabControlEX1);
          this.Name = "DatalogUnitControl";
          this.Size = new System.Drawing.Size(1111, 836);
          this.tabControlEX1.ResumeLayout(false);
          this.tabPageEX1.ResumeLayout(false);
          this.tabPageEX1.PerformLayout();
          this.tabPageEX2.ResumeLayout(false);
          this.tabPageEX2.PerformLayout();
          this.panel4.ResumeLayout(false);
          this.groupBox4.ResumeLayout(false);
          this.groupBox4.PerformLayout();
          this.groupBox2.ResumeLayout(false);
          this.groupBox2.PerformLayout();
          this.groupBox1.ResumeLayout(false);
          this.groupBox1.PerformLayout();
          this.groupBox3.ResumeLayout(false);
          this.groupBox3.PerformLayout();
          ((System.ComponentModel.ISupportInitialize)(this.autoDeleteDaysNumeric)).EndInit();
          this.ResumeLayout(false);

      }

      #endregion

      private Dotnetrix.Controls.TabControlEX tabControlEX1;
      private Dotnetrix.Controls.TabPageEX tabPageEX1;
      private Dotnetrix.Controls.TabPageEX tabPageEX2;
      private System.Windows.Forms.CheckBox realTimeUpdateCheckBox;
      private System.Windows.Forms.TextBox historyLogTextBox;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.TextBox logFolderTextBox;
      private System.Windows.Forms.GroupBox groupBox3;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.NumericUpDown autoDeleteDaysNumeric;
      private System.Windows.Forms.CheckBox autoDeleteLogCheckBox;
      private System.Windows.Forms.Button deleteAllLogsButton;
      private System.Windows.Forms.ListBox todayLogListBox;
      private System.Windows.Forms.CheckBox showLastLogCheckBox;
      private System.Windows.Forms.FolderBrowserDialog logFolderBrowserDialog;
      private System.Windows.Forms.Panel panel4;
      private System.Windows.Forms.RadioButton showSearchLogButton;
      private System.Windows.Forms.RadioButton showAllDaysLogButton;
      private System.Windows.Forms.DateTimePicker searchStartDatePicker;
      private System.Windows.Forms.DateTimePicker searchEndTimePicker;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.DateTimePicker searchStartTimePicker;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.DateTimePicker searchEndDatePicker;
      private System.Windows.Forms.RadioButton showYesterdayLogButton;
      private System.Windows.Forms.TextBox searchWhatTextBox;
      private System.Windows.Forms.RadioButton showTodayLogButton;
      private System.Windows.Forms.GroupBox groupBox2;
      private System.Windows.Forms.GroupBox groupBox4;
      private System.Windows.Forms.Button findWhatButton;
      private System.Windows.Forms.RadioButton showLastMonthLogButton;
       private System.Windows.Forms.RadioButton showLastWeekLogButton;
       private System.Windows.Forms.Button selectLogFileFolderButton;
   }
}
