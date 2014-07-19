using System;
using System.Collections.Generic;
using System.Text;
using CommunicationInterface;
using System.Timers;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Threading;

namespace ContrelModule
{
    public class LaserCMD
    {
        private static Int32 LaserCallback(Int32 iChannel, Int32 iCmdType, Int32 iErrCode, IntPtr pData)
        {
            return 0;
        }
        public static bool LaserInitial()
        {
            return LSDLL.LAS_LaserContrelInit();
        }

        public static bool Fire()
        {
            if (CheckLaserStatus())
            {
                LSDLL.LAS_Source_SHON();
                LSDLL.LAS_SetShutterON(2);
            }
            else
                return false;
            return true;
        }

        //  停止擊發
        public static bool Stop()
        {            
            LSDLL.LAS_SetShutterOFF(1);
            LSDLL.LAS_SetShutterOFF(2);
	        return true;
        }

        //  設定雷射能量（）
        public static bool SetPower(double power)
        { 
            //  雷射Power 輸入mW  需要用Double型別
	        if( CheckLaserStatus() )
	       {		      
                LSDLL.LAS_Motor_RunRomTable(1, (int)power);
		        //CString tempstr;
		        //tempstr.Format("雷射能量設定階數  %d", (int)power);
		        //theApp.m_MMonitor.SendToMachineMsg("LaserCmdUI", "SetPower", tempstr,TRUE);
	        }
	        else
		        return false;

	        return true;
        }

        //  設定雷射波長
        public static bool SetWavelength(double Wavelength)
        {
	        //AfxMessageBox("目前無此功能");
	        return false;

	        if( CheckLaserStatus() )
	        {
        		
	        }
	        else
		        return false;
	        return true;
        }

        //  設定偏振方向角度
        public static bool SetPolarize(double angle)
        {
	        if( CheckLaserStatus() )
	        {
                //		LAS_GoAnglePosition(angle);
	        }
	        else
		        return false;

	        return true;
        }
        //  設定偏光板是否On  M8馬達
        public static bool SetColorFilter(bool IsOn)
        {

            //	if( IsOn )
            //		LAS_Motor_RunRomTable(8,1000);  //  有濾光
            //	else
            //		LAS_Motor_RunRomTable(8,0);  //  無濾光
	        if( IsOn )
                LSDLL.LAS_Motor_RealPluseMove(8, 11500, 0);  //  正轉
	        else
                LSDLL.LAS_Motor_RealPluseMove(8, 11500, 1);  //  反轉

	        return true;
        }

        //  確認雷射機狀態
        public static bool CheckLaserStatus()
        {
            if (IsLaserReady())
            {
                if (!IsLaserFire())
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("雷射擊發中，請稍待！！");
                    return false;  
                }
            }
            else
            {
                MessageBox.Show("Laser Not Ready！！");
                return false;
            }
        }

        public static bool IsLaserReady()
        {
            return LSDLL.LAS_Source_GetLaserReadyS();            
        }

