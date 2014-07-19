using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using SDDEMsg;
using System.IO.Ports;
using Maintain;

namespace CIM
{
    public class CIM_Schedule
    {
        private static CIM_Schedule singleton = null;

        private PLC_Interface.CCPLC_Component objForPLCHandshake = PLC_Monitor.getSingleton().ccplC_Component1;

        private int m_iRecipeChangeIdx = 0;
        private int m_iLoadHandshakeIdx = 0;
        private int m_iUnloadHandshakeIdx = 0;
        private int m_iExchangeHandshakeIdx = 0;
        private int m_iMismatchHandshakeIdx = 0;

        #region singal
        private int m_iRecipeChangeRequest = 0;

        private int m_iLDAutoOperationRun = 0;
        private int m_iSupplyEnd = 0;
        private int m_iEQAutoOperationRun = 0;

        private int m_iDelivering = 0;

        private int m_iLoadReady = 0;
        private int m_iLoadComplate = 0;
        private int m_iLoadCancel = 0;

        private int m_iUnloadReady = 0;
        private int m_iUnloadComplate = 0;
        private int m_iUnloadCancel = 0;

        private int m_iExchangeReady = 0;
        private int m_iExchangeComplate = 0;

        private int m_iCIMPCSingal = 0;
        private bool m_iReportAlarm = false;
        #endregion

        private DateTime m_dtCIMPCStopTime = new DateTime(2000, 1, 1);

        private int m_iPreviewLoadHandshakeIdx = 0;
        private int m_iPreviewUnloadHandshakeIdx = 0;
        private int m_iPreviewExchangeHandshakeIdx = 0;

        private enumAbnormalReleaseCase m_enumLoadAlarmReleaseCase = enumAbnormalReleaseCase.None;
        private enumEqStatus m_enumNowEqStatus = enumEqStatus.Stop;
        private bool m_bAbnormal = false;
        private bool m_bMismatch = false;
        private bool m_bRecipeChangeOK = true;

        private DateTime m_iMismatchStartTime = DateTime.Now;
        private int m_iMismatchRetryCount = 0;

        private Thread objThread = null;

        private bool m_bReportAlarmFlag = false;
        private Queue<string> m_aszAlarmMsg = new Queue<string>();
        private bool m_bReportLightFlag = true;
        private Queue<string> m_aszLightMsg = new Queue<string>();


        #region Damon Add 20100722, for handshake flag
        private bool m_bLoadHandshake = false;
        private bool m_bUnloadHandshake = false;
        private bool m_bExchangeHandshake = false;
        public bool LoadHandshakeFlag
        {
            get { return m_bLoadHandshake; }
            set { m_bLoadHandshake = value; }
        }

        public bool UnloadHandshakeFlag
        {
            get { return m_bUnloadHandshake; }
            set { m_bUnloadHandshake = value; }
        }

        public bool ExchangeHandshakeFlag
        {
            get { return m_bExchangeHandshake; }
            set { m_bExchangeHandshake = value; }
        }

        public int SupplyEndSingal
        {
            get { return m_iSupplyEnd; }
        }

        #endregion

        public Datalog.DatalogUnitControl USLog = new Datalog.DatalogUnitControl("US Log");
        public Datalog.DatalogUnitControl EQLog = new Datalog.DatalogUnitControl("EQ Log");
        public Datalog.DatalogUnitControl LoaderLog = new Datalog.DatalogUnitControl("Loader Log");
        public Datalog.DatalogUnitControl UnLoaderLog = new Datalog.DatalogUnitControl("UnLoader Log");
        public Datalog.DatalogUnitControl ExchangeLog = new Datalog.DatalogUnitControl("Exchange Log");
        public Datalog.DatalogUnitControl GlassLoadLog = new Datalog.DatalogUnitControl("GlassLoad Log");
        public Datalog.DatalogUnitControl GlassUnLoadLog = new Datalog.DatalogUnitControl("GlassUnLoad Log");
        public Datalog.DatalogUnitControl GlassRemoveLog = new Datalog.DatalogUnitControl("GlassRemove Log");
        private Int64 m_iUSStatus = 0;
        private Int64 m_iEqStatus = 0;
        private Int64 m_iLoaderStatus = 0;
        private Int64 m_iUnLoaderStatus = 0;
        private Int64 m_iExchangeStatus = 0;

        public CIM_Schedule()
        {
            //InitHandshakeBit();

            objThread = new Thread(new ThreadStart(AllHandshake));
            objThread.Start();
        }

        public void Destory()
        {
            objThread.Abort();
            singleton = null;
        }

        public static CIM_Schedule getSingleton()
        {
            if (singleton == null)
            {
                singleton = new CIM_Schedule();
            }
            return singleton;
        }

        private void AllHandshake()
        {
            while (true)
            {
                #region 檢查訊號
                #region 檢查 Recipe Change Request
                objForPLCHandshake.Get_PLC_Data(CCCIM_HandshakeBitLoaderForUnit1.RecipeChangeRequest, ref m_iRecipeChangeRequest);
                #endregion

                #region 檢查 Auto Operation Run & SupplyEnd
                objForPLCHandshake.Get_PLC_Data(CCCIM_HandshakeBitLoaderForAll.AutoOperationStatus, ref m_iLDAutoOperationRun);
                objForPLCHandshake.Get_PLC_Data(CCCIM_HandshakeBitLoaderForAll.SupplyEnd, ref m_iSupplyEnd);
                objForPLCHandshake.Get_PLC_Data(CCCIM_HandshakeBitEQUnit1.AutoOperationStatus, ref m_iEQAutoOperationRun);
                #endregion

                #region 檢查 Deliver
                objForPLCHandshake.Get_PLC_Data(CCCIM_HandshakeBitLoaderForUnit1.Delivering, ref m_iDelivering);
                #endregion

                #region 檢查 Loader訊號
                objForPLCHandshake.Get_PLC_Data(CCCIM_HandshakeBitLoaderForUnit1.LoadReady, ref m_iLoadReady);
                objForPLCHandshake.Get_PLC_Data(CCCIM_HandshakeBitLoaderForUnit1.LoadComplete, ref m_iLoadComplate);
                objForPLCHandshake.Get_PLC_Data(CCCIM_HandshakeBitLoaderForUnit1.LoadCancel, ref m_iLoadCancel);
                #endregion

                #region 檢查 Unloader訊號
                objForPLCHandshake.Get_PLC_Data(CCCIM_HandshakeBitLoaderForUnit1.UnloadReady, ref m_iUnloadReady);
                objForPLCHandshake.Get_PLC_Data(CCCIM_HandshakeBitLoaderForUnit1.UnloadComplete, ref m_iUnloadComplate);
                objForPLCHandshake.Get_PLC_Data(CCCIM_HandshakeBitLoaderForUnit1.UnloadCancel, ref m_iUnloadCancel);
                #endregion

                #region 檢查 Exchange 訊號
                objForPLCHandshake.Get_PLC_Data(CCCIM_HandshakeBitLoaderForUnit1.ExchangeReady, ref m_iExchangeReady);
                objForPLCHandshake.Get_PLC_Data(CCCIM_HandshakeBitLoaderForUnit1.ExchangeComplete, ref m_iExchangeComplate);
                #endregion

                #region 檢查 CIM/PC 訊號
                objForPLCHandshake.Get_PLC_Data(CCCIM_HandshakeBitBCForAll.CIMStatus, ref m_iCIMPCSingal);
                if (m_iCIMPCSingal == 0)
                {
                    if (m_iReportAlarm != true)
                    {
                        if (m_dtCIMPCStopTime.Year == 2000)
                        {
                            m_dtCIMPCStopTime = DateTime.Now;
                        }
                        else
                        {
                            TimeSpan tmpTime = DateTime.Now.Subtract(m_dtCIMPCStopTime);
                            if (tmpTime.Seconds > 10)
                            {
                                Common.GlobalValue.AlarmQueue.Enqueue("E1000");
                                m_iReportAlarm = true;
                            }
                        }
                    }
                }
                else
                {
                    m_dtCIMPCStopTime = new DateTime(2000, 1, 1);
                    m_iReportAlarm = false;
                }

                //objForPLCHandshake.Set_PLC_Data(CCCIM_HandshakeEqUnit1ES05.NumberOfGlass_1, (Common.GlobalValue.GlassProcessStatus[1] ? 1 : 0) + (Common.GlobalValue.GlassProcessStatus[2] ? 1 : 0));
                #endregion

                #endregion

                if (m_iRecipeChangeRequest == 1)
                {
                    RecipeChange();
                }

                {
                    LogUSStatus();
                    LogEQStatus();
                    LogLoadHandshake();
                    LogUnLoadHandshake();
                    LogExchangeHandshake();
                }

                LoadHandshake();
                UnloadHandshake();
                ExchangeHandshake();

                ReportAlarm();
                ReportLight();

                // test
                Scenario.StageScenarioExecute();
                Scenario.TunrUnitScenarioExecute();
                CCVCRScenario.ScenarioExecute();

                if (m_bMismatch == true)
                {
                    DataMismatch();
                }

                Thread.Sleep(1);
            }
        }

        #region Handshake Function
        private void RecipeChange()
        {
            if (objForPLCHandshake._7_Enable_)
            {
                if (m_iRecipeChangeRequest == 1)
                {
                    switch (RecipeChangeIdx)
                    {
                        case 0:
                            objForPLCHandshake.Set_PLC_Data(CCCIM_HandshakeBitEQUnit1.RecipeChangeAcceptance, 0);
                            RecipeChangeOK = false;
                            RecipeChangeIdx = 10;
                            RecipeDataGet();
                            break;

                        case 10:
                            if (RecipeChangeOK == true)
                            {
                                RecipeChangeIdx = 20;
                            }
                            break;

                        case 30:
                            objForPLCHandshake.Set_PLC_Data(CCCIM_HandshakeBitEQUnit1.RecipeChangeAcceptance, 1);
                            RecipeChangeIdx = 0;
                            break;
                    }
                }
            }
        }

