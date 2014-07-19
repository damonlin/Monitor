using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using IniTool;
using System.IO;

namespace Maintain.Teaching
{
    public partial class CCLaserPathTeachControl : Common.Wizard.CCInteriorWizardPage
    {

        #region Private Member
        private CCLaserPathTeachInfo m_info = new CCLaserPathTeachInfo();
        private List<Point> m_listPath = new List<Point>();
        private LaserPathMove m_auto_first_direction = LaserPathMove.LASER_PATH_MOVE_FIRSTY;
        private LaserPathMove m_auto_dirX = LaserPathMove.LASER_PATH_MOVE_LEFT;
        private LaserPathMove m_auto_dirY = LaserPathMove.LASER_PATH_MOVE_UP;
        private enum LaserPathMove
        {
            LASER_PATH_MOVE_LEFT = 120,   //  X軸移動方向
            LASER_PATH_MOVE_RIGHT,        //  X軸移動方向
            LASER_PATH_MOVE_UP,              //  Y軸移動方向 
            LASER_PATH_MOVE_DOWN,        //  Y軸移動方向
            LASER_PATH_MOVE_FIRSTX,      //  第一個移動方向 X
            LASER_PATH_MOVE_FIRSTY,      //  第一個移動方向 Y
            LASER_PATH_MOVE_ANGLE,      //  移動方向有角度
            LASER_PATH_MOVE_LEFTUP,     //  左上
            LASER_PATH_MOVE_LEFTDOWN,  //  左下
            LASER_PATH_MOVE_RIGHTUP,   //  右上
            LASER_PATH_MOVE_RIGHTDOWN  //  右下
        };
        private CCLaserPathStrategy m_Strategy = null;

        #endregion

        #region Ctor
        public CCLaserPathTeachControl()
        {
            InitializeComponent();

            // 將資料交由 TeachingInfoFactory 管理            
            TeachingInfoFactory.RegisterTeachInfoToFactory(m_info);

            // Load Ini in order to show
            LoadIniFilesList();
        }
        #endregion

        #region Protected Method
        protected override bool OnSetActive()
        {
            if (!base.OnSetActive())
                return false;

            // Enable both the Next and Back buttons on this page    
            Wizard.SetWizardButtons(Common.Wizard.WizardButton.Back | Common.Wizard.WizardButton.Next);
            return true;
        }
        #endregion

        #region Private Method
        private void m_btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog DialogSave = new SaveFileDialog();
            DialogSave.InitialDirectory = TeachingInfoFactory.GetTeachInfoObject("Laser Path").IniDirPath;
            DialogSave.Filter = "Ini file (*.ini)|";
            DialogSave.DefaultExt = "ini";

            if (DialogSave.ShowDialog() == DialogResult.OK)
            {
                if (DialogSave.FileName != "")
                {
                    IniFile iniFile = new IniFile(DialogSave.FileName);

                    iniFile.WriteValue("Laser Para", "LaserPower", m_txbLaserPower.Text);
                    iniFile.WriteValue("Laser Para", "Acc", m_txbAcc.Text);
                    iniFile.WriteValue("Laser Para", "Speed", m_txbSpeed.Text);
                    iniFile.WriteValue("Laser Para", "Dec", m_txbDec.Text);

                    for (int iIdx = 0; iIdx < m_listPath.Count; ++iIdx)
                    {
                        iniFile.WriteValue("Laser Point", String.Format("X-{0}", iIdx), m_listPath[iIdx].X);
                        iniFile.WriteValue("Laser Point", String.Format("Y-{0}", iIdx), m_listPath[iIdx].Y);
                    }
                }
            }
            DialogSave.Dispose();
            DialogSave = null;

            // Reload Ini  File List
            LoadIniFilesList();
        }

        private void LoadIniFilesList()
        {
            m_lbLaserPara.Items.Clear();

            string[] filelist = m_info.GetAllFiles();
            m_lbLaserPara.Items.AddRange(filelist);
        }

