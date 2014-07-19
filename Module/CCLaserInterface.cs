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

        //  �������o
        public static bool Stop()
        {            
            LSDLL.LAS_SetShutterOFF(1);
            LSDLL.LAS_SetShutterOFF(2);
	        return true;
        }

        //  �]�w�p�g��q�]�^
        public static bool SetPower(double power)
        { 
            //  �p�gPower ��JmW  �ݭn��Double���O
	        if( CheckLaserStatus() )
	       {		      
                LSDLL.LAS_Motor_RunRomTable(1, (int)power);
		        //CString tempstr;
		        //tempstr.Format("�p�g��q�]�w����  %d", (int)power);
		        //theApp.m_MMonitor.SendToMachineMsg("LaserCmdUI", "SetPower", tempstr,TRUE);
	        }
	        else
		        return false;

	        return true;
        }

        //  �]�w�p�g�i��
        public static bool SetWavelength(double Wavelength)
        {
	        //AfxMessageBox("�ثe�L���\��");
	        return false;

	        if( CheckLaserStatus() )
	        {
        		
	        }
	        else
		        return false;
	        return true;
        }

        //  �]�w������V����
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
        //  �]�w�����O�O�_On  M8���F
        public static bool SetColorFilter(bool IsOn)
        {

            //	if( IsOn )
            //		LAS_Motor_RunRomTable(8,1000);  //  ���o��
            //	else
            //		LAS_Motor_RunRomTable(8,0);  //  �L�o��
	        if( IsOn )
                LSDLL.LAS_Motor_RealPluseMove(8, 11500, 0);  //  ����
	        else
                LSDLL.LAS_Motor_RealPluseMove(8, 11500, 1);  //  ����

	        return true;
        }

        //  �T�{�p�g�����A
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
                    MessageBox.Show("�p�g���o���A�еy�ݡI�I");
                    return false;  
                }
            }
            else
            {
                MessageBox.Show("Laser Not Ready�I�I");
                return false;
            }
        }

        public static bool IsLaserReady()
        {
            return LSDLL.LAS_Source_GetLaserReadyS();            
        }

        //  �p�gShutter�ثe���A
        public static bool IsLaserFire()
        {
            //  true �}  false ��
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

        #region �p�g��������
        //DLLEXPORT long LAS_Motor_Home(int NumOfMotor);              //���氨�F�kHome���O (NumOfMotor 1~8)
        /// <summary>
        /// //���氨�F�kHome���O (NumOfMotor 1~8)
        /// </summary>
        /// <param name="NumOfMotor"></param>
        /// <returns></returns>
        [DllImport("LaserControl.dll", EntryPoint = "?LAS_Motor_Home@@YAJH@Z")]
        public static extern long LAS_Motor_Home(Int32 NumOfMotor); 

        //DLLEXPORT BOOL LAS_Motor_GetBusyFlag(int NumOfMotor);       //���o���F���L���A (NumOfMotor 1~8)
        /// <summary>
        /// ���o���F���L���A (NumOfMotor 1~8)
        /// </summary>
        /// <param name="NumOfMotor"></param>
        /// <returns></returns>
        [DllImport("LaserControl.dll", EntryPoint = "?LAS_Motor_GetBusyFlag@@YAHH@Z")]
        public static extern bool LAS_Motor_GetBusyFlag(Int32 NumOfMotor);

        //DLLEXPORT BOOL LAS_Motor_RunRomTable(int NumOfMotor,int TableRank);      //����Rom�����FTable����m
        [DllImport("LaserControl.dll", EntryPoint = "?LAS_Motor_GetBusyFlag@@YAHH@Z")]
        public static extern float LAS_Motor_RunRomTable(Int32 NumOfMotor, Int32 TableRank);

        // DLLEXPORT void LAS_Motor_SetInitialPosition(int NumOfMotor,int pulse);   //���F��l�Ʀ�m�]�m��Home��m�b����n Pulse
        [DllImport("LaserControl.dll", EntryPoint = "?LAS_Motor_SetInitialPosition@@YAXHH@Z")]
        public static extern float LAS_Motor_SetInitialPosition(Int32 NumOfMotor, Int32 pulse);

        //DLLEXPORT void LAS_Motor_GoInitialPosition(int NumOfMotor);    //���氨�F��l�Ʀ�m
        [DllImport("LaserControl.dll", EntryPoint = "?LAS_Motor_GoInitialPosition@@YAXH@Z")]
        public static extern void LAS_Motor_GoInitialPosition(Int32 NumOfMotor);

        //DLLEXPORT long LAS_GetLaserCount();						    //���o�p�g��Fire Count��
        [DllImport("LaserControl.dll", EntryPoint = "?LAS_GetLaserCount@@YAJXZ")]
        public static extern long LAS_GetLaserCount();

        // DLLEXPORT BOOL LAS_GetInputIOStatus(int num);               //���oInput IO ���A (num 1~12)
        [DllImport("LaserControl.dll", EntryPoint = "?LAS_GetInputIOStatus@@YAHH@Z")]
        public static extern bool LAS_GetInputIOStatus(Int32 num);

        //DLLEXPORT BOOL LAS_GetOutputIOStatus(int num);				//���oOutput IO ���A (num 1~12)
        [DllImport("LaserControl.dll", EntryPoint = "?LAS_GetOutputIOStatus@@YAHH@Z")]
        public static extern bool LAS_GetOutputIOStatus(Int32 num);

        //DLLEXPORT BOOL LAS_GetShutterStatus(int num);               //���oShutter���A (num 1~2)
        [DllImport("LaserControl.dll", EntryPoint = "?LAS_GetShutterStatus@@YAHH@Z")]
        public static extern bool LAS_GetShutterStatus(Int32 num);

        //DLLEXPORT BOOL LAS_GetShutterStatus(int num);               //���oShutter���A (num 1~2)
        [DllImport("LaserControl.dll", EntryPoint = "?LAS_GetShutterStatus@@YAHH@Z")]
        public static extern bool LAS_ChangeRegularQuery(Int32 num);

        //DLLEXPORT BOOL LAS_GetShutterStatus(int num);               //���oShutter���A (num 1~2)
        [DllImport("LaserControl.dll", EntryPoint = "?LAS_ReadFPGA@@YAHH@Z")]
        public static extern float LAS_ReadFPGA(Int32 num);

        [DllImport("LaserControl.dll", EntryPoint = "?LAS_SetShutterON@@YAXH@Z")]
        public static extern float LAS_SetShutterON(Int32 num);

        [DllImport("LaserControl.dll", EntryPoint = "?LAS_SetShutterOFF@@YAXH@Z")]
        public static extern float LAS_SetShutterOFF(Int32 num);

        //DLLEXPORT void LAS_Motor_RealPluseMove(int NumOfMotor,int pluse,int dir);  //Dir:0 ����  1 ����  //�u�}�� NumOfMotor = 7
        [DllImport("LaserControl.dll", EntryPoint = "?LAS_Motor_RealPluseMove@@YAXHHH@Z")]
        public static extern float LAS_Motor_RealPluseMove(Int32 num, Int32 pluse, Int32 dir);

        //DLLEXPORT BOOL LAS_SetFireSH(int type);                     //�]�w�p�g���o�ɥ���Shutter�}�Ҫ��A  Type:0 ���� 1:SH1�}  2:SH2�}
        [DllImport("LaserControl.dll", EntryPoint = "?LAS_SetFireSH@@YAHH@Z")]
        public static extern float LAS_SetFireSH(Int32 num);
        #endregion

        #region �p�g�Ҳժ�l�� �]�A�s�u�إ߻PCallBack Func. & ���F��m��l�� & �Ѽƪ�l��
        [UnmanagedFunctionPointer (CallingConvention.Cdecl)]
        public delegate Int32 LaserProcessCallBack(Int32 iChannel, Int32 iCmdType, Int32 iErrCode, IntPtr pData);

        [DllImport("LaserControl.dll", EntryPoint = "?LAS_LaserContrelInit@@YAHXZ")]
        public static extern bool LAS_LaserContrelInit();

        [DllImport("LaserControl.dll", EntryPoint = "?LAS_LaserContrelRelease@@YAHXZ")]
        public static extern bool LAS_LaserContrelRelease();

        #region Laser Source ����
        /// <summary>
        /// �p�gsource��l�� ����Power Warm��Ready
        /// </summary>
        /// <returns></returns>
        [DllImport("LaserControl.dll", EntryPoint = "?LAS_Source_Initial@@YAXXZ")]
        public static extern bool LAS_Source_Initial();

        /// <summary>
        /// �߰ݹp�g��l�ƺX�Ъ��A(�O�_Ready)
        /// </summary>
        /// <returns></returns>
        [DllImport("LaserControl.dll", EntryPoint = "?LAS_Source_GetLaserReadyS@@YAHXZ")]
        public static extern bool LAS_Source_GetLaserReadyS();

        /// <summary>
        /// �߰�Laser Source Shutter���A
        /// </summary>
        /// <returns></returns>
        [DllImport("LaserControl.dll", EntryPoint = "?LAS_Source_QuerySHStatus@@YAXXZ")]
        public static extern bool LAS_Source_QuerySHStatus();

        /// <summary>
        /// �߰�Laser Source Shutter���A
        /// </summary>
        /// <returns></returns>
        [DllImport("LaserControl.dll", EntryPoint = "?LAS_Source_SHON@@YAXXZ")]
        public static extern bool LAS_Source_SHON();

        /// <summary>
        /// ����Laser Source Shutter OFF
        /// </summary>
        /// <returns></returns>
        [DllImport("LaserControl.dll", EntryPoint = "?LAS_Source_SHOFF@@YAXXZ")]
        public static extern bool LAS_Source_SHOFF();

        #endregion

        #region �վ��M��

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

        // DLLEXPORT void LAS_Motor_RealMove(int NumOfMotor,BYTE *data_send,int dir);  //Dir:0 ����  1 ����

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

        //�p�g��������禡

        /// <summary>
        /// �p�g���o
        /// </summary>
        public void LaserStartFire()
        {
            SendCommand((char)RequestCommand.LaserFire);
        }
        
        /// <summary>
        /// �p�g�������o
        /// </summary>
        public void LaserStopFire()
        {
            SendCommand((char)RequestCommand.LaserStop);
        }

        /// <summary>
        /// ���F�@Home�C
        /// </summary>
        /// <param name="p_iMotorNum">���F�s��</param>
        public void MotorHome(int p_iMotorNum)
        {
            if (p_iMotorNum <= 0 || p_iMotorNum > MAX_MOTOR_NUM)
                return;

            int iCmdOffset = 0x10 * (p_iMotorNum - 1);          
            char realCommand =  (char)((char)RequestCommand.Motor1Home + (char)iCmdOffset);

            SendCommand (realCommand );
        }

        /// <summary>
        /// ���F�O�_���L���C
        /// </summary>
        /// <param name="p_iMotorNum">���F�s��</param>
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
        /// �]�wShutter�}�ҩάO�����C
        /// </summary>
        /// <param name="p_iShutterNum">Shutter�s��</param>
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

        //�p�g�]�w�����禡
        /// <summary>
        /// �]�w���F�kHome�ѼơC
        /// </summary>
        /// <param name="p_iMotorNum">���F�s��</param>
        /// <param name="p_data">�ѼƸ��</param>
        public void MotorSetHomePara(int p_iMotorNum, char[] p_data)
        {
            char cmd = GetAssociatedCmdByMotor(p_iMotorNum, RequestCommand.SetupMotor1HomePara);
            if (cmd != '0')
                SendCommand(cmd, p_data);
        }

        /// <summary>
        /// �]�w�I�حȡC
        /// </summary>
        /// <param name="p_iMotorNum">���F�s��</param>
        /// <param name="p_data">�I�ح�</param>
        public void MotorSetGap(int p_iMotorNum, char[] p_data)
        {
            char cmd = GetAssociatedCmdByMotor(p_iMotorNum, RequestCommand.SetupMotor1BackGap);
            if (cmd != '0')
                SendCommand(cmd, p_data);
        }

        /// <summary>
        /// �]�w���F�t�סC
        /// </summary>
        /// <param name="p_iMotorNum">���F�s��</param>
        /// <param name="p_data">�t��</param>
        public void MotorSetSpeed(int p_iMotorNum, char[] p_data)
        {
            char cmd = GetAssociatedCmdByMotor(p_iMotorNum, RequestCommand.SetupMotor1Speed);
            if (cmd != '0')
                SendCommand(cmd, p_data);
        }

        /// <summary>
        /// �]�wTable�ȡC
        /// </summary>
        /// <param name="p_iMotorNum">���F�s��</param>
        /// <param name="p_data">Table���</param>
        public void MotorSetTable(int p_iMotorNum, char[] p_data)
        {
            char cmd = GetAssociatedCmdByMotor(p_iMotorNum, RequestCommand.SetupMotor1Table);
            if (cmd != '0')
                SendCommand(cmd, p_data);
        }
     
        /// <summary>
        /// Ū�� Table �ȶi�沾�ʫ��O�C
        /// </summary>
        /// <param name="p_iMotorNum">���F�s��</param>
        /// <param name="p_data">Table���</param>
        public void ReadTableAndRunMotor(int p_iMotorNum, char[] p_data)
        {
            char cmd = GetAssociatedCmdByMotor(p_iMotorNum, RequestCommand.ReadMotor1TableAndMove);
            if (cmd != '0')
                SendCommand(cmd, p_data);
        }

        /// <summary>
        /// �]�w�p�g�ѼơC
        /// </summary>
        /// <param name="p_dPower"></param>
        public void SetPower(double p_dPower)
        {

        }

        /// <summary>
        /// �]�w�p�g�i���C
        /// </summary>
        /// <param name="p_Wavelength"></param>
        public void SetWaveLength(double p_Wavelength)
        {

        }

        /// <summary>
        /// �]�wSlit�j�p�C
        /// </summary>
        public void SetSlit(double p_dSlitx, double p_dSlity)
        {

        }

        /// <summary>
        /// �]�w�������O�_ON�C
        /// </summary>
        /// <param name="p_dAngle"></param>
        public void SetColorFilter(bool p_bOn)
        {

        }

        /// <summary>
        /// �]�w�����O���ਤ�סC
        /// </summary>
        /// <param name="p_dAngle"></param>
        public void SetColorFilterAngle(double p_dAngle)
        {

        }

        /// <summary>
        /// �p�gShutter�ثe���A
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
        UnknowCommandError = '\x01', // �L�ī��O
        CRCError = '\x02', // CRC���~
        LaserWarmUpError = '\x03', // �p�g���x�}�����~
        KnowHowIOError = '\x04', // Know How �}���QĲ�o
        LaserInterlockIOError = '\x05', // Laser Interlock �}���QĲ�o
        MachineEMIOError = '\x06', // Machine EM �}���QĲ�o
        MotorBusyError = '\x07', // ���F�B�ণ�L��
        TableOutOfRangeError = '\x08', // Table�g�J/Ū����ƶW�L�d��
        LaserShutterOnError = '\x09', // Laser Shutter On ���~
        LaserShutterOffError = '\x0A', // Laser Shutter Off ���~
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

            // 5. CRC : ���o�n�p��CRC����ơG LEN + CMD + DATA            
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

            // TODO: �p�G enum parse ���ѡA�|��XException
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
