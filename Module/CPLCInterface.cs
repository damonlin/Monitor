using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.IO.Ports;
using System.Windows.Forms;

namespace ContrelModule
{
   public class CPLCInterface
    {
        #region Private Member
        private  SerialPort m_SerialPort = null;
        static private CPLCInterface Singleton;

        private enum PLC_COMMAND
        {
            STX = '\x02',
            ETX = '\x03',
            EOT = '\x04',
            ENQ = '\x05',
            ACK = '\x06',
            LF  = '\x0A',
            CL  = '\x0C',
            CR  = '\x0D',
            NAK = '\x15'
        };

        //private enum PLC_REQUSET
        //{
        //    READ        = "0",
        //    WRITE       = "1",
        //    FORCEON     = "7",
        //    FORCEOFF    = "8"
        //};
        #endregion       

        #region Ctor
        protected CPLCInterface()
        {
            m_SerialPort = new SerialPort();
            m_SerialPort.DataReceived += new SerialDataReceivedEventHandler(this.PLCDataReceived);            
        }
        #endregion

        #region properties

        // COM port
        public string PortNumber
        {
            get { return m_SerialPort.PortName; }
            set
            {
                if (m_SerialPort.IsOpen == false)
                    m_SerialPort.PortName = value;
            }
        }

        // Port Boudrate
        public int PortBoudrate
        {
            get { return m_SerialPort.BaudRate; }
            set
            {
                if (m_SerialPort.IsOpen == false)
                    m_SerialPort.BaudRate = value;
            }
        }

        // Port DataBits
        public int PortDataBits
        {
            get { return m_SerialPort.DataBits; }
            set
            {
                if (m_SerialPort.IsOpen == false)
                    m_SerialPort.DataBits = value;
            }
        }

        // Port StopBits
        public StopBits PortStopBits
        {
            get { return m_SerialPort.StopBits; }
            set
            {
                if (m_SerialPort.IsOpen == false)
                    m_SerialPort.StopBits = value;
            }
        }

        // Port Parity
        public Parity PortParity
        {
            get { return m_SerialPort.Parity; }
            set
            {
                if (m_SerialPort.IsOpen == false)
                    m_SerialPort.Parity = value;
            }
        }

        // Port DataReceived     
        public SerialDataReceivedEventHandler DataReceiveHandler
        {
            set
            {
                //if (m_SerialPort.IsOpen == false)
                    m_SerialPort.DataReceived += value;
            }            
        }        
        #endregion

       #region Public Method

       public static CPLCInterface GetSingleton()
       {
           if (Singleton == null)
               Singleton = new CPLCInterface();
           return Singleton;
       }

       public void Open()
       {
            m_SerialPort.Open();
       }

       public void Close()
       {
            m_SerialPort.Close();
       }

       public byte[] Receive()
       {
            int nbytes = m_SerialPort.BytesToRead;
            byte[] data = new byte[nbytes];
            m_SerialPort.Read(data, 0, data.Length);
            return data;
       }

       public void PLCConnect(string startAddr, int count)
       {
           //ENQ + 站號 + PLC型號 + BR + 延時 + 開始位址 + 長度 + checksum
           StringBuilder cmd = new StringBuilder(30);

           cmd.Append( (char)PLC_COMMAND.ENQ );
           cmd.Append("00");
           cmd.Append("FF");
           cmd.Append("WR");
           cmd.Append("A");
           cmd.Append("D0008");
           cmd.Append("01");
           //cmd.Append(count.ToString("01"));

           string checksum = CheckSum(cmd);
           cmd.Append(checksum);
           m_SerialPort.Write(cmd.ToString());
       }

       public void PLCReadWord()
       {
           //STX　Cmd　Addrs　Bytes　Data　ETX　SUM
           StringBuilder cmd = new StringBuilder(30);

           cmd.Append((char)PLC_COMMAND.STX);
           cmd.Append("0");
           cmd.Append("00A0");
           cmd.Append("02");
           cmd.Append((char)PLC_COMMAND.ETX);

           string checksum = CheckSum(cmd);
           cmd.Append(checksum);
           m_SerialPort.Write(cmd.ToString());
       }
     
       public void PLCWriteWord_D()
       {
           //ENQ + 站號 + PLC型號 + BR + 延時 + 開始位址 + 長度 + checksum
           StringBuilder cmd = new StringBuilder(30);

           cmd.Append((char)PLC_COMMAND.ENQ);
           cmd.Append("00");
           cmd.Append("FF");
           cmd.Append("WW");
           cmd.Append("A");
           cmd.Append("D0008");
           cmd.Append("02");
           cmd.Append("FFFF1111");
           //cmd.Append(count.ToString("01"));

           string checksum = CheckSum(cmd);
           cmd.Append(checksum);
           m_SerialPort.Write(cmd.ToString());
       }
       public void PLCReadWord_D()
       {
           //ENQ + 站號 + PLC型號 + BR + 延時 + 開始位址 + 長度 + checksum
           StringBuilder cmd = new StringBuilder(30);

           cmd.Append((char)PLC_COMMAND.ENQ);
           cmd.Append("00");
           cmd.Append("FF");
           cmd.Append("WR");
           cmd.Append("A");
           cmd.Append("D0008");
           cmd.Append("01");
           //cmd.Append(count.ToString("01"));

           string checksum = CheckSum(cmd);
           cmd.Append(checksum);
           m_SerialPort.Write(cmd.ToString());
       }

