using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using IniTool;

namespace Maintain
{
   public partial class SignalTowerPanelControl : UserControl
   {
      private const string strINIPath = "INI\\SignalTower.ini";
      private static SignalTower[] signalTower;
      private Hashtable hashTable = new Hashtable();

      private bool bInit = false;

      public SignalTowerPanelControl()
      {
         InitializeComponent();

         hashTable.Add(SignalTower.BlinkMode.ON, "On");
         hashTable.Add(SignalTower.BlinkMode.OFF, "Off");
         hashTable.Add(SignalTower.BlinkMode.PER0500ms, "Flash(500ms)");
         hashTable.Add(SignalTower.BlinkMode.PER1000ms, "Flash(1000ms)");
         hashTable.Add(SignalTower.BlinkMode.PER1500ms, "Flash(1500ms)");
         hashTable.Add(SignalTower.BlinkMode.PER2000ms, "Flash(2000ms)");
         hashTable.Add(SignalTower.BlinkMode.PER2500ms, "Flash(2500ms)");
         hashTable.Add(SignalTower.BlinkMode.PER3000ms, "Flash(3000ms)");
         hashTable.Add(SignalTower.BlinkMode.PER3500ms, "Flash(3500ms)");
         hashTable.Add(SignalTower.BlinkMode.PER4000ms, "Flash(4000ms)");
         hashTable.Add(SignalTower.BlinkMode.PER4500ms, "Flash(4500ms)");
         hashTable.Add(SignalTower.BlinkMode.PER5000ms, "Flash(5000ms)");

         hashTable.Add(SignalTower.BlinkMode.NoSound, "No sound");
         hashTable.Add(SignalTower.BlinkMode.LongBeep, "Long beep");
         hashTable.Add(SignalTower.BlinkMode.ShortIntervalBeep, "Short interval beep");

         LoadIniFile(strINIPath);

         bInit = true;
      }

      private void LoadIniFile(string iniFilePath)
      {
         IniFile iniFile = new IniFile(iniFilePath);

         string[] sectionName = iniFile.GetSectionNames();
         if (sectionName.Length!=0)
         {
            signalTower = new SignalTower[sectionName.Length];
            for (int i = 0; i<sectionName.Length; i++)
            {
               signalTower[i] = new SignalTower();

               signalTower[i].Status = sectionName[i];
               signalTower[i].Description = iniFile.GetString(sectionName[i], "Description", "");
               
               signalTower[i].RedLightType = (SignalTower.BlinkMode)iniFile.GetInt32(sectionName[i], "Red", (int)SignalTower.BlinkMode.OFF);
               signalTower[i].YellowLightType = (SignalTower.BlinkMode)iniFile.GetInt32(sectionName[i], "Yellow", (int)SignalTower.BlinkMode.OFF);
               signalTower[i].GreenLightType = (SignalTower.BlinkMode)iniFile.GetInt32(sectionName[i], "Green", (int)SignalTower.BlinkMode.OFF);
               signalTower[i].BlueLightType = (SignalTower.BlinkMode)iniFile.GetInt32(sectionName[i], "Blue", (int)SignalTower.BlinkMode.OFF); 
               signalTower[i].BuzzerType = (SignalTower.BlinkMode)iniFile.GetInt32(sectionName[i], "Buzzer", (int)SignalTower.BlinkMode.OFF);
            }

            dataGridView.Rows.Add(sectionName.Length);
            for (int i = 0; i < sectionName.Length; i++)
            {
               dataGridView.Rows[i].SetValues(i + 1, sectionName[i], signalTower[i].Description,
                  hashTable[signalTower[i].RedLightType], hashTable[signalTower[i].YellowLightType], hashTable[signalTower[i].GreenLightType], hashTable[signalTower[i].BlueLightType], hashTable[signalTower[i].BuzzerType]);
            }
         }
      }

      private void SaveToIniFile(string iniFilePath)
      {
         IniFile iniFile = new IniFile(iniFilePath);

         //iniFile.WriteValue();

         if (dataGridView.Rows.Count != 0)
         {
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
               signalTower[i].Status = (string)dataGridView.Rows[i].Cells[1].Value;
               signalTower[i].Description = (string)dataGridView.Rows[i].Cells[2].Value;

               foreach (object key in hashTable.Keys)
               {
                  if (dataGridView.Rows[i].Cells[3].Value.Equals(hashTable[key]))
                  {
                     signalTower[i].RedLightType = (SignalTower.BlinkMode)key;
                     break;
                  }
               }
               foreach (object key in hashTable.Keys)
               {
                  if (dataGridView.Rows[i].Cells[4].Value.Equals(hashTable[key]))
                  {
                     signalTower[i].YellowLightType = (SignalTower.BlinkMode)key;
                     break;
                  }
               }
               foreach (object key in hashTable.Keys)
               {
                  if (dataGridView.Rows[i].Cells[5].Value.Equals(hashTable[key]))
                  {
                     signalTower[i].GreenLightType = (SignalTower.BlinkMode)key;
                     break;
                  }
               }
               foreach (object key in hashTable.Keys)
               {
                  if (dataGridView.Rows[i].Cells[6].Value.Equals(hashTable[key]))
                  {
                     signalTower[i].BlueLightType = (SignalTower.BlinkMode)key;
                     break;
                  }
               }
               foreach (object key in hashTable.Keys)
               {
                  if (dataGridView.Rows[i].Cells[7].Value.Equals(hashTable[key]))
                  {
                     signalTower[i].BuzzerType = (SignalTower.BlinkMode)key;
                     break;
                  } 
               }
            }
            
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
               if (signalTower[i].Description==null)
               {
                  signalTower[i].Description = " ";
               }
               iniFile.WriteValue(signalTower[i].Status, "Description", signalTower[i].Description);
               iniFile.WriteValue(signalTower[i].Status, "Red", (int)signalTower[i].RedLightType);
               iniFile.WriteValue(signalTower[i].Status, "Yellow", (int)signalTower[i].YellowLightType);
               iniFile.WriteValue(signalTower[i].Status, "Blue", (int)signalTower[i].BlueLightType);
               iniFile.WriteValue(signalTower[i].Status, "Green", (int)signalTower[i].GreenLightType);
               iniFile.WriteValue(signalTower[i].Status, "Buzzer", (int)signalTower[i].BuzzerType);
            }
         }
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

      private void SignalTowerPanelControl_Load(object sender, EventArgs e)
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

      private void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
      {
         if (bInit == true)
         {
            SaveToIniFile(strINIPath);

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
      }

      private void dataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
      {

      }

      private void dataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
      {
         if (e.ColumnIndex==8)
         {
            if (SignalTowerPreviewForm.GetSingleton().Visible == false)
               SignalTowerPreviewForm.GetSingleton().Show(this);
            else
               SignalTowerPreviewForm.GetSingleton().Activate(); 
            SignalTowerPreviewForm.GetSingleton().SetSignal(signalTower[e.RowIndex]);
         }
      }

		public static SignalTower GetSignalFromTable(string Status)
		{
			int i = 0;
			for (i = 0; i < signalTower.Length; i++)
			{
				if (signalTower[i].Status.Equals(Status))
				{
					return signalTower[i];
				}
			}
			return null;
		}
	}
}
