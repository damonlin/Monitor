using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using GlacialComponents.Controls;
using IniTool;
using System.Collections;
using System.IO;

namespace Recipe
{    
    public partial class CCRecipeTableControl : Common.Template.SubInfoPanelTemplate
    {
        #region Private Method
        private const string m_Identity = "Recipe";      
        static private CCRecipeTableControl singleton;
        #endregion

        #region Ctor
        protected CCRecipeTableControl()
        {
            InitializeComponent();

            LoadTableContent();
        }
        #endregion

        #region Public Method
        public static CCRecipeTableControl getSingleton()
        {
            if (singleton == null)
                singleton = new CCRecipeTableControl();
            return singleton;
        }
        #endregion

        #region Private Method
        private void SavePIDTableToIniFile()
        {
            CheckPIDCorrect();

            CCRecipeListInfo.INIFile.DeleteAll();            

            foreach (GLItem item in m_listTable.Items)
            {
                int tmp = int.Parse(item.SubItems[0].Text);
                string strSectionName = String.Format("{0:0000}", tmp);

                for (int iIdx = 1; iIdx < m_listTable.Columns.Count; ++iIdx)
                {
                    GLColumn col = m_listTable.Columns[iIdx];
                    CCRecipeListInfo.INIFile.WriteValue(strSectionName, col.Text, item.SubItems[iIdx].Text);
                }
            }
        }
        private void LoadTableHeader()
        {            
            string[] listColumnName = CCRecipeListInfo.GetKeyNames();

            //int iCOLUMN_LENGTH = (this.Width / (listColumnName.Length + 1)) - 60;

            m_listTable.Columns.Clear();

            // ���إ�PID Column
            GLColumn col = m_listTable.Columns.Add(m_Identity, m_Identity.Length*15);
            col.ActivatedEmbeddedType = GLActivatedEmbeddedTypes.TextBox;
            col.TextAlignment = ContentAlignment.MiddleCenter;

            // �A�إ߳ѤU��Column
            foreach (string name in listColumnName)
            {
                col = m_listTable.Columns.Add(name, name.Length * 10);

                // �p�G�����ݭn�䴩��L������A�pComboBox����....�b�o�̳]�w!!
                col.ActivatedEmbeddedType = GLActivatedEmbeddedTypes.ComboBox;

                col.TextAlignment = ContentAlignment.MiddleCenter;
                col.ActiveControlItems.Clear();
            }

            // �u���}�Ĥ@��Column��CheckBox
            m_listTable.Columns[0].CheckBoxes = true;
        }        
        private void LoadTableContent()
        {            
            LoadTableHeader();
            
            string[] sectionNames = CCRecipeListInfo.INIFile.GetSectionNames();
            if (sectionNames.Length <= 0)
                return;

            m_listTable.Items.Clear();

            foreach (string sectionName in sectionNames)
            {
                List<KeyValuePair<string, string>> data = CCRecipeListInfo.INIFile.GetSectionValuesAsList(sectionName);

                int intResult;
                GLItem listItem;

                // A little bit boring here, but we try to keep PID as interger format
                if (int.TryParse(sectionName, out intResult))
                    listItem = m_listTable.Items.Add(intResult.ToString());
                else
                    listItem = m_listTable.Items.Add(sectionName);

                foreach (KeyValuePair<string, string> pair in data)
                {                    
                    int iIndex = m_listTable.Columns.GetColumnIndex(pair.Key);
                    listItem.SubItems[iIndex].Text = pair.Value;
                }
            }
        }

        /// <summary>
        /// �o�̬O�ˬd����A�T�O�x�s����ƬO���T��
        /// </summary>
        /// <returns></returns>
        
