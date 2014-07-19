using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;


namespace Monitor
{
   public partial class PLCMonitorForm : Form
   {
      private PLCIOGroup plcIOGroup = new PLCIOGroup();
      private int iMainGroupIndex = 0;
      private int iSubGroupIndex = 0;
      private System.Windows.Forms.DataGridView refreshGridView = null;
      private PLCIOGroup refreshGroup = null;
      private bool bEnableDisplayDetails = false;

      public PLCMonitorForm()
      {
         InitializeComponent();
         if (LoadParaFromINI("D:\\Book1.csv")==0)
         {
            InitUI();
            level1TabControlEX_SelectedIndexChanged(null, null);
         }
      }

      private bool InitUI()
      {
         this.level1TabControlEX.Controls.Clear();

         Dotnetrix.Controls.TabPageEX[] tabPageEX = new Dotnetrix.Controls.TabPageEX[plcIOGroup.GroupList.Count];

         for (int i=0; i<plcIOGroup.GroupList.Count; i++)
         {
            tabPageEX[i] = new Dotnetrix.Controls.TabPageEX();

            tabPageEX[i].SuspendLayout();
            tabPageEX[i].Location = new System.Drawing.Point(4, 44);
            tabPageEX[i].Name = "tabPageEX1";
            tabPageEX[i].Size = new System.Drawing.Size(882, 439);
            tabPageEX[i].TabIndex = 0;
            tabPageEX[i].Text = ((PLCIOGroup)plcIOGroup.GroupList[i]).GroupName;
            tabPageEX[i].ResumeLayout(false);

            if (((PLCIOGroup)plcIOGroup.GroupList[i]).GroupList.Count>0)
            {
               /////////////////////////////////////
               Dotnetrix.Controls.TabControlEX subTabControl = new Dotnetrix.Controls.TabControlEX();

               subTabControl = new Dotnetrix.Controls.TabControlEX();
               subTabControl.SuspendLayout();
               subTabControl.Appearance = Dotnetrix.Controls.TabAppearanceEX.FlatButton;
               subTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
               subTabControl.Location = new System.Drawing.Point(0, 0);
               subTabControl.Name = "tabControlEX2";
               subTabControl.SelectedIndex = 0;
               subTabControl.SelectedTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(203)))), ((int)(((byte)(186)))));
               subTabControl.SelectedTabFontStyle = System.Drawing.FontStyle.Bold;
               subTabControl.Size = new System.Drawing.Size(882, 439);
               subTabControl.TabIndex = 2;
               subTabControl.UseVisualStyles = false;
               subTabControl.SelectedIndexChanged += new System.EventHandler(this.level1TabControlEX_SelectedIndexChanged);
               subTabControl.ResumeLayout(false);
               /////////////////////////////////////
               Dotnetrix.Controls.TabPageEX[] subTabPageEX = new Dotnetrix.Controls.TabPageEX[((PLCIOGroup)plcIOGroup.GroupList[i]).GroupList.Count];
               for (int j = 0; j < ((PLCIOGroup)plcIOGroup.GroupList[i]).GroupList.Count; j++)
               {
                  /////////////////////////////////////
                  subTabPageEX[j] = new Dotnetrix.Controls.TabPageEX();

                  subTabPageEX[j].SuspendLayout();
                  subTabPageEX[j].Location = new System.Drawing.Point(4, 44);
                  subTabPageEX[j].Name = "tabPageEX1";
                  subTabPageEX[j].Size = new System.Drawing.Size(882, 439);
                  subTabPageEX[j].TabIndex = 0;
                  subTabPageEX[j].Text = ((PLCIOGroup)((PLCIOGroup)plcIOGroup.GroupList[i]).GroupList[j]).GroupName;
                  subTabPageEX[j].ResumeLayout(false);
                  /////////////////////////////////////
                  System.Windows.Forms.DataGridView dataGridView = new DataGridView();

                  dataGridView.AllowUserToAddRows = false;
                  dataGridView.AllowUserToDeleteRows = false;
                  //dataGridView.AllowUserToResizeColumns = false;
                  //dataGridView.AllowUserToResizeRows = false;
                  dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
                  dataGridView.ColumnHeadersDefaultCellStyle = dataGridView1.ColumnHeadersDefaultCellStyle;
                  dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                  dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                     (DataGridViewColumn)this.dataGridViewTextBoxColumn1.Clone(),
                     (DataGridViewColumn)this.dataGridViewTextBoxColumn2.Clone(),
                     (DataGridViewColumn)this.dataGridViewTextBoxColumn3.Clone(),
                     (DataGridViewColumn)this.dataGridViewTextBoxColumn4.Clone(),
                     (DataGridViewColumn)this.dataGridViewTextBoxColumn5.Clone()});
                  dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
                  dataGridView.Location = new System.Drawing.Point(0, 0);
                  dataGridView.MultiSelect = false;
                  dataGridView.Name = "dataGridView1";
                  dataGridView.ReadOnly = true;
                  dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
                  dataGridView.RowHeadersVisible = false;
                  dataGridView.RowTemplate.Height = 16;
                  dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
                  dataGridView.Size = new System.Drawing.Size(874, 410);
                  dataGridView.TabIndex = 3;
                  dataGridView.RowHeightChanged += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView_RowHeightChanged);
                  /////////////////////////////////////
                  dataGridView.Rows.Add(((PLCIOGroup)((PLCIOGroup)plcIOGroup.GroupList[i]).GroupList[j]).GroupList.Count);
                  for (int k = 0; k < ((PLCIOGroup)((PLCIOGroup)plcIOGroup.GroupList[i]).GroupList[j]).GroupList.Count; k++)
                  {
                     PLCIOUnit unit = (PLCIOUnit)((PLCIOGroup)((PLCIOGroup)plcIOGroup.GroupList[i]).GroupList[j]).GroupList[k];
                     string address = ((unit.IOType == (int)PLCIOUnit.PLCIOType.WORD) ? "W" : "B") + unit.Address.ToString("X4");
                     dataGridView.Rows[k].SetValues(address, unit.Name, unit.ValueMemo, "", unit.Memo);
                  }

                  resizeRowHeight(dataGridView);

                  subTabPageEX[j].Controls.Add(dataGridView);
                  subTabControl.Controls.Add(subTabPageEX[j]);
               }
               tabPageEX[i].Controls.Add(subTabControl);
            }

            this.level1TabControlEX.Controls.Add(tabPageEX[i]);
         }
         return true;
      }

      private int LoadParaFromINI(string strIniPath)
      {
         ArrayList list = new ArrayList();
         list.AddRange(System.IO.File.ReadAllLines(strIniPath));

         char[] seperator = new char[] { ',' };

         PLCIOGroup mainGroup = null;
         PLCIOGroup subGroup = null;

         for (int i = 0; i < list.Count; i++ )
         {
            string line = (string)list[i];
            ArrayList splitList = new ArrayList();
            splitList.AddRange(line.Split(seperator, 8));
            if (splitList.Count>=5)
            {
               if (((string)splitList[0]).Length!=0)
               {
                  mainGroup = new PLCIOGroup();
                  mainGroup.GroupName = (string)splitList[0];

                  plcIOGroup.GroupList.Add(mainGroup);
               }
               else if (((string)splitList[1]).Length != 0)
               {
                  subGroup = new PLCIOGroup();
                  subGroup.GroupName = (string)splitList[1];
                  subGroup.GroupName = (string)splitList[1];

                  mainGroup.GroupList.Add(subGroup);
               } 
               else
               {
                  string address = (string)splitList[3];

                  if (address.Length!=5 || (address[0] != 'B' && address[0] != 'W'))
                  {
                     MessageBox.Show("[Line " + (i+1) + "] " + address + "\nHint: must be W#### or B####", "Invalid PLC address format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     return -1;
                  }

                  if (((string)splitList[5]) != "B" && ((string)splitList[5]) != "C" && ((string)splitList[5]) != "D")
                  {
                     MessageBox.Show("[Line " + (i+1) + "] " + address + "'s display type [" + splitList[5] + "] is invalid!\nHint: must be B, C or D", "Invalid PLC address format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     return -2;
                  }

                  int iAddress = 0;
                  try
                  {
                     iAddress = Convert.ToInt32(address.Substring(1, 4), 16);
                  }
                  catch (System.FormatException formatException)
                  {
                     MessageBox.Show("[Line " + (i + 1) + "] " + address + "\nHint: must be W#### or B####\n\n" + formatException.ToString(), "Invalid PLC address format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     return -3;
                  }
                  // IO Type
                  PLCIOUnit.PLCIOType ioType = PLCIOUnit.PLCIOType.WORD;

                  switch (address[0])
                  {
                  case 'W':
                     ioType = PLCIOUnit.PLCIOType.WORD;
                  	break;
                  case 'B':
                     ioType = PLCIOUnit.PLCIOType.BIT;
                     break;
                  }

                  PLCIOUnit.DisplayType displayType = PLCIOUnit.DisplayType.BIT;
                  // Display Type
                  switch ((string)splitList[5])
                  {
                     case "B":
                        displayType = PLCIOUnit.DisplayType.BIT;
                        break;
                     case "C":
                        displayType = PLCIOUnit.DisplayType.CHAR;
                        break;
                     case "D":
                        displayType = PLCIOUnit.DisplayType.DEC;
                        break;
                  }

                  subGroup.GroupList.Add(new PLCIOUnit(ioType, iAddress, (string)splitList[4], displayType, (splitList.Count>=7) ? (string)splitList[6] : "", (splitList.Count>=8) ? (string)splitList[7] : ""));
               }
            }
         }
         return 0;
      }

      private int SaveParaToINI(string strIniPath)
      {
         return 0;
      }

      private int GetParaFromUI()
      {
         return 0;
      }

      private int SetParaToUI()
      {
         return 0;
      }

      private void exitButton_Click(object sender, EventArgs e)
      {
         this.Hide();
      }

      private void dataGridView_RowHeightChanged(object sender, DataGridViewRowEventArgs e)
      {
         Int32 preferredNormalContentHeight =
         e.Row.GetPreferredHeight(e.Row.Index,
         DataGridViewAutoSizeRowMode.AllCellsExceptHeader, true) -
         e.Row.DefaultCellStyle.Padding.Bottom;

         // Specify a new padding.
         Padding newPadding = e.Row.DefaultCellStyle.Padding;
         newPadding.Bottom = e.Row.Height - preferredNormalContentHeight;
         e.Row.DefaultCellStyle.Padding = newPadding;
      }

      private void resizeRowHeight(DataGridView dataGridView)
      {
         // 自動更新每一個Row的高度
         for (int i = 0; i < dataGridView.Rows.Count; i++)
         {
            Int32 preferredNormalContentHeight =
                dataGridView.Rows[i].GetPreferredHeight(dataGridView.Rows[i].Index,
                DataGridViewAutoSizeRowMode.AllCellsExceptHeader, true) -
                dataGridView.Rows[i].DefaultCellStyle.Padding.Bottom;

            dataGridView.Rows[i].Height = preferredNormalContentHeight;
         }
      }

      private void refreshTimer_Tick(object sender, EventArgs e)
      {
         //int iMainGroupTmpIndex = 0;
         //int iSubGroupTmpIndex = 0;
         System.Windows.Forms.DataGridView refreshGridViewTmp = refreshGridView;
         PLCIOGroup refreshGroupTmp = refreshGroup;
         
         if (plcIOGroup.GroupList.Count==0)
            return;

         if (refreshGridViewTmp != null)
         {
            string strValue = "";
            UInt16 iValue = 0;
            
            for (int i = 0; i < refreshGroupTmp.GroupList.Count; i++)
            {
               // Row Value
               refreshGridViewTmp.Rows[i].Cells[3].Value = ((PLCIOUnit)refreshGroupTmp.GroupList[i]).IOValue.ToString("X4") + "H";
               // Friendly Value Format
               iValue = ((PLCIOUnit)refreshGroupTmp.GroupList[i]).IOValue;
               iValue = 3;
               switch (((PLCIOUnit)refreshGroupTmp.GroupList[i]).DisplayFormat)
               {
                  case PLCIOUnit.DisplayType.BIT:
                     strValue = "" +
                          ((iValue & 0x8000) >> 15) + ((iValue & 0x4000) >> 14) + ((iValue & 0x2000) >> 13) + ((iValue & 0x1000) >> 12) + " " +
                          ((iValue & 0x0800) >> 11) + ((iValue & 0x0400) >> 10) + ((iValue & 0x0200) >> 9) + ((iValue & 0x0100) >> 8) + " " +
                          ((iValue & 0x0080) >> 7) + ((iValue & 0x0040) >> 6) + ((iValue & 0x0020) >> 5) + ((iValue & 0x0010) >> 4) + " " +
                          ((iValue & 0x0008) >> 3) + ((iValue & 0x0004) >> 2) + ((iValue & 0x0002) >> 1) + (iValue & 0x0001);
               	   break;
                  case PLCIOUnit.DisplayType.CHAR:
                     strValue = Convert.ToChar((iValue & 0xFF00) >> 8) + "        " + Convert.ToChar((iValue & 0x00FF));
                     break;
                  case PLCIOUnit.DisplayType.DEC:
                     strValue = iValue.ToString();
                     break;
               }
               
               if (bEnableDisplayDetails==true)
               {
                  refreshGridViewTmp.Rows[i].Cells[2].Value = ((PLCIOUnit)refreshGroupTmp.GroupList[i]).ValueMemo + "\n" + strValue;
               }
               else
               {
                  refreshGridViewTmp.Rows[i].Cells[2].Value = strValue;
               }
            }
            
         }
      }

      private void PLCMonitorForm_VisibleChanged(object sender, EventArgs e)
      {
         refreshTimer.Enabled = this.Visible;
      }

      private void level1TabControlEX_SelectedIndexChanged(object sender, EventArgs e)
      {
         if (level1TabControlEX.SelectedIndex >= 0)
         {
            iMainGroupIndex = level1TabControlEX.SelectedIndex;

            //plcIOGroup.GroupList
            if (((Dotnetrix.Controls.TabPageEX)level1TabControlEX.Controls[level1TabControlEX.SelectedIndex]).Controls.Count > 0)
            {
               Dotnetrix.Controls.TabControlEX subTabControl = (Dotnetrix.Controls.TabControlEX)((Dotnetrix.Controls.TabPageEX)level1TabControlEX.Controls[level1TabControlEX.SelectedIndex]).Controls[0];
               iSubGroupIndex = subTabControl.SelectedIndex;

               Dotnetrix.Controls.TabPageEX tabPage = (Dotnetrix.Controls.TabPageEX)subTabControl.Controls[iSubGroupIndex];
               refreshGridView = (System.Windows.Forms.DataGridView)tabPage.Controls[0];

               refreshGroup = (PLCIOGroup)(((PLCIOGroup)plcIOGroup.GroupList[iMainGroupIndex]).GroupList[iSubGroupIndex]);

               refreshTimer_Tick(null, null);
               resizeRowHeight(refreshGridView);
            }
            else
            {
               refreshGridView = null;
               refreshGroup = null;
            }
         }
         else
         {
            refreshGridView = null;
            refreshGroup = null;
         }
      }

      private void enableDetailsCheckBox_CheckedChanged(object sender, EventArgs e)
      {
         bEnableDisplayDetails = !bEnableDisplayDetails;
         level1TabControlEX_SelectedIndexChanged(null, null);
      }

      private void findWhatButton_Click(object sender, EventArgs e)
      {
         //findWhatTextBox.Text
         for (int i = 0; i < plcIOGroup.GroupList.Count; i++)
         {
            for (int j = 0; j < ((PLCIOGroup)plcIOGroup.GroupList[i]).GroupList.Count; j++)
            {
               //((PLCIOUnit)((PLCIOGroup)plcIOGroup.GroupList[i]).GroupList[j]).Address;
            }
         }
      }
   }

   public class PLCIOGroup
   {
      private string strGroupName = "";
      private ArrayList groupList = new ArrayList();

      public PLCIOGroup()
      {
      }

      public PLCIOGroup(string strGroupName, ArrayList groupList)
      {
         GroupName = strGroupName;
         GroupList.AddRange(GroupList);
      }

      public string GroupName
      {
         get
         {
            return strGroupName;
         }
         set
         {
            strGroupName = value;
         }
      }

      public ArrayList GroupList
      {
         get
         {
            return groupList;
         }
         set
         {
            groupList = value;
         }
      }

   }

   public class PLCIOUnit : IOUnit
   {
      public enum PLCIOType { WORD = 10, BIT };
      public enum DisplayType { BIT = 0, CHAR, DEC };
      private PLCIOType ioType = PLCIOType.WORD;
      private DisplayType displayType = DisplayType.BIT;
      private string strValueMemo = "";
      private string strAddress = "";

      public PLCIOUnit()
      {
      }

      public PLCIOUnit(PLCIOType ioType, int address, string strName, DisplayType displayType, string strValueMemo, string strMemo) :
         base((int)ioType, address, strName, strMemo)
      {
         IOType = (int)ioType;
         DisplayFormat = displayType;
         ValueMemo = strValueMemo;
         Memo = strMemo;
      }

      public string AddressString
      {
         get
         {
            return strAddress;
         }
         set
         {
            strAddress = value;
         }
      }
 
      public DisplayType DisplayFormat
      {
         get
         {
            return displayType;
         }
         set
         {
            displayType = value;
         }
      }

      public string ValueMemo
      {
         get
         {
            return strValueMemo;
         }
         set
         {
            strValueMemo = value;
         }
      }
   }
}