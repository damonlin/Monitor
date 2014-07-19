using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using IniTool;
using Common;

namespace Datalog
{
    public partial class DIOMonitorUnitControl : Common.Template.SubInfoPanelTemplate
    {
        public const string strDIOINIPath = "INI\\DIOName.ini";
        string tmpDI = "", tmpDO = "";//Log 比較使用;

        private Datalog.DatalogUnitControl IOLog = new Datalog.DatalogUnitControl("IO Log");

        public DIOMonitorUnitControl()
        {
            InitializeComponent();
            UserControl_Load();
            IOLog.Log("========== IO Log Start ==========");
        }

        //private void UserControl1_Load(object sender, EventArgs e)
        private void UserControl_Load()
        {
            DIMonitorUnitControl.LoadUI(strDIOINIPath, Datalog.CCIOMonitorUnitControl.IOType.DI_TYPE);
            DOMonitorUnitControl.LoadUI(strDIOINIPath, Datalog.CCIOMonitorUnitControl.IOType.DO_TYPE);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bool[] DI = new bool[TK.CCTKform.TK_DIO.CCDioModule_GetDIPointNum()];
            bool[] DO = new bool[TK.CCTKform.TK_DIO.CCDioModule_GetDOPointNum()];
            IniFile iniFile = new IniFile(Datalog.CCIOMonitorUnitControl.IOLogListINIPath);
            string szLog = "";
            

            TK.CCTKform.TK_DIO.CCDioModule_GetAllDI(ref DI);
            TK.CCTKform.TK_DIO.CCDioModule_GetAllDO(ref DO);

            szLog = "DI=";
            for (int i = 0; i < DI.Length; i++)
            {
                string keyName = "DI" + i;

                if (iniFile.GetInt32("DI Check List", keyName, 1) == 0)
                {
                    szLog = szLog + "-";
                }
                else
                {
                    szLog = szLog + ((bool)DI[i] ? 1 : 0); 
                }               
            }
            if (szLog.CompareTo(tmpDI) != 0)
            {
                IOLog.Log(szLog);
                tmpDI = szLog;
            }

            szLog = "DO=";
            for (int i = 0; i < DO.Length; i++)
            {
                string keyName = "DO" + i;
                if (iniFile.GetInt32("DO Check List", keyName, 1) == 0)
                {
                    szLog = szLog + "-";
                }
                else
                {
                    szLog = szLog + ((bool)DO[i] ? 1 : 0);
                }   
            }
            if (szLog.CompareTo(tmpDO) != 0)
            {
                IOLog.Log(szLog);
                tmpDO = szLog;
            }

            DIMonitorUnitControl.RefreshUI(DI);
            DOMonitorUnitControl.RefreshUI(DO);
        }
    }
}
