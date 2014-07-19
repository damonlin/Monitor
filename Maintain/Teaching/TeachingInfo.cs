using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Maintain.Teaching
{
    /// <summary>
    /// 這是抽象類別,主要存放各種教點功能的資料,如教點資料存放路徑,教導名稱等等....
    /// 當然有其他的資訊也可以新增
    /// </summary>
    public abstract class CCAbstractTeachingInfo
    {
        #region Private Member
        protected string m_strDirPath = "";
        protected string m_strTeachName = "";
        #endregion

        #region Public Property      
        /// <summary>
        /// 取得教導名稱。        
        /// </summary>
        public string TeachName
        {
            get { return m_strTeachName; }
        }

        /// <summary>
        /// 取得教導INI目錄路徑。
        /// </summary>
        public string IniDirPath
        {
            get
            {
                // TODO: 需要根據FilePath設定Recipe路徑來作更動

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
        /// 取得該教導功能的所有INI檔案名稱。
        /// </summary>
        /// <returns>檔案陣列</returns>
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
    /// 這裡使用 Null Object Pattern，如此可以利用 NullTeachingInfo 來取代 檢查Null的 手續
    /// </summary>
    public class NullTeachingInfo : CCAbstractTeachingInfo
    {
        // Do nothing
    }

    /// <summary>
    /// 管理教點資料的物件，如果其他地方的物件想要使用某個教點資料，可以利用InfoObjectFactory來獲得
    /// 如CCRecipeTablControl利用InfoObjectFactory取得教點資料的檔案名稱.
    /// </summary>
    public static class TeachingInfoFactory
    {
        #region Private Static Member
        private static Dictionary<string, CCAbstractTeachingInfo> m_dirInfoObj = new Dictionary<string, CCAbstractTeachingInfo>();
        #endregion

        #region Public Static Method
        /// <summary>
        /// 註冊 TeachInfo 物件給TeachingInfoFactory。
        /// </summary>
        /// <param name="p_Obj"></param>
        public static void RegisterTeachInfoToFactory(CCAbstractTeachingInfo p_Obj)
        {
            m_dirInfoObj.Add(p_Obj.TeachName, p_Obj);
        }

        /// <summary>
        /// 根據教導名稱，獲取已經註冊的 TeachInfo 物件。
        /// </summary>
        /// <param name="p_TeachName">教導名稱</param>
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