        private void CheckPIDCorrect()
        {
            List<string> compareList = new List<string>();
            
            foreach (GLItem item in m_listTable.Items)
            {
                compareList.Add(item.SubItems[0].Text);
            }
            
            compareList.Sort();           
            for (int iIdx = 0; iIdx < compareList.Count; ++iIdx )
            {
                int iResult;
                if( !int.TryParse(compareList[iIdx] , out iResult))
                    throw new Exception("Recipe ���O�ƭ� !!");
                // �Q��Binary Search ��ٷj�M�ɶ�(O(logN))
                else if (compareList.BinarySearch(iIdx + 1, compareList.Count - (iIdx + 1), compareList[iIdx], null) >= 0) // Found It!!
                    throw new Exception("Recipe ���_ !!");                                                    
            }
        }        
        /// <summary>
        /// UI Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void m_btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SavePIDTableToIniFile();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Save Error");
            }
            finally
            {                
                LoadTableContent();
            }
        }
        private void m_btnAdd_Click(object sender, EventArgs e)
        {
            GLItem listItem = new GLItem();
            m_listTable.Items.Insert(0, listItem);
            listItem.Selected = true;       
            m_listTable.Refresh();                                  
        }
        private void m_btnDelete_Click(object sender, EventArgs e)
        {
            for (int iIdx = m_listTable.Items.Count - 1; iIdx >= 0; --iIdx)
            {
                if (m_listTable.Items[iIdx].SubItems[0].Checked == false)
                    continue;

                m_listTable.Items.Remove(iIdx);
            }

            try
            {
                SavePIDTableToIniFile();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Delete Error");
            }
            finally
            {
                LoadTableContent();
            }
        }
        private void m_btnCopy_Click(object sender, EventArgs e)
        {
            for (int iIdx = 0; iIdx < m_listTable.Items.Count; ++iIdx)
            {
                if (m_listTable.Items[iIdx].SubItems[0].Checked == false)
                    continue;

                GLItem copyitem = new GLItem();

                for (int iJdx = 0; iJdx < m_listTable.Items[iIdx].SubItems.Count; ++iJdx)
                {
                    GLSubItem subItem = new GLSubItem();
                    subItem.Text = m_listTable.Items[iIdx].SubItems[iJdx].Text;

                    copyitem.SubItems.Add(subItem);
                }
                // Since We've copied the item, cancel the item check !!
                m_listTable.Items[iIdx].SubItems[0].Checked = false; 

                m_listTable.Items.Insert(0, copyitem);
                copyitem.Selected = true;      
                m_listTable.Refresh();
            }            
        }
        

        /*
         * Damon : Bug Fix for ComboBox control
         */ 
        private void m_listTable_DoubleClick(object sender, EventArgs ea)
        {
            MouseEventArgs e = (MouseEventArgs)ea;
            GLListRegion reg;
            int cellX, cellY;
            int item;
            int columnClicked = 0;
            ListStates ls;
            // interpret the x & y coordinates of the event.
            m_listTable.InterpretCoords(e.X, e.Y,
                                             out reg,
                                             out cellX, out cellY,
                                             out item,
                                             out columnClicked,
                                             out ls);
                        
            // Check if we got the right kind of control...
            if (m_listTable.ActivatedEmbeddedControl != null && m_listTable.ActivatedEmbeddedControl.GetType().IsSubclassOf(typeof(ComboBox)))
            {
                int selected = 0;
                ComboBox comboActions;

                if (m_listTable.Columns[columnClicked].ActivatedEmbeddedType == GLActivatedEmbeddedTypes.ComboBox)
                {
                    comboActions = (ComboBox)m_listTable.ActivatedEmbeddedControl;
                    comboActions.DropDownStyle = ComboBoxStyle.DropDownList;
                    comboActions.Items.Clear();
                                      
                    string[] files = Maintain.Teaching.TeachingInfoFactory.GetTeachInfoObject(m_listTable.Columns[columnClicked].Text).GetAllFiles();

                    if (files != null)
                    {
                        // fill in the comboActions.Items collection
                        comboActions.Items.AddRange(files);
                        if (files.Length > 0)
                            comboActions.SelectedIndex = selected;
                    }    
                }               
            }
        }
        #endregion
    }

    // ���ƩMUI���}
    /*public class CCRecipeListInfo : Maintain.Teaching1.CCAbstractInfoObj
    {
        #region Public Method
        public string[] GetKeyNames()
        {
            IniFile file = new IniFile(IniDirPath + "\\RecipeTable.ini");

            string strSectionName = file.GetSectionNames()[0];
            return file.GetKeyNames(strSectionName);
        }

        public string[] GetSectionNames()
        {
            IniFile file = new IniFile(IniDirPath + "\\RecipeTable.ini");
            return file.GetSectionNames();
        }

        public List<KeyValuePair<string, string>> GetSectionValuesAsList(string p_strSectionName)
        {
            IniFile file = new IniFile(IniDirPath + "\\RecipeTable.ini");
            return file.GetSectionValuesAsList(p_strSectionName);
        }
        #endregion
    }*/

    public static class CCRecipeListInfo
    {
        #region Private Member
        private static string m_strINIPath = "INI\\Recipe\\RecipeTable.ini";
        private static IniFile m_iniFile = null;
        #endregion
        

        #region Public Property
        public static string IniPath
        {
            get { return m_strINIPath; }
        }
        public static IniFile INIFile
        {
            get { return m_iniFile; }
        }
        #endregion


        #region Public Static Method
        public static string[] GetKeyNames()
        {
            // �Q�� FilePanelControl �Ө��oRecipe�ؿ�
            /*Maintain.FilePathUnit unit = new Maintain.FilePathUnit();
            Maintain.FilePanelControl.getSingleton().GetFileInfo("Local", "Recipe File", ref unit);
            m_strINIPath = unit.Directory;

            if (File.Exists(m_strINIPath + "\\RecipeTable.ini"))
                m_iniFile = new IniFile(m_strINIPath + "\\RecipeTable.ini");
            else
                m_iniFile = new IniFile("INI\\Recipe\\RecipeTable.ini"); // Default Directory Paths
            */
            m_iniFile = new IniFile("INI\\Recipe\\RecipeTable.ini");
            string strSectionName = CCRecipeListInfo.INIFile.GetSectionNames()[0];
            return m_iniFile.GetKeyNames(strSectionName);
        }
        #endregion
    }

}
