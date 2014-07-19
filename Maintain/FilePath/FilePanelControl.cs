using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Collections;
using IniTool;

namespace Maintain
{
   public partial class FilePanelControl : Common.Template.SubInfoPanelTemplate
   {
      static private FilePanelControl singleton;
      private const string strINIPath = "INI\\FilePath.INI";
      private bool bInit = false;
      private FilePath filePath = new FilePath();

      protected FilePanelControl()
      {
         InitializeComponent();

         DefineFilePath("Server", "Data File", true);
         DefineFilePath("Server", "Image File", true);
         DefineFilePath("Server", "SPC File", true);

         DefineFilePath("Local", "Data File", false);
         DefineFilePath("Local", "Image File", false);
         DefineFilePath("Local", "SPC File", false);
         DefineFilePath("Local", "Test#1 File", false);
         DefineFilePath("Local", "Test#2 File", false);
         DefineFilePath("Local", "Test#3 File", false);
         DefineFilePath("Local", "Test#4 File", false);
         DefineFilePath("Local", "Test#5 File", false);
         DefineFilePath("Local", "Test#6 File", false);
         DefineFilePath("Local", "Test#7 File", false);

         LoadParaFromIniFile(strINIPath);
         SetParaToUI();
         bInit = true;
      }

      public static FilePanelControl getSingleton()
      {
         if (singleton == null)
            singleton = new FilePanelControl();
         return singleton;
      }

      private void LoadParaFromIniFile(string iniFilePath)
      {
         IniFile iniFile = new IniFile(iniFilePath);
         // Others
         DataFilePath.EnableAutoDeleteLocalFile = (iniFile.GetInt32("Others", "EnableAutoDeleteLocalFile", 0) == 1) ? true : false;
         DataFilePath.AutoDeleteDays = iniFile.GetInt32("Others", "AutoDeleteDays", 0);
         DataFilePath.CautionHDDCheckLimit = iniFile.GetInt32("Others", "CautionHDDCheckLimit", 0);
         DataFilePath.WarningHDDCheckLimit = iniFile.GetInt32("Others", "WarningHDDCheckLimit", 0);
         DataFilePath.EnableShowCommunicationError = (iniFile.GetInt32("Others", "EnableShowCommunicationError", 0) == 1) ? true : false;
      }

      private void SaveParaToIniFile(string iniFilePath)
      {
         IniFile iniFile = new IniFile(iniFilePath);
         // Others
         iniFile.WriteValue("Others", "EnableAutoDeleteLocalFile", (DataFilePath.EnableAutoDeleteLocalFile == true) ? 1 : 0);
         iniFile.WriteValue("Others", "AutoDeleteDays", DataFilePath.AutoDeleteDays);
         iniFile.WriteValue("Others", "CautionHDDCheckLimit", DataFilePath.CautionHDDCheckLimit);
         iniFile.WriteValue("Others", "WarningHDDCheckLimit", DataFilePath.WarningHDDCheckLimit);
         iniFile.WriteValue("Others", "EnableShowCommunicationError", (DataFilePath.EnableShowCommunicationError == true) ? 1 : 0);
      }

      public override int SetParaToUI()
      {
         filePathTabControlEX.Controls.Clear();
         for (int i = 0; i < DataFilePath.FilePathGroupList.Count; i++)
         {         
            // FilePathUnitControl
            FilePathGroup filePathGroup = new FilePathGroup();
            filePathGroup = (FilePathGroup)DataFilePath.FilePathGroupList[i];
				FilePathUnitControl filePathUnitControl = new FilePathUnitControl(ref filePathGroup, strINIPath);
            
            filePathUnitControl.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            filePathUnitControl.Location = new System.Drawing.Point(-1, -1);
            filePathUnitControl.Margin = new System.Windows.Forms.Padding(4);
            filePathUnitControl.Name = "filePathUnitControl";
            filePathUnitControl.Size = new System.Drawing.Size(1058, 251);
            filePathUnitControl.TabIndex = 0;

            filePathUnitControl.Dock = System.Windows.Forms.DockStyle.Fill;
            
            // TabPage
            Dotnetrix.Controls.TabPageEX tabPageEX;

            tabPageEX = new Dotnetrix.Controls.TabPageEX();
            tabPageEX.SuspendLayout();
            filePathTabControlEX.Controls.Add(tabPageEX);
            // tabPageEX
            tabPageEX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
            tabPageEX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            tabPageEX.Controls.Add(filePathUnitControl);
            tabPageEX.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tabPageEX.Location = new System.Drawing.Point(4, 25);
            tabPageEX.Name = "tabPageEX"+i;
            tabPageEX.Size = new System.Drawing.Size(1058, 251);
            tabPageEX.TabIndex = 0;
            tabPageEX.Text = ((FilePathGroup)DataFilePath.FilePathGroupList[i]).FileGroupName;
            tabPageEX.ResumeLayout(false);      
         }
         // Others
         autoDeleteLocalFileCheckBox.Checked = DataFilePath.EnableAutoDeleteLocalFile;
         autoDeleteDays.Value = DataFilePath.AutoDeleteDays;
         cautionHDDLimit.Value = DataFilePath.CautionHDDCheckLimit;
         warningHDDLimit.Value = DataFilePath.WarningHDDCheckLimit;
         showCommErrorCheckBox.Checked = DataFilePath.EnableShowCommunicationError;

         return 0;
      }

