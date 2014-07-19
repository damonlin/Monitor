using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Maintain.Teaching
{
    /// <summary>
    /// �o�O��H���O,�D�n�s��U�ر��I�\�઺���,�p���I��Ʀs����|,�оɦW�ٵ���....
    /// ��M����L����T�]�i�H�s�W
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
    /// �޲z���I��ƪ�����A�p�G��L�a�誺����Q�n�ϥάY�ӱ��I��ơA�i�H�Q��InfoObjectFactory����o
    /// �pCCRecipeTablControl�Q��InfoObjectFactory���o���I��ƪ��ɮצW��.
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