        private void LoadIniContent()
        {
            if (m_lbLaserPara.SelectedIndex < 0)
            {
                MessageBox.Show("請選擇一個路徑參數");
                return;
            }

            string filepath = m_info.IniDirPath + m_lbLaserPara.SelectedItem.ToString();
            if (!File.Exists(filepath))
                return;

            IniFile iniFile = new IniFile(filepath);
            m_txbLaserPower.Text = iniFile.GetString("Laser Para", "LaserPower", "");
            m_txbAcc.Text = iniFile.GetString("Laser Para", "Acc", "");
            m_txbSpeed.Text = iniFile.GetString("Laser Para", "Speed", "");
            m_txbDec.Text = iniFile.GetString("Laser Para", "Dec", "");

            m_listPath.Clear();
            List<KeyValuePair<string, string>> points = iniFile.GetSectionValuesAsList("Laser Point");
            for (int iIdx = 0; iIdx < points.Count / 2; ++iIdx)
            {
                Point tmp = new Point();
                tmp.X = int.Parse(iniFile.GetString("Laser Point", String.Format("X-{0}", iIdx), ""));
                tmp.Y = int.Parse(iniFile.GetString("Laser Point", String.Format("Y-{0}", iIdx), ""));
                m_listPath.Add(tmp);
            }
            /*
            // test 
            Graphics my = ccd1.CreateGraphics();
            SolidBrush drawBrush = new SolidBrush(Color.White);
            my.DrawLines(new Pen(drawBrush), m_listPath.ToArray());
            */

            ccd1.DrawLines(1, 1, 1, m_listPath, 0x00FF00);
        }

        private void m_btnDelete_Click(object sender, EventArgs e)
        {
            if (m_lbLaserPara.SelectedIndex < 0)
            {
                MessageBox.Show("請選擇一個路徑參數");
                return;
            }

            string filename = m_lbLaserPara.SelectedItem.ToString();
            File.Delete(m_info.IniDirPath + "\\" + filename);

            // Reload Ini  File List
            LoadIniFilesList();
        }

        private void m_btnLoad_Click(object sender, EventArgs e)
        {
            LoadIniContent();
        }

        // Shamelessly stole from IDP4... :)
        private void m_btnAutoDrawPath_Click(object sender, EventArgs e)
        {
            if (m_txbWidth.Text == "" || m_txbHeight.Text == "" || m_txbPitchX.Text == "" || m_txbPitchY.Text == "")
            {
                MessageBox.Show("請輸入雷射路徑範圍與Pitch X&Y");
                return;
            }

            // TODO: 取得目前鏡頭倍率，來換算螢幕上的 Width Height X Pitch Y Pitch
            const int iScaleX = 1;
            if (iScaleX <= 0)
            {
                MessageBox.Show("雷射鏡頭設定有誤");
                return;
            }

            // 刪除所有路徑
            m_listPath.Clear();

            // 設定畫路徑起始點
            Point startPoint = new Point(ccd1.Width / 2, ccd1.Height / 2);

            switch (m_auto_first_direction)
            {
                case LaserPathMove.LASER_PATH_MOVE_FIRSTX:
                    do_drawX(startPoint, iScaleX);
                    break;

                case LaserPathMove.LASER_PATH_MOVE_FIRSTY:
                    do_drawY(startPoint, iScaleX);
                    break;

                case LaserPathMove.LASER_PATH_MOVE_ANGLE:
                    do_drawAngle(startPoint, iScaleX);
                    break;
            }

            ccd1.ClearDraw(1);
            // test 
            //Graphics my = ccd1.CreateGraphics();
            //SolidBrush drawBrush = new SolidBrush(Color.White);
            //my.DrawLines(new Pen(drawBrush), m_listPath.ToArray());
            ccd1.DrawLines(1, 1, 1, m_listPath, 0x00FF00);

            
            // Draw X Axis Line
            List<Point> tmp = new List<Point>();
            tmp.Add(new Point(0, ccd1.Height / 2));
            tmp.Add(new Point(ccd1.Width, ccd1.Height / 2));
            //my.DrawLines(new Pen(drawBrush), tmp.ToArray());
            ccd1.DrawLines(1, 1, 1, tmp, 0x0000FF);
            
            // Draw Y Axis Line
            tmp.Clear();
            tmp.Add(new Point(ccd1.Width / 2, 0));
            tmp.Add(new Point(ccd1.Width / 2, ccd1.Height));
            //my.DrawLines(new Pen(drawBrush), tmp.ToArray());
            ccd1.DrawLines(1, 1, 1, tmp, 0x0000FF);


        }