      public override int GetParaFromUI()
      {
         DataFilePath.EnableAutoDeleteLocalFile = autoDeleteLocalFileCheckBox.Checked;
         DataFilePath.AutoDeleteDays = (int)autoDeleteDays.Value;
         DataFilePath.CautionHDDCheckLimit = (int)cautionHDDLimit.Value;
         DataFilePath.WarningHDDCheckLimit = (int)warningHDDLimit.Value;
         DataFilePath.EnableShowCommunicationError = showCommErrorCheckBox.Checked;

         return 0;
      }

      public bool DefineFilePath(string strFilePathGroupName, string strFilePathName, bool enableUploadFunction)
      {
         FilePathGroup filePathGroupTemp = new FilePathGroup();
         bool bGroupExist = false;

         for (int i = 0; i < DataFilePath.FilePathGroupList.Count; i++ )
         {
            if (((FilePathGroup)DataFilePath.FilePathGroupList[i]).FileGroupName.Equals(strFilePathGroupName) == true)
            {
               filePathGroupTemp = ((FilePathGroup)DataFilePath.FilePathGroupList[i]);
               bGroupExist = true;
            }
         }

         if (bGroupExist==false)
         {
            FilePathGroup filePathGroup = new FilePathGroup(strFilePathGroupName);
            DataFilePath.FilePathGroupList.Add(filePathGroup);

            filePathGroupTemp = filePathGroup;
         }

         for (int i = 0; i < filePathGroupTemp.FilePathUnitList.Count; i++)
         {
            // 檢查File名稱是否重複
            if (((FilePathUnit)filePathGroupTemp.FilePathUnitList[i]).FileName.Equals(strFilePathName) == true)
            {
               return false;
            }
         }

         FilePathUnit filePathUnit = new FilePathUnit(strFilePathName, "", enableUploadFunction);
         filePathGroupTemp.FilePathUnitList.Add(filePathUnit);
         return true;
      }

      public bool GetFileInfo(string strFilePathGroupName, string strFileName, ref FilePathUnit filePathUnit)
      {
         for (int i = 0; i < DataFilePath.FilePathGroupList.Count; i++)
         {
            if (((FilePathGroup)DataFilePath.FilePathGroupList[i]).FileGroupName.Equals(strFilePathGroupName) == true)
            {
               for (int j = 0; j < ((FilePathGroup)DataFilePath.FilePathGroupList[i]).FilePathUnitList.Count; j++)
               {
                  if (((FilePathUnit)((FilePathGroup)DataFilePath.FilePathGroupList[i]).FilePathUnitList[j]).FileName.Equals(strFileName) == true)
                  {
                     filePathUnit = (FilePathUnit)((FilePathGroup)DataFilePath.FilePathGroupList[i]).FilePathUnitList[j];
                     return true;
                  }
               }
            }
         }
         return false;
      }

      public FilePath DataFilePath
      {
         get
         {
            return filePath;
         }
         set
         {
            filePath = value;
         }
      }

      private void advancedButton_Click(object sender, EventArgs e)
      {
      }

      private void para_ValueChanged(object sender, EventArgs e)
      {
         if (bInit==true)
         {
            GetParaFromUI();
            SaveParaToIniFile(strINIPath);
         }
      }

      public bool AddFilePathUnit(FilePathUnit filePathUnit)
      {

         return true;
      }
   }

   public class FilePath : Object
   {
      private ArrayList filePathGroupList = new ArrayList();
      private bool enableShowCommunicationError = false;
      private bool enableAutoDeleteLocalFile = false;
      private int autoDeleteDays = 0;
      private int cautionHDDCheckLimit = 0;
      private int warningHDDCheckLimit = 0;

      public FilePath()
      {

      }

      public bool EnableShowCommunicationError
      {
         get
         {
            return enableShowCommunicationError;
         }
         set
         {
            enableShowCommunicationError = value;
         }
      }

      public bool EnableAutoDeleteLocalFile
      {
         get
         {
            return enableAutoDeleteLocalFile;
         }
         set
         {
            enableAutoDeleteLocalFile = value;
         }
      }

      public int AutoDeleteDays
      {
         get
         {
            return autoDeleteDays;
         }
         set
         {
            autoDeleteDays = value;
         }
      }

      public int CautionHDDCheckLimit
      {
         get
         {
            return cautionHDDCheckLimit;
         }
         set
         {
            cautionHDDCheckLimit = value;
         }
      }

      public int WarningHDDCheckLimit
      {
         get
         {
            return warningHDDCheckLimit;
         }
         set
         {
            warningHDDCheckLimit = value;
         }
      }

      public ArrayList FilePathGroupList
      {
         get
         {
            return filePathGroupList;
         }
         set
         {
            filePathGroupList = value;
         }
      }
   }
}