        //  雷射Shutter目前狀態
        public static bool IsLaserFire()
        {
            //  true 開  false 關
            return LSDLL.LAS_GetShutterStatus(2);        
        }
    }
    
    public class LSDLL
    {
        [DllImport("LaserControl.dll", EntryPoint = "?LAS_ReSetLaserCard@@YAXXZ")]
        public static extern float LAS_ReSetLaserCard();

        // DLLEXPORT BOOL LAS_SendCommand(char* pSendCmd,char* pSendMsg,int mode)
        [DllImport("LaserControl.dll", EntryPoint = "?LAS_SendCommand@@YAHPBD0H@Z")]
        public static extern bool LAS_SendCommand(string pSendCmd, string pSendMsg);

        // DLLEXPORT int LAS_CmdQueueCount();
        [DllImport("LaserControl.dll", EntryPoint = "?LAS_CmdQueueCount@@YAHXZ")]
        public static extern Int32 LAS_CmdQueueCount();

        #region 雷射控制元件相關
        //DLLEXPORT long LAS_Motor_Home(int NumOfMotor);              //執行馬達歸Home指令 (NumOfMotor 1~8)
        /// <summary>
        /// //執行馬達歸Home指令 (NumOfMotor 1~8)
        /// </summary>
        /// <param name="NumOfMotor"></param>
        /// <returns></returns>
        [DllImport("LaserControl.dll", EntryPoint = "?LAS_Motor_Home@@YAJH@Z")]
        public static extern long LAS_Motor_Home(Int32 NumOfMotor); 

        //DLLEXPORT BOOL LAS_Motor_GetBusyFlag(int NumOfMotor);       //取得馬達忙碌狀態 (NumOfMotor 1~8)
        /// <summary>
        /// 取得馬達忙碌狀態 (NumOfMotor 1~8)
        /// </summary>
        /// <param name="NumOfMotor"></param>
        /// <returns></returns>
        [DllImport("LaserControl.dll", EntryPoint = "?LAS_Motor_GetBusyFlag@@YAHH@Z")]
        public static extern bool LAS_Motor_GetBusyFlag(Int32 NumOfMotor);

        //DLLEXPORT BOOL LAS_Motor_RunRomTable(int NumOfMotor,int TableRank);      //執行Rom中馬達Table的位置
        [DllImport("LaserControl.dll", EntryPoint = "?LAS_Motor_GetBusyFlag@@YAHH@Z")]
        public static extern float LAS_Motor_RunRomTable(Int32 NumOfMotor, Int32 TableRank);

        // DLLEXPORT void LAS_Motor_SetInitialPosition(int NumOfMotor,int pulse);   //馬達初始化位置設置為Home位置在正轉n Pulse
        [DllImport("LaserControl.dll", EntryPoint = "?LAS_Motor_SetInitialPosition@@YAXHH@Z")]
        public static extern float LAS_Motor_SetInitialPosition(Int32 NumOfMotor, Int32 pulse);

        //DLLEXPORT void LAS_Motor_GoInitialPosition(int NumOfMotor);    //執行馬達初始化位置
        [DllImport("LaserControl.dll", EntryPoint = "?LAS_Motor_GoInitialPosition@@YAXH@Z")]
        public static extern void LAS_Motor_GoInitialPosition(Int32 NumOfMotor);

        //DLLEXPORT long LAS_GetLaserCount();						    //取得雷射機Fire Count數
        [DllImport("LaserControl.dll", EntryPoint = "?LAS_GetLaserCount@@YAJXZ")]
        public static extern long LAS_GetLaserCount();

        // DLLEXPORT BOOL LAS_GetInputIOStatus(int num);               //取得Input IO 狀態 (num 1~12)
        [DllImport("LaserControl.dll", EntryPoint = "?LAS_GetInputIOStatus@@YAHH@Z")]
        public static extern bool LAS_GetInputIOStatus(Int32 num);

        //DLLEXPORT BOOL LAS_GetOutputIOStatus(int num);				//取得Output IO 狀態 (num 1~12)
        [DllImport("LaserControl.dll", EntryPoint = "?LAS_GetOutputIOStatus@@YAHH@Z")]
        public static extern bool LAS_GetOutputIOStatus(Int32 num);

        //DLLEXPORT BOOL LAS_GetShutterStatus(int num);               //取得Shutter狀態 (num 1~2)
        [DllImport("LaserControl.dll", EntryPoint = "?LAS_GetShutterStatus@@YAHH@Z")]
        public static extern bool LAS_GetShutterStatus(Int32 num);

        //DLLEXPORT BOOL LAS_GetShutterStatus(int num);               //取得Shutter狀態 (num 1~2)
        [DllImport("LaserControl.dll", EntryPoint = "?LAS_GetShutterStatus@@YAHH@Z")]
        public static extern bool LAS_ChangeRegularQuery(Int32 num);

        //DLLEXPORT BOOL LAS_GetShutterStatus(int num);               //取得Shutter狀態 (num 1~2)
        [DllImport("LaserControl.dll", EntryPoint = "?LAS_ReadFPGA@@YAHH@Z")]
        public static extern float LAS_ReadFPGA(Int32 num);

        [DllImport("LaserControl.dll", EntryPoint = "?LAS_SetShutterON@@YAXH@Z")]
        public static extern float LAS_SetShutterON(Int32 num);

        [DllImport("LaserControl.dll", EntryPoint = "?LAS_SetShutterOFF@@YAXH@Z")]
        public static extern float LAS_SetShutterOFF(Int32 num);

        //DLLEXPORT void LAS_Motor_RealPluseMove(int NumOfMotor,int pluse,int dir);  //Dir:0 正轉  1 反轉  //只開放 NumOfMotor = 7
        [DllImport("LaserControl.dll", EntryPoint = "?LAS_Motor_RealPluseMove@@YAXHHH@Z")]
        public static extern float LAS_Motor_RealPluseMove(Int32 num, Int32 pluse, Int32 dir);

        //DLLEXPORT BOOL LAS_SetFireSH(int type);                     //設定雷射擊發時光路Shutter開啟狀態  Type:0 全關 1:SH1開  2:SH2開
        [DllImport("LaserControl.dll", EntryPoint = "?LAS_SetFireSH@@YAHH@Z")]
        public static extern float LAS_SetFireSH(Int32 num);
        #endregion

        #region 雷射模組初始化 包括連線建立與CallBack Func. & 馬達位置初始化 & 參數初始化
        [UnmanagedFunctionPointer (CallingConvention.Cdecl)]
        public delegate Int32 LaserProcessCallBack(Int32 iChannel, Int32 iCmdType, Int32 iErrCode, IntPtr pData);

        [DllImport("LaserControl.dll", EntryPoint = "?LAS_LaserContrelInit@@YAHXZ")]
        public static extern bool LAS_LaserContrelInit();

        [DllImport("LaserControl.dll", EntryPoint = "?LAS_LaserContrelRelease@@YAHXZ")]
        public static extern bool LAS_LaserContrelRelease();

        #region Laser Source 相關
        /// <summary>
        /// 雷射source初始化 等待Power Warm至Ready
        /// </summary>
        /// <returns></returns>
        [DllImport("LaserControl.dll", EntryPoint = "?LAS_Source_Initial@@YAXXZ")]
        public static extern bool LAS_Source_Initial();

        /// <summary>
        /// 詢問雷射初始化旗標狀態(是否Ready)
        /// </summary>
        /// <returns></returns>
        [DllImport("LaserControl.dll", EntryPoint = "?LAS_Source_GetLaserReadyS@@YAHXZ")]
        public static extern bool LAS_Source_GetLaserReadyS();

        /// <summary>
        /// 詢問Laser Source Shutter狀態
        /// </summary>
        /// <returns></returns>
        [DllImport("LaserControl.dll", EntryPoint = "?LAS_Source_QuerySHStatus@@YAXXZ")]
        public static extern bool LAS_Source_QuerySHStatus();

        /// <summary>
        /// 詢問Laser Source Shutter狀態
        /// </summary>
        /// <returns></returns>
        [DllImport("LaserControl.dll", EntryPoint = "?LAS_Source_SHON@@YAXXZ")]
        public static extern bool LAS_Source_SHON();

        /// <summary>
        /// 執行Laser Source Shutter OFF
        /// </summary>
        /// <returns></returns>
        [DllImport("LaserControl.dll", EntryPoint = "?LAS_Source_SHOFF@@YAXXZ")]
        public static extern bool LAS_Source_SHOFF();

        #endregion

        #region 調機專用

        //[DllImport("LaserControl.dll", EntryPoint = "?LAS_Motor_SetHomePar@@YAXHPAE@Z")]
        //public static extern void LAS_Motor_SetHomePar(Int32 NumOfMotor,BYTE *data_send);

        [DllImport("LaserControl.dll", EntryPoint = "?LAS_Motor_GetHomePar_CMD@@YAXH@Z")]
        public static extern void LAS_Motor_GetHomePar_CMD(Int32 NumOfMotor);

        // DLLEXPORT BYTE *LAS_Motor_GetHomePar_Re(int NumOfMotor);
        // DLLEXPORT void LAS_Motor_SetGAP(int NumOfMotor,BYTE *data_send);

        [DllImport("LaserControl.dll", EntryPoint = "?LAS_Motor_GetGAP_CMD@@YAXH@Z")]
        public static extern void LAS_Motor_GetGAP_CMD(Int32 NumOfMotor);

        // DLLEXPORT BYTE *LAS_Motor_GetGAP_Re(int NumOfMotor);
        // DLLEXPORT void LAS_Motor_SetSpeed(int NumOfMotor,BYTE *data_send);

        [DllImport("LaserControl.dll", EntryPoint = "?LAS_Motor_GetSPEED_CMD@@YAXH@Z")]
        public static extern void LAS_Motor_GetSPEED_CMD(Int32 NumOfMotor);

        // DLLEXPORT BYTE *LAS_Motor_GetSpeed_Re(int NumOfMotor);

        [DllImport("LaserControl.dll", EntryPoint = "?LAS_Motor_SaveAll@@YAXH@Z")]
        public static extern void LAS_Motor_SaveAll(Int32 NumOfMotor);

        // DLLEXPORT void LAS_Motor_SetTable(int NumOfMotor,BYTE *data_send);

        [DllImport("LaserControl.dll", EntryPoint = "?LAS_Motor_SetTableValue@@YAXHHJ@Z")]
        public static extern void LAS_Motor_SetTableValue(Int32 NumOfMotor,Int32 iIndex,long iValue);

        // DLLEXPORT void LAS_Motor_GetTable_CMD(int NumOfMotor,BYTE *data_send);
        // DLLEXPORT BYTE *LAS_Motor_GetTable_Re(int NumOfMotor,BYTE *data_send);

        [DllImport("LaserControl.dll", EntryPoint = "?LAS_Motor_PositionNow_Re@@YAJH@Z")]
        public static extern long LAS_Motor_PositionNow_Re(Int32 NumOfMotor);

        [DllImport("LaserControl.dll", EntryPoint = "?LAS_Motor_PositionNow_CMD@@YAXH@Z")]
        public static extern void LAS_Motor_PositionNow_CMD(Int32 NumOfMotor);

        // DLLEXPORT void LAS_Motor_RealMove(int NumOfMotor,BYTE *data_send,int dir);  //Dir:0 正轉  1 反轉

        #endregion
   
        #endregion

    }

    

    /*public class CCLaserInterface
    {
        #region Private Member
        private static CCLaserInterface m_Singleton = null;
        private CCStandardInterface m_Interface = new CCStandardInterface();
        private const uint MAX_MOTOR_NUM = 8;
        private const uint MAX_SHUTTER_NUM = 2;

        private int m_MotorBusyMap = 0;
        private int m_iQueryScenarioIdx = 0;
        private Timer m_ScenarioTimer = new Timer(500);
        private int m_iMotorIdx = 1;
        #endregion

        #region Ctor
        protected CCLaserInterface()
        {
            // Setup RS232 Protocol
            CCRS232Protocol protocol = new CCRS232Protocol();
            protocol.PortBoudrate = 115200;
            protocol.PortStopBits = System.IO.Ports.StopBits.One;
            protocol.PortDataBits = 8;
            protocol.PortParity = System.IO.Ports.Parity.None;
            protocol.PortNumber = "COM3";
            m_Interface.Protocol = protocol;

            // Setup Parser
            m_Interface.Parser = new CCLaserParser();

            // Setup Dispatcher
            CCLaserDispatcher dispatcher = new CCLaserDispatcher(m_Interface);
            dispatcher.LaserInterface = this;
            m_Interface.Dispatcher = dispatcher;

            m_Interface.EnableRetry = false;
            m_Interface.Create();

            // Setup Timer
            m_ScenarioTimer.Elapsed += new ElapsedEventHandler(QueryStatusScenario);

        }
        #endregion

        #region Public Proterty
        public int QueryScenarioIdx
        {
            set { m_iQueryScenarioIdx = value; }
            get { return m_iQueryScenarioIdx; }
        }
        #endregion

        #region Private Method
        private void SendCommand(char p_cCommand)
        {
            char[] message = new char[1];

            message[0] = p_cCommand;
            m_Interface.SendMessage(new string(message));
        }
        private void SendCommand(char p_cCommand, char[] p_strData)
        {
            char[] message = new char[1 + p_strData.Length];

            message[0] = p_cCommand;
            Array.Copy(p_strData, 0, message, 1, p_strData.Length);
            m_Interface.SendMessage(new string(message));
        }
        private void QueryStatusScenario(object source, ElapsedEventArgs e)       
        {
            switch (m_iQueryScenarioIdx)
            {
                case 0:    // Idle
                    break;

                case  10: // Query Motor1
                    //ReadMotorStatusPos(m_iMotorIdx);
                    m_iQueryScenarioIdx = 20;
                    break;

                case 20: // Wait Reply
                    break;

                case 30: // Receive Rely
                    m_iMotorIdx++;
                    if (m_iMotorIdx <= MAX_MOTOR_NUM)
                        m_iQueryScenarioIdx = 10;
                    else
                        m_iQueryScenarioIdx = 40;
                    break;

                case 40: // End of Scenario
                    break;
            }
        }
        private char GetAssociatedCmdByMotor(int p_iMotorNum, RequestCommand p_cmd)
        {
            if (p_iMotorNum <= 0 || p_iMotorNum > MAX_MOTOR_NUM)
                return '0';

            int iCmdOffset = 0x10 * (p_iMotorNum - 1);
            char realCommand = (char)((char)p_cmd + (char)iCmdOffset);
            return realCommand;
        }
        #endregion

        #region Public Method    
        
        public static CCLaserInterface getSingleton()
        {
            if (m_Singleton == null)
                m_Singleton = new CCLaserInterface();
            return m_Singleton;
        }        
    
        public void Destroy()
        {
            m_Interface.Destroy();
        }

        public void StartScenario()
        {
            m_iQueryScenarioIdx = 10;
            m_ScenarioTimer.Enabled = true;
        }

        //雷射控制相關函式

        /// <summary>
        /// 雷射擊發
        /// </summary>
        public void LaserStartFire()
        {
            SendCommand((char)RequestCommand.LaserFire);
        }
        
        /// <summary>
        /// 雷射停止擊發
        /// </summary>
        public void LaserStopFire()
        {
            SendCommand((char)RequestCommand.LaserStop);
        }

        /// <summary>
        /// 馬達作Home。
        /// </summary>
        /// <param name="p_iMotorNum">馬達編號</param>
        public void MotorHome(int p_iMotorNum)
        {
            if (p_iMotorNum <= 0 || p_iMotorNum > MAX_MOTOR_NUM)
                return;

            int iCmdOffset = 0x10 * (p_iMotorNum - 1);          
            char realCommand =  (char)((char)RequestCommand.Motor1Home + (char)iCmdOffset);

            SendCommand (realCommand );
        }

        /// <summary>
        /// 馬達是否忙碌中。
        /// </summary>
        /// <param name="p_iMotorNum">馬達編號</param>
        /// <returns></returns>
        public bool IsMotorBusy(int p_iMotorNum)
        {
            if (p_iMotorNum <= 0 || p_iMotorNum > MAX_MOTOR_NUM)
                return false;

            int mapIdx = 1 << (p_iMotorNum-1);
            int busyflag = m_MotorBusyMap & mapIdx;
            return (busyflag != 0 ) ? true : false;
        }

        /// <summary>
        /// 設定Shutter開啟或是關閉。
        /// </summary>
        /// <param name="p_iShutterNum">Shutter編號</param>
        /// <param name="On"></param>
        public void SetShutter(int p_iShutterNum, bool On)
        {
            if (p_iShutterNum <= 0 || p_iShutterNum > MAX_SHUTTER_NUM)
                return;

            RequestCommand cmd;
            if (p_iShutterNum == 1 && On == true)
                cmd = RequestCommand.SetupShutter1On;
            else if (p_iShutterNum == 1 && On == false)
                cmd = RequestCommand.SetupShutter1Off;
            else if (p_iShutterNum == 2 && On == true)
                cmd = RequestCommand.SetupShutter2On;
            else
                cmd = RequestCommand.SetupShutter2Off;

            SendCommand( (char)cmd);
        }

        /*public void ReadMotorStatusPos(int p_iMotorNum)
        {
            if (p_iMotorNum <= 0 || p_iMotorNum > MAX_MOTOR_NUM)
                return;

            int iCmdOffset = 0x10 * (p_iMotorNum - 1);
            char realCommand = (char)((char)RequestCommand.ReadMotor1Pos_Status + (char)iCmdOffset);
            
            SendCommand(realCommand);
        }
        public bool GetShutterStatus(int p_iShutterNum)
        {
            return false;
        }

        //雷射設定相關函式
        /// <summary>
        /// 設定馬達歸Home參數。
        /// </summary>
        /// <param name="p_iMotorNum">馬達編號</param>
        /// <param name="p_data">參數資料</param>
        public void MotorSetHomePara(int p_iMotorNum, char[] p_data)
        {
            char cmd = GetAssociatedCmdByMotor(p_iMotorNum, RequestCommand.SetupMotor1HomePara);
            if (cmd != '0')
                SendCommand(cmd, p_data);
        }

        /// <summary>
        /// 設定背隙值。
        /// </summary>
        /// <param name="p_iMotorNum">馬達編號</param>
        /// <param name="p_data">背隙值</param>
        public void MotorSetGap(int p_iMotorNum, char[] p_data)
        {
            char cmd = GetAssociatedCmdByMotor(p_iMotorNum, RequestCommand.SetupMotor1BackGap);
            if (cmd != '0')
                SendCommand(cmd, p_data);
        }

        /// <summary>
        /// 設定馬達速度。
        /// </summary>
        /// <param name="p_iMotorNum">馬達編號</param>
        /// <param name="p_data">速度</param>
        public void MotorSetSpeed(int p_iMotorNum, char[] p_data)
        {
            char cmd = GetAssociatedCmdByMotor(p_iMotorNum, RequestCommand.SetupMotor1Speed);
            if (cmd != '0')
                SendCommand(cmd, p_data);
        }

        /// <summary>
        /// 設定Table值。
        /// </summary>
        /// <param name="p_iMotorNum">馬達編號</param>
        /// <param name="p_data">Table資料</param>
        public void MotorSetTable(int p_iMotorNum, char[] p_data)
        {
            char cmd = GetAssociatedCmdByMotor(p_iMotorNum, RequestCommand.SetupMotor1Table);
            if (cmd != '0')
                SendCommand(cmd, p_data);
        }
     
        /// <summary>
        /// 讀取 Table 值進行移動指令。
        /// </summary>
        /// <param name="p_iMotorNum">馬達編號</param>
        /// <param name="p_data">Table資料</param>
        public void ReadTableAndRunMotor(int p_iMotorNum, char[] p_data)
        {
            char cmd = GetAssociatedCmdByMotor(p_iMotorNum, RequestCommand.ReadMotor1TableAndMove);
            if (cmd != '0')
                SendCommand(cmd, p_data);
        }

        /// <summary>
        /// 設定雷射參數。
        /// </summary>
        /// <param name="p_dPower"></param>
        public void SetPower(double p_dPower)
        {

        }

        /// <summary>
        /// 設定雷射波長。
        /// </summary>
        /// <param name="p_Wavelength"></param>
        public void SetWaveLength(double p_Wavelength)
        {

        }

        /// <summary>
        /// 設定Slit大小。
        /// </summary>
        public void SetSlit(double p_dSlitx, double p_dSlity)
        {

        }

        /// <summary>
        /// 設定偏光版是否ON。
        /// </summary>
        /// <param name="p_dAngle"></param>
        public void SetColorFilter(bool p_bOn)
        {

        }

        /// <summary>
        /// 設定偏光板旋轉角度。
        /// </summary>
        /// <param name="p_dAngle"></param>
        public void SetColorFilterAngle(double p_dAngle)
        {

        }

        /// <summary>
        /// 雷射Shutter目前狀態
        /// </summary>
        /// <returns></returns>
        public bool IsLaserFire()
        {
            return true;
        }


        #endregion
    }

    public enum RequestCommand
    {
        ResetControlCard = '\x01',
        EchoCommandForebug = '\xFF',
        LaserFire = '\x02',
        LaserStop = '\x03',
        OpenMotorInitialize = '\x05',
        CloseMotorInitialize = '\x06',

        ReadInputIO = '\xB0',
        SetupOutputIO = '\xB1',
        ReadOutputIO = '\xB2',
        SetupShutter1On = '\xB3',
        SetupShutter1Off = '\xB4',
        SetupShutter2On = '\xB5',
        SetupShutter2Off = '\xB6',
        ReadShutterStatus = '\xB7',
        SetupLaserFireShutterStatus = '\xB8',
        ReadLaserFireShutterStatus = '\xB9',

        // RS232 - Port 1
        SetupPort1ComPort = '\x10',
        ReadPort1ComPort = '\x11',
        SetupPort1BaudRate = '\x12',
        ReadPort1BaudRate = '\x13',
        ReadPort1RcvBufferValue = '\x14',
        ReadPort1RcvBufferStatus = '\x15',
        SetupPort1SndBufferValue = '\x16',
        ReadPort1SndBufferValue = '\x17',
        ReadPort1SndBufferStatus = '\x18',
        WritePort1BaudRateToFlash = '\x19',
        ReadPort1BaudRateFromFlash = '\x1A',

        // RS232 - Port 2
        SetupPort2ComPort = '\x20',
        ReadPort2ComPort = '\x21',
        SetupPort2BaudRate = '\x22',
        ReadPort2BaudRate = '\x23',
        ReadPort2RcvBufferValue = '\x24',
        ReadPort2RcvBufferStatus = '\x25',
        SetupPort2SndBufferValue = '\x26',
        ReadPort2SndBufferValue = '\x27',
        ReadPort2SndBufferStatus = '\x28',
        WritePort2BaudRateToFlash = '\x29',
        ReadPort2BaudRateFromFlash = '\x2A',

        // Motor 1
        Motor1Home = '\x30',
        SetupMotor1HomePara = '\x31',
        ReadMotor1HomePara = '\x32',
        SetupMotor1BackGap = '\x33',
        ReadMotor1BackGap = '\x34',
        SetupMotor1Speed = '\x35',
        ReadMotor1Speed = '\x36',
        ReadMotor1Pos_Status = '\x37',
        SetupMotor1Table = '\x38',
        ReadMotor1Table = '\x39',
        ReadMotor1TableAndMove = '\x3A',
        WriteMotor1ToFlash = '\x3B',
        ReadMotor1FromFlash = '\x3C',
        SetupMotor1ClockwisePulse = '\x3D',
        SetupMotor1CounterclockwisePulse = '\x3E',
        SetupMotor1AbsolutePulse = '\x3F',
      
        SetupDeviceCounterStatus = '\xC0',
        ReadDeviceCounterStatus = '\xC1',
        LoadDeviceCounterValue = '\xC2',
        ReadDeviceCounterValue = '\xC3',
        SetupLaserCounterStatus = '\xC4',
        ReadLaserCounterStatus = '\xC5',
        LoadLaserCounterValue = '\xC6',
        ReadLaserCounterValue = '\xC7',
        WriteDeviceTimerValueToFlash = '\xC8',
        ReadDeviceTimerValuefFromFlash = '\xC9',
        WriteLaserTimerValueToFlash = '\xCA',
        ReadLaserTimerValuefFromFlash = '\xCB',

    }
    public enum ReplyCommand
    {
        ReadResponse = '\x01',
        WriteResponse = '\x02',
        ErrorResponse = '\x03',
        EchoResponse = '\xff'
    };

    public enum ErrorResponseCode
    {
        UnknowCommandError = '\x01', // 無效指令
        CRCError = '\x02', // CRC錯誤
        LaserWarmUpError = '\x03', // 雷射機暖開機錯誤
        KnowHowIOError = '\x04', // Know How 開關被觸發
        LaserInterlockIOError = '\x05', // Laser Interlock 開關被觸發
        MachineEMIOError = '\x06', // Machine EM 開關被觸發
        MotorBusyError = '\x07', // 馬達運轉忙碌中
        TableOutOfRangeError = '\x08', // Table寫入/讀取比數超過範圍
        LaserShutterOnError = '\x09', // Laser Shutter On 錯誤
        LaserShutterOffError = '\x0A', // Laser Shutter Off 錯誤
    }

    public class CCLaserParser : CCBaseParser
    {
        #region Private Member

        // Define Field Length
        private const int STX_LENGTH = 1;
        private const int DATA_LENGTH = 1;
        private const int CMD_LENGTH = 1;
        private const int CRC_LENGTH = 2;
        private const int ETX_LENGTH = 1;

        // Define Flag of test
        private const char STX = '\x30';
        private const char ETX = '\x0D';
        #endregion

        #region Ctor
        public CCLaserParser()
            : base()
        {
        }
        #endregion

        #region Public Method
        public override void ParserMessage(string p_String)
        {
            char[] szCommand = new char[p_String.Length];
            int iOffset = 0;

            // 1. STX
            char cSTX = p_String[iOffset];
            if (cSTX != STX)
                throw new Exception(ErrorResponseCode.UnknowCommandError.ToString());
            iOffset += STX_LENGTH;

            // 2. LEN
            char cLen = p_String[iOffset];
            iOffset += DATA_LENGTH;

            // 3. CMD
            char[] cCmd = new char[1];
            cCmd[0] = p_String[iOffset];
            m_strCommand = new string(cCmd);
            iOffset += CMD_LENGTH;

            // 4. Data
            int iRealDataLength = p_String.Length - STX_LENGTH - DATA_LENGTH - CMD_LENGTH - CRC_LENGTH - ETX_LENGTH;
            if (iRealDataLength != (int)cLen)
                throw new Exception(ErrorResponseCode.CRCError.ToString());

            char[] data = new char[iRealDataLength];
            p_String.CopyTo(iOffset, data, 0, data.Length);
            m_strMessage = new string(data);
            iOffset += iRealDataLength;

            // 6. ETX
            // only waste time

        }

        public override string EncodeMessage(string p_szCommand)
        {
            // We don't need to add CMD_LENGTH because p_szCommand consists of CMD_LENGTH !!
            int iTotalLen = STX_LENGTH + DATA_LENGTH + p_szCommand.Length + CRC_LENGTH + ETX_LENGTH;

            char[] szSendString = new char[iTotalLen];
            int iOffset = 0;

            // 1. STX
            szSendString[iOffset] = '\x30';
            iOffset += STX_LENGTH;

            // 2. LEN            
            szSendString[iOffset] = (char)(p_szCommand.Length - CMD_LENGTH);// wtf, byteCommand consists of CMD_LENGTH
            iOffset += DATA_LENGTH;

            // 3. CMD            
            p_szCommand.CopyTo(0, szSendString, iOffset, CMD_LENGTH);
            iOffset += CMD_LENGTH;

            // 4. Data                        
            p_szCommand.CopyTo(CMD_LENGTH, szSendString, iOffset, p_szCommand.Length - CMD_LENGTH);
            iOffset += p_szCommand.Length - CMD_LENGTH;

            // 5. CRC : 取得要計算CRC的資料： LEN + CMD + DATA            
            char[] crcdata = new char[DATA_LENGTH + p_szCommand.Length];
            Array.Copy(szSendString, STX_LENGTH, crcdata, 0, crcdata.Length);

            Crc16Ccitt crc = new Crc16Ccitt();
            ushort crcresult = crc.ComputeChecksum(crcdata);
            szSendString[iOffset++] = (char)(crcresult >> 8);
            szSendString[iOffset++] = (char)(crcresult & 0xff);

            // 6. ETX
            szSendString[iOffset] = '\x0D';

            return new string(szSendString);
        }

        public override string ShowMessageFormat()
        {
            StringBuilder result = new StringBuilder();

            char[] hexString = m_strCommand.ToCharArray();
            foreach (char letter in hexString)
            {
                int value = Convert.ToInt32(letter);
                result.Append(String.Format("0x{0:X} ", value));
            }

            hexString = m_strMessage.ToCharArray();
            foreach (char letter in hexString)
            {
                int value = Convert.ToInt32(letter);
                result.Append(String.Format("0x{0:X} ", value));
            }
            return result.ToString();
        }

        #endregion
    }

    public class CCLaserDispatcher : CCBaseDispatcher
    {
        #region Private Member
        private CCLaserInterface m_laserInterface = null;
        #endregion

        #region Public Property
        public CCLaserInterface LaserInterface
        {
            set { m_laserInterface = value; }
        }
        #endregion

        #region Ctor
        public CCLaserDispatcher(CCStandardInterface p_Interface)
            : base(p_Interface)
        {
        }
        #endregion
        
        public override void DealWithParserError(string p_Error)
        {            

            // TODO: 如果 enum parse 失敗，會丟出Exception
            ErrorResponseCode parserError = (ErrorResponseCode)Enum.Parse(typeof(ErrorResponseCode), p_Error);
            char[] errorResopnse = new char[1 + 1];

            switch (parserError)
            {
                case ErrorResponseCode.CRCError:                    
                    errorResopnse[0] = (char)ReplyCommand.ErrorResponse;
                    errorResopnse[1] = (char)ErrorResponseCode.CRCError;
                    m_Interface.ReplyMessage(new string(errorResopnse));
                    break;

                case ErrorResponseCode.UnknowCommandError:
                    errorResopnse[0] = (char)ReplyCommand.ErrorResponse;
                    errorResopnse[1] = (char)ErrorResponseCode.UnknowCommandError;
                    m_Interface.ReplyMessage(new string(errorResopnse));
                    break;
            }
        }

        protected override void DefaultCommandHandler(string szCmd)
        {                                   
            switch ((char)szCmd[0])
            {
                case (char)ReplyCommand.ReadResponse:
                    if(m_laserInterface.QueryScenarioIdx == 20)
                        m_laserInterface.QueryScenarioIdx = 30;
                    break;

                case (char)ReplyCommand.WriteResponse:                    
                    break;
            }
        }
    }


    /// <summary>
    /// This can caculate CRC-16, don't ask me how it works............just use it.. :)
    /// </summary>
    public class Crc16Ccitt
    {
        public enum InitialCrcValue { Zeros, NonZero1 = 0xffff, NonZero2 = 0x1D0F }

        #region Private Member
        const ushort poly = 0x1021;
        ushort[] table = new ushort[256];
        ushort initialValue = 0;
        #endregion

        #region Ctor
        public Crc16Ccitt(/*InitialCrcValue initialValue)
        {
            this.initialValue = (ushort)InitialCrcValue.NonZero1;
            ushort temp, a;
            for (int i = 0; i < table.Length; ++i)
            {
                temp = 0;
                a = (ushort)(i << 8);
                for (int j = 0; j < 8; ++j)
                {
                    if (((temp ^ a) & 0x8000) != 0)
                    {
                        temp = (ushort)((temp << 1) ^ poly);
                    }
                    else
                    {
                        temp <<= 1;
                    }
                    a <<= 1;
                }
                table[i] = temp;
            }
        }
        #endregion

        #region Public Method
        public ushort ComputeChecksum(char[] bytes)
        {
            ushort crc = this.initialValue;
            for (int i = 0; i < bytes.Length; ++i)
            {
                crc = (ushort)((crc << 8) ^ table[((crc >> 8) ^ (0xff & bytes[i]))]);
            }
            return crc;
        }
        #endregion


    }*/
}