        /// <summary>
        /// 先從 Y 方向開始畫。        
        /// </summary>
        private void do_drawY(Point p_StartPoint, int p_iScale)
        {
            //  Y Pitch必須大於X Pitch
            if (long.Parse(m_txbPitchX.Text) > long.Parse(m_txbPitchY.Text))
            {
                MessageBox.Show("Y Pitch 必須大於X Pitch");
                return;
            }

            // 根據鏡頭調整
            int width = (int)(long.Parse(m_txbWidth.Text) / p_iScale);
            int height = (int)(long.Parse(m_txbHeight.Text) / p_iScale);
            int X_Pitch = (int)(long.Parse(m_txbPitchX.Text) / p_iScale);
            int Y_Pitch = (int)(long.Parse(m_txbPitchY.Text) / p_iScale);

            if (m_auto_dirX == LaserPathMove.LASER_PATH_MOVE_LEFT)  //  往左
            {
                switch (m_auto_dirY)
                {
                    case LaserPathMove.LASER_PATH_MOVE_UP: //  往上                                               
                        m_Strategy = new CCDrawYUpAndXLeftStrategy(p_StartPoint, width, height, X_Pitch, Y_Pitch);
                        break;

                    case LaserPathMove.LASER_PATH_MOVE_DOWN: //  往下                                              
                        m_Strategy = new CCDrawYDownAndXLeftStrategy(p_StartPoint, width, height, X_Pitch, Y_Pitch);
                        break;
                }
            }
            else if (m_auto_dirX == LaserPathMove.LASER_PATH_MOVE_RIGHT)  //  往右
            {
                switch (m_auto_dirY)
                {
                    case LaserPathMove.LASER_PATH_MOVE_UP: //  往上                                               
                        m_Strategy = new CCDrawYUpAndXRightStrategy(p_StartPoint, width, height, X_Pitch, Y_Pitch);
                        break;

                    case LaserPathMove.LASER_PATH_MOVE_DOWN: //  往下
                        m_Strategy = new CCDrawYDownAndXRightStrategy(p_StartPoint, width, height, X_Pitch, Y_Pitch);
                        break;
                }
            }
            m_listPath.AddRange(m_Strategy.CaculatePath());
        }

        /// <summary>
        /// 先從 X 方向開始畫。        
        /// </summary>
        private void do_drawX(Point p_StartPoint, int p_iScale)
        {
            //  X Pitch必須大於 Y Pitch
            if (long.Parse(m_txbPitchY.Text) > long.Parse(m_txbPitchX.Text))
            {
                MessageBox.Show("X Pitch 必須大於 Y Pitch");
                return;
            }

            // 根據鏡頭調整
            int width = (int)(long.Parse(m_txbWidth.Text) / p_iScale);
            int height = (int)(long.Parse(m_txbHeight.Text) / p_iScale);
            int X_Pitch = (int)(long.Parse(m_txbPitchX.Text) / p_iScale);
            int Y_Pitch = (int)(long.Parse(m_txbPitchY.Text) / p_iScale);

            if (m_auto_dirX == LaserPathMove.LASER_PATH_MOVE_LEFT)  //  往左
            {
                switch (m_auto_dirY)
                {
                    case LaserPathMove.LASER_PATH_MOVE_UP: //  往上                                                                      
                        m_Strategy = new CCDrawXLeftAndYUpStrategy(p_StartPoint, width, height, X_Pitch, Y_Pitch);
                        break;

                    case LaserPathMove.LASER_PATH_MOVE_DOWN: //  往下                                              
                        m_Strategy = new CCDrawXLeftAndYDownStrategy(p_StartPoint, width, height, X_Pitch, Y_Pitch);
                        break;
                }
            }
            else if (m_auto_dirX == LaserPathMove.LASER_PATH_MOVE_RIGHT)  //  往右
            {
                switch (m_auto_dirY)
                {
                    case LaserPathMove.LASER_PATH_MOVE_UP: //  往上                                               
                        m_Strategy = new CCDrawXRightAndYUpStrategy(p_StartPoint, width, height, X_Pitch, Y_Pitch);
                        break;

                    case LaserPathMove.LASER_PATH_MOVE_DOWN: //  往下
                        m_Strategy = new CCDrawXRightAndYDownStrategy(p_StartPoint, width, height, X_Pitch, Y_Pitch);
                        break;
                }
            }
            m_listPath.AddRange(m_Strategy.CaculatePath());
        }

