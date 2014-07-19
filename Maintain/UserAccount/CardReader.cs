using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Ports;
using System.Text;
using System.Windows.Forms;

namespace Maintain
{
    public partial class CardReader : Component
    {
        private static CardReader singleton = null;
        private CardReaderType enumCardReaderType = CardReaderType.HID;
        private TransmissionRate objTransmissionRate = new TransmissionRate();
        private TextBox objForSetCardID = null;
        private SerialPort objForCardReader = new SerialPort();
        private delegate void TextDelegate(int iCardID);
        
        public CardReader()
        {
            InitializeComponent();

            objForCardReader.DataReceived += CardReader_DataReceived;
                
        }
        
        ~CardReader()
        {
            objForCardReader.Close();
        }

        public CardReader(IContainer container)
        {
            if (singleton == null)
            {
                singleton = new CardReader();
            }

            container.Add(singleton);
        }

        void CardReader_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (objForSetCardID.Visible)
            {
                string szReaderString = objForCardReader.ReadTo("");

                switch (enumCardReaderType)
                {
                    case CardReaderType.HID:
                        if (szReaderString.Length != 11)
                            return;

                        int iCardID = int.Parse(szReaderString.Substring(7, 4), System.Globalization.NumberStyles.HexNumber);
                        objForSetCardID.Invoke(new TextDelegate(textDelegate), iCardID);
                        break;

                    case CardReaderType.RFID:
                        break;
                }
            }
        }

        private void textDelegate(int iCardID)
        {
            objForSetCardID.Text = iCardID.ToString();
        }

        public CardReaderType CardType
        {
            get
            {
                if (singleton != null)
                {
                    return singleton.enumCardReaderType;
                }
                else
                {
                    return enumCardReaderType;
                }
            }
            set
            {
                if (singleton != null)
                {
                    singleton.enumCardReaderType = value;
                }
                else
                {
                    enumCardReaderType = value;
                }
            }
        }

        [TypeConverterAttribute(typeof(TransmissionRate))]
        public TransmissionRate CardReaderTransmissionRate
        {
            get 
            {
                if (singleton != null)
                {
                    return singleton.objTransmissionRate;
                }
                else
                {
                    return objTransmissionRate;
                }
            }
            set
            {
                if (singleton != null)
                {
                    if (singleton.objForCardReader.IsOpen != true)
                    {
                        singleton.objTransmissionRate = value;
                    
                        singleton.objForCardReader.PortName = string.Format("COM{0:d}", singleton.objTransmissionRate.PortNumber);
                        singleton.objForCardReader.BaudRate = singleton.objTransmissionRate.Boudrate;
                        singleton.objForCardReader.DataBits = singleton.objTransmissionRate.DataBits;
                        singleton.objForCardReader.Parity = singleton.objTransmissionRate.PortParity;
                        singleton.objForCardReader.StopBits = singleton.objTransmissionRate.StopBits;

                        if (Common.CTAPSetup.EnableCardReader)
                        {
                            singleton.objForCardReader.Open();
                        }
                    }
                }
                else
                {
                    objTransmissionRate = value;

                    objForCardReader.PortName = string.Format("COM{0:d}", objTransmissionRate.PortNumber);
                    objForCardReader.BaudRate = objTransmissionRate.Boudrate;
                    objForCardReader.DataBits = objTransmissionRate.DataBits;
                    objForCardReader.Parity = objTransmissionRate.PortParity;
                    objForCardReader.StopBits = objTransmissionRate.StopBits;
                }
            }
        }

        public TextBox TextBoxForSetCardID
        {
            get
            {
                if (singleton != null)
                {
                    return singleton.objForSetCardID;
                }
                else
                {
                    return objForSetCardID;
                }
            }
            set
            {
                if (singleton != null)
                {
                    singleton.objForSetCardID = value;
                }
                else
                {
                    objForSetCardID = value;
                } 
            }
        }
    }

    public enum CardReaderType
    {
        HID = 0,
        RFID = 1
    }

    public class TransmissionRate : ExpandableObjectConverter
    {
        private int iPortNumber = 0;
        private int iBaudRate = 9600;
        private int iDataBits = 8;
        private StopBits enumStopBits = StopBits.One;
        private Parity enumParity = Parity.None;
        // COM port
        public int PortNumber
        {
            get { return iPortNumber; }
            set { iPortNumber = value; }
        }

        // Port Boudrate
        public int Boudrate
        {
            get { return iBaudRate; }
            set { iBaudRate = value; }
        }

        // Port DataBits
        public int DataBits
        {
            get { return iDataBits; }
            set { iDataBits = value; }
        }

        // Port StopBits
        public StopBits StopBits
        {
            get { return enumStopBits; }
            set { enumStopBits = value; }
        }

        // Port Parity
        public Parity PortParity
        {
            get { return enumParity; }
            set { enumParity = value; }
        }
    }
}
