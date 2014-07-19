using System;
using System.Collections.Generic;
using System.Text;
using CommunicationInterface;
using System.Timers;

namespace Maintain.TestZone
{
    public class CCLaserTriggerInterface
    {
        #region Define Const 
        private const int MAX_CARD_NUM = 5;
        #endregion

        #region Private Member
        private static CCLaserTriggerInterface m_Singleton = null;
        private CCStandardInterface m_Interface = new CCStandardInterface();
        private const uint MAX_MOTOR_NUM = 8;
        private const uint MAX_SHUTTER_NUM = 2;

        private int m_MotorBusyMap = 0;
        private int m_iQueryScenarioIdx = 0;
        //private Timer m_ScenarioTimer = new Timer(500);
        private int m_iMotorIdx = 1;
        #endregion

        #region Ctor
        protected CCLaserTriggerInterface()
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
            m_Interface.Parser = new CCLaserTriggerParser();

            // Setup Dispatcher
            CCLaserTriggerDispatcher dispatcher = new CCLaserTriggerDispatcher(m_Interface);
            dispatcher.LaserInterface = this;
            m_Interface.Dispatcher = dispatcher;

            m_Interface.EnableRetry = false;
            m_Interface.Create();

            // Setup Timer
            //m_ScenarioTimer.Elapsed += new ElapsedEventHandler(QueryStatusScenario);

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
        private void SendReadCommand(char p_Address)
        {
            char[] message = new char[1 + 1 + 2]; // CMD(1 Byte) + real data byte coun(1 Byte) + Address(2 Byte)

            message[0] = (char)RequestCommand.ReadDataFromFPGA; // Command
            message[1] = (char)0x04; // 要讀取的位元數： 4 Bytes
            message[2] = (char)((int)p_Address >> 8);       // 取高 8 位元
            message[3] = (char)((int)p_Address & 0xFF);  // 取低 8 位元
            
            m_Interface.SendMessage(new string(message));
        }

        private void SendWriteCommand(char p_Address, char[] p_strData)
        {
            /*
             * It's really hard to explain why I do this.....(:
             * Basically, p_strData is "NOT" really data to be sent, the real data contains "real data byte count(1 Byte)" + "address(2 Byte)" + "real data(4 Byte) "
             */
            char[] message = new char[1 + 1 + 2 + 4]; // CMD(1 Byte) + real data byte count(1 Byte) + Address(2 Byte) + Real Data(4 Byte)

            message[0] = (char)RequestCommand.WriteDataToFPGA; // Command
            message[1] = (char)p_strData.Length; // Write Data Length: 真正要寫入的資料      
            message[2] = (char)((int)p_Address >> 8);      // 取高 8 位元
            message[3] = (char)((int)p_Address & 0xFF); // 取低 8 位元

            Array.Copy(p_strData, 0, message, 4, p_strData.Length);
            m_Interface.SendMessage(new string(message));
        }
                
        #endregion

        #region Public Method
        
        public static CCLaserTriggerInterface getSingleton()
        {
            if (m_Singleton == null)
                m_Singleton = new CCLaserTriggerInterface();
            return m_Singleton;
        }

        public void Destroy()
        {
            m_Interface.Destroy();
        }
        #endregion

        #region Laser Trigger Card 寫入函式

        /// <summary>
        /// 設定 Trigger Card 的控制模式。
        /// </summary>
        /// <param name="p_iCh1">Channel 1 -> 0:UnUse / 1:FIFO /2:Linear</param>
        /// <param name="p_iCh2">Channel 2 -> 0:UnUse / 1:FIFO /2:Linear</param>
        /// <param name="p_iCh3">Channel 3 -> 0:UnUse / 1:FIFO /2:Linear</param>
        /// <param name="p_iCh4">Channel 4 -> 0:UnUse / 1:FIFO /2:Linear</param>
        public void TrigCardModeSet(int p_iCh1, int p_iCh2, int p_iCh3, int p_iCh4)
        {
            if ((p_iCh1 > 2 && p_iCh1 < 0) || (p_iCh2 > 2 && p_iCh2 < 0) || (p_iCh3 > 2 && p_iCh3 < 0) || (p_iCh4 > 2 && p_iCh4 < 0))
                return;

            int iCardVal = 0;
            
            if (p_iCh1 == 1)
                iCardVal |= 0x01;
            else if (p_iCh1 == 2)
                iCardVal |= 0x10;

            if (p_iCh2 == 1)
                iCardVal |= 0x02;
            else if (p_iCh2 == 2)
                iCardVal |= 0x20;

            if (p_iCh2 == 1)
                iCardVal |= 0x04;
            else if (p_iCh2 == 2)
                iCardVal |= 0x40;

            if (p_iCh2 == 1)
                iCardVal |= 0x08;
            else if (p_iCh2 == 2)
                iCardVal |= 0x80;

            SendWriteCommand((char)WriteRegisterAddress.EN_CTL, 
                                              new char[] { (char)iCardVal });
        }