        private void LoadHandshake()
        {
            if (objForPLCHandshake._7_Enable_)
            {

                if (m_iLDAutoOperationRun != 1 && m_bAbnormal == false && LoadHandshakeIdx != 0)
                {
                    m_bAbnormal = true;
                    m_iPreviewLoadHandshakeIdx = LoadHandshakeIdx;
                    LoadHandshakeIdx = 110;
                }

                if (m_iEQAutoOperationRun != 1 && m_bAbnormal == false && LoadHandshakeIdx != 0)
                {
                    m_bAbnormal = true;
                    m_iPreviewLoadHandshakeIdx = LoadHandshakeIdx;
                    LoadHandshakeIdx = -99;
                }

                if (m_bAbnormal == true && m_iLoadComplate == 1)
                {

                    objForPLCHandshake.Set_PLC_Data(CCCIM_HandshakeBitEQUnit1.LoadRequest, 0);
                    objForPLCHandshake.Set_PLC_Data(CCCIM_HandshakeBitEQUnit1.LoadOK, 0);
                    LoadHandshakeIdx = 0;

                    if (Common.GlobalValue.GlassProcessStatus[1] == false)
                    {
                        GlassDataExist(1);
                    }
                    else
                    {
                        GlassDataExist(2);
                    }

                    m_bAbnormal = false;

                }

                switch (LoadHandshakeIdx)
                {
                    case 0:
                        break;

                    #region Normal
                    case 10:
                        objForPLCHandshake.Set_PLC_Data(CCCIM_HandshakeBitEQUnit1.LoadRequest, 1);
                        LoadHandshakeIdx = 20;

                        m_bLoadHandshake = false;
                        break;

                    case 20:
                        if (m_iLoadReady == 1)
                        {
                            if (GlassDataExchangeGet() != 0)
                            {
                                objForPLCHandshake.Set_PLC_Data(CCCIM_HandshakeBitEQUnit1.DeliveryCancelRequest, 1);
                                objForPLCHandshake.Set_PLC_Data(CCCIM_HandshakeBitEQUnit1.LoadRequest, 0);
                                Common.GlobalValue.AlarmQueue.Enqueue("E1001");
                                LoadHandshakeIdx = 0;
                                break;
                            }

                            LoadHandshakeIdx = 30;
                        }
                        break;


                    case 30:
                        if (m_iLoadReady == 1)
                        {
                            objForPLCHandshake.Set_PLC_Data(CCCIM_HandshakeBitEQUnit1.LoadOK, 1);

                            EQStatus = enumEqStatus.Run;
                            LoadHandshakeIdx = 40;
                        }
                        break;


                    case 40:
                        if (m_iLoadReady == 1)
                        {
                            if (m_iDelivering == 1)
                            {
                                LoadHandshakeIdx = 50;
                            }
                        }
                        break;

                    case 50:
                        if (m_iLoadReady == 1)
                        {
                            if (m_iDelivering == 0)
                            {
                                LoadHandshakeIdx = 60;
                            }
                        }
                        break;

                    case 60:
                        if (m_iLoadReady == 1)
                        {
                            if (m_iLoadComplate == 1)
                            {
                                objForPLCHandshake.Set_PLC_Data(CCCIM_HandshakeBitEQUnit1.LoadRequest, 0);
                                objForPLCHandshake.Set_PLC_Data(CCCIM_HandshakeBitEQUnit1.LoadOK, 0);
                                LoadHandshakeIdx = 70;

                                if (Common.GlobalValue.GlassProcessStatus[1] == false)
                                {
                                    GlassDataExist(1);
                                }
                                else
                                {
                                    GlassDataExist(2);
                                }
                            }
                        }
                        break;

                    case 70:
                        if (m_iLoadReady == 0 && m_iLoadComplate == 0)
                        {
                            LoadHandshakeIdx = 0;
                            m_bLoadHandshake = true;

                        }
                        break;
                    #endregion

                    #region Abnormal 1
                    case 110:
                        if (m_iLDAutoOperationRun == 0)
                        {
                            if (m_iLoadComplate == 1)
                            {
                                LoadHandshakeIdx = m_iPreviewLoadHandshakeIdx;
                                m_bAbnormal = false;
                            }
                            else if (m_iLoadCancel == 1)
                            {
                                InitHandshakeBit();
                                LoadHandshakeIdx = 120;
                            }
                        }
                        break;

                    case 120:
                        if (m_iLDAutoOperationRun == 1)
                        {
                            LoadHandshakeIdx = 10;
                            m_bAbnormal = false;
                        }
                        break;
                    #endregion

                    #region Abnormal 2 or 3
                    case -99:
                        switch (m_enumLoadAlarmReleaseCase)
                        {
                            case enumAbnormalReleaseCase.None:
                                break;

                            case enumAbnormalReleaseCase.Recovery:
                                LoadHandshakeIdx = 210;
                                break;

                            case enumAbnormalReleaseCase.Cancel:
                                LoadHandshakeIdx = 310;
                                break;
                        }
                        break;

                    #region Abnormal 2
                    case 210:
                        if (m_iEQAutoOperationRun == 1)
                        {
                            LoadHandshakeIdx = 220;
                        }
                        break;

                    case 220:
                        LoadHandshakeIdx = m_iPreviewLoadHandshakeIdx;
                        m_bAbnormal = false;
                        break;
                    #endregion

                    #region Abnormal 3
                    case 310:
                        if (m_iEQAutoOperationRun != 1)
                        {
                            objForPLCHandshake.Set_PLC_Data(CCCIM_HandshakeBitEQUnit1.LoadRequest, 0);
                            objForPLCHandshake.Set_PLC_Data(CCCIM_HandshakeBitEQUnit1.LoadOK, 0);
                            objForPLCHandshake.Set_PLC_Data(CCCIM_HandshakeBitEQUnit1.DeliveryCancelRequest, 1);
                            LoadHandshakeIdx = 320;
                        }
                        break;

                    case 320:
                        if (m_iEQAutoOperationRun != 1)
                        {
                            if (m_iDelivering == 0 && m_iLoadReady == 0)
                            {
                                LoadHandshakeIdx = 330;
                            }
                        }
                        break;

                    case 330:
                        if (m_iEQAutoOperationRun != 1)
                        {
                            objForPLCHandshake.Set_PLC_Data(CCCIM_HandshakeBitEQUnit1.DeliveryCancelRequest, 0);
                            LoadHandshakeIdx = 340;
                        }
                        break;

                    case 340:
                        if (m_iLDAutoOperationRun == 0)
                        {
                            LoadHandshakeIdx = 350;
                        }
                        break;

                    case 350:
                        if (m_iLDAutoOperationRun == 1)
                        {
                            LoadHandshakeIdx = 0;
                            m_bAbnormal = false;
                        }
                        break;
                    #endregion
                    #endregion

                }
            }
        }

        private void UnloadHandshake()
        {
            if (objForPLCHandshake._7_Enable_)
            {
                if (m_iLDAutoOperationRun != 1 && m_bAbnormal == false && UnloadHandshakeIdx != 0)
                {
                    m_bAbnormal = true;
                    m_iPreviewUnloadHandshakeIdx = UnloadHandshakeIdx;
                    UnloadHandshakeIdx = 110;
                }

                switch (UnloadHandshakeIdx)
                {
                    case 0:
                        break;

                    #region Normal
                    case 10:
                        GlassDataExchangeSet(Common.GlobalValue.UnloadGlass);
                        UnloadHandshakeIdx = 20;

                        m_bUnloadHandshake = false;
                        break;


                    case 20:
                        objForPLCHandshake.Set_PLC_Data(CCCIM_HandshakeBitEQUnit1.UnloadRequest, 1);
                        UnloadHandshakeIdx = 30;
                        break;

                    case 30:
                        if (m_iUnloadReady == 1)
                        {
                            objForPLCHandshake.Set_PLC_Data(CCCIM_HandshakeBitEQUnit1.UnloadOK, 1);
                            UnloadHandshakeIdx = 40;
                        }
                        break;


                    case 40:
                        if (m_iUnloadReady == 1)
                        {
                            if (m_iDelivering == 1)
                            {
                                UnloadHandshakeIdx = 50;
                            }
                        }
                        break;

                    case 50:
                        if (m_iUnloadReady == 1)
                        {
                            if (m_iDelivering == 0)
                            {
                                UnloadHandshakeIdx = 60;
                            }
                        }
                        break;

                    case 60:
                        if (m_iUnloadReady == 1)
                        {
                            if (m_iUnloadComplate == 1)
                            {
                                objForPLCHandshake.Set_PLC_Data(CCCIM_HandshakeBitEQUnit1.UnloadRequest, 0);
                                objForPLCHandshake.Set_PLC_Data(CCCIM_HandshakeBitEQUnit1.UnloadOK, 0);
                                UnloadHandshakeIdx = 70;

                                GlassDataClear(Common.GlobalValue.UnloadGlass);
                                EQStatus = enumEqStatus.Idle;
                            }
                        }
                        break;

                    case 70:
                        if (m_iUnloadReady == 0 && m_iUnloadComplate == 0)
                        {
                            UnloadHandshakeIdx = 0;
                            m_bUnloadHandshake = true;
                        }
                        break;
                    #endregion

                    #region Abnormal 1
                    case 110:
                        if (m_iLDAutoOperationRun == 0)
                        {
                            if (m_iUnloadComplate == 1)
                            {
                                UnloadHandshakeIdx = m_iPreviewUnloadHandshakeIdx;
                                m_bAbnormal = false;
                            }
                            else if (m_iUnloadCancel == 1)
                            {
                                InitHandshakeBit();
                                UnloadHandshakeIdx = 120;
                            }
                        }
                        break;

                    case 120:
                        if (m_iLDAutoOperationRun == 1)
                        {
                            UnloadHandshakeIdx = 10;
                            m_bAbnormal = false;
                        }
                        break;
                    #endregion
                }
            }
        }

