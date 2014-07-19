using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Maintain.Teaching
{
    /// <summary>
    /// 這是抽象類別,主要存放各種教點功能的資料,如教點資料存放路徑,教導名稱等等....
    /// 當然有其他的資訊也可以新增
    /// </summary>
    public abstract class CCAbstractInfoObj
    {
        #region Private Member
        protected string m_strDirPath = "";
        protected string m_strInfoName = "";
        #endregion

        #region Public Property      
        public string Name
        {
            get { return m_strInfoName; }
        }
        public string IniDirPath
        {
            get
            {
                if (m_strInfoName.Length <= 0)
                    m_strDirPath = GetINIDirPath();
                else
                    m_strDirPath = GetINIDirPath() + "\\" + m_strInfoName + "\\";
                return m_strDirPath;
            }
        }
        #endregion

        #region Public Method
        public string GetINIDirPath()
        {
            //Maintain.FilePathUnit unit = new Maintain.FilePathUnit();
            //Maintain.FilePanelControl.getSingleton().GetFileInfo("Local", "Recipe File", ref unit);
            //return unit.Directory;
            return "INI\\Recipe\\";
        }        
        public string[] GetAllFiles()
        {
            DirectoryInfo dir = new DirectoryInfo(IniDirPath);
            if (!dir.Exists)
                return null;

            FileInfo[] fileArray = dir.GetFiles();

            List<string> ret = new List<string>();
            foreach (FileInfo file in fileArray)
            {
                ret.Add(file.Name);
            }
            return ret.ToArray();
        }
        #endregion
    }

    /// <summary>
    /// 管理教點資料的物件，如果其他地方的物件想要使用某個教點資料，可以利用InfoObjectFactory來獲得
    /// 如CCRecipeTablControl利用InfoObjectFactory取得教點資料的檔案名稱.
    /// </summary>
    public static class InfoObjectFactory
    {
        #region Private Static Member
        private static Dictionary<string, CCAbstractInfoObj> m_dirInfoObj = new Dictionary<string, CCAbstractInfoObj>();
        #endregion

        #region Public Static Method
        public static void AddInfoObj(string p_strKey, CCAbstractInfoObj p_Obj)
        {
            m_dirInfoObj.Add(p_strKey,p_Obj);
        }
        public static CCAbstractInfoObj GetInfoObject(string type)
        {
            return m_dirInfoObj[type]; 
        }
        #endregion
   }
}