        /// <summary>
        /// 設定Trigger Card的IN_CTL。
        /// </summary>
        /// <param name="p_iCh1">Channel 1 -> 0:UnUse / 1:FIFO /2:Linear</param>
        /// <param name="p_iCh2">Channel 2 -> 0:UnUse / 1:FIFO /2:Linear</param>
        /// <param name="p_iCh3">Channel 3 -> 0:UnUse / 1:FIFO /2:Linear</param>
        /// <param name="p_iCh4">Channel 4 -> 0:UnUse / 1:FIFO /2:Linear</param>
        public void TrigCardPhaseInSwitch(int p_iCh1, int p_iCh2, int p_iCh3, int p_iCh4)
        {
            if ((p_iCh1 > 2 && p_iCh1 < 0) || (p_iCh2 > 2 && p_iCh2 < 0) || (p_iCh3 > 2 && p_iCh3 < 0) || (p_iCh4 > 2 && p_iCh4 < 0))
                return;

            int iCardVal = 0;

            iCardVal |= p_iCh1 & 0x03;
            iCardVal |= (p_iCh2<<2) & 0x0C;
            iCardVal |= (p_iCh3<<4) & 0x30;
            iCardVal |= (p_iCh4<<6) & 0xC0;

            SendWriteCommand((char)WriteRegisterAddress.IN_CTL, 
                                              new char[] { (char)iCardVal });
        }

        /// <summary>
        /// 設定Trigger Card的OUT_CTL。
        /// </summary>
        /// <param name="p_iOut1">Out1 Value</param>
        /// <param name="p_iOut2">Out2 Value</param>
        /// <param name="p_iOut3">Out3 Value</param>
        /// <param name="p_iOut4">Out4 Value</param>
        /// <param name="p_iOut5">Out5 Value</param>
        /// <param name="p_iOut6">Out6 Value</param>
        /// <param name="p_iOut7">Out7 Value</param>
        /// <param name="p_iOut8">Out8 Value</param>
        public void TrigCardPhaseOutSwitch(int p_iOut1, int p_iOut2, int p_iOut3, int p_iOut4, int p_iOut5, int p_iOut6, int p_iOut7, int p_iOut8)
        {          
            int iFirstByte = 0, iSecondByte = 0, iThirdByte = 0, iForthByte = 0;

            iFirstByte |= (p_iOut2 << 4);
            iFirstByte |= p_iOut1;

            iSecondByte |= (p_iOut4 << 4);
            iSecondByte |= p_iOut3;

            iThirdByte |= (p_iOut6 << 4);
            iThirdByte |= p_iOut5;

            iForthByte |= (p_iOut8 << 4);
            iForthByte |= p_iOut7;

            SendWriteCommand((char)WriteRegisterAddress.OUT_CTL,
                                              new char[] { (char)iForthByte, (char)iThirdByte, (char)iSecondByte, (char)iFirstByte });
        }

        /// <summary>
        /// 設定TriggerCard的 Filter Value。
        /// </summary>
        /// <param name="p_iCh">Channel 編號</param>
        /// <param name="p_iiNoiseFilter">Filter 值</param>
        public void TrigCardSetFilter(int p_iCh, int p_iNoiseFilter)
        {
            if (p_iCh <= 0 || p_iCh > 4)
                return;

            SendWriteCommand( (char)((int)WriteRegisterAddress.NoiseFilterValue_1 * p_iCh),
                                               new char[] { (char)p_iNoiseFilter }); 

        }

