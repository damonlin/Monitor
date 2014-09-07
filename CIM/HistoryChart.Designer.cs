namespace HistoryChart
{
    partial class HistoryChartPanel
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改這個方法的內容。
        ///
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.m_Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numberStartHour = new System.Windows.Forms.NumericUpDown();
            this.numberEndHour = new System.Windows.Forms.NumericUpDown();
            this.numberStartMin = new System.Windows.Forms.NumericUpDown();
            this.numberEndMin = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.chkScientific = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnLast100 = new System.Windows.Forms.Button();
            this.btnLast25 = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnNext100 = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPaint = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_Chart)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberStartHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberEndHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberStartMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberEndMin)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.59102F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.40898F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.m_Chart, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1268, 649);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // m_Chart
            // 
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.LabelAutoFitMaxFontSize = 7;
            chartArea1.AxisX.LabelStyle.Format = "HH:mm:ss";
            chartArea1.AxisX.LabelStyle.Interval = 1D;
            chartArea1.AxisY.Interval = 100D;
            chartArea1.AxisY.LabelStyle.Interval = 100D;
            chartArea1.AxisY.LineColor = System.Drawing.Color.DarkRed;
            chartArea1.AxisY.Maximum = 1200D;
            chartArea1.AxisY.Minimum = 0.001D;
            chartArea1.Name = "Default";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 94F;
            chartArea1.Position.Width = 100F;
            chartArea1.Position.Y = 3F;
            this.m_Chart.ChartAreas.Add(chartArea1);
            this.m_Chart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.m_Chart.Legends.Add(legend1);
            this.m_Chart.Location = new System.Drawing.Point(372, 3);
            this.m_Chart.Name = "m_Chart";
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.m_Chart.Series.Add(series1);
            this.m_Chart.Size = new System.Drawing.Size(872, 643);
            this.m_Chart.TabIndex = 7;
            this.m_Chart.Text = "HVG";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 643);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Condition";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.chkScientific, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel2, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel3, 0, 6);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.27273F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.72727F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 234F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(357, 622);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.03448F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.96552F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel3.Controls.Add(this.dateTimePickerEnd, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.numberStartHour, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.numberEndHour, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.numberStartMin, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.numberEndMin, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.dateTimePickerStart, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(351, 57);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.CalendarFont = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePickerEnd.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerEnd.Location = new System.Drawing.Point(69, 31);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(141, 37);
            this.dateTimePickerEnd.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "End";
            // 
            // numberStartHour
            // 
            this.numberStartHour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numberStartHour.Location = new System.Drawing.Point(216, 3);
            this.numberStartHour.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numberStartHour.Name = "numberStartHour";
            this.numberStartHour.Size = new System.Drawing.Size(67, 37);
            this.numberStartHour.TabIndex = 4;
            this.numberStartHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numberEndHour
            // 
            this.numberEndHour.Location = new System.Drawing.Point(216, 31);
            this.numberEndHour.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numberEndHour.Name = "numberEndHour";
            this.numberEndHour.Size = new System.Drawing.Size(67, 37);
            this.numberEndHour.TabIndex = 5;
            this.numberEndHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numberStartMin
            // 
            this.numberStartMin.Location = new System.Drawing.Point(289, 3);
            this.numberStartMin.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numberStartMin.Name = "numberStartMin";
            this.numberStartMin.Size = new System.Drawing.Size(57, 37);
            this.numberStartMin.TabIndex = 6;
            this.numberStartMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numberEndMin
            // 
            this.numberEndMin.Location = new System.Drawing.Point(289, 31);
            this.numberEndMin.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numberEndMin.Name = "numberEndMin";
            this.numberEndMin.Size = new System.Drawing.Size(57, 37);
            this.numberEndMin.TabIndex = 7;
            this.numberEndMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.CalendarFont = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePickerStart.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerStart.Location = new System.Drawing.Point(69, 3);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(141, 37);
            this.dateTimePickerStart.TabIndex = 8;
            // 
            // chkScientific
            // 
            this.chkScientific.AutoSize = true;
            this.chkScientific.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkScientific.Location = new System.Drawing.Point(3, 66);
            this.chkScientific.Name = "chkScientific";
            this.chkScientific.Size = new System.Drawing.Size(351, 41);
            this.chkScientific.TabIndex = 1;
            this.chkScientific.Text = "Scientific Notation(科學符號)";
            this.chkScientific.UseVisualStyleBackColor = true;
            this.chkScientific.Click += new System.EventHandler(this.chkScientific_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.50562F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.49438F));
            this.tableLayoutPanel4.Controls.Add(this.comboBox1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnFilter, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 113);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(351, 40);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(241, 37);
            this.comboBox1.TabIndex = 0;
            // 
            // btnFilter
            // 
            this.btnFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFilter.Location = new System.Drawing.Point(250, 3);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(98, 34);
            this.btnFilter.TabIndex = 1;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flowLayoutPanel1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 203);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(351, 130);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnFirst);
            this.flowLayoutPanel1.Controls.Add(this.btnLast100);
            this.flowLayoutPanel1.Controls.Add(this.btnLast25);
            this.flowLayoutPanel1.Controls.Add(this.btnNextPage);
            this.flowLayoutPanel1.Controls.Add(this.btnNext100);
            this.flowLayoutPanel1.Controls.Add(this.btnLast);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 33);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(345, 94);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(3, 3);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(77, 36);
            this.btnFirst.TabIndex = 0;
            this.btnFirst.Text = "|<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnLast100
            // 
            this.btnLast100.Location = new System.Drawing.Point(86, 3);
            this.btnLast100.Name = "btnLast100";
            this.btnLast100.Size = new System.Drawing.Size(77, 36);
            this.btnLast100.TabIndex = 1;
            this.btnLast100.Text = "<<";
            this.btnLast100.UseVisualStyleBackColor = true;
            // 
            // btnLast25
            // 
            this.btnLast25.Location = new System.Drawing.Point(169, 3);
            this.btnLast25.Name = "btnLast25";
            this.btnLast25.Size = new System.Drawing.Size(77, 36);
            this.btnLast25.TabIndex = 2;
            this.btnLast25.Text = "<";
            this.btnLast25.UseVisualStyleBackColor = true;
            // 
            // btnNextPage
            // 
            this.btnNextPage.Location = new System.Drawing.Point(252, 3);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(77, 36);
            this.btnNextPage.TabIndex = 3;
            this.btnNextPage.Text = ">";
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // btnNext100
            // 
            this.btnNext100.Location = new System.Drawing.Point(3, 45);
            this.btnNext100.Name = "btnNext100";
            this.btnNext100.Size = new System.Drawing.Size(77, 36);
            this.btnNext100.TabIndex = 4;
            this.btnNext100.Text = ">>";
            this.btnNext100.UseVisualStyleBackColor = true;
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(86, 45);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(77, 36);
            this.btnLast.TabIndex = 5;
            this.btnLast.Text = ">|";
            this.btnLast.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label3);
            this.flowLayoutPanel2.Controls.Add(this.button7);
            this.flowLayoutPanel2.Controls.Add(this.button8);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 339);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(351, 45);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Scaling";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(97, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(48, 36);
            this.button7.TabIndex = 6;
            this.button7.Text = "+";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(151, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(48, 36);
            this.button8.TabIndex = 7;
            this.button8.Text = "-";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.btnPaint);
            this.flowLayoutPanel3.Controls.Add(this.btnSave);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 390);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(351, 229);
            this.flowLayoutPanel3.TabIndex = 5;
            // 
            // btnPaint
            // 
            this.btnPaint.Location = new System.Drawing.Point(3, 3);
            this.btnPaint.Name = "btnPaint";
            this.btnPaint.Size = new System.Drawing.Size(116, 47);
            this.btnPaint.TabIndex = 0;
            this.btnPaint.Text = "Paint";
            this.btnPaint.UseVisualStyleBackColor = true;
            this.btnPaint.Click += new System.EventHandler(this.btnPaint_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(125, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 47);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // HistoryChartPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "HistoryChartPanel";
            this.Size = new System.Drawing.Size(1268, 649);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_Chart)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberStartHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberEndHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberStartMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberEndMin)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numberStartHour;
        private System.Windows.Forms.NumericUpDown numberEndHour;
        private System.Windows.Forms.NumericUpDown numberStartMin;
        private System.Windows.Forms.NumericUpDown numberEndMin;
        private System.Windows.Forms.CheckBox chkScientific;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnLast100;
        private System.Windows.Forms.Button btnLast25;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Button btnNext100;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button btnPaint;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DataVisualization.Charting.Chart m_Chart;


    }
}