        private void ExchangeHandshake()
        {
            if (objForPLCHandshake._7_Enable_)
            {
                if (m_iLDAutoOperationRun != 1 && m_bAbnormal == false && ExchangeHandshakeIdx != 0)
                {
                    if ((ExchangeHandshakeIdx / 5) % 2 == 1)
                    {
                        m_bAbnormal = true;
                        m_iPreviewExchangeHandshakeIdx = ExchangeHandshakeIdx;
                        ExchangeHandshakeIdx = 110;
                    }
                }

                switch (ExchangeHandshakeIdx)
                {
                    case 0:
                        break;

                    #region Normal
                    case 10:
                        GlassDataExchangeSet(Common.GlobalValue.UnloadGlass);
                        ExchangeHandshakeIdx = 20;

                        m_bExchangeHandshake = false;
                        break;


                    case 20:
                        if (m_iSupplyEnd == 0)
                        {
                            ExchangeHandshakeIdx = 30;
                        }
                        else
                        {
                            ExchangeHandshakeIdx = 35;
                        }
                        break;

                    #region Loading Glass
                    case 30:
                        objForPLCHandshake.Set_PLC_Data(CCCIM_HandshakeBitEQUnit1.ExchangeRequest, 1);

                        ExchangeHandshakeIdx = 40;
                        break;

                    case 40:
                        if (m_iExchangeReady == 1)
                        {
                            if (GlassDataExchangeGet() != 0)
                            {
                                objForPLCHandshake.Set_PLC_Data(CCCIM_HandshakeBitEQUnit1.DeliveryCancelRequest, 1);
                                objForPLCHandshake.Set_PLC_Data(CCCIM_HandshakeBitEQUnit1.ExchangeRequest, 0);
                                Common.GlobalValue.AlarmQueue.Enqueue("E1001");
                                ExchangeHandshakeIdx = 0;
                                break;
                            }

                            ExchangeHandshakeIdx = 50;
                        }
                        else if (m_iUnloadReady == 1)
                        {
                            ExchangeHandshakeIdx = 35;
                        }
                        break;

                    case 50:
                        if (m_iExchangeReady == 1)
                        {
                            objForPLCHandshake.Set_PLC_Data(CCCIM_HandshakeBitEQUnit1.ExchangeOK, 1);
                            ExchangeHandshakeIdx = 60;
                        }
                        break;

                    case 60:
                        if (m_iExchangeReady == 1)
                        {
                            if (m_iDelivering == 1)
                            {
                                ExchangeHandshakeIdx = 70;
                            }
                        }
                        break;

                    case 70:
                        if (m_iExchangeReady == 1)
                        {
                            if (m_iDelivering == 0)
                            {
                                ExchangeHandshakeIdx = 80;
                            }
                        }
                        break;

                    case 80:
                        if (m_iExchangeReady == 1)
                        {
                            if (m_iExchangeComplate == 1)
                            {
                                objForPLCHandshake.Set_PLC_Data(CCCIM_HandshakeBitEQUnit1.ExchangeRequest, 0);
                                objForPLCHandshake.Set_PLC_Data(CCCIM_HandshakeBitEQUnit1.ExchangeOK, 0);
                                ExchangeHandshakeIdx = 90;
                            }
                        }
                        break;

                    case 90:
                        if (m_iExchangeReady == 0 && m_iExchangeComplate == 0)
                        {
                            //if (Common.GlobalValue.GlassProcessStatus[Common.GlobalValue.UnloadGlass] == false)
                            {
                                GlassDataExist(Common.GlobalValue.UnloadGlass);
                            }

                            ExchangeHandshakeIdx = 0;

                            m_bExchangeHandshake = true;
                        }
                        break;
                    #endregion

                    #region No Loading Glass
                    case 35:
                        if (m_iUnloadReady == 1)
                        {
                            objForPLCHandshake.Set_PLC_Data(CCCIM_HandshakeBitEQUnit1.UnloadOK, 1);
                            ExchangeHandshakeIdx = 45;
                        }
                        break;

                    case 45:
                        if (m_iUnloadReady == 1)
                        {
                            if (m_iDelivering == 1)
                            {
                                ExchangeHandshakeIdx = 55;
                            }
                        }
                        break;

                    case 55:
                        if (m_iUnloadReady == 1)
                        {
                            if (m_iDelivering == 0)
                            {
                                ExchangeHandshakeIdx = 65;
                            }
                        }
                        break;

                    case 65:
                        if (m_iUnloadReady == 1)
                        {
                            if (m_iUnloadComplate == 1)
                            {
                                objForPLCHandshake.Set_PLC_Data(CCCIM_HandshakeBitEQUnit1.ExchangeRequest, 0);
                                objForPLCHandshake.Set_PLC_Data(CCCIM_HandshakeBitEQUnit1.UnloadOK, 0);
                                ExchangeHandshakeIdx = 75;
                            }
                        }
                        break;

                    case 75:
                        if (m_iExchangeReady == 0 && m_iUnloadComplate == 0)
                        {
                            GlassDataClear(Common.GlobalValue.UnloadGlass);
                            ExchangeHandshakeIdx = 0;

                            m_bExchangeHandshake = true;
                        }
                        break;
                    #endregion
                    #endregion

                    #region Abnormal 1
                    case 110:
                        if (m_iLDAutoOperationRun == 0)
                        {
                            if (m_iUnloadComplate == 1)
                            {
                                ExchangeHandshakeIdx = m_iPreviewExchangeHandshakeIdx;
                                m_bAbnormal = false;
                            }
                            else if (m_iUnloadCancel == 1)
                            {
                                InitHandshakeBit();
                                ExchangeHandshakeIdx = 120;
                            }
                        }
                        break;

                    case 120:
                        if (m_iLDAutoOperationRun == 1)
                        {
                            ExchangeHandshakeIdx = 10;
                            m_bAbnormal = false;
                        }
                        break;
                    #endregion
                }
            }
        }

        public void InitHandshakeBit()
        {
            objForPLCHandshake.Set_PLC_Data(CCCIM_HandshakeBitEQUnit1.RecipeChangeAcceptance, 0);
            objForPLCHandshake.Set_PLC_Data(CCCIM_HandshakeBitEQUnit1.LoadRequest, 0);
            objForPLCHandshake.Set_PLC_Data(CCCIM_HandshakeBitEQUnit1.LoadOK, 0);
            objForPLCHandshake.Set_PLC_Data(CCCIM_HandshakeBitEQUnit1.DeliveryCancelRequest, 0);
            objForPLCHandshake.Set_PLC_Data(CCCIM_HandshakeBitEQUnit1.UnloadRequest, 0);
            objForPLCHandshake.Set_PLC_Data(CCCIM_HandshakeBitEQUnit1.UnloadOK, 0);
            objForPLCHandshake.Set_PLC_Data(CCCIM_HandshakeBitEQUnit1.ExchangeRequest, 0);
            objForPLCHandshake.Set_PLC_Data(CCCIM_HandshakeBitEQUnit1.ExchangeOK, 0);

        }

        private void DataMismatch()
        {
            if (objForPLCHandshake._7_Enable_)
            {
                switch (MismatchHandshakeIdx)
                {
                    case 0:
                        break;

                    case 10:
                        objForPLCHandshake.Set_PLC_Data(CCCIM_HandshakeBitEQUnit1.MissmatchGlassInformationRequest, 1);
                        m_iMismatchStartTime = DateTime.Now;
                        MismatchHandshakeIdx = 20;
                        break;

                    case 20:
                        int iMissmatchGlassInformationExist = 0;
                        int iMissmatchGlassInformationNone = 0;

                        objForPLCHandshake.Get_PLC_Data(CCCIM_HandshakeBitBCForUnit1.MissmatchGlassInformationExist, ref iMissmatchGlassInformationExist);
                        objForPLCHandshake.Get_PLC_Data(CCCIM_HandshakeBitBCForUnit1.MissmatchGlassInformationNone, ref iMissmatchGlassInformationNone);

                        if (iMissmatchGlassInformationExist == 1)
                        {
                            MismatchHandshakeIdx = 33;
                        }
                        else if (iMissmatchGlassInformationNone == 1)
                        {
                            MismatchHandshakeIdx = 34;
                        }
                        else
                        {
                            MismatchHandshakeIdx = 35;
                        }
                        break;

                    case 33:
                        break;

                    case 34:
                        break;

                    case 35:
                        if (m_iMismatchRetryCount <= 3)
                        {
                            if (DateTime.Now.Subtract(m_iMismatchStartTime).Milliseconds > 5000)
                            {
                                Thread.Sleep(1000);
                                MismatchHandshakeIdx = 10;
                                m_iMismatchRetryCount++;
                            }
                        }
                        else
                        {
                            MismatchHandshakeIdx = 36;
                        }
                        break;

                    case 36:
                        break;
                }
            }
        }
        #endregion