        /// <summary>
        /// 設定Trigger Card Type 1 的細部參數 ：Channel 1/ Channel 2。
        /// </summary>
        /// <param name="p_iCh">設定的Channel</param>
        /// <param name="p_iNoiseFilter">Encoder Counter 濾波器</param>
        /// <param name="p_iTriggerWidth">Trigger Pulse clock count of counter 1 (Type1 Trigger)</param>
        /// <param name="p_iStartPoint">Start trigger point of linear mode trigger 1(Type1 )</param>
        /// <param name="p_iRepeat">After start trigger, repeat times of linear mode trigger 1 (Type1 )</param>
        /// <param name="p_iPeriod">The interval count between this trigger and next trigger (Linear Trigger 1 ) (Type1)</param>
        public void TrigCardSetEncoderValueForType1(int p_iCh, int p_iNoiseFilter, int p_iTriggerWidth, int p_iStartPoint, int p_iRepeat, int p_iPeriod)
        {
            if (p_iCh <= 0 || p_iCh > 2)
                return;

            SendWriteCommand( (char)((int)WriteRegisterAddress.NoiseFilterValue_1 * p_iCh),
                                               new char[] { (char)p_iNoiseFilter });

            SendWriteCommand( (char)((int)WriteRegisterAddress.TriggerPulseWidth_1 * p_iCh),
                                               new char[] { (char)p_iTriggerWidth });

            SendWriteCommand( (char)((int)WriteRegisterAddress.LT_StartPoint_1 * p_iCh),
                                               new char[] { (char)p_iStartPoint });

            SendWriteCommand( (char)((int)WriteRegisterAddress.LT_RepeatTimes_1 * p_iCh),
                                               new char[] { (char)p_iRepeat });

            SendWriteCommand( (char)((int)WriteRegisterAddress.LT_Period_1 * p_iCh),
                                               new char[] { (char)p_iPeriod });
        }

        /// <summary>
        /// 設定 Trigger Card Type 2 的細部參數。
        /// </summary>
        /// <param name="p_iCh">設定的Channel</param>
        /// <param name="p_iNoiseFilter">Encoder Counter 濾波器</param>
        /// <param name="p_iTriggerWidth">Encoder Counter 3之motion方向偵測, 當移動方向連續此count以後, 才確定方向</param>
        /// <param name="p_iStartPoint">Start trigger point of linear mode trigger 1(Type2 )</param>
        /// <param name="p_iRepeat">After start trigger, repeat times of linear mode trigger 1 (Type2 )</param>
        /// <param name="p_iPeriod">The interval count between this trigger and next trigger (Linear Trigger 1 ) (Type2)</param>
        /// <param name="p_iAssertInterval">當linear trigger 3 assert , 經過此encoder count後, deassert. (Type2)</param>
        public void TrigCardSetEncoderValueForType2(int p_iCh, int p_iNoiseFilter, int p_iTriggerWidth, int p_iStartPoint, int p_iRepeat, int p_iPeriod, int p_iAssertInterval)
        {
            if (p_iCh <= 2|| p_iCh > 4)
                return;

            SendWriteCommand(  (char)((int)WriteRegisterAddress.NoiseFilterValue_1 * p_iCh),
                                                 new char[] { (char)p_iNoiseFilter });

            SendWriteCommand(   (char)((int)WriteRegisterAddress.TriggerPulseWidth_1 * p_iCh),
                                                 new char[] { (char)p_iTriggerWidth });

            SendWriteCommand(  (char)((int)WriteRegisterAddress.LT_StartPoint_1 * p_iCh),
                                                 new char[] { (char)p_iStartPoint });

            SendWriteCommand(  (char)((int)WriteRegisterAddress.LT_RepeatTimes_1 * p_iCh),
                                                 new char[] { (char)p_iRepeat });

            SendWriteCommand(  (char)((int)WriteRegisterAddress.LT_Period_1 * p_iCh),
                                                 new char[] { (char)p_iPeriod });

            SendWriteCommand( (p_iCh == 3) ? (char)WriteRegisterAddress.LT_AssertInterval_3 : (char)WriteRegisterAddress.LT_AssertInterval_4,
                                                 new char[] { (char)p_iAssertInterval });
        }