        /// <summary>
        /// 先從 右上，右下，左上，左下 方向開始畫。        
        /// </summary>
        private void do_drawAngle(Point p_StartPoint, int p_iScale)
        {
            int direction = 1;
            double ratio = 0;  //  X Y 的比例  X:Y = 1:1 >> 45度  即斜率
            int boundx1 = 0, boundx2 = 0, boundy1 = 0, boundy2 = 0;

            // 根據鏡頭調整
            int width = (int)(long.Parse(m_txbWidth.Text) / p_iScale);
            int height = (int)(long.Parse(m_txbHeight.Text) / p_iScale);
            int X_Pitch = (int)(long.Parse(m_txbPitchX.Text) / p_iScale);
            int Y_Pitch = (int)(long.Parse(m_txbPitchY.Text) / p_iScale);

            Point start = new Point(ccd1.Size.Width / 2, ccd1.Size.Height / 2);
            int iAngle = int.Parse(m_txbAngle.Text);

            switch (m_auto_dirX)
            {
                case LaserPathMove.LASER_PATH_MOVE_LEFTUP:
                    //  往左上 0~90
                    direction = -1;
                    ratio = Math.Tan((180 - iAngle) * Math.PI / 180);
                    boundx1 = start.X - width;
                    boundy1 = start.Y;
                    boundx2 = start.X;
                    boundy2 = start.Y + height;
                    break;

                case LaserPathMove.LASER_PATH_MOVE_LEFTDOWN:
                    //  往左下 270~360
                    direction = -1;
                    //ratio = Math.Tan((360-(iAngle-180)) * Math.PI / 180);
                    ratio = Math.Tan((360 - iAngle + 180) * Math.PI / 180);
                    boundx1 = start.X;
                    boundy1 = start.Y;
                    boundx2 = start.X + width;
                    boundy2 = start.Y + height;
                    break;

                case LaserPathMove.LASER_PATH_MOVE_RIGHTUP:
                    //  往右上 90~180
                    direction = 1;
                    ratio = Math.Tan((180 - iAngle) * Math.PI / 180);
                    boundx1 = start.X;
                    boundy1 = start.Y;
                    boundx2 = start.X + width;
                    boundy2 = start.Y + height;
                    break;

                case LaserPathMove.LASER_PATH_MOVE_RIGHTDOWN:
                    //  往右下 180~270
                    direction = 1;
                    ratio = Math.Tan((360 - iAngle + 180) * Math.PI / 180);
                    boundx1 = start.X - width;
                    boundy1 = start.Y;
                    boundx2 = start.X;
                    boundy2 = start.Y + height;
                    break;
            }

            //計算起始點的直線方程式
            double start_intercept = start.Y - ratio * start.X;  //  起始點截距

            while (true)
            {
                start_intercept += X_Pitch;  //  下一線段的截距

                //求解與四個線段的交點

                //第一個線段的交點
                int pos1x = 0, pos1y = 0;
                pos1x = boundx1;
                pos1y = (int)(ratio * pos1x + start_intercept);

                //第二個線段的交點
                int pos2x = 0, pos2y = 0;
                pos2y = boundy1;
                pos2x = (int)((pos2y - start_intercept) / ratio);

                //第三個線段的交點
                int pos3x = 0, pos3y = 0;
                pos3x = boundx2;
                pos3y = (int)(ratio * pos3x + start_intercept);

                //第四個線段的交點
                int pos4x = 0, pos4y = 0;
                pos4y = boundy2;
                pos4x = (int)((pos4y - start_intercept) / ratio);

                int count = 0;  //  計算符合條件之點數量
                Point[] InRangePo = new Point[4];

                //  檢查交點是否在範圍內
                if (pos1x >= boundx1 && pos1x <= boundx2 && pos1y >= boundy1 && pos1y <= boundy2)
                {
                    InRangePo[count].X = pos1x;
                    InRangePo[count].Y = pos1y;
                    count++;
                }
                if (pos2x >= boundx1 && pos2x <= boundx2 && pos2y >= boundy1 && pos2y <= boundy2)
                {
                    InRangePo[count].X = pos2x;
                    InRangePo[count].Y = pos2y;
                    count++;
                }
                if (pos3x >= boundx1 && pos3x <= boundx2 && pos3y >= boundy1 && pos3y <= boundy2)
                {
                    InRangePo[count].X = pos3x;
                    InRangePo[count].Y = pos3y;
                    count++;
                }
                if (pos4x >= boundx1 && pos4x <= boundx2 && pos4y >= boundy1 && pos4y <= boundy2)
                {
                    InRangePo[count].X = pos4x;
                    InRangePo[count].Y = pos4y;
                    count++;
                }

                if (count > 2)
                {
                    MessageBox.Show("計算交點判斷錯誤，交點大於2");
                    break;
                }
                if (count == 0)
                    break;  // 所有交點都已經在範圍外

                if (count <= 2)  //  正常情況下只會有兩個交點
                {
                    if (direction == 1)  //  
                    {
                        //  X軸向較小為第一點
                        if (InRangePo[0].X < InRangePo[1].X)
                        {
                            m_listPath.Add(new Point(InRangePo[0].X, InRangePo[0].Y));
                            m_listPath.Add(new Point(InRangePo[1].X, InRangePo[1].Y));
                        }
                        else
                        {
                            m_listPath.Add(new Point(InRangePo[1].X, InRangePo[1].Y));
                            m_listPath.Add(new Point(InRangePo[0].X, InRangePo[0].Y));
                        }
                        direction *= -1;
                    }
                    else if (direction == -1)
                    {
                        //  X軸向較大為第一點
                        if (InRangePo[0].X > InRangePo[1].X)  //  
                        {
                            m_listPath.Add(new Point(InRangePo[0].X, InRangePo[0].Y));
                            m_listPath.Add(new Point(InRangePo[1].X, InRangePo[1].Y));
                        }
                        else
                        {
                            m_listPath.Add(new Point(InRangePo[1].X, InRangePo[1].Y));
                            m_listPath.Add(new Point(InRangePo[0].X, InRangePo[0].Y));
                        }
                        direction *= -1;
                    }
                }  //  end if( count < 2)  //  正常情況下只會有兩個交點
            }  //  while( TRUE )  //  X_Pitch  Y_Pitch                         
        }