        private int GlassDataExchangeGet()
        {
            if (objForPLCHandshake._7_Enable_)
            {
                int[] tmpPLCData = new int[50];
                Common.CCGlassData tmpGlassData = new Common.CCGlassData();

                objForPLCHandshake.Get_PLC_Data(CCCIM_HandshakeWordLoaderForUnit1.LoadGlassData_2, 2, ref tmpPLCData);
                tmpGlassData.SlotNo = tmpPLCData[0] & 0x00FF;
                tmpGlassData.CassetteNo = (tmpPLCData[0] & 0x3F00) >> 8;
                tmpGlassData.KindNo = tmpPLCData[1] & 0x03FF;
                tmpGlassData.PortNo = (tmpPLCData[0] & 0xF000) >> 12;

                if (tmpGlassData.SlotNo == 0)
                {
                    return -1;
                }
                else if (tmpGlassData.CassetteNo == 0)
                {
                    return -2;
                }

                objForPLCHandshake.Get_PLC_Data(CCCIM_HandshakeWordLoaderForUnit1.BatchID_8, 8, ref tmpPLCData);
                tmpGlassData.BatchID = "";
                for (int iCount = 0; iCount < 8; iCount++)
                {
                    tmpGlassData.BatchID += (char)(tmpPLCData[iCount] & 0x00FF);
                    tmpGlassData.BatchID += (char)((tmpPLCData[iCount] & 0xFF00) >> 8);
                }

                objForPLCHandshake.Get_PLC_Data(CCCIM_HandshakeWordLoaderForUnit1.BatchType_8, 8, ref tmpPLCData);
                for (int iCount = 0; iCount < 8; iCount++)
                {
                    tmpGlassData.BatchType += (char)(tmpPLCData[iCount] & 0x00FF);
                    tmpGlassData.BatchType += (char)((tmpPLCData[iCount] & 0xFF00) >> 8);
                }

                objForPLCHandshake.Get_PLC_Data(CCCIM_HandshakeWordLoaderForUnit1.LotID_12, 12, ref tmpPLCData);
                for (int iCount = 0; iCount < 12; iCount++)
                {
                    tmpGlassData.LotID += (char)(tmpPLCData[iCount] & 0x00FF);
                    tmpGlassData.LotID += (char)((tmpPLCData[iCount] & 0xFF00) >> 8);
                }

                objForPLCHandshake.Get_PLC_Data(CCCIM_HandshakeWordLoaderForUnit1.LotType_8, 8, ref tmpPLCData);
                for (int iCount = 0; iCount < 8; iCount++)
                {
                    tmpGlassData.LotType += (char)(tmpPLCData[iCount] & 0x00FF);
                    tmpGlassData.LotType += (char)((tmpPLCData[iCount] & 0xFF00) >> 8);
                }

                objForPLCHandshake.Get_PLC_Data(CCCIM_HandshakeWordLoaderForUnit1.GlassID_9, 9, ref tmpPLCData);
                for (int iCount = 0; iCount < 9; iCount++)
                {
                    tmpGlassData.GlassID += (char)(tmpPLCData[iCount] & 0x00FF);
                    tmpGlassData.GlassID += (char)((tmpPLCData[iCount] & 0xFF00) >> 8);
                }

                if (tmpGlassData.GlassID.Trim().Length == 0)
                {
                    return -3;
                }

                objForPLCHandshake.Get_PLC_Data(CCCIM_HandshakeWordLoaderForUnit1.ProductID_8, 8, ref tmpPLCData);
                for (int iCount = 0; iCount < 8; iCount++)
                {
                    tmpGlassData.ProductID += (char)(tmpPLCData[iCount] & 0x00FF);
                    tmpGlassData.ProductID += (char)((tmpPLCData[iCount] & 0xFF00) >> 8);
                }

                objForPLCHandshake.Get_PLC_Data(CCCIM_HandshakeWordLoaderForUnit1.PlanID_16, 16, ref tmpPLCData);
                for (int iCount = 0; iCount < 16; iCount++)
                {
                    tmpGlassData.PlanID += (char)(tmpPLCData[iCount] & 0x00FF);
                    tmpGlassData.PlanID += (char)((tmpPLCData[iCount] & 0xFF00) >> 8);
                }

                objForPLCHandshake.Get_PLC_Data(CCCIM_HandshakeWordLoaderForUnit1.StepID_16, 16, ref tmpPLCData);
                for (int iCount = 0; iCount < 16; iCount++)
                {
                    tmpGlassData.StepID += (char)(tmpPLCData[iCount] & 0x00FF);
                    tmpGlassData.StepID += (char)((tmpPLCData[iCount] & 0xFF00) >> 8);
                }

                objForPLCHandshake.Get_PLC_Data(CCCIM_HandshakeWordLoaderForUnit1.StepNo_4, 4, ref tmpPLCData);
                for (int iCount = 0; iCount < 4; iCount++)
                {
                    tmpGlassData.StepNo += (char)(tmpPLCData[iCount] & 0x00FF);
                    tmpGlassData.StepNo += (char)((tmpPLCData[iCount] & 0xFF00) >> 8);
                }

                objForPLCHandshake.Get_PLC_Data(CCCIM_HandshakeWordLoaderForUnit1.RecipeID_9, 9, ref tmpPLCData);
                for (int iCount = 0; iCount < 9; iCount++)
                {
                    tmpGlassData.RecipeID += (char)(tmpPLCData[iCount] & 0x00FF);
                    tmpGlassData.RecipeID += (char)((tmpPLCData[iCount] & 0xFF00) >> 8);
                }

                objForPLCHandshake.Get_PLC_Data(CCCIM_HandshakeWordLoaderForUnit1.PPID_8, 8, ref tmpPLCData);
                for (int iCount = 0; iCount < 8; iCount++)
                {
                    tmpGlassData.PPID += (char)(tmpPLCData[iCount] & 0x00FF);
                    tmpGlassData.PPID += (char)((tmpPLCData[iCount] & 0xFF00) >> 8);
                }

                objForPLCHandshake.Get_PLC_Data(CCCIM_HandshakeWordLoaderForUnit1.AbnormalFlag_9, 9, ref tmpPLCData);
                for (int iCount = 0; iCount < 9; iCount++)
                {
                    tmpGlassData.AbnormalFlag += (char)(tmpPLCData[iCount] & 0x00FF);
                    tmpGlassData.AbnormalFlag += (char)((tmpPLCData[iCount] & 0xFF00) >> 8);
                }

                objForPLCHandshake.Get_PLC_Data(CCCIM_HandshakeWordLoaderForUnit1.FinalJudge_2, 2, ref tmpPLCData);
                for (int iCount = 0; iCount < 2; iCount++)
                {
                    tmpGlassData.FinalJudge += (char)(tmpPLCData[iCount] & 0x00FF);
                    tmpGlassData.FinalJudge += (char)((tmpPLCData[iCount] & 0xFF00) >> 8);
                }

                objForPLCHandshake.Get_PLC_Data(CCCIM_HandshakeWordLoaderForUnit1.Grade_2, 2, ref tmpPLCData);
                for (int iCount = 0; iCount < 2; iCount++)
                {
                    tmpGlassData.Grade += (char)(tmpPLCData[iCount] & 0x00FF);
                    tmpGlassData.Grade += (char)((tmpPLCData[iCount] & 0xFF00) >> 8);
                }

                objForPLCHandshake.Get_PLC_Data(CCCIM_HandshakeWordLoaderForUnit1.GradeCode_4, 4, ref tmpPLCData);
                for (int iCount = 0; iCount < 4; iCount++)
                {
                    tmpGlassData.GradeCode += (char)(tmpPLCData[iCount] & 0x00FF);
                    tmpGlassData.GradeCode += (char)((tmpPLCData[iCount] & 0xFF00) >> 8);
                }

                objForPLCHandshake.Get_PLC_Data(CCCIM_HandshakeWordLoaderForUnit1.CelRepCount_1, 1, ref tmpPLCData);
                tmpGlassData.CelRepCount = tmpGlassData.CelRepCount + ((tmpPLCData[0] & 0xF000) >> 12) * 1000;
                tmpGlassData.CelRepCount = tmpGlassData.CelRepCount + ((tmpPLCData[0] & 0x0F00) >> 08) * 100;
                tmpGlassData.CelRepCount = tmpGlassData.CelRepCount + ((tmpPLCData[0] & 0x00F0) >> 04) * 10;
                tmpGlassData.CelRepCount = tmpGlassData.CelRepCount + ((tmpPLCData[0] & 0x000F) >> 00) * 1;

                objForPLCHandshake.Get_PLC_Data(CCCIM_HandshakeWordLoaderForUnit1.CelTrimCount_1, 1, ref tmpPLCData);
                tmpGlassData.CelTrimCount = tmpGlassData.CelRepCount + ((tmpPLCData[0] & 0xF000) >> 12) * 1000;
                tmpGlassData.CelTrimCount = tmpGlassData.CelRepCount + ((tmpPLCData[0] & 0x0F00) >> 08) * 100;
                tmpGlassData.CelTrimCount = tmpGlassData.CelRepCount + ((tmpPLCData[0] & 0x00F0) >> 04) * 10;
                tmpGlassData.CelTrimCount = tmpGlassData.CelRepCount + ((tmpPLCData[0] & 0x000F) >> 00) * 1;

                objForPLCHandshake.Get_PLC_Data(CCCIM_HandshakeWordLoaderForUnit1.ParCount_1, 1, ref tmpPLCData);
                for (int iCount = 0; iCount < 1; iCount++)
                {
                    tmpGlassData.ParCount += (char)(tmpPLCData[iCount] & 0x00FF);
                    tmpGlassData.ParCount += (char)((tmpPLCData[iCount] & 0xFF00) >> 8);
                }

                objForPLCHandshake.Get_PLC_Data(CCCIM_HandshakeWordLoaderForUnit1.ModelName_50, 50, ref tmpPLCData);
                for (int iCount = 0; iCount < 50; iCount++)
                {
                    tmpGlassData.ModelName += (char)(tmpPLCData[iCount] & 0x00FF);
                    tmpGlassData.ModelName += (char)((tmpPLCData[iCount] & 0xFF00) >> 8);
                }

                objForPLCHandshake.Get_PLC_Data(CCCIM_HandshakeWordLoaderForUnit1.EQID_5, 5, ref tmpPLCData);
                for (int iCount = 0; iCount < 5; iCount++)
                {
                    tmpGlassData.EQID += (char)(tmpPLCData[iCount] & 0x00FF);
                    tmpGlassData.EQID += (char)((tmpPLCData[iCount] & 0xFF00) >> 8);
                }

                objForPLCHandshake.Get_PLC_Data(CCCIM_HandshakeWordLoaderForUnit1.VCRFlag_1, 1, ref tmpPLCData);
                tmpGlassData.VCRFlag += (char)(tmpPLCData[0] & 0x00FF);

                objForPLCHandshake.Get_PLC_Data(CCCIM_HandshakeWordLoaderForUnit1.LotSubType_2, 2, ref tmpPLCData);
                for (int iCount = 0; iCount < 2; iCount++)
                {
                    tmpGlassData.LotSubType += (char)(tmpPLCData[iCount] & 0x00FF);
                    tmpGlassData.LotSubType += (char)((tmpPLCData[iCount] & 0xFF00) >> 8);
                }

                objForPLCHandshake.Get_PLC_Data(CCCIM_HandshakeWordLoaderForUnit1.ArrayGlassID_9, 9, ref tmpPLCData);
                for (int iCount = 0; iCount < 9; iCount++)
                {
                    tmpGlassData.ArrayGlassID += (char)(tmpPLCData[iCount] & 0x00FF);
                    tmpGlassData.ArrayGlassID += (char)((tmpPLCData[iCount] & 0xFF00) >> 8);
                }

                objForPLCHandshake.Get_PLC_Data(CCCIM_HandshakeWordLoaderForUnit1.CFGlassID_9, 9, ref tmpPLCData);
                for (int iCount = 0; iCount < 9; iCount++)
                {
                    tmpGlassData.CFGlassID += (char)(tmpPLCData[iCount] & 0x00FF);
                    tmpGlassData.CFGlassID += (char)((tmpPLCData[iCount] & 0xFF00) >> 8);
                }

                objForPLCHandshake.Get_PLC_Data(CCCIM_HandshakeWordLoaderForUnit1.ProcessPortNo_1, 1, ref tmpPLCData);
                tmpGlassData.ProcessPortNo += (char)(tmpPLCData[0] & 0x00FF);

                objForPLCHandshake.Get_PLC_Data(CCCIM_HandshakeWordLoaderForUnit1.CassetteID_12, 12, ref tmpPLCData);
                for (int iCount = 0; iCount < 12; iCount++)
                {
                    tmpGlassData.CassetteID += (char)(tmpPLCData[iCount] & 0x00FF);
                    tmpGlassData.CassetteID += (char)((tmpPLCData[iCount] & 0xFF00) >> 8);
                }

                objForPLCHandshake.Get_PLC_Data(CCCIM_HandshakeWordLoaderForUnit1.SlotID_2, 2, ref tmpPLCData);
                tmpGlassData.SlotID += (char)(tmpPLCData[0] & 0x00FF);
                tmpGlassData.SlotID += (char)(tmpPLCData[0] & 0xFF00 >> 8);
                tmpGlassData.SlotID += (char)(tmpPLCData[1] & 0x00FF);

                Common.GlobalValue.TempGlassData = tmpGlassData;

                return 0;
            }
            return 0;
        }