       public void PLCWriteBit_M()
       {
           //ENQ + 站號 + PLC型號 + BR + 延時 + 開始位址 + 長度 + checksum
           StringBuilder cmd = new StringBuilder(30);

           cmd.Append((char)PLC_COMMAND.ENQ);
           cmd.Append("00");
           cmd.Append("FF");
           cmd.Append("BW");
           cmd.Append("A");
           cmd.Append("M0010");
           cmd.Append("05");
           cmd.Append("00001");
           //cmd.Append(count.ToString("01"));

           string checksum = CheckSum(cmd);
           cmd.Append(checksum);
           m_SerialPort.Write(cmd.ToString());
       }

       public void PLCReadBit_M()
       {
           //ENQ + 站號 + PLC型號 + BR + 延時 + 開始位址 + 長度 + checksum
           StringBuilder cmd = new StringBuilder(30);

           cmd.Append((char)PLC_COMMAND.ENQ);
           cmd.Append("00");
           cmd.Append("FF");
           cmd.Append("BR");
           cmd.Append("A");
           cmd.Append("M0010");
           cmd.Append("05");          
           //cmd.Append(count.ToString("01"));

           string checksum = CheckSum(cmd);
           cmd.Append(checksum);
           m_SerialPort.Write(cmd.ToString());
       }

       
       public void PLCWriteWord_R()
       {
           //STX　Cmd　Addrs　Bytes　Data　ETX　SUM
           StringBuilder cmd = new StringBuilder(30);

           cmd.Append((char)PLC_COMMAND.STX);
           cmd.Append("1");
           cmd.Append("10F6");  // address    
           cmd.Append("04");    // byte 數

           // D123: 12 34
           // D124: AB CD
           cmd.Append("22");    // 第一筆資料
           cmd.Append("33");
           cmd.Append("11");
           cmd.Append("44");
           cmd.Append((char)PLC_COMMAND.ETX);

           string checksum = CheckSum(cmd);
           cmd.Append(checksum);
           m_SerialPort.Write(cmd.ToString());
       }       

       public void PLCReadWord_R()
       {
           //STX　Cmd　Addrs　Bytes　Data　ETX　SUM
           StringBuilder cmd = new StringBuilder(30);

           cmd.Append((char)PLC_COMMAND.STX);
           cmd.Append("0");
           cmd.Append("00A0");  // address    
           cmd.Append("02");    // byte 數
           
           cmd.Append((char)PLC_COMMAND.ETX);

           string checksum = CheckSum(cmd);
           cmd.Append(checksum);
           m_SerialPort.Write(cmd.ToString());
       }

       
       public void PLCSendACK()
       {
           //STX　Cmd　Addrs　Bytes　Data　ETX　SUM
           StringBuilder cmd = new StringBuilder(30);

           cmd.Append((char)PLC_COMMAND.ACK);
           cmd.Append("00FF");
           
           string checksum = CheckSum(cmd);
           cmd.Append(checksum);
           m_SerialPort.Write(cmd.ToString());
       }



       //public void StartContinusReadVCR()
       // {
       //     byte[] initialVCR = new byte[2] { (byte)'g', 0x0D };
       //     m_SerialPort.Write(initialVCR, 0, initialVCR.Length);
       //     Thread.Sleep(10);

       //     byte[] continusCMD = new byte[8 + 1] { (byte)'c', (byte)'o', (byte)'n', (byte)'t', (byte)'i', (byte)'n', (byte)'u', (byte)'e', 0x0D };            
       //     m_SerialPort.Write(continusCMD, 0, continusCMD.Length);
       // }

       // public void StopContinueReadVCR()
       // {
       //     byte[] continusCMD = new byte[4 + 1] { (byte)'s', (byte)'t', (byte)'o', (byte)'p', 0x0D };
       //     m_SerialPort.Write(continusCMD, 0, continusCMD.Length);
       // }
       public void PLCDataReceived(object sender, SerialDataReceivedEventArgs e)
       {
           byte[] data = Receive();
           int iOffset = 0;

           if (data.Length <= 0)
               return;

           switch (data[iOffset])
           {
               case (int)PLC_COMMAND.ACK: // 'V'
                   //PLCReadWord();
                   //PLCWriteWord();
                   //PLCReadWord_R();
                   break;

               case (int)PLC_COMMAND.STX: // 'V'
                   //PLCReadWord_R();
                   //PLCWriteWord();
                   //PLCSendACK();
                   break;

               case (int)PLC_COMMAND.ETX: // 'V'
                   //PLCReadWord();
                   //PLCWriteWord();
                   //PLCSendACK();
                   break;

               case (int)PLC_COMMAND.NAK: // 'V'
                   break;
           }
       }
       #endregion

       #region Private Method
       
       private string CheckSum(StringBuilder str)
       {
            //宣告：int為整數、string為字符串
            int sum = 0;
            string checkstring = "";
            string checksum = "";
     
            //通訊格式中的英文字符必須為大寫(a~f)，故先行將text所輸入之傳送數據，經由程序自動轉換為大寫字母，然後加上結束碼etx：chr(3)，形成一字符串checkstring
            checkstring = str.ToString();
     
            // for屬於重複結構中之計數循環，指令pc在一定的次數內，重複的執行某一敘述區段，亦即取出checkstring字符串中每一個字符，並累加每一個字符的ascii碼，而得出一整數sum。
            for (int i = 1; i < checkstring.Length; i++) 
            {
                int tmp = Convert.ToInt32(checkstring[i]);
                sum += tmp;
            }
     
            //將10進制整數sum轉換為16進制，並取其右邊二位數，即為所求檢查碼。
            checksum = String.Format("{0:X}", sum);
            checksum.PadLeft(2,'0');
            checksum = checksum.Substring(checksum.Length - 2, 2);
         
            return checksum;
        } 
       #endregion      
        
    }
}
