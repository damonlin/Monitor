namespace Recipe
{
    partial class CCPIDTableControl
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.m_listTable = new GlacialComponents.Controls.GlacialList();
            this.m_btnCopy = new System.Windows.Forms.Button();
            this.m_btnAdd = new System.Windows.Forms.Button();
            this.m_btnDelete = new System.Windows.Forms.Button();
            this.m_btnSave = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.49638F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.50362F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.m_listTable, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(887, 596);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.m_btnCopy, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.m_btnAdd, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.m_btnDelete, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.m_btnSave, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(787, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(97, 590);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // m_listTable
            // 
            this.m_listTable.AllowColumnResize = true;
            this.m_listTable.AllowMultiselect = false;
            this.m_listTable.AlternateBackground = System.Drawing.Color.Wheat;
            this.m_listTable.AlternatingColors = true;
            this.m_listTable.AutoHeight = true;
            this.m_listTable.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.m_listTable.BackgroundStretchToFit = true;
            this.m_listTable.ControlStyle = GlacialComponents.Controls.GLControlStyles.XP;
            this.m_listTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_listTable.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_listTable.FullRowSelect = true;
            this.m_listTable.GridColor = System.Drawing.Color.LightGray;
            this.m_listTable.GridLines = GlacialComponents.Controls.GLGridLines.gridBoth;
            this.m_listTable.GridLineStyle = GlacialComponents.Controls.GLGridLineStyles.gridSolid;
            this.m_listTable.GridTypes = GlacialComponents.Controls.GLGridTypes.gridOnExists;
            this.m_listTable.HeaderHeight = 30;
            this.m_listTable.HeaderVisible = true;
            this.m_listTable.HeaderWordWrap = false;
            this.m_listTable.HotColumnTracking = true;
            this.m_listTable.HotItemTracking = true;
            this.m_listTable.HotTrackingColor = System.Drawing.Color.LightGray;
            this.m_listTable.HoverEvents = false;
            this.m_listTable.HoverTime = 1;
            this.m_listTable.ImageList = null;
            this.m_listTable.ItemHeight = 25;
            this.m_listTable.ItemWordWrap = false;
            this.m_listTable.Location = new System.Drawing.Point(3, 3);
            this.m_listTable.Name = "m_listTable";
            this.m_listTable.Selectable = true;
            this.m_listTable.SelectedTextColor = System.Drawing.Color.White;
            this.m_listTable.SelectionColor = System.Drawing.Color.CornflowerBlue;
            this.m_listTable.ShowBorder = true;
            this.m_listTable.ShowFocusRect = false;
            this.m_listTable.Size = new System.Drawing.Size(778, 590);
            this.m_listTable.SortType = GlacialComponents.Controls.SortTypes.InsertionSort;
            this.m_listTable.SuperFlatHeaderColor = System.Drawing.Color.White;
            this.m_listTable.TabIndex = 2;
            this.m_listTable.DoubleClick += new System.EventHandler(this.m_listTable_DoubleClick);
            // 
            // m_btnCopy
            // 
            this.m_btnCopy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_btnCopy.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_btnCopy.Image = global::Recipe.Properties.Resources.copy_icon;
            this.m_btnCopy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_btnCopy.Location = new System.Drawing.Point(3, 213);
            this.m_btnCopy.Name = "m_btnCopy";
            this.m_btnCopy.Size = new System.Drawing.Size(91, 64);
            this.m_btnCopy.TabIndex = 6;
            this.m_btnCopy.Text = "Copy";
            this.m_btnCopy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.m_btnCopy.UseVisualStyleBackColor = true;
            this.m_btnCopy.Click += new System.EventHandler(this.m_btnCopy_Click);
            // 
            // m_btnAdd
            // 
            this.m_btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_btnAdd.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_btnAdd.Image = global::Recipe.Properties.Resources.netvibes;
            this.m_btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_btnAdd.Location = new System.Drawing.Point(3, 73);
            this.m_btnAdd.Name = "m_btnAdd";
            this.m_btnAdd.Size = new System.Drawing.Size(91, 64);
            this.m_btnAdd.TabIndex = 4;
            this.m_btnAdd.Text = "Add";
            this.m_btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.m_btnAdd.UseVisualStyleBackColor = true;
            this.m_btnAdd.Click += new System.EventHandler(this.m_btnAdd_Click);
            // 
            // m_btnDelete
            // 
            this.m_btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_btnDelete.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_btnDelete.Image = global::Recipe.Properties.Resources.x_32x32;
            this.m_btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_btnDelete.Location = new System.Drawing.Point(3, 143);
            this.m_btnDelete.Name = "m_btnDelete";
            this.m_btnDelete.Size = new System.Drawing.Size(91, 64);
            this.m_btnDelete.TabIndex = 5;
            this.m_btnDelete.Text = "Delete";
            this.m_btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.m_btnDelete.UseVisualStyleBackColor = true;
            this.m_btnDelete.Click += new System.EventHandler(this.m_btnDelete_Click);
            // 
            // m_btnSave
            // 
            this.m_btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_btnSave.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.m_btnSave.Image = global::Recipe.Properties.Resources.save_32x32;
            this.m_btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_btnSave.Location = new System.Drawing.Point(3, 3);
            this.m_btnSave.Name = "m_btnSave";
            this.m_btnSave.Size = new System.Drawing.Size(91, 64);
            this.m_btnSave.TabIndex = 2;
            this.m_btnSave.Text = "Save";
            this.m_btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.m_btnSave.UseVisualStyleBackColor = true;
            this.m_btnSave.Click += new System.EventHandler(this.m_btnSave_Click);
            // 
            // CCPIDTableControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CCPIDTableControl";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button m_btnSave;
        private System.Windows.Forms.Button m_btnAdd;
        private System.Windows.Forms.Button m_btnDelete;
        private GlacialComponents.Controls.GlacialList m_listTable;
        private System.Windows.Forms.Button m_btnCopy;



    }
}