        private void GlassDataExchangeSet(int iGlassDataNum)
        {
            if (objForPLCHandshake._7_Enable_)
            {
                int[] tmpPLCData = new int[50];
                Common.CCGlassData tmpGlassData = null;
                Common.CCLaserPowerData tmpLaserPowerData = Common.GlobalValue.LaserPowerData;

                if (iGlassDataNum == 1)
                {
                    tmpGlassData = Common.GlobalValue.GlassData1;
                }
                else if (iGlassDataNum == 2)
                {
                    tmpGlassData = Common.GlobalValue.GlassData2;
                }

                for (int iCount = 0; iCount < 9; iCount++)
                {
                    tmpPLCData[iCount] = Convert.ToInt32(tmpGlassData.GlassID[iCount * 2 + 0]) + (Convert.ToInt32(tmpGlassData.GlassID[iCount * 2 + 1]) << 8);
                }
                objForPLCHandshake.Set_PLC_Data(CCCIM_HandshakeWordEQUnit1.GlassID_9, 9, tmpPLCData);

                for (int iCount = 0; iCount < 8; iCount++)
                {
                    tmpPLCData[iCount] = Convert.ToInt32(tmpGlassData.PPID[iCount * 2 + 0]) + (Convert.ToInt32(tmpGlassData.PPID[iCount * 2 + 1]) << 8);
                }
                objForPLCHandshake.Set_PLC_Data(CCCIM_HandshakeWordEQUnit1.PPID_8, 8, tmpPLCData);

                for (int iCount = 0; iCount < 12; iCount++)
                {
                    tmpPLCData[iCount] = Convert.ToInt32(tmpGlassData.LotID[iCount * 2 + 0]) + (Convert.ToInt32(tmpGlassData.LotID[iCount * 2 + 1]) << 8);
                }
                objForPLCHandshake.Set_PLC_Data(CCCIM_HandshakeWordEQUnit1.LotID_12, 12, tmpPLCData);

                for (int iCount = 0; iCount < 16; iCount++)
                {
                    tmpPLCData[iCount] = Convert.ToInt32(tmpGlassData.StepID[iCount * 2 + 0]) + (Convert.ToInt32(tmpGlassData.StepID[iCount * 2 + 1]) << 8);
                }
                objForPLCHandshake.Set_PLC_Data(CCCIM_HandshakeWordEQUnit1.StepID_16, 16, tmpPLCData);

                for (int iCount = 0; iCount < 16; iCount++)
                {
                    tmpPLCData[iCount] = Convert.ToInt32(tmpGlassData.StepID[iCount * 2 + 0]) + (Convert.ToInt32(tmpGlassData.StepID[iCount * 2 + 1]) << 8);
                }
                objForPLCHandshake.Set_PLC_Data(CCCIM_HandshakeWordEQUnit1.StepID_16, 16, tmpPLCData);

                objForPLCHandshake.Set_PLC_Data(CCCIM_HandshakeWordEQUnit1.CelRepCount_1, tmpGlassData.CelRepCount);

                for (int iCount = 0; iCount < 5; iCount++)
                {
                    tmpPLCData[iCount] = Convert.ToInt32(tmpGlassData.EQID[iCount * 2 + 0]) + (Convert.ToInt32(tmpGlassData.EQID[iCount * 2 + 1]) << 8);
                }
                objForPLCHandshake.Set_PLC_Data(CCCIM_HandshakeWordEQUnit1.EQID_5, 5, tmpPLCData);

                /*
                for (int iCount = 0; iCount < 4; iCount++)
                {
                    tmpPLCData[iCount] = Convert.ToInt32(tmpGlassData.[iCount * 2 + 0]) + (Convert.ToInt32(tmpGlassData.EQID[iCount * 2 + 1]) << 8);
                }
                objForPLCHandshake.Set_PLC_Data(CCCIM_HandshakeWordEQUnit1.CellTestCSTID_4, 4, tmpPLCData);
                */

                /*
                for (int iCount = 0; iCount < 2; iCount++)
                {
                    tmpPLCData[iCount] = Convert.ToInt32(tmpGlassData.[iCount * 2 + 0]) + (Convert.ToInt32(tmpGlassData.EQID[iCount * 2 + 1]) << 8);
                }
                objForPLCHandshake.Set_PLC_Data(CCCIM_HandshakeWordEQUnit1.CollectFlag_2, 2, tmpPLCData);
                */

                for (int iCount = 0; iCount < 2; iCount++)
                {
                    tmpPLCData[iCount] = Convert.ToInt32(tmpGlassData.Grade[iCount * 2 + 0]) + (Convert.ToInt32(tmpGlassData.Grade[iCount * 2 + 1]) << 8);
                }
                objForPLCHandshake.Set_PLC_Data(CCCIM_HandshakeWordEQUnit1.Grade_2, 2, tmpPLCData);

                for (int iCount = 0; iCount < 4; iCount++)
                {
                    tmpPLCData[iCount] = Convert.ToInt32(tmpGlassData.GradeCode[iCount * 2 + 0]) + (Convert.ToInt32(tmpGlassData.GradeCode[iCount * 2 + 1]) << 8);
                }
                objForPLCHandshake.Set_PLC_Data(CCCIM_HandshakeWordEQUnit1.GradeCode_4, 4, tmpPLCData);

                for (int iCount = 0; iCount < 2; iCount++)
                {
                    tmpPLCData[iCount] = Convert.ToInt32(tmpLaserPowerData.MaxPower.ToString("D4")[iCount * 2 + 0]) + (Convert.ToInt32(tmpLaserPowerData.MaxPower.ToString("D4")[iCount * 2 + 1]) << 8);
                }
                objForPLCHandshake.Set_PLC_Data(CCCIM_HandshakeWordEQUnit1.MAXPower_4, 4, tmpPLCData);

                for (int iCount = 0; iCount < 2; iCount++)
                {
                    tmpPLCData[iCount] = Convert.ToInt32(tmpLaserPowerData.MinPower.ToString("D4")[iCount * 2 + 0]) + (Convert.ToInt32(tmpLaserPowerData.MinPower.ToString("D4")[iCount * 2 + 1]) << 8);
                }
                objForPLCHandshake.Set_PLC_Data(CCCIM_HandshakeWordEQUnit1.MINPower_4, 4, tmpPLCData);

                for (int iCount = 0; iCount < 2; iCount++)
                {
                    tmpPLCData[iCount] = Convert.ToInt32(tmpLaserPowerData.AvgPower.ToString("D4")[iCount * 2 + 0]) + (Convert.ToInt32(tmpLaserPowerData.AvgPower.ToString("D4")[iCount * 2 + 1]) << 8);
                }
                objForPLCHandshake.Set_PLC_Data(CCCIM_HandshakeWordEQUnit1.AVGPower_4, 4, tmpPLCData);

                for (int iCount = 0; iCount < 2; iCount++)
                {
                    tmpPLCData[iCount] = Convert.ToInt32(tmpLaserPowerData.StdPower.ToString("D4")[iCount * 2 + 0]) + (Convert.ToInt32(tmpLaserPowerData.StdPower.ToString("D4")[iCount * 2 + 1]) << 8);
                }
                objForPLCHandshake.Set_PLC_Data(CCCIM_HandshakeWordEQUnit1.STDPower_4, 4, tmpPLCData);

                //EG05
                {
                    objForPLCHandshake.Set_PLC_Data(CCCIM_HandshakeEqUnit1EG05.CstAndSlotNo_1, (tmpGlassData.CassetteNo << 8) + tmpGlassData.SlotNo);
                    objForPLCHandshake.Set_PLC_Data(CCCIM_HandshakeEqUnit1EG05.KindNo_1, tmpGlassData.KindNo);
                }

                GlassUnLoadLog.Log(tmpGlassData.GlassID);

            }
        }

        private void RecipeDataGet()
        {
            int iData = 0;
            objForPLCHandshake.Get_PLC_Data(CCCIM_HandshakeLUDUnit1ED01.RecipeData_1, ref iData);

            Common.GlobalValue.RecipeData = iData;

            RecipeChangeOK = true;
        }

        private void GlassDataClear(int iGlassDataNum)
        {
            if (iGlassDataNum == 1)
            {
                Common.GlobalValue.GlassProcessStatus[1] = false;
                Common.GlobalValue.GlassData1 = null;
            }
            else if (iGlassDataNum == 2)
            {
                Common.GlobalValue.GlassProcessStatus[2] = false;
                Common.GlobalValue.GlassData2 = null;
            }
        }

        private void GlassDataExist(int iGlassDataNum)
        {
            Common.CCGlassData TempGlassData = new Common.CCGlassData();
            if (iGlassDataNum == 1)
            {
                Common.GlobalValue.GlassProcessStatus[1] = true;
                TempGlassData = Common.GlobalValue.TempGlassData;
                Common.GlobalValue.GlassData1 = TempGlassData;
            }
            else if (iGlassDataNum == 2)
            {
                Common.GlobalValue.GlassProcessStatus[2] = true;
                TempGlassData = Common.GlobalValue.TempGlassData;
                Common.GlobalValue.GlassData2 = TempGlassData;
            }

            GlassLoadLog.Log(TempGlassData.GlassID);
        }

        public void RemoveData(int iGlassDataNum)
        {
            if (Common.GlobalValue.GlassProcessStatus[iGlassDataNum])
            {
                Common.CCGlassData tmpGlassData = new Common.CCGlassData();

                if (iGlassDataNum == 1)
                {
                    tmpGlassData = Common.GlobalValue.GlassData1;
                }
                else if (iGlassDataNum == 2)
                {
                    tmpGlassData = Common.GlobalValue.GlassData2;
                }

                //EG05
                {
                    objForPLCHandshake.Set_PLC_Data(CCCIM_HandshakeEqUnit1EG01.CstAndSlotNo_1, (tmpGlassData.CassetteNo << 8) + tmpGlassData.SlotNo);
                    objForPLCHandshake.Set_PLC_Data(CCCIM_HandshakeEqUnit1EG01.KindNo_1, tmpGlassData.KindNo);
                }

                GlassDataClear(iGlassDataNum);
                GlassRemoveLog.Log(tmpGlassData.GlassID);
            }
        }

        #region Index

        public int RecipeChangeIdx
        {
            get { return m_iRecipeChangeIdx; }
            set { m_iRecipeChangeIdx = value; }
        }

        public int LoadHandshakeIdx
        {
            get { return m_iLoadHandshakeIdx; }
            set { m_iLoadHandshakeIdx = value; }
        }

        public int UnloadHandshakeIdx
        {
            get { return m_iUnloadHandshakeIdx; }
            set { m_iUnloadHandshakeIdx = value; }
        }

        public int ExchangeHandshakeIdx
        {
            get { return m_iExchangeHandshakeIdx; }
            set { m_iExchangeHandshakeIdx = value; }
        }

        public int MismatchHandshakeIdx
        {
            get { return m_iMismatchHandshakeIdx; }
            set { m_iMismatchHandshakeIdx = value; }
        }
        #endregion

        public bool Mismatch
        {
            get { return m_bMismatch; }
            set { m_bMismatch = value; }
        }

        public bool RecipeChangeOK
        {
            get { return m_bRecipeChangeOK; }
            set
            {
                m_bRecipeChangeOK = value;
                if (value)
                {
                    objForPLCHandshake.Set_PLC_Data(CCCIM_HandshakeEqUnit1ES06.CurrentRecipeNo_1, Common.GlobalValue.RecipeData);
                }
            }
        }
        public bool AbnormalFlag
        {
            get { return m_bAbnormal; }
            set { m_bAbnormal = value; }
        }

        public bool InlineStatus
        {
            set { objForPLCHandshake.Set_PLC_Data(CCCIM_HandshakeBitEQUnit1.InlineStatus, value ? 1 : 0); }
        }

        public enumEqStatus EQStatus
        {
            get { return m_enumNowEqStatus; }
            set
            {
                m_enumNowEqStatus = value;
                objForPLCHandshake.Set_PLC_Data(CCCIM_HandshakeEqUnit1ES06.EQStatus_1, 0x1 << (int)value); ;
            }
        }

        public bool AutoOperation
        {
            set { objForPLCHandshake.Set_PLC_Data(CCCIM_HandshakeBitEQUnit1.AutoOperationStatus, value ? 1 : 0); }
        }

        public void ResetAlarm()
        {
            objForPLCHandshake.Set_PLC_Data(CCCIM_HandshakeBitEQUnit1.HeavyAlarmStatus, 0);
            m_bReportAlarmFlag = true;
        }

        public Queue<string> ReportAlarmQueue
        {
            get { return m_aszAlarmMsg; }
            set { m_aszAlarmMsg = value; }
        }

        public void ResetLight()
        {
            objForPLCHandshake.Set_PLC_Data(CCCIM_HandshakeBitEQUnit1.LightAlarmStatus, 0);
            m_bReportLightFlag = true;
        }

        public Queue<string> ReportLightQueue
        {
            get { return m_aszLightMsg; }
            set { m_aszLightMsg = value; }
        }

        private void ReportAlarm()
        {
            if (m_bReportAlarmFlag && m_aszAlarmMsg.Count != 0)
            {
                string AlarmString = m_aszAlarmMsg.Dequeue();

                AlarmString = AlarmString.Substring(0, 4);
                {
                    objForPLCHandshake.Set_PLC_Data(CCCIM_HandshakeLUDUnit1ES02.HeavyAlarmCode_1, int.Parse(AlarmString.Substring(1, 3)));
                    Thread.Sleep(1000);
                    objForPLCHandshake.Set_PLC_Data(CCCIM_HandshakeBitEQUnit1.HeavyAlarmStatus, 1);

                }
                m_bReportAlarmFlag = false;
            }
        }

        private void ReportLight()
        {
            /*if (m_bReportLightFlag && m_aszLightMsg.Count != 0)
            {
                string AlarmString = m_aszLightMsg.Dequeue();

                AlarmString = AlarmString.Substring(0, 4);

                {

                    objForPLCHandshake.Set_PLC_Data(CCCIM_HandshakeLUDUnit1ES02.LightAlarmCode_1, int.Parse(AlarmString.Substring(1, 3)));
                    Thread.Sleep(1000);
                    objForPLCHandshake.Set_PLC_Data(CCCIM_HandshakeBitEQUnit1.LightAlarmStatus, 1);
                }
                m_bReportLightFlag = false;
            }*/
        }

        private void LogUSStatus()
        {
            int[] temp = new int[16];
            Int64 tempValue = 0;

            objForPLCHandshake.Get_PLC_Data(CCCIM_HandshakeBitLoaderForAll.InlineStatus, 16, ref temp);

            for (int iCount = 0; iCount < 16; iCount++)
            {
                tempValue = (tempValue << 1) & temp[iCount];
            }

            if (tempValue != m_iUSStatus)
            {
                USLog.Log(tempValue.ToString());
                m_iUSStatus = tempValue;
            }
        }

        private void LogEQStatus()
        {
            int[] temp = new int[8];
            Int64 tempValue = 0;

            objForPLCHandshake.Get_PLC_Data(CCCIM_HandshakeBitEQUnit1.InlineStatus, 8, ref temp);

            for (int iCount = 0; iCount < 8; iCount++)
            {
                tempValue = (tempValue << 1) | temp[iCount];
            }

            if (tempValue != m_iEqStatus)
            {
                EQLog.Log(tempValue.ToString());
                m_iEqStatus = tempValue;
            }
        }

        private void LogLoadHandshake()
        {
            int[] temp = new int[9];
            Int64 tempValue = 0;

            objForPLCHandshake.Get_PLC_Data(CCCIM_HandshakeBitLoaderForAll.AutoOperationStatus, ref temp[0]);
            objForPLCHandshake.Get_PLC_Data(CCCIM_HandshakeBitLoaderForUnit1.LoadReady, ref temp[1]);
            objForPLCHandshake.Get_PLC_Data(CCCIM_HandshakeBitLoaderForUnit1.LoadComplete, ref temp[2]);
            objForPLCHandshake.Get_PLC_Data(CCCIM_HandshakeBitLoaderForUnit1.LoadCancel, ref temp[3]);
            objForPLCHandshake.Get_PLC_Data(CCCIM_HandshakeBitLoaderForUnit1.Delivering, ref temp[4]);

            objForPLCHandshake.Get_PLC_Data(CCCIM_HandshakeBitEQUnit1.AutoOperationStatus, ref temp[5]);
            objForPLCHandshake.Get_PLC_Data(CCCIM_HandshakeBitEQUnit1.LoadRequest, ref temp[6]);
            objForPLCHandshake.Get_PLC_Data(CCCIM_HandshakeBitEQUnit1.LoadOK, ref temp[7]);
            objForPLCHandshake.Get_PLC_Data(CCCIM_HandshakeBitEQUnit1.DeliveryCancelRequest, ref temp[8]);

            for (int iCount = 0; iCount < 9; iCount++)
            {
                tempValue = (tempValue << 1) | temp[iCount];
            }

            if (tempValue != m_iLoaderStatus)
            {
                LoaderLog.Log(tempValue.ToString());
                m_iLoaderStatus = tempValue;
            }
        }

        private void LogUnLoadHandshake()
        {
            int[] temp = new int[9];
            Int64 tempValue = 0;

            objForPLCHandshake.Get_PLC_Data(CCCIM_HandshakeBitLoaderForAll.AutoOperationStatus, ref temp[0]);
            objForPLCHandshake.Get_PLC_Data(CCCIM_HandshakeBitLoaderForUnit1.UnloadReady, ref temp[1]);
            objForPLCHandshake.Get_PLC_Data(CCCIM_HandshakeBitLoaderForUnit1.UnloadComplete, ref temp[2]);
            objForPLCHandshake.Get_PLC_Data(CCCIM_HandshakeBitLoaderForUnit1.UnloadCancel, ref temp[3]);
            objForPLCHandshake.Get_PLC_Data(CCCIM_HandshakeBitLoaderForUnit1.Delivering, ref temp[4]);

            objForPLCHandshake.Get_PLC_Data(CCCIM_HandshakeBitEQUnit1.AutoOperationStatus, ref temp[5]);
            objForPLCHandshake.Get_PLC_Data(CCCIM_HandshakeBitEQUnit1.UnloadRequest, ref temp[6]);
            objForPLCHandshake.Get_PLC_Data(CCCIM_HandshakeBitEQUnit1.UnloadOK, ref temp[7]);
            objForPLCHandshake.Get_PLC_Data(CCCIM_HandshakeBitEQUnit1.DeliveryCancelRequest, ref temp[8]);

            for (int iCount = 0; iCount < 9; iCount++)
            {
                tempValue = (tempValue << 1) | temp[iCount];
            }

            if (tempValue != m_iUnLoaderStatus)
            {
                UnLoaderLog.Log(tempValue.ToString());
                m_iUnLoaderStatus = tempValue;
            }
        }

        private void LogExchangeHandshake()
        {
            int[] temp = new int[9];
            Int64 tempValue = 0;

            objForPLCHandshake.Get_PLC_Data(CCCIM_HandshakeBitLoaderForAll.AutoOperationStatus, ref temp[0]);
            objForPLCHandshake.Get_PLC_Data(CCCIM_HandshakeBitLoaderForUnit1.ExchangeReady, ref temp[1]);
            objForPLCHandshake.Get_PLC_Data(CCCIM_HandshakeBitLoaderForUnit1.ExchangeComplete, ref temp[2]);
            objForPLCHandshake.Get_PLC_Data(CCCIM_HandshakeBitLoaderForUnit1.ExchangeCancel, ref temp[3]);
            objForPLCHandshake.Get_PLC_Data(CCCIM_HandshakeBitLoaderForUnit1.Delivering, ref temp[4]);

            objForPLCHandshake.Get_PLC_Data(CCCIM_HandshakeBitEQUnit1.AutoOperationStatus, ref temp[5]);
            objForPLCHandshake.Get_PLC_Data(CCCIM_HandshakeBitEQUnit1.ExchangeRequest, ref temp[6]);
            objForPLCHandshake.Get_PLC_Data(CCCIM_HandshakeBitEQUnit1.ExchangeOK, ref temp[7]);
            objForPLCHandshake.Get_PLC_Data(CCCIM_HandshakeBitEQUnit1.DeliveryCancelRequest, ref temp[8]);

            for (int iCount = 0; iCount < 9; iCount++)
            {
                tempValue = (tempValue << 1) | temp[iCount];
            }

            if (tempValue != m_iExchangeStatus)
            {
                ExchangeLog.Log(tempValue.ToString());
                m_iExchangeStatus = tempValue;
            }
        }
    }

    public enum enumAbnormalReleaseCase
    {
        None = 0,
        Recovery = 2,
        Cancel = 3
    }

    public enum enumEqStatus
    {
        Run = 0,
        Idle = 1,
        Stop = 2,
        Down = 3
    }

    public class CCVCRScenario
    {
        #region Private Member
        private static int m_iIndex = 0;       
        #endregion

        #region Public  Property
        public static int ScenarioIndex
        {
            get { return m_iIndex; }
            set { m_iIndex = value; }
        }
        #endregion

        public static void StartToRead()
        {
            ScenarioIndex = 10;
        }