        // TODO:
        public void TrigCardSel_FT_Add_FIFO34(int p_iCh, int p_iStartPos, int p_iStopPos, int p_iTrigDir, int p_iEnTrigDir)
        {                
            
        }

        /// <summary>
        /// 重置Trigger。
        /// </summary>
        /// <param name="p_iCh">Channel 編號</param>
        /// <param name="p_iMode">模式：1 FIFO 2:linear Triger</param>
        public void TrigCardResetMode(int p_iCh, int p_iMode)
        {
            if (p_iCh <= 0 || p_iCh > 4)
                return;

            if (p_iMode == 1) // FIFO Mode
            {
                if( p_iCh == 1 )
                    SendWriteCommand((char)MEM32Address.SelResetFT_1, new char[] { (char)0x01 });
                else if( p_iCh == 2 )
                    SendWriteCommand((char)MEM32Address.SelResetFT_2, new char[] { (char)0x01 });
                else if (p_iCh == 3)
                    SendWriteCommand((char)MEM32Address.SelResetFT_3, new char[] { (char)0x01 });
                else if (p_iCh == 4)
                    SendWriteCommand((char)MEM32Address.SelResetFT_4, new char[] { (char)0x01 });
            }
            else if (p_iMode == 2) // Linear Mode
            {
                if (p_iCh == 1)
                    SendWriteCommand((char)MEM32Address.SelResetLT_1, new char[] { (char)0x01 });
                else if (p_iCh == 2)
                    SendWriteCommand((char)MEM32Address.SelResetLT_2, new char[] { (char)0x01 });
                else if (p_iCh == 3)
                    SendWriteCommand((char)MEM32Address.SelResetLT_3, new char[] { (char)0x01 });
                else if (p_iCh == 4)
                    SendWriteCommand((char)MEM32Address.SelResetLT_4, new char[] { (char)0x01 });
            }
        }

        /// <summary>
        /// 設定 Count 值。
        /// </summary>
        /// <param name="p_iCh">Channel 編號</param>
        /// <param name="p_iCountVal">Counter 值</param>
        public void TrigCardSetCount(int p_iCh, int p_iCountVal)
        {
            if (p_iCh <= 0 || p_iCh > 4)
                return;

            SendWriteCommand((char)((int)MEM32Address.SelSetCounter1 + (0x04 * (p_iCh - 1))), new char[] { (char)p_iCountVal });
        }
        
        /// <summary>
        /// 寫入位置。
        /// </summary>
        /// <param name="p_iCh">Channel 編號</param>
        /// <param name="p_iPos">位置</param>
        public void TrigCardSel_FT_Add_FIFO12(int p_iCh, int p_iPos)
        {
            if( p_iCh == 1 )
                SendWriteCommand((char)MEM32Address.SelAdd_FT_FIFO_1, new char[] { (char)p_iPos });
            else if( p_iCh == 2 )
                SendWriteCommand((char)MEM32Address.SelAdd_FT_FIFO_2, new char[] { (char)p_iPos });
        }

        #endregion

        #region Laser Trigger Card 讀取函式

        /// <summary>
        /// 讀取FIFO的等待項目。
        /// </summary>
        /// <param name="p_iCh">設定的Channel</param>
        public void TrigCardReadFIFOWait(int p_iCh)
        {
            if (p_iCh <= 0 || p_iCh > 4)
                return;

            SendReadCommand( (char)((int)ReadRegisterAddress.ItemCountInFIFO1 + (p_iCh-1) * 4));
        }

        /// <summary>
        /// 讀取Trigger未完成工作項。
        /// </summary>
        /// <param name="p_iCh">設定的Channel</param>
        public void TrigCardReadEncoder(int p_iCh)
        {
            if (p_iCh <= 0 || p_iCh > 4)
                return;

            SendReadCommand((char)((int)ReadRegisterAddress.EncoderCounter1 + (p_iCh - 1) * 4));
        }