        private void m_radio_Click(object sender, EventArgs e)
        {
            RadioButton tmpSender = (RadioButton)sender;

            if (tmpSender == m_radioLeft)
            {
                m_auto_first_direction = LaserPathMove.LASER_PATH_MOVE_FIRSTX;
                m_auto_dirX = LaserPathMove.LASER_PATH_MOVE_LEFT;
                m_auto_dirY = (m_radioYStartUp.Checked) ? LaserPathMove.LASER_PATH_MOVE_UP : LaserPathMove.LASER_PATH_MOVE_DOWN;
                m_txbAngle.Text = String.Format("{0}", 180);

                // Disable Direction Botton
                m_radioXStartLeft.Enabled = false;
                m_radioXStartRight.Enabled = false;
                m_radioYStartUp.Enabled = true;
                m_radioYStartDown.Enabled = true;
            }
            else if (tmpSender == m_radioTopLeft)
            {
                m_auto_first_direction = LaserPathMove.LASER_PATH_MOVE_ANGLE;
                m_auto_dirX = LaserPathMove.LASER_PATH_MOVE_LEFTUP;
                m_auto_dirY = LaserPathMove.LASER_PATH_MOVE_LEFTUP;
                m_txbAngle.Text = String.Format("{0}", 135);

                // Disable Direction Botton
                m_radioXStartLeft.Enabled = false;
                m_radioXStartRight.Enabled = false;
                m_radioYStartUp.Enabled = false;
                m_radioYStartDown.Enabled = false;
            }
            else if (tmpSender == m_radioBottonLeft)
            {
                m_auto_first_direction = LaserPathMove.LASER_PATH_MOVE_ANGLE;
                m_auto_dirX = LaserPathMove.LASER_PATH_MOVE_LEFTDOWN;
                m_auto_dirY = LaserPathMove.LASER_PATH_MOVE_LEFTDOWN;
                m_txbAngle.Text = String.Format("{0}", 225);

                // Disable Direction Botton
                m_radioXStartLeft.Enabled = false;
                m_radioXStartRight.Enabled = false;
                m_radioYStartUp.Enabled = false;
                m_radioYStartDown.Enabled = false;
            }
            else if (tmpSender == m_radioTop)
            {
                m_auto_first_direction = LaserPathMove.LASER_PATH_MOVE_FIRSTY;
                m_auto_dirY = LaserPathMove.LASER_PATH_MOVE_UP;
                m_auto_dirX = (m_radioXStartLeft.Checked) ? LaserPathMove.LASER_PATH_MOVE_LEFT : LaserPathMove.LASER_PATH_MOVE_RIGHT;
                m_txbAngle.Text = String.Format("{0}", 90);

                // Disable Direction Botton
                m_radioXStartLeft.Enabled = true;
                m_radioXStartRight.Enabled = true;
                m_radioYStartUp.Enabled = false;
                m_radioYStartDown.Enabled = false;
            }
            else if (tmpSender == m_radioBotton)
            {
                m_auto_first_direction = LaserPathMove.LASER_PATH_MOVE_FIRSTY;
                m_auto_dirY = LaserPathMove.LASER_PATH_MOVE_DOWN;
                m_auto_dirX = (m_radioXStartLeft.Checked) ? LaserPathMove.LASER_PATH_MOVE_LEFT : LaserPathMove.LASER_PATH_MOVE_RIGHT;
                m_txbAngle.Text = String.Format("{0}", 270);

                // Disable Direction Botton
                m_radioXStartLeft.Enabled = true;
                m_radioXStartRight.Enabled = true;
                m_radioYStartUp.Enabled = false;
                m_radioYStartDown.Enabled = false;
            }
            else if (tmpSender == m_radioRight)
            {
                m_auto_first_direction = LaserPathMove.LASER_PATH_MOVE_FIRSTX;
                m_auto_dirX = LaserPathMove.LASER_PATH_MOVE_RIGHT;
                m_auto_dirY = (m_radioYStartUp.Checked) ? LaserPathMove.LASER_PATH_MOVE_UP : LaserPathMove.LASER_PATH_MOVE_DOWN;
                m_txbAngle.Text = String.Format("{0}", 0);

                // Disable Direction Botton
                m_radioXStartLeft.Enabled = false;
                m_radioXStartRight.Enabled = false;
                m_radioYStartUp.Enabled = true;
                m_radioYStartDown.Enabled = true;
            }
            else if (tmpSender == m_radioTopRight)
            {
                m_auto_first_direction = LaserPathMove.LASER_PATH_MOVE_ANGLE;
                m_auto_dirX = LaserPathMove.LASER_PATH_MOVE_RIGHTUP;
                m_auto_dirY = LaserPathMove.LASER_PATH_MOVE_RIGHTUP;
                m_txbAngle.Text = String.Format("{0}", 45);

                // Disable Direction Botton
                m_radioXStartLeft.Enabled = false;
                m_radioXStartRight.Enabled = false;
                m_radioYStartUp.Enabled = false;
                m_radioYStartDown.Enabled = false;
            }
            else if (tmpSender == m_radioTopLeft)
            {
                m_auto_first_direction = LaserPathMove.LASER_PATH_MOVE_ANGLE;
                m_auto_dirX = LaserPathMove.LASER_PATH_MOVE_RIGHTDOWN;
                m_auto_dirY = LaserPathMove.LASER_PATH_MOVE_RIGHTDOWN;
                m_txbAngle.Text = String.Format("{0}", 315);

                // Disable Direction Botton
                m_radioXStartLeft.Enabled = false;
                m_radioXStartRight.Enabled = false;
                m_radioYStartUp.Enabled = false;
                m_radioYStartDown.Enabled = false;
            }
        }

