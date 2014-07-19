using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Maintain.Teaching
{
    /// <summary>
    /// �o�O��H���O,�D�n�s��U�ر��I�\�઺���,�p���I��Ʀs����|,�оɦW�ٵ���....
    /// ��M����L����T�]�i�H�s�W
    /// </summary>
    public abstract class CCAbstractTeachingInfo
    {
        #region Private Member
        protected string m_strDirPath = "";
        protected string m_strTeachName = "";
        #endregion

        #region Public Property      
        /// <summary>
        /// ���o�оɦW�١C        
        /// </summary>
        public string TeachName
        {
            get { return m_strTeachName; }
        }

        /// <summary>
        /// ���o�о�INI�ؿ����|�C
        /// </summary>
        public string IniDirPath
        {
            get
            {
                // TODO: �ݭn�ھ�FilePath�]�wRecipe���|�ӧ@���

                //string root = Directory.GetCurrentDirectory();
                string root = Application.StartupPath;
                string ret = "";
                if (m_strTeachName == "")
                    ret = root + "\\INI\\Recipe\\";
                else
                    ret = root + "\\INI\\Recipe\\" + m_strTeachName + "\\";
                return ret;
            }
        }
        #endregion

        #region Public Method          
   
        /// <summary>
        /// ���o�ӱоɥ\�઺�Ҧ�INI�ɮצW�١C
        /// </summary>
        /// <returns>�ɮװ}�C</returns>
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
    /// �o�̨ϥ� Null Object Pattern�A�p���i�H�Q�� NullTeachingInfo �Ө��N �ˬdNull�� ����
    /// </summary>
    public class NullTeachingInfo : CCAbstractTeachingInfo
    {
        // Do nothing
    }

    /// <summary>
    /// �޲z���I��ƪ�����A�p�G��L�a�誺����Q�n�ϥάY�ӱ��I��ơA�i�H�Q��InfoObjectFactory����o
    /// �pCCRecipeTablControl�Q��InfoObjectFactory���o���I��ƪ��ɮצW��.
    /// </summary>
    public static class TeachingInfoFactory
    {
        #region Private Static Member
        private static Dictionary<string, CCAbstractTeachingInfo> m_dirInfoObj = new Dictionary<string, CCAbstractTeachingInfo>();
        #endregion

        #region Public Static Method
        /// <summary>
        /// ���U TeachInfo ����TeachingInfoFactory�C
        /// </summary>
        /// <param name="p_Obj"></param>
        public static void RegisterTeachInfoToFactory(CCAbstractTeachingInfo p_Obj)
        {
            m_dirInfoObj.Add(p_Obj.TeachName, p_Obj);
        }

        /// <summary>
        /// �ھڱоɦW�١A����w�g���U�� TeachInfo ����C
        /// </summary>
        /// <param name="p_TeachName">�оɦW��</param>
        /// <returns></returns>
        public static CCAbstractTeachingInfo GetTeachInfoObject(string p_TeachName)
        {
            if (m_dirInfoObj.ContainsKey(p_TeachName))
                return m_dirInfoObj[p_TeachName];
            else
                return new NullTeachingInfo();
        }
        #endregion
   }
}