        #endregion
    }

    public enum RequestCommand
    {
        WriteDataToFPGA = '\x01',
        ReadDataFromFPGA = '\x02',
        ResetControlCard = '\xFE',
        Echo = '\xFF'
    }
    public enum ReplyCommand
    {
        ReadResponse = '\x01',
        WriteResponse = '\x02',
        ErrorResponse = '\x03',
        EchoResponse = '\xff'
    }
    public enum WriteRegisterAddress
    {
        EN_CTL = '\x0000',
        IN_CTL = '\x0004',
        OUT_CTL = '\x0008',
        NoiseFilterValue_1 = '\x0100',
        TriggerPulseWidth_1 = '\x0104',
        LT_StartPoint_1 = '\x0108',
        LT_RepeatTimes_1 = '\x010C',
        LT_Period_1 = '\x0120',
        LT_AssertInterval_3 = '\x0324',
        LT_AssertInterval_4 = '\x0424'       
    }
    public enum ReadRegisterAddress
    {
        EncoderCounter1 = '\x4000',
        EncoderCounter2 = '\x4004',
        EncoderCounter3 = '\x4008',
        EncoderCounter4 = '\x400C',
        ItemCountInFIFO1 = '\x4100',
        ItemCountInFIFO2 = '\x4104',
        ItemCountInFIFO3 = '\x4108',
        ItemCountInFIFO4 = '\x410C',
        FIFO1_WORK_COUNT_TOTAL = '\x4110',
        FIFO2_WORK_COUNT_TOTAL = '\x4114',
        FIFO3_WORK_COUNT_TOTAL = '\x4118',
        FIFO4_WORK_COUNT_TOTAL = '\x411C',
        RR_ADDR_FIFO3_WORK_START = '\x4200',
        RR_ADDR_FIFO3_WORK_STOP = '\x4204',
        RR_ADDR_FIFO4_WORK_START = '\x4208',
        RR_ADDR_FIFO4_WORK_STOP = '\x420C',
        RR_DB_1 = '\x4300',
        RR_DB_2 = '\x4304'
    }
    public enum MEM64Address
    {
        Sel_FT_Add_FIFO_3 = '\x8000',
        Sel_FT_Add_FIFO_4 = '\x8100'       
    }
    public enum MEM32Address
    {
        SelResetFT_1 = '\xC000',
        SelResetLT_1 = '\xC004',
        SelResetFT_2 = '\xC008',
        SelResetLT_2 = '\xC00C',
        SelResetFT_3 = '\xC010',
        SelResetLT_3 = '\xC014',
        SelResetFT_4 = '\xC018',
        SelResetLT_4 = '\xC01C',
        SelSetCounter1 = '\xC020',
        //SelSetCounter2 = '\xC024',
        //SelSetCounter3 = '\xC028',
        //SelSetCounter4 = '\xC02C',
        SelAdd_FT_FIFO_1 = '\xC200',
        SelAdd_FT_FIFO_2 = '\xC300',
    }
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

    public class CCLaserTriggerParser : CCBaseParser
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
        private const char ETX = '\x30';
        #endregion

        #region Ctor
        public CCLaserTriggerParser()
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
            szSendString[iOffset] = STX;
            iOffset += STX_LENGTH;

            // 2. LEN
            szSendString[iOffset] = (char)(p_szCommand.Length - CMD_LENGTH);// wtf, Command consists of CMD_LENGTH
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
            szSendString[iOffset] = ETX;
            
            return new string(szSendString);
        }
        /*
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
        */
        #endregion
    }

    public class CCLaserTriggerDispatcher : CCBaseDispatcher
    {
        #region Private Member
        private CCLaserTriggerInterface m_laserInterface = null;
        #endregion

        #region Public Property
        public CCLaserTriggerInterface LaserInterface
        {
            set { m_laserInterface = value; }
        }
        #endregion
        
        #region Ctor
        public CCLaserTriggerDispatcher(CCStandardInterface p_Interface)
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
        public Crc16Ccitt(/*InitialCrcValue initialValue*/)
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
    }
}