        private void m_radioXStart_Click(object sender, EventArgs e)
        {
            RadioButton tmpSender = (RadioButton)sender;

            if (tmpSender == m_radioXStartLeft)
            {
                m_auto_dirX = LaserPathMove.LASER_PATH_MOVE_LEFT;
            }
            else if (tmpSender == m_radioXStartRight)
            {
                m_auto_dirX = LaserPathMove.LASER_PATH_MOVE_RIGHT;
            }
        }

        private void m_radioYStart_Click(object sender, EventArgs e)
        {
            RadioButton tmpSender = (RadioButton)sender;

            if (tmpSender == m_radioYStartUp)
            {
                m_auto_dirY = LaserPathMove.LASER_PATH_MOVE_UP;
            }
            else if (tmpSender == m_radioYStartDown)
            {
                m_auto_dirY = LaserPathMove.LASER_PATH_MOVE_DOWN;
            }
        }


        #endregion

        private void m_btnDrawPath_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void m_btnLen50X_Click(object sender, EventArgs e)
        {
            RadioButton Camerabtn = (RadioButton)sender;

            // test 
            //char[] data = new char[3] { '\x12','\x34','\x56' };
            Maintain.TestZone.CCLaserTriggerInterface.getSingleton().TrigCardReadFIFOWait(3);

            if (Camerabtn == m_btnLen20X)
            {
                SDDEMsg.SDDE.GetSingleton().SendMessageToTK("C101,3");
            }
            else if (Camerabtn == m_btnLen50X)
            {
                SDDEMsg.SDDE.GetSingleton().SendMessageToTK("C101,4");
            }
        }

    }
    /// <summary>
    /// 存放教點相關資訊
    /// </summary>
    public class CCLaserPathTeachInfo : CCAbstractTeachingInfo
    {
        #region Ctor
        public CCLaserPathTeachInfo()
        {
            m_strTeachName = "Laser Path";
        }
        #endregion
    }

    /// <summary>
    /// 這是計算 Laser Path 的演算法介面。使用 Strategy Pattern。
    /// </summary>    
    public abstract class CCLaserPathStrategy
    {
        #region Protected Member
        protected int m_iWidth = 0;
        protected int m_iHeight = 0;
        protected int m_iXPitch = 0;
        protected int m_iYPitch = 0;
        protected Point m_StartPos = new Point(0, 0);
        protected List<Point> m_listPath = new List<Point>();
        #endregion

        #region Ctor
        public CCLaserPathStrategy(Point p_StartPos, int p_iWidth, int p_iHeight, int p_iXPitch, int p_iYPitch)
        {
            m_StartPos = p_StartPos;
            m_listPath.Add(m_StartPos);

            m_iWidth = p_iWidth;
            m_iHeight = p_iHeight;
            m_iXPitch = p_iXPitch;
            m_iYPitch = p_iYPitch;
        }
        #endregion

        public abstract Point[] CaculatePath();
    }

    /// 畫路徑方向性為下圖:                   
    ///           ←←
    ///                 ↑
    ///           →→ 
    ///          ↑
    ///           ←←     start
    public class CCDrawXLeftAndYUpStrategy : CCLaserPathStrategy
    {
        #region Ctor
        public CCDrawXLeftAndYUpStrategy(Point p_StartPos, int p_iWidth, int m_iHeight, int m_iXPitch, int m_iYPitch)
            : base(p_StartPos, p_iWidth, m_iHeight, m_iXPitch, m_iYPitch)
        {

        }
        #endregion

        public override Point[] CaculatePath()
        {
            int line_amount = (m_iWidth / m_iXPitch) + 1;  //  以實際的距離來計算避免誤差
            int point_amount = line_amount * 2;  //  點數量為線數量的兩倍

            Point temppos = m_StartPos;
            for (int iIdx = 1; iIdx < point_amount; iIdx += 2)
            {
                m_iXPitch *= -1;  //  改變X方向
                temppos.X += m_iXPitch;
                m_listPath.Add(temppos);

                temppos.Y -= m_iYPitch;
                m_listPath.Add(temppos);
            }

            return m_listPath.ToArray();
        }

    }

    /// 畫路徑方向性為下圖:
    ///           ←←  start
    ///          ↓        
    ///           →→ 
    ///                 ↓
    ///           ←←
    public class CCDrawXLeftAndYDownStrategy : CCLaserPathStrategy
    {
        #region Ctor
        public CCDrawXLeftAndYDownStrategy(Point p_StartPos, int p_iWidth, int m_iHeight, int m_iXPitch, int m_iYPitch)
            : base(p_StartPos, p_iWidth, m_iHeight, m_iXPitch, m_iYPitch)
        {

        }
        #endregion

        public override Point[] CaculatePath()
        {
            int line_amount = (m_iWidth / m_iXPitch) + 1;  //  以實際的距離來計算避免誤差
            int point_amount = line_amount * 2;  //  點數量為線數量的兩倍

            Point temppos = m_StartPos;
            for (int iIdx = 1; iIdx < point_amount; iIdx += 2)
            {
                m_iXPitch *= -1;  //  改變Y方向
                temppos.X += m_iXPitch;
                m_listPath.Add(temppos);

                temppos.Y += m_iYPitch;
                m_listPath.Add(temppos);
            }

            return m_listPath.ToArray();
        }
    }

    /// 畫路徑方向性為下圖: 
    ///           →→
    ///          ↑
    ///           ←←
    ///                 ↑
    ///   start  →→ 
    public class CCDrawXRightAndYUpStrategy : CCLaserPathStrategy
    {
        #region Ctor
        public CCDrawXRightAndYUpStrategy(Point p_StartPos, int p_iWidth, int m_iHeight, int m_iXPitch, int m_iYPitch)
            : base(p_StartPos, p_iWidth, m_iHeight, m_iXPitch, m_iYPitch)
        {

        }
        #endregion

        public override Point[] CaculatePath()
        {
            int line_amount = (m_iWidth / m_iXPitch) + 1;  //  以實際的距離來計算避免誤差
            int point_amount = line_amount * 2;  //  點數量為線數量的兩倍

            Point temppos = m_StartPos;
            for (int iIdx = 1; iIdx < point_amount; iIdx += 2)
            {
                temppos.X += m_iXPitch;
                m_listPath.Add(temppos);
                m_iXPitch *= -1;  //  改變X方向                              

                temppos.Y -= m_iYPitch;
                m_listPath.Add(temppos);
            }

            return m_listPath.ToArray();
        }
    }

    /// 畫路徑方向性為下圖: 
    ///    start →→
    ///                 ↓
    ///           ←←
    ///          ↓     
    ///           →→ 
    public class CCDrawXRightAndYDownStrategy : CCLaserPathStrategy
    {
        #region Ctor
        public CCDrawXRightAndYDownStrategy(Point p_StartPos, int p_iWidth, int m_iHeight, int m_iXPitch, int m_iYPitch)
            : base(p_StartPos, p_iWidth, m_iHeight, m_iXPitch, m_iYPitch)
        {

        }
        #endregion

        public override Point[] CaculatePath()
        {
            int line_amount = (m_iWidth / m_iXPitch) + 1;  //  以實際的距離來計算避免誤差
            int point_amount = line_amount * 2;  //  點數量為線數量的兩倍

            Point temppos = m_StartPos;
            for (int iIdx = 1; iIdx < point_amount; iIdx += 2)
            {
                temppos.X += m_iXPitch;
                m_listPath.Add(temppos);
                m_iXPitch *= -1;  //  改變X方向  

                temppos.Y += m_iYPitch;
                m_listPath.Add(temppos);
            }

            return m_listPath.ToArray();
        }

    }

    /// 畫路徑方向性為下圖: 
    ///   ←←               ←←          ←←
    ///           ↑        ↓      ↑      ↑     ↑                          
    ///              ←←             ←←           start
    public class CCDrawYUpAndXLeftStrategy : CCLaserPathStrategy
    {
        #region Ctor
        public CCDrawYUpAndXLeftStrategy(Point p_StartPos, int p_iWidth, int m_iHeight, int m_iXPitch, int m_iYPitch)
            : base(p_StartPos, p_iWidth, m_iHeight, m_iXPitch, m_iYPitch)
        {

        }
        #endregion

        public override Point[] CaculatePath()
        {
            int line_amount = (m_iWidth / m_iXPitch) + 1;  //  以實際的距離來計算避免誤差
            int point_amount = line_amount * 2;  //  點數量為線數量的兩倍

            Point temppos = m_StartPos;
            for (int iIdx = 1; iIdx < point_amount; iIdx += 2)
            {
                temppos.Y -= m_iYPitch;
                m_listPath.Add(temppos);
                m_iYPitch *= -1;  //  改變Y方向  

                temppos.X -= m_iXPitch;
                m_listPath.Add(temppos);
            }

            return m_listPath.ToArray();
        }
    }

    /// 畫路徑方向性為下圖: 
    ///                     ←←       ←←       start
    ///                   ↓     ↑   ↓   ↑    ↓                          
    ///             ←←         ←←       ←←
    public class CCDrawYDownAndXLeftStrategy : CCLaserPathStrategy
    {
        #region Ctor
        public CCDrawYDownAndXLeftStrategy(Point p_StartPos, int p_iWidth, int m_iHeight, int m_iXPitch, int m_iYPitch)
            : base(p_StartPos, p_iWidth, m_iHeight, m_iXPitch, m_iYPitch)
        {

        }
        #endregion

        public override Point[] CaculatePath()
        {
            int line_amount = (m_iWidth / m_iXPitch) + 1;  //  以實際的距離來計算避免誤差
            int point_amount = line_amount * 2;  //  點數量為線數量的兩倍

            Point temppos = m_StartPos;
            for (int iIdx = 1; iIdx < point_amount; iIdx += 2)
            {
                m_iYPitch *= -1;  //  改變Y方向
                temppos.Y -= m_iYPitch;
                m_listPath.Add(temppos);

                temppos.X -= m_iXPitch;
                m_listPath.Add(temppos);
            }

            return m_listPath.ToArray();
        }
    }

    /// 畫路徑方向性為下圖: 
    ///          →→          →→          →→
    ///          ↑   ↓    ↑      ↓     ↑                          
    ///      start      →→             →→
    public class CCDrawYUpAndXRightStrategy : CCLaserPathStrategy
    {
        #region Ctor
        public CCDrawYUpAndXRightStrategy(Point p_StartPos, int p_iWidth, int m_iHeight, int m_iXPitch, int m_iYPitch)
            : base(p_StartPos, p_iWidth, m_iHeight, m_iXPitch, m_iYPitch)
        {

        }
        #endregion

        public override Point[] CaculatePath()
        {
            int line_amount = (m_iWidth / m_iXPitch) + 1;  //  以實際的距離來計算避免誤差
            int point_amount = line_amount * 2;  //  點數量為線數量的兩倍

            Point temppos = m_StartPos;
            for (int iIdx = 1; iIdx < point_amount; iIdx += 2)
            {
                temppos.Y -= m_iYPitch;
                m_listPath.Add(temppos);
                m_iYPitch *= -1;  //  改變Y方向  

                temppos.X += m_iXPitch;
                m_listPath.Add(temppos);
            }

            return m_listPath.ToArray();
        }
    }

    /// 畫路徑方向性為下圖: 
    ///   start           →→        →→
    ///         ↓      ↑   ↓     ↑                   
    ///           →→          →→
    public class CCDrawYDownAndXRightStrategy : CCLaserPathStrategy
    {
        #region Ctor
        public CCDrawYDownAndXRightStrategy(Point p_StartPos, int p_iWidth, int m_iHeight, int m_iXPitch, int m_iYPitch)
            : base(p_StartPos, p_iWidth, m_iHeight, m_iXPitch, m_iYPitch)
        {

        }
        #endregion

        public override Point[] CaculatePath()
        {
            int line_amount = (m_iWidth / m_iXPitch) + 1;  //  以實際的距離來計算避免誤差
            int point_amount = line_amount * 2;  //  點數量為線數量的兩倍

            Point temppos = m_StartPos;
            for (int iIdx = 1; iIdx < point_amount; iIdx += 2)
            {
                temppos.Y += m_iYPitch;
                m_listPath.Add(temppos);
                m_iYPitch *= -1;  //  改變Y方向                  

                temppos.X += m_iXPitch;
                m_listPath.Add(temppos);
            }

            return m_listPath.ToArray();
        }
    }
}