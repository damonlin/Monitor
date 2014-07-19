using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Common.Template;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Drawing.Imaging;
using Module;

namespace Inspect
{
    public partial class InspectPanel : InfoPanelTemplate
    {
        private static InspectPanel singleton = null;
        static Vision.pHookFunc rtety = null;

        public InspectPanel()
        {
            InitializeComponent();

            rtety = new Vision.pHookFunc(CCDHook);
            ccd1.RegHookFunction(1, rtety);
        }

        public static InspectPanel getSingleton()
        {
            if (singleton == null)
            {
                singleton = new InspectPanel();
            }
            return singleton;
        }

        private void CCDHook(Vision._MouseInfo mouseHook)
        {
            if (mouseHook.ievent == Vision.HookMouseEvent.WM_RBUTTONDOWN)
            {
                switch (Common.GlobalValue.Lens)
                {
                    case 0: // 2X
                        // 2­¿
                        {
                            int Pixelx = (ccd1.Width / 2) - mouseHook.dPointX;
                            int UmX = Pixelx * 5;
                            int PluseX = UmX * 5 * 2;
                           
                            int Pixely = ((ccd1.Height / 2) - mouseHook.dPointY) * (-1);
                            int Umy = Pixely * 5;
                            int Plusey = Umy * 5 * 2;
                           
                            SDDEMsg.SDDE.GetSingleton().SendMessageToTK(string.Format("C930,0,{0:d},{1:d},{1:d},0,1000,300,300,0", Plusey, PluseX));
                        }
                        break;

                    case 1: // 5X
                        // 2­¿
                        {
                            int Pixelx = (ccd1.Width / 2) - mouseHook.dPointX;
                            int UmX = Pixelx * 1;
                            int PluseX = UmX * 5 *2;

                            int Pixely = ((ccd1.Height / 2) - mouseHook.dPointY) * (-1);
                            int Umy = Pixely * 1;
                            int Plusey = Umy * 5 *2;

                            SDDEMsg.SDDE.GetSingleton().SendMessageToTK(string.Format("C930,0,{0:d},{1:d},{1:d},0,1000,300,300,0", Plusey, PluseX));
                        }
                        break;

                    case 2: // 20X
                        {
                            int Pixelx = (ccd1.Width / 2) - mouseHook.dPointX;
                            double UmX = Pixelx * 0.5;
                            double PluseX = UmX * 5 *2;

                            int Pixely = ((ccd1.Height / 2) - mouseHook.dPointY) * (-1);
                            double Umy = Pixely * 0.5;
                            double Plusey = Umy * 5 *2;

                            SDDEMsg.SDDE.GetSingleton().SendMessageToTK(string.Format("C930,0,{0:d},{1:d},{1:d},0,1000,300,300,0", (int)Plusey, (int)PluseX));
                        }
                        break;

                    case 3: // 50X
                        {
                            int Pixelx = (ccd1.Width / 2) - mouseHook.dPointX;
                            double UmX = Pixelx * 0.2;
                            double PluseX = UmX * 5 *2;

                            int Pixely = ((ccd1.Height / 2) - mouseHook.dPointY) * (-1);
                            double Umy = Pixely * 0.2;
                            double Plusey = Umy * 5 * 2;
                            SDDEMsg.SDDE.GetSingleton().SendMessageToTK(string.Format("C930,0,{0:d},{1:d},{1:d},0,1000,300,300,0", (int)Plusey, (int)PluseX));
                        }
                        break;
                }
                
            }

            GC.KeepAlive(rtety);
        }

        private void MonitorMappingToReal(int CCDX, int CCDY,ref int MotionX,ref int MotionY)
        {

        }

        private void otherFunction1_Load(object sender, EventArgs e)
        {

        }
    }
}