        public static void DataHandler(object sender, SerialDataReceivedEventArgs e)
        {
            byte[] data = ContrelModule.CCVCRInterface.GetSingleton().Receive();
            int iOffset = 0;

            if (data.Length <= 0)
                return;

            switch (data[iOffset])
            {
                case 0x56: // 'V'
                case 0x44: // 'D'

                    // 1. Header
                    iOffset++;

                    // 2. Data Length
                    int iDatalen = Convert.ToInt16(data[iOffset]);
                    iOffset += 2;

                    // 3. ID
                    byte[] id = new byte[iDatalen];
                    Array.Copy(data, iOffset, id, 0, id.Length);
                    string panelID = Encoding.Default.GetString(id);

                    //MessageBox.Show("讀取ID: " + panelID);

                    if (ScenarioIndex == 20)
                        ScenarioIndex = 30;


                    break;

                case 0x52: // 'R'
                    // TODO: Retry
                    break;
            }
        }

        public static void ScenarioExecute()
        {
            switch (ScenarioIndex)
            {
                case 0:
                    break;

                case 10: // Start To Read VCR
                    ContrelModule.CCVCRInterface vcr = ContrelModule.CCVCRInterface.GetSingleton();
                    vcr.DataReceiveHandler = DataHandler;
                    ContrelModule.CCVCRInterface.GetSingleton().ReadVCR();
                    ScenarioIndex = 20; 
                    break;

                case 20: // Wait Callback
                    break;

                case 30:
                    ScenarioIndex = 0;

                    //if (Scenario.ScenarioIndex == 133)
                    //    Scenario.ScenarioIndex = 135;
                    if (Scenario.StageIndex == 800)
                        Scenario.StageIndex = 900;
                    break;
            }
        }

    }

    public class Scenario
    {
        #region Private Member
        private static int m_iIndex = 0;
        private static int m_iPanelCount = 0;

        private static int m_iLULIndex = 0;
        private static int m_iStageIndex = 0;
        private static bool m_bSupplyEnd = true;
        #endregion

        #region Public  Property
        public static int ScenarioIndex
        {
            get { return m_iIndex; }
            set { m_iIndex = value; }
        }
        public static int LULIndex
        {
            get { return m_iLULIndex; }
            set { m_iLULIndex = value; }
        }

        public static int StageIndex
        {
            get { return m_iStageIndex; }
            set { m_iStageIndex = value; }
        }

        public static bool SupplyEnd
        {
            get { return m_bSupplyEnd; }
            set { m_bSupplyEnd = value; }
        }
        #endregion

        #region Ctor
        protected Scenario()
        {

        }
        #endregion

        #region Public Method

        public static void StartToLoad()
        {
            //ScenarioIndex = 10;

            Common.GlobalValue.HandShakeByPass = true;
            m_iLULIndex = 100;
        }

        public static void StartToUnload()
        {
            m_iStageIndex = 1300;
        }

        public static void TunrUnitScenarioExecute()
        {
            switch (m_iLULIndex)
            {
                case 0:
                    break;

                case 100: // Start To Load
                    SDDE.GetSingleton().SendMessageToTK("C201");

                    if (Common.GlobalValue.HandShakeByPass == true)
                        m_iLULIndex = 500;
                    else
                        m_iLULIndex = 200;
                    break;

                case 200: // Start To Load Request Handshake
                    if (CIM_Schedule.getSingleton().LoadHandshakeIdx == 0 && CIM_Schedule.getSingleton().LoadHandshakeFlag == false)
                    {
                        CIM_Schedule.getSingleton().LoadHandshakeIdx = 10;
                        m_iLULIndex = 300;
                    }
                    break;

                case 300: // Wait Load Request Handshake Complete
                    if (CIM_Schedule.getSingleton().LoadHandshakeIdx == 0 && CIM_Schedule.getSingleton().LoadHandshakeFlag == true)
                    {
                        m_iLULIndex = 500;
                        CIM_Schedule.getSingleton().LoadHandshakeFlag = false;
                    }

                    break;

                case 400: // Load Request Handshake Error                 
                    break;

                case 500: // Wait R201
                    break;

                case 600: // Receive R201 and Send C203(上半部入料)
                    m_iPanelCount++;

                    SDDE.GetSingleton().SendMessageToTK("C203");
                    m_iLULIndex = 700;
                    break;

                case 700: // Wait R203
                    break;

                case 800: // Receive R203 and Send C205(下半部入料)
                    SDDE.GetSingleton().SendMessageToTK("C205");
                    m_iLULIndex = 900;
                    break;

                case 900: // Wait R205
                    break;
                        
                case 1000: // Receive R205 and Start To Repair Panel
                    if( m_iPanelCount == 1 && m_bSupplyEnd == false) // 直接入料，另外還有一片玻璃進來
                    {
                        m_iLULIndex  = 100; // 重新要片
                        m_iStageIndex = 100; // 開始修片
                    }
                    else if(  m_iPanelCount == 1 && m_bSupplyEnd == true ) // 直接入料，只有一片玻璃要進機台
                    {
                        m_iLULIndex  = 1100; // 等待玻璃修補
                        m_iStageIndex = 100; // 開始修片
                    }
                    else if( m_iPanelCount == 2  && m_iStageIndex == 0 && m_bSupplyEnd == true )
                    {
                        // 機台裡面有兩片作交換,一個修片完成出料，一個開始修片, 外面沒有玻璃要進來
                        m_iLULIndex = 2920; // 作上半部出料
                        m_iStageIndex = 100;
                    }
                    else if( m_iPanelCount == 2  && m_iStageIndex == 0 && m_bSupplyEnd == false )
                    {
                        // 機台裡面有兩片作交換,一個修片完成出料，一個開始修片，外面有玻璃要進來
                        m_iLULIndex = 2000; // 開始出料
                        m_iStageIndex = 100; // 開始修片
                    }
                    break;

                case 1100: // Panel Processing
                    break;

                case 1900: // 等待是否有上半部玻璃在動作
                    break;

                case 2000: // Start To Exchange or Unload Panel Handshake
                    /*if (Common.GlobalValue.GlassProcessStatus[1] == true &&
                        Common.GlobalValue.GlassProcessStatus[2] == true &&
                        CIM_Schedule.getSingleton().SupplyEndSingal == 0) // Exchange
                     */
                    if (m_iPanelCount == 2 && m_bSupplyEnd == false )
                    {
                        //if (CIM_Schedule.getSingleton().ExchangeHandshakeIdx == 0 && CIM_Schedule.getSingleton().ExchangeHandshakeFlag == false)
                        {
                            /*if (Common.GlobalValue.GlassProcessStatus[1] == true)
                                Common.GlobalValue.UnloadGlass = 1;
                            else if (Common.GlobalValue.GlassProcessStatus[2] == true)
                                Common.GlobalValue.UnloadGlass = 2;*/

                            SDDE.GetSingleton().SendMessageToTK("C917,98,1");            

                            m_iLULIndex = 2100; // Exchange

                        }
                    }
                    else // Unload
                    {
                        //if (CIM_Schedule.getSingleton().UnloadHandshakeIdx == 0 && CIM_Schedule.getSingleton().UnloadHandshakeFlag == false)
                        {
                            /*
                            if (Common.GlobalValue.GlassProcessStatus[1] == true)
                                Common.GlobalValue.UnloadGlass = 1;
                            else if (Common.GlobalValue.GlassProcessStatus[2] == true)
                                Common.GlobalValue.UnloadGlass = 2;
                            */

                            SDDE.GetSingleton().SendMessageToTK("C917,98,0");                            
                            m_iLULIndex = 2900; // Unload
                        }
                    }
                    break;

                #region ----------------------------------------------------------------------------------------Exchange 

                case 2100: // Send C204
                    SDDE.GetSingleton().SendMessageToTK("C204");
                    m_iLULIndex = 2110;
                    break;

                case 2110: // Wait R204
                    break;

                case 2120: // Receive R204 and Send C202
                    SDDE.GetSingleton().SendMessageToTK("C202");
                    m_iLULIndex = 2130;
                    break;

                case 2130: // 判斷是否要作 Exchange Handshake
                    if (Common.GlobalValue.HandShakeByPass == true)
                        m_iLULIndex = 2300;                  
                    else
                        m_iLULIndex = 2140;                    
                    break;

                case 2140: // Start To Exchange Handshake
                    if (CIM_Schedule.getSingleton().ExchangeHandshakeIdx == 0 && CIM_Schedule.getSingleton().ExchangeHandshakeFlag == false)
                    {
                        // 開始起始 Exchange HandShake Scenario
                        CIM_Schedule.getSingleton().ExchangeHandshakeIdx = 10;

                        m_iLULIndex = 2200;
                    }
                    break;

                case 2200: // Exchange Handshake Complete
                    if (CIM_Schedule.getSingleton().ExchangeHandshakeIdx == 0 && CIM_Schedule.getSingleton().ExchangeHandshakeFlag == true)
                    {
                        m_iLULIndex = 2300;
                        CIM_Schedule.getSingleton().ExchangeHandshakeFlag = false;
                    }
                    break;

                case 2300: // VIO 9 On for Exchange
                    //SDDE.GetSingleton().SendMessageToTK("C917,9,1");
                    m_iLULIndex = 2400;
                    break;
                
                case 2400: // Wait Receive R202
                    break;

                case 2500: // Receive R202, 完成交換片
                    m_iPanelCount--;
                    m_iLULIndex = 600;                    
                    break;

                //case 2600: // Send C205, 下半部入料
                        //SDDE.GetSingleton().SendMessageToTK("C205");
                //    m_iLULIndex = 900; // 重新等待 Stage 玻璃 退出
                //    break;
                #endregion

                #region ------------------------------------------------------------------------------Unload

                case 2900: // Send C206
                        SDDE.GetSingleton().SendMessageToTK("C206");
                    m_iLULIndex = 2910;
                    break;

                case 2910: // Wait R206
                    break;

                case 2920: // Receive R206 and Send C204
                    SDDE.GetSingleton().SendMessageToTK("C204");
                    m_iLULIndex = 2930;
                    break;                

                case 2930: // Wait R204
                    break;

                case 2940: // Receive R204 and Send C202
                    SDDE.GetSingleton().SendMessageToTK("C202");
                    m_iLULIndex = 2950;
                    break;

                case 2950:
                    if (Common.GlobalValue.HandShakeByPass == true)
                        m_iLULIndex = 3100;
                    else
                        m_iLULIndex = 2960;                   
                    break;

                case 2960:
                    if (CIM_Schedule.getSingleton().UnloadHandshakeIdx == 0 && CIM_Schedule.getSingleton().UnloadHandshakeFlag == false)
                    {
                        // 開始起始 Unload HandShake Scenario
                        CIM_Schedule.getSingleton().UnloadHandshakeIdx = 10;

                        m_iLULIndex = 3000;
                    }
                    break;

                case 3000: // 等待 Unload Handshake
                    if (CIM_Schedule.getSingleton().UnloadHandshakeIdx == 0 && CIM_Schedule.getSingleton().UnloadHandshakeFlag == true)
                    {
                        m_iLULIndex = 3100;
                        CIM_Schedule.getSingleton().UnloadHandshakeFlag = false;
                    }
                    break;

                case 3100: // VIO 9 On for Unload
                    //SDDE.GetSingleton().SendMessageToTK("C917,9,1");
                    m_iLULIndex = 3200;
                    break;

                case 3200: // Wait R202
                    break;

                case 3300: // Receive R202 and Unload Complete
                    m_iPanelCount--;
                    m_iLULIndex = 0;
                    break;
                #endregion
                        }
                    }

        public static void StageScenarioExecute()
                    {
            switch (m_iStageIndex)
                        {
                case 0: 
                    break;

                case 100: // Start to Send C301(平台入料)
                    SDDE.GetSingleton().SendMessageToTK("C301");
                    m_iStageIndex = 200;
                    break;

                case 200: // Wait R301
                    break;

                case 300: // Receive R301 and 開始十字定位
                    PatternFind.StartPatternFind();
                    m_iStageIndex = 400;
                    break;

                case 400: // 等待十字定位結束
                    break;

                case 500: //  Read VCR
                    // TODO: 利用Recipe取得教點位置           

                    int iRecipeID = Common.GlobalValue.RecipeData;
                    Dictionary<string, string> RecipeInfo = Recipe.CCRecipeListInfo.INIFile.GetSectionValues(string.Format("{0:D4}", iRecipeID));

                    IniTool.IniFile VCRIni = new IniTool.IniFile(Maintain.Teaching.TeachingInfoFactory.GetTeachInfoObject("VCR Teach").IniDirPath + "\\" + RecipeInfo["VCR Teach"]);
                    int iGPos = int.Parse(VCRIni.GetString("VCR", "G Axis", ""));
                    int iSPos = int.Parse(VCRIni.GetString("VCR", "S Axis", ""));
                    double iZPos = double.Parse(VCRIni.GetString("VCR", "Z Axis", ""));

                    SDDE.GetSingleton().SendMessageToTK(string.Format("C401,{0},{1},{1},2000,300,300,1", iSPos/10, iGPos/10));

                    //SDDE.GetSingleton().SendMessageToTK("C401,3199657,7193257,7193257,2000,300,300,1");
                    ContrelModule.ZMotion.ZMAbsMove(iZPos);
                    m_iStageIndex = 600;
                    break;

                case 600: // Wait VCR Position
                    break;

                case 700: // Start to read VCR
                    CCVCRScenario.StartToRead();
                    m_iStageIndex = 800;
                    break;

                case 800: // Wait VCR 讀取
                    break;

                case 900: // Quick 點燈
                    // 送給 TK 點燈位置
                    SDDE.GetSingleton().SendMessageToTK("C602,461000,0,461000,-12000,-2532000,0,-2532000,-33500,37000,1135000,30000,169010,30000,-1117000");
                    m_iStageIndex = 1000;
                    break;

                case 1000: // 開始做點燈
                    SDDE.GetSingleton().SendMessageToTK("C305");
                    m_iStageIndex = 1100;
                    break;

                case 1100: // Wait R305
                    break;

                case 1200: // 等待退料
                    break;

                case 1300: // 平台自動出料流程
                    SDDE.GetSingleton().SendMessageToTK("C302");
                    m_iStageIndex = 1400;
                    break;

                case 1400: // Wait R302
                    break;

                case 1500: // Receive R302            
                    m_iStageIndex = 0;

                    // 如果只剩下一片出料，就直接下 Unload 指令
                    if (m_iPanelCount == 1 && m_bSupplyEnd == true)
                        m_iLULIndex = 2000;

                    break;

            }
        }
        
        
        #endregion

    }

    public class PatternFind
    {
        private static PatternFind singleton = null;
        private static int m_iPatternFindIdx = 0;
        private static int m_iMarkIdx = 1;
        private Thread objThread = null;
        private static Dictionary<string, Dictionary<string, string>> MarkInfo = new Dictionary<string, Dictionary<string, string>>();
            
        public PatternFind()
        {
            objThread = new Thread(new ThreadStart(PatternFindExecute));
            objThread.Start();
        }

        public void Destory()
        {
            objThread.Abort();
            singleton = null;
        }
        
        public static PatternFind getSingleton()
        {
            if (singleton == null)
            {
                singleton = new PatternFind();
            }
            return singleton;
        }

        public static void PatternFindExecute()
        {
            //Dictionary<string, Dictionary<string, string>> MarkInfo = new Dictionary<string, Dictionary<string, string>>();
            int iXYIdx = 1;
            string[] szMarkString = { "Mark A", "Mark B" };

            while (true)
            {
                switch (m_iPatternFindIdx)
                {
                    case 0:
                        break;

                    case 10:        //載入資訊
                        MarkInfo = new Dictionary<string, Dictionary<string, string>>();

                        int iRecipeID = Common.GlobalValue.RecipeData;
                        Dictionary<string, string> RecipeInfo = Recipe.CCRecipeListInfo.INIFile.GetSectionValues(string.Format("{0:D4}",iRecipeID));

                        IniTool.IniFile MarkIni = new IniTool.IniFile(Maintain.Teaching.TeachingInfoFactory.GetTeachInfoObject("Mark Teach").IniDirPath + "\\" + RecipeInfo["Mark Teach"]);
                        string[] MarkSectionNames = MarkIni.GetSectionNames();
                        foreach (string MarkSection in MarkSectionNames)
                        {
                            MarkInfo.Add(MarkSection, MarkIni.GetSectionValues(MarkSection));
                        }
                                                
                        m_iPatternFindIdx = 20;
                        break;

                    case 20:        //切換到2X
                        //Inspect.InspectPanel.getSingleton().lens1.LensSwitch(0);
                        m_iPatternFindIdx = 30;
                        break;

                    case 25:        //等待切換完畢，由DealError R101,0切換到30
                        break;

                    case 30:        //初始化PF及Load Modal
                        Inspect.InspectPanel.getSingleton().ccd1.PatternFindInit();
                        Inspect.InspectPanel.getSingleton().ccd1.PatternFindLoadModal(MarkInfo["MarkModal"]["ModalName"]);
                        m_iPatternFindIdx = 40;

                        break;

                    case 40:        

                        // 九宮格位置分配表       CCD 馬達座標為    
                        //    ----------                                                      
                        //    |07|08|09|          Y ^                       
                        //    ----------            |                               
                        //    |06|01|02|            |                               
                        //    ----------            |                               
                        //    |05|04|03|            ------>X        
                        //    ----------
                        //                      1  2  3  4  5  6  7  8  9 
                        int[] l_iXWeight = { 0, 0, 1, 1, 0, -1, -1, -1, 0, 1 };
                        int[] l_iYWeight = { 0, 0, 0, -1, -1, -1, 0, 1, 1, 1 };

                        int iXPos = int.Parse(MarkInfo[szMarkString[m_iMarkIdx]]["S Position"]) / 10 + (l_iXWeight[iXYIdx] * int.Parse(MarkInfo["Serach Pitch"]["Pitch"]));
                        int iYPos = int.Parse(MarkInfo[szMarkString[m_iMarkIdx]]["G Position"]) / 10 + (l_iYWeight[iXYIdx] * int.Parse(MarkInfo["Serach Pitch"]["Pitch"]));
                        //int iZPos = int.Parse(MarkInfo[szMarkString[m_iMarkIdx]]["G Position"]) / 10 + (l_iYWeight[iXYIdx] * int.Parse(MarkInfo["Serach Pitch"]["Pitch"]));

                        string szCmd;

                        szCmd = "C401," + iXPos.ToString() + ","
                                        + iYPos.ToString() + ","
                                        + iYPos.ToString() + "," + "200,300,300,1";

                        SDDEMsg.SDDE.GetSingleton().SendMessageToTK(szCmd);

                        // Damon Add 20100803, 跑Z軸高度
                        string ZPos = MarkInfo[szMarkString[m_iMarkIdx]]["Z Position"];
                        ContrelModule.ZMotion.ZMAbsMove(double.Parse(ZPos));

                        m_iPatternFindIdx = 45;
                        break;

                    case 45:        //等待移動完畢，由DealError R401,0切換到50
                        break;

                    case 50:
                        //Inspect.InspectPanel.getSingleton().zMotionControl1.AF();
                        ContrelModule.ZMotion.ZMAutofocus();
                        m_iPatternFindIdx = 55;
                        break;

                    case 55:
                        if (ContrelModule.ZMotion.ZMReady())
                        {
                            m_iPatternFindIdx = 60;
                        }
                        break;

                    case 60:
                        if (Inspect.InspectPanel.getSingleton().ccd1.PatternFindModalResult(1, MarkInfo["MarkModal"]["ModalName"]) == 1)
                        {
                            Inspect.InspectPanel.getSingleton().ccd1.DrawCross(1, 1, 1, 320, 240, 640, 480, 0x0000FF);
                            if (m_iMarkIdx == 0)
                            {
                                m_iMarkIdx = 1;
                                m_iPatternFindIdx = 40;
                            }
                            else
                            {
                                m_iPatternFindIdx = 70;
                            }
                            iXYIdx = 1;
                        }
                        else
                        {
                            Inspect.InspectPanel.getSingleton().ccd1.DrawCross(1, 1, 1, 320, 240, 640, 480, 0x0000FF);
                            if (iXYIdx == 9)
                            {
                                Common.GlobalValue.AlarmQueue.Enqueue("A001");
                                m_iPatternFindIdx = 0;
                            }
                            else
                            {
                                iXYIdx++;
                                m_iPatternFindIdx = 40;
                            }
                        }
                        break;

                    case 70:
                        Inspect.InspectPanel.getSingleton().ccd1.PatternFindReleaseAllModal();
                        m_iPatternFindIdx = 80;
                        break;

                    case 80:
                        Inspect.InspectPanel.getSingleton().ccd1.PatternFindRelease();
                        m_iPatternFindIdx = 0;

                        // 通知 Scenario十字定位OK
                        //if (Scenario.ScenarioIndex == 140)
                        //    Scenario.ScenarioIndex = 150;
                        if (Scenario.StageIndex == 400)
                            Scenario.StageIndex = 500;

                        break;
                }

                Thread.Sleep(1);
            }
        }
        public static void StartPatternFind()
        {
            if (m_iPatternFindIdx == 0)
            {
                m_iMarkIdx = 0;
                m_iPatternFindIdx = 10;
            }
        }

        public static int PatternFindIdx
        {
            get { return m_iPatternFindIdx; }
            set { m_iPatternFindIdx = value; }
        }
    }
}
