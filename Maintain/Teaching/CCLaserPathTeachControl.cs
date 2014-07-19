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
            LASER_PATH_MOVE_LEFT = 120,   //  X�b���ʤ�V
            LASER_PATH_MOVE_RIGHT,        //  X�b���ʤ�V
            LASER_PATH_MOVE_UP,              //  Y�b���ʤ�V 
            LASER_PATH_MOVE_DOWN,        //  Y�b���ʤ�V
            LASER_PATH_MOVE_FIRSTX,      //  �Ĥ@�Ӳ��ʤ�V X
            LASER_PATH_MOVE_FIRSTY,      //  �Ĥ@�Ӳ��ʤ�V Y
            LASER_PATH_MOVE_ANGLE,      //  ���ʤ�V������
            LASER_PATH_MOVE_LEFTUP,     //  ���W
            LASER_PATH_MOVE_LEFTDOWN,  //  ���U
            LASER_PATH_MOVE_RIGHTUP,   //  �k�W
            LASER_PATH_MOVE_RIGHTDOWN  //  �k�U
        };
        private CCLaserPathStrategy m_Strategy = null;

        #endregion

        #region Ctor
        public CCLaserPathTeachControl()
        {
            InitializeComponent();

            // �N��ƥ�� TeachingInfoFactory �޲z            
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
                MessageBox.Show("�п�ܤ@�Ӹ��|�Ѽ�");
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
                MessageBox.Show("�п�ܤ@�Ӹ��|�Ѽ�");
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
                MessageBox.Show("�п�J�p�g���|�d��PPitch X&Y");
                return;
            }

            // TODO: ���o�ثe���Y���v�A�Ӵ���ù��W�� Width Height X Pitch Y Pitch
            const int iScaleX = 1;
            if (iScaleX <= 0)
            {
                MessageBox.Show("�p�g���Y�]�w���~");
                return;
            }

            // �R���Ҧ����|
            m_listPath.Clear();

            // �]�w�e���|�_�l�I
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
        /// ���q Y ��V�}�l�e�C        
        /// </summary>
        private void do_drawY(Point p_StartPoint, int p_iScale)
        {
            //  Y Pitch�����j��X Pitch
            if (long.Parse(m_txbPitchX.Text) > long.Parse(m_txbPitchY.Text))
            {
                MessageBox.Show("Y Pitch �����j��X Pitch");
                return;
            }

            // �ھ����Y�վ�
            int width = (int)(long.Parse(m_txbWidth.Text) / p_iScale);
            int height = (int)(long.Parse(m_txbHeight.Text) / p_iScale);
            int X_Pitch = (int)(long.Parse(m_txbPitchX.Text) / p_iScale);
            int Y_Pitch = (int)(long.Parse(m_txbPitchY.Text) / p_iScale);

            if (m_auto_dirX == LaserPathMove.LASER_PATH_MOVE_LEFT)  //  ����
            {
                switch (m_auto_dirY)
                {
                    case LaserPathMove.LASER_PATH_MOVE_UP: //  ���W                                               
                        m_Strategy = new CCDrawYUpAndXLeftStrategy(p_StartPoint, width, height, X_Pitch, Y_Pitch);
                        break;

                    case LaserPathMove.LASER_PATH_MOVE_DOWN: //  ���U                                              
                        m_Strategy = new CCDrawYDownAndXLeftStrategy(p_StartPoint, width, height, X_Pitch, Y_Pitch);
                        break;
                }
            }
            else if (m_auto_dirX == LaserPathMove.LASER_PATH_MOVE_RIGHT)  //  ���k
            {
                switch (m_auto_dirY)
                {
                    case LaserPathMove.LASER_PATH_MOVE_UP: //  ���W                                               
                        m_Strategy = new CCDrawYUpAndXRightStrategy(p_StartPoint, width, height, X_Pitch, Y_Pitch);
                        break;

                    case LaserPathMove.LASER_PATH_MOVE_DOWN: //  ���U
                        m_Strategy = new CCDrawYDownAndXRightStrategy(p_StartPoint, width, height, X_Pitch, Y_Pitch);
                        break;
                }
            }
            m_listPath.AddRange(m_Strategy.CaculatePath());
        }

        /// <summary>
        /// ���q X ��V�}�l�e�C        
        /// </summary>
        private void do_drawX(Point p_StartPoint, int p_iScale)
        {
            //  X Pitch�����j�� Y Pitch
            if (long.Parse(m_txbPitchY.Text) > long.Parse(m_txbPitchX.Text))
            {
                MessageBox.Show("X Pitch �����j�� Y Pitch");
                return;
            }

            // �ھ����Y�վ�
            int width = (int)(long.Parse(m_txbWidth.Text) / p_iScale);
            int height = (int)(long.Parse(m_txbHeight.Text) / p_iScale);
            int X_Pitch = (int)(long.Parse(m_txbPitchX.Text) / p_iScale);
            int Y_Pitch = (int)(long.Parse(m_txbPitchY.Text) / p_iScale);

            if (m_auto_dirX == LaserPathMove.LASER_PATH_MOVE_LEFT)  //  ����
            {
                switch (m_auto_dirY)
                {
                    case LaserPathMove.LASER_PATH_MOVE_UP: //  ���W                                                                      
                        m_Strategy = new CCDrawXLeftAndYUpStrategy(p_StartPoint, width, height, X_Pitch, Y_Pitch);
                        break;

                    case LaserPathMove.LASER_PATH_MOVE_DOWN: //  ���U                                              
                        m_Strategy = new CCDrawXLeftAndYDownStrategy(p_StartPoint, width, height, X_Pitch, Y_Pitch);
                        break;
                }
            }
            else if (m_auto_dirX == LaserPathMove.LASER_PATH_MOVE_RIGHT)  //  ���k
            {
                switch (m_auto_dirY)
                {
                    case LaserPathMove.LASER_PATH_MOVE_UP: //  ���W                                               
                        m_Strategy = new CCDrawXRightAndYUpStrategy(p_StartPoint, width, height, X_Pitch, Y_Pitch);
                        break;

                    case LaserPathMove.LASER_PATH_MOVE_DOWN: //  ���U
                        m_Strategy = new CCDrawXRightAndYDownStrategy(p_StartPoint, width, height, X_Pitch, Y_Pitch);
                        break;
                }
            }
            m_listPath.AddRange(m_Strategy.CaculatePath());
        }

        /// <summary>
        /// ���q �k�W�A�k�U�A���W�A���U ��V�}�l�e�C        
        /// </summary>
        private void do_drawAngle(Point p_StartPoint, int p_iScale)
        {
            int direction = 1;
            double ratio = 0;  //  X Y �����  X:Y = 1:1 >> 45��  �Y�ײv
            int boundx1 = 0, boundx2 = 0, boundy1 = 0, boundy2 = 0;

            // �ھ����Y�վ�
            int width = (int)(long.Parse(m_txbWidth.Text) / p_iScale);
            int height = (int)(long.Parse(m_txbHeight.Text) / p_iScale);
            int X_Pitch = (int)(long.Parse(m_txbPitchX.Text) / p_iScale);
            int Y_Pitch = (int)(long.Parse(m_txbPitchY.Text) / p_iScale);

            Point start = new Point(ccd1.Size.Width / 2, ccd1.Size.Height / 2);
            int iAngle = int.Parse(m_txbAngle.Text);

            switch (m_auto_dirX)
            {
                case LaserPathMove.LASER_PATH_MOVE_LEFTUP:
                    //  �����W 0~90
                    direction = -1;
                    ratio = Math.Tan((180 - iAngle) * Math.PI / 180);
                    boundx1 = start.X - width;
                    boundy1 = start.Y;
                    boundx2 = start.X;
                    boundy2 = start.Y + height;
                    break;

                case LaserPathMove.LASER_PATH_MOVE_LEFTDOWN:
                    //  �����U 270~360
                    direction = -1;
                    //ratio = Math.Tan((360-(iAngle-180)) * Math.PI / 180);
                    ratio = Math.Tan((360 - iAngle + 180) * Math.PI / 180);
                    boundx1 = start.X;
                    boundy1 = start.Y;
                    boundx2 = start.X + width;
                    boundy2 = start.Y + height;
                    break;

                case LaserPathMove.LASER_PATH_MOVE_RIGHTUP:
                    //  ���k�W 90~180
                    direction = 1;
                    ratio = Math.Tan((180 - iAngle) * Math.PI / 180);
                    boundx1 = start.X;
                    boundy1 = start.Y;
                    boundx2 = start.X + width;
                    boundy2 = start.Y + height;
                    break;

                case LaserPathMove.LASER_PATH_MOVE_RIGHTDOWN:
                    //  ���k�U 180~270
                    direction = 1;
                    ratio = Math.Tan((360 - iAngle + 180) * Math.PI / 180);
                    boundx1 = start.X - width;
                    boundy1 = start.Y;
                    boundx2 = start.X;
                    boundy2 = start.Y + height;
                    break;
            }

            //�p��_�l�I�����u��{��
            double start_intercept = start.Y - ratio * start.X;  //  �_�l�I�I�Z

            while (true)
            {
                start_intercept += X_Pitch;  //  �U�@�u�q���I�Z

                //�D�ѻP�|�ӽu�q�����I

                //�Ĥ@�ӽu�q�����I
                int pos1x = 0, pos1y = 0;
                pos1x = boundx1;
                pos1y = (int)(ratio * pos1x + start_intercept);

                //�ĤG�ӽu�q�����I
                int pos2x = 0, pos2y = 0;
                pos2y = boundy1;
                pos2x = (int)((pos2y - start_intercept) / ratio);

                //�ĤT�ӽu�q�����I
                int pos3x = 0, pos3y = 0;
                pos3x = boundx2;
                pos3y = (int)(ratio * pos3x + start_intercept);

                //�ĥ|�ӽu�q�����I
                int pos4x = 0, pos4y = 0;
                pos4y = boundy2;
                pos4x = (int)((pos4y - start_intercept) / ratio);

                int count = 0;  //  �p��ŦX�����I�ƶq
                Point[] InRangePo = new Point[4];

                //  �ˬd���I�O�_�b�d��
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
                    MessageBox.Show("�p����I�P�_���~�A���I�j��2");
                    break;
                }
                if (count == 0)
                    break;  // �Ҧ����I���w�g�b�d��~

                if (count <= 2)  //  ���`���p�U�u�|����ӥ��I
                {
                    if (direction == 1)  //  
                    {
                        //  X�b�V���p���Ĥ@�I
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
                        //  X�b�V���j���Ĥ@�I
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
                }  //  end if( count < 2)  //  ���`���p�U�u�|����ӥ��I
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
    /// �s����I������T
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
    /// �o�O�p�� Laser Path ���t��k�����C�ϥ� Strategy Pattern�C
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

    /// �e���|��V�ʬ��U��:                   
    ///           ����
    ///                 ��
    ///           ���� 
    ///          ��
    ///           ����     start
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
            int line_amount = (m_iWidth / m_iXPitch) + 1;  //  �H��ڪ��Z���ӭp���קK�~�t
            int point_amount = line_amount * 2;  //  �I�ƶq���u�ƶq���⭿

            Point temppos = m_StartPos;
            for (int iIdx = 1; iIdx < point_amount; iIdx += 2)
            {
                m_iXPitch *= -1;  //  ����X��V
                temppos.X += m_iXPitch;
                m_listPath.Add(temppos);

                temppos.Y -= m_iYPitch;
                m_listPath.Add(temppos);
            }

            return m_listPath.ToArray();
        }

    }

    /// �e���|��V�ʬ��U��:
    ///           ����  start
    ///          ��        
    ///           ���� 
    ///                 ��
    ///           ����
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
            int line_amount = (m_iWidth / m_iXPitch) + 1;  //  �H��ڪ��Z���ӭp���קK�~�t
            int point_amount = line_amount * 2;  //  �I�ƶq���u�ƶq���⭿

            Point temppos = m_StartPos;
            for (int iIdx = 1; iIdx < point_amount; iIdx += 2)
            {
                m_iXPitch *= -1;  //  ����Y��V
                temppos.X += m_iXPitch;
                m_listPath.Add(temppos);

                temppos.Y += m_iYPitch;
                m_listPath.Add(temppos);
            }

            return m_listPath.ToArray();
        }
    }

    /// �e���|��V�ʬ��U��: 
    ///           ����
    ///          ��
    ///           ����
    ///                 ��
    ///   start  ���� 
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
            int line_amount = (m_iWidth / m_iXPitch) + 1;  //  �H��ڪ��Z���ӭp���קK�~�t
            int point_amount = line_amount * 2;  //  �I�ƶq���u�ƶq���⭿

            Point temppos = m_StartPos;
            for (int iIdx = 1; iIdx < point_amount; iIdx += 2)
            {
                temppos.X += m_iXPitch;
                m_listPath.Add(temppos);
                m_iXPitch *= -1;  //  ����X��V                              

                temppos.Y -= m_iYPitch;
                m_listPath.Add(temppos);
            }

            return m_listPath.ToArray();
        }
    }

    /// �e���|��V�ʬ��U��: 
    ///    start ����
    ///                 ��
    ///           ����
    ///          ��     
    ///           ���� 
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
            int line_amount = (m_iWidth / m_iXPitch) + 1;  //  �H��ڪ��Z���ӭp���קK�~�t
            int point_amount = line_amount * 2;  //  �I�ƶq���u�ƶq���⭿

            Point temppos = m_StartPos;
            for (int iIdx = 1; iIdx < point_amount; iIdx += 2)
            {
                temppos.X += m_iXPitch;
                m_listPath.Add(temppos);
                m_iXPitch *= -1;  //  ����X��V  

                temppos.Y += m_iYPitch;
                m_listPath.Add(temppos);
            }

            return m_listPath.ToArray();
        }

    }

    /// �e���|��V�ʬ��U��: 
    ///   ����               ����          ����
    ///           ��        ��      ��      ��     ��                          
    ///              ����             ����           start
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
            int line_amount = (m_iWidth / m_iXPitch) + 1;  //  �H��ڪ��Z���ӭp���קK�~�t
            int point_amount = line_amount * 2;  //  �I�ƶq���u�ƶq���⭿

            Point temppos = m_StartPos;
            for (int iIdx = 1; iIdx < point_amount; iIdx += 2)
            {
                temppos.Y -= m_iYPitch;
                m_listPath.Add(temppos);
                m_iYPitch *= -1;  //  ����Y��V  

                temppos.X -= m_iXPitch;
                m_listPath.Add(temppos);
            }

            return m_listPath.ToArray();
        }
    }

    /// �e���|��V�ʬ��U��: 
    ///                     ����       ����       start
    ///                   ��     ��   ��   ��    ��                          
    ///             ����         ����       ����
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
            int line_amount = (m_iWidth / m_iXPitch) + 1;  //  �H��ڪ��Z���ӭp���קK�~�t
            int point_amount = line_amount * 2;  //  �I�ƶq���u�ƶq���⭿

            Point temppos = m_StartPos;
            for (int iIdx = 1; iIdx < point_amount; iIdx += 2)
            {
                m_iYPitch *= -1;  //  ����Y��V
                temppos.Y -= m_iYPitch;
                m_listPath.Add(temppos);

                temppos.X -= m_iXPitch;
                m_listPath.Add(temppos);
            }

            return m_listPath.ToArray();
        }
    }

    /// �e���|��V�ʬ��U��: 
    ///          ����          ����          ����
    ///          ��   ��    ��      ��     ��                          
    ///      start      ����             ����
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
            int line_amount = (m_iWidth / m_iXPitch) + 1;  //  �H��ڪ��Z���ӭp���קK�~�t
            int point_amount = line_amount * 2;  //  �I�ƶq���u�ƶq���⭿

            Point temppos = m_StartPos;
            for (int iIdx = 1; iIdx < point_amount; iIdx += 2)
            {
                temppos.Y -= m_iYPitch;
                m_listPath.Add(temppos);
                m_iYPitch *= -1;  //  ����Y��V  

                temppos.X += m_iXPitch;
                m_listPath.Add(temppos);
            }

            return m_listPath.ToArray();
        }
    }

    /// �e���|��V�ʬ��U��: 
    ///   start           ����        ����
    ///         ��      ��   ��     ��                   
    ///           ����          ����
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
            int line_amount = (m_iWidth / m_iXPitch) + 1;  //  �H��ڪ��Z���ӭp���קK�~�t
            int point_amount = line_amount * 2;  //  �I�ƶq���u�ƶq���⭿

            Point temppos = m_StartPos;
            for (int iIdx = 1; iIdx < point_amount; iIdx += 2)
            {
                temppos.Y += m_iYPitch;
                m_listPath.Add(temppos);
                m_iYPitch *= -1;  //  ����Y��V                  

                temppos.X += m_iXPitch;
                m_listPath.Add(temppos);
            }

            return m_listPath.ToArray();
        }
    }
}