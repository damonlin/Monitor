using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using IniTool;

namespace Monitor
{
   public partial class IOMonitorUnitControl : UserControl
   {
      private const int _DISPLAY_IO_NUM_PER_PAGE_ = 32;
      private const int _DISPLAY_IO_NUM_PER_COLUMN_ = 8;
      public enum IOType { DI_TYPE = 0, DO_TYPE };

      private System.Windows.Forms.TabPage[] tabPage;
      private System.Windows.Forms.Label[] diLEDLabel;
      private System.Windows.Forms.Label[] diNameLabel;

      private System.Windows.Forms.DataGridView[] ioDataGridView;
      private System.Windows.Forms.DataGridViewTextBoxColumn[,] IdxTest;
      private System.Windows.Forms.DataGridViewButtonColumn[,] StatusTest;
      private System.Windows.Forms.DataGridViewTextBoxColumn[,] DescriptionTest;


      public IOMonitorUnitControl()
      {
         InitializeComponent();
      }

      public int LoadUI(string iniFilePath, IOMonitorUnitControl.IOType ioType)
      {
         SuspendLayout();

         IniFile iniFile = new IniFile(iniFilePath);

         int dioNumber = iniFile.GetInt32("Info", (ioType == IOType.DI_TYPE) ? "DITotal" : "DOTotal", 0);

         tabPage = new System.Windows.Forms.TabPage[(dioNumber % _DISPLAY_IO_NUM_PER_PAGE_) == 0 ? dioNumber / _DISPLAY_IO_NUM_PER_PAGE_ : dioNumber / _DISPLAY_IO_NUM_PER_PAGE_ + 1];
         diLEDLabel = new System.Windows.Forms.Label[dioNumber];
         diNameLabel = new System.Windows.Forms.Label[dioNumber];

         //////////////////////////////////////////////////////////////////////////
         ioDataGridView = new System.Windows.Forms.DataGridView[(dioNumber % _DISPLAY_IO_NUM_PER_PAGE_) == 0 ? dioNumber / _DISPLAY_IO_NUM_PER_PAGE_ : dioNumber / _DISPLAY_IO_NUM_PER_PAGE_ + 1];

         IdxTest = new System.Windows.Forms.DataGridViewTextBoxColumn[(dioNumber % _DISPLAY_IO_NUM_PER_PAGE_) == 0 ? dioNumber / _DISPLAY_IO_NUM_PER_PAGE_ : dioNumber / _DISPLAY_IO_NUM_PER_PAGE_ + 1, 4];
         StatusTest = new System.Windows.Forms.DataGridViewButtonColumn[(dioNumber % _DISPLAY_IO_NUM_PER_PAGE_) == 0 ? dioNumber / _DISPLAY_IO_NUM_PER_PAGE_ : dioNumber / _DISPLAY_IO_NUM_PER_PAGE_ + 1, 4];
         DescriptionTest = new System.Windows.Forms.DataGridViewTextBoxColumn[(dioNumber % _DISPLAY_IO_NUM_PER_PAGE_) == 0 ? dioNumber / _DISPLAY_IO_NUM_PER_PAGE_ : dioNumber / _DISPLAY_IO_NUM_PER_PAGE_ + 1, 4]; 
         //////////////////////////////////////////////////////////////////////////

         tabControlEX.Controls.Clear();

         for (int tabIdx = 0; tabIdx < tabPage.Length; tabIdx++)
         {
            // 
            // 建立TabPage
            // 
            tabPage[tabIdx] = new Dotnetrix.Controls.TabPageEX();
            tabPage[tabIdx].Location = new System.Drawing.Point(4, 21);
            tabPage[tabIdx].Name = "sampleTabPage";
            tabPage[tabIdx].Padding = new System.Windows.Forms.Padding(3);
            tabPage[tabIdx].Size = new System.Drawing.Size(368, 434);
            tabPage[tabIdx].TabIndex = 0;
            tabPage[tabIdx].Text = string.Format("{0}~{1}", tabIdx * _DISPLAY_IO_NUM_PER_PAGE_, (tabIdx + 1) * _DISPLAY_IO_NUM_PER_PAGE_ - 1);
            tabPage[tabIdx].UseVisualStyleBackColor = true;

            tabControlEX.Controls.Add(tabPage[tabIdx]);

            for (int i = 0; i < 4; i++)
            {
               ////////////////////////////////////////////// 
               // Idx
               // 
               IdxTest[tabIdx, i] = new System.Windows.Forms.DataGridViewTextBoxColumn();
               IdxTest[tabIdx, i].HeaderText = "Idx";
               IdxTest[tabIdx, i].Name = "Column1";
               IdxTest[tabIdx, i].ReadOnly = true;
               IdxTest[tabIdx, i].Width = 26;

               //////////////////////////////////////////////
               // 
               // Status
               // 
               System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
               StatusTest[tabIdx, i] = new System.Windows.Forms.DataGridViewButtonColumn();
               dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
               dataGridViewCellStyle2.BackColor = System.Drawing.Color.Lime;
               dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
               StatusTest[tabIdx, i].DefaultCellStyle = dataGridViewCellStyle2;
               StatusTest[tabIdx, i].FlatStyle = System.Windows.Forms.FlatStyle.Popup;
               StatusTest[tabIdx, i].HeaderText = "Status";
               StatusTest[tabIdx, i].Name = "Status";
               StatusTest[tabIdx, i].ReadOnly = true;
               StatusTest[tabIdx, i].Width = 20;

               // 
               // Description
               //
               DescriptionTest[tabIdx, i] = new System.Windows.Forms.DataGridViewTextBoxColumn();

               //DescriptionTest[tabIdx, i].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
               DescriptionTest[tabIdx, i].HeaderText = "Description";
               DescriptionTest[tabIdx, i].Name = "Description";
               DescriptionTest[tabIdx, i].ReadOnly = true;
               DescriptionTest[tabIdx, i].Width = 180;

               /////////////////////////////////////////////////////////////////////////
            }
            
            // 
            // sampleDataGridView
            // 
            ioDataGridView[tabIdx] = new System.Windows.Forms.DataGridView();
            tabPage[tabIdx].Controls.Add(ioDataGridView[tabIdx]);

            ioDataGridView[tabIdx].AllowUserToAddRows = false;
            ioDataGridView[tabIdx].AllowUserToDeleteRows = false;
            ioDataGridView[tabIdx].AllowUserToResizeColumns = false;
            ioDataGridView[tabIdx].AllowUserToResizeRows = false;
            //ioDataGridView[tabIdx].AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            //ioDataGridView[tabIdx].ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ioDataGridView[tabIdx].ColumnHeadersVisible = false;
            ioDataGridView[tabIdx].Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
               IdxTest[tabIdx, 0],
               StatusTest[tabIdx, 0],
               DescriptionTest[tabIdx, 0],
               IdxTest[tabIdx, 1],
               StatusTest[tabIdx, 1],
               DescriptionTest[tabIdx, 1],
               IdxTest[tabIdx, 2],
               StatusTest[tabIdx, 2],
               DescriptionTest[tabIdx, 2],
               IdxTest[tabIdx, 3],
               StatusTest[tabIdx, 3],
               DescriptionTest[tabIdx, 3]});

            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();

            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            ioDataGridView[tabIdx].DefaultCellStyle = dataGridViewCellStyle3;

            //ioDataGridView[tabIdx].Dock = System.Windows.Forms.DockStyle.Fill;
            ioDataGridView[tabIdx].EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;

            ioDataGridView[tabIdx].Location = sampleDataGridView.Location;
            ioDataGridView[tabIdx].MultiSelect = false;
            ioDataGridView[tabIdx].Name = "sampleDataGridView";
            ioDataGridView[tabIdx].ReadOnly = true;
            ioDataGridView[tabIdx].RowHeadersVisible = false;
            ioDataGridView[tabIdx].RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            ioDataGridView[tabIdx].SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.RowHeaderSelect;
            ioDataGridView[tabIdx].ScrollBars = System.Windows.Forms.ScrollBars.None;
            ioDataGridView[tabIdx].Size = sampleDataGridView.Size;
            ioDataGridView[tabIdx].TabIndex = 15;
            
            ioDataGridView[tabIdx].Rows.Add(_DISPLAY_IO_NUM_PER_COLUMN_);

            foreach (DataGridViewRow de in ioDataGridView[tabIdx].Rows)
               de.Height = 19;           

            string ioName;
            int iColumnIdx = 0;
            int iRowIdx = 0;
            
            for (int ioIdx = 0; ioIdx < _DISPLAY_IO_NUM_PER_PAGE_; ioIdx++)
            {
               //ioName = string.Format("{0}. ", ioIdx + _DISPLAY_IO_NUM_PER_PAGE_ * tabIdx) + iniFile.GetString((ioType == IOType.DI_TYPE) ? "DIName" : "DOName", string.Format("{0:D4}", ioIdx + _DISPLAY_IO_NUM_PER_PAGE_ * tabIdx), "");
               ioName = iniFile.GetString((ioType == IOType.DI_TYPE) ? "DIName" : "DOName", string.Format("{0:D4}", ioIdx + _DISPLAY_IO_NUM_PER_PAGE_ * tabIdx), "");

               if (ioIdx != 0 && ioIdx % _DISPLAY_IO_NUM_PER_COLUMN_ == 0)
               {
                  iColumnIdx++;
                  iRowIdx = 0;
               }
               ioDataGridView[tabIdx].Rows[iRowIdx].Cells[0 + 3 * iColumnIdx].Value = string.Format("{0}", ioIdx + _DISPLAY_IO_NUM_PER_PAGE_ * tabIdx);
               ioDataGridView[tabIdx].Rows[iRowIdx].Cells[0 + 3 * iColumnIdx].Style.BackColor = Color.Black;
               ioDataGridView[tabIdx].Rows[iRowIdx].Cells[0 + 3 * iColumnIdx].Style.ForeColor = Color.White;
               ioDataGridView[tabIdx].Rows[iRowIdx].Cells[1 + 3 * iColumnIdx].Style.BackColor = Color.Lime;
               ioDataGridView[tabIdx].Rows[iRowIdx].Cells[2 + 3 * iColumnIdx].Value = ioName;
               ioDataGridView[tabIdx].Rows[iRowIdx].Cells[2 + 3 * iColumnIdx].Style.ForeColor = Color.White;
               ioDataGridView[tabIdx].Rows[iRowIdx].Cells[2 + 3 * iColumnIdx].Style.BackColor = Color.Gray;

               iRowIdx++;
            }
         }
         ResumeLayout();
         return 0;
      }

      private void timer1_Tick(object sender, EventArgs e)
      {
         //ioDataGridView[tabIdx].Rows[iRowIdx].Cells[2 + 3 * iColumnIdx].Style.BackColor = Color.Gray;
      }
   }

   

   public class DIOUnit : IOUnit
   {
      public enum DIOType { X = 0, Y };

      public DIOUnit()
      {
      }
      
      public DIOUnit(DIOType ioType, int address, string strName, string strMemo)
         : base((int)ioType, address, strName, strMemo)
      {
      }
   }
}
