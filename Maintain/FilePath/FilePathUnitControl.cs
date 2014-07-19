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
   public partial class FilePathUnitControl : UserControl
   {
      private FilePathGroup filePathGroup = new FilePathGroup();

      private ArrayList pathLabelList = new ArrayList();
      private ArrayList filePathTextBoxList = new ArrayList();
      private ArrayList selectFolderButtonList = new ArrayList();
      private ArrayList enableUploadCheckBoxList = new ArrayList();

      private string iniFilePath = "";
      private bool bInit = false;

      public FilePathUnitControl()
      {
         InitializeComponent();

      }

      public FilePathUnitControl(ref FilePathGroup filePathGroup, string iniFilePath)
      {
         InitializeComponent();
         InitUIInfo();

         this.filePathGroup = filePathGroup;
         this.iniFilePath = iniFilePath;

         LoadParaFromIniFile();
         SetParaToUI();

         bInit = true;
      }

      private void InitUIInfo()
      {
         TextBox[] pathLabel = { pathName01, pathName02, pathName03, pathName04, pathName05, 
            pathName06, pathName07, pathName08, pathName09, pathName10};
         TextBox[] filePathTextBox = { filePathTextBox01, filePathTextBox02, filePathTextBox03, filePathTextBox04, filePathTextBox05, 
            filePathTextBox06, filePathTextBox07, filePathTextBox08, filePathTextBox09, filePathTextBox10};
         Button[] selectFolderButton = { selectFolderButton01, selectFolderButton02, selectFolderButton03, selectFolderButton04, selectFolderButton05, 
            selectFolderButton06, selectFolderButton07, selectFolderButton08, selectFolderButton09, selectFolderButton10};
         CheckBox[] enableUploadCheckBox = { enableUploadCheckBox01, enableUploadCheckBox02, enableUploadCheckBox03, enableUploadCheckBox04, enableUploadCheckBox05, 
            enableUploadCheckBox06, enableUploadCheckBox07, enableUploadCheckBox08, enableUploadCheckBox09, enableUploadCheckBox10};

         pathLabelList.AddRange(pathLabel);
         filePathTextBoxList.AddRange(filePathTextBox);
         selectFolderButtonList.AddRange(selectFolderButton);
         enableUploadCheckBoxList.AddRange(enableUploadCheckBox);
      }

      private void LoadParaFromIniFile()
      {
         IniFile iniFile = new IniFile(iniFilePath);
         for (int i = 0; i < filePathGroup.FilePathUnitList.Count; i++)
         {
            ((FilePathUnit)filePathGroup.FilePathUnitList[i]).Directory = iniFile.GetString(filePathGroup.FileGroupName + "_" + ((FilePathUnit)filePathGroup.FilePathUnitList[i]).FileName, "Directory", "");
            ((FilePathUnit)filePathGroup.FilePathUnitList[i]).EnableUpload = (iniFile.GetInt32(filePathGroup.FileGroupName+"_"+ ((FilePathUnit)filePathGroup.FilePathUnitList[i]).FileName, "EnableUpload", 0) == 1) ? true : false;
         }
      }

      private void SaveParaToIniFile()
      {
         IniFile iniFile = new IniFile(iniFilePath);

         for (int i = 0; i < filePathGroup.FilePathUnitList.Count; i++)
         {
            iniFile.WriteValue(filePathGroup.FileGroupName + "_" + ((FilePathUnit)filePathGroup.FilePathUnitList[i]).FileName, "Directory", ((FilePathUnit)filePathGroup.FilePathUnitList[i]).Directory);
            iniFile.WriteValue(filePathGroup.FileGroupName + "_" + ((FilePathUnit)filePathGroup.FilePathUnitList[i]).FileName, "EnableUpload", (((FilePathUnit)filePathGroup.FilePathUnitList[i]).EnableUpload == true) ? 1 : 0);
         }
      }

      private void SetParaToUI()
      {
         for (int i = 0; i < 10; i++)
         {
            if (i<filePathGroup.FilePathUnitList.Count)
            {
               ((TextBox)pathLabelList[i]).Text = ((FilePathUnit)filePathGroup.FilePathUnitList[i]).FileName;
               ((TextBox)filePathTextBoxList[i]).Text = ((FilePathUnit)filePathGroup.FilePathUnitList[i]).Directory;
               ((CheckBox)enableUploadCheckBoxList[i]).Checked = ((FilePathUnit)filePathGroup.FilePathUnitList[i]).EnableUpload;

               if (((FilePathUnit)filePathGroup.FilePathUnitList[i]).EnableUploadFunction == false)
               {
                  ((TextBox)filePathTextBoxList[i]).Size = new Size(((TextBox)filePathTextBoxList[i]).Size.Width + 100, ((TextBox)filePathTextBoxList[i]).Size.Height);
                  ((Button)selectFolderButtonList[i]).Location = new Point(((Button)selectFolderButtonList[i]).Location.X + 99, ((Button)selectFolderButtonList[i]).Location.Y);

                  ((CheckBox)enableUploadCheckBoxList[i]).Visible = false;
               }
               else
                  ((CheckBox)enableUploadCheckBoxList[i]).Visible = true;
            }
            else
               ((CheckBox)enableUploadCheckBoxList[i]).Visible = false;

            ((TextBox)pathLabelList[i]).Visible = i < filePathGroup.FilePathUnitList.Count;
            ((TextBox)filePathTextBoxList[i]).Visible = i < filePathGroup.FilePathUnitList.Count;
            ((Button)selectFolderButtonList[i]).Visible = i < filePathGroup.FilePathUnitList.Count;
            
         }
      }

      private void GetParaFromUI()
      {
         for (int i = 0; i < filePathGroup.FilePathUnitList.Count; i++)
         {
            ((FilePathUnit)filePathGroup.FilePathUnitList[i]).Directory = ((TextBox)filePathTextBoxList[i]).Text;
            ((FilePathUnit)filePathGroup.FilePathUnitList[i]).EnableUpload = ((CheckBox)enableUploadCheckBoxList[i]).Checked;
         }
      }

      private void selectFolderButton_Click(object sender, EventArgs e)
      {
         if (bInit==true)
         {
            for (int i = 0; i < selectFolderButtonList.Count; i++)
            {
               if (sender == selectFolderButtonList[i])
               {
                  System.Windows.Forms.FolderBrowserDialog folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
                  folderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
                  folderBrowserDialog.Description = string.Format("Please select \"{0}\" folder...", ((TextBox)pathLabelList[i]).Text);
                  folderBrowserDialog.ShowDialog(this);
                  ((TextBox)filePathTextBoxList[i]).Text = folderBrowserDialog.SelectedPath;

                  GetParaFromUI();
                  SaveParaToIniFile();
                  break;
               }
            }
         }
      }

      private void enableUploadCheckBox_CheckedChanged(object sender, EventArgs e)
      {
         if (bInit == true)
         {
            for (int i = 0; i < enableUploadCheckBoxList.Count; i++)
            {
               if (sender == enableUploadCheckBoxList[i])
               {
                  GetParaFromUI();
                  SaveParaToIniFile();
                  break;
               }
            }
         }
      }
   }

   public class FilePathGroup : Object
   {
      private string strFileGroupName = "";
      private ArrayList filePathUnitList = new ArrayList();
      
      public FilePathGroup()
      {

      }

      public FilePathGroup(string strFileGroupName)
      {
         this.strFileGroupName = strFileGroupName;
      }

      public string FileGroupName
      {
         get
         {
            return strFileGroupName;
         }
         set
         {
            strFileGroupName = value;
         }
      }

      public ArrayList FilePathUnitList
      {
         get
         {
            return filePathUnitList;
         }
         set
         {
            filePathUnitList = value;
         }
      }
   }

   public class FilePathUnit : Object
   {
      private string fileName = "";
      private string directory = "";
      private bool enableUploadFunction = false;
      private bool enableUpload = false;

      public FilePathUnit()
      {
      }

      public FilePathUnit(string fileName, string directory)
      {
         FileName = fileName;
         Directory = directory;
      }
      
      public FilePathUnit(string fileName, string directory, bool enableUploadFunction)
      {
         FileName = fileName;
         Directory = directory;
         EnableUploadFunction = enableUploadFunction;
      }
/*
      public FilePathUnit(string fileName, string directory, bool enableUpload)
      {
         FileName = fileName;
         Directory = directory;
         EnableUpload = enableUpload;
      }
      */
      public string FileName
      {
         get
         {
            return fileName;
         }
         set
         {
            fileName = value;
         }
      }

      public string Directory
      {
         get
         {
            return directory;
         }
         set
         {
            directory = value;
         }
      }

      public bool EnableUploadFunction
      {
         get
         {
            return enableUploadFunction;
         }
         set
         {
            enableUploadFunction = value;
         }
      }

      public bool EnableUpload
      {
         get
         {
            return enableUpload;
         }
         set
         {
            enableUpload = value;
         }
      }
   }
}
