using System;
using System.Collections.Generic;
using System.Text;

namespace Maintain.Teaching
{
    /// <summary>
    /// �o�O��H���b���O�C�򥻤W�C�@�Ӷb���|�갵�@�Ӷb����C
    /// </summary>
    public abstract class CCAbstractAxis
    {
        #region Protected Member
        protected int m_iSpeed = 50000;
        protected double m_iSpeedPercentage = 1.0;
        protected int m_iAcc = 500;
        protected int m_iDec = 500;
        protected bool m_bIsAbsolute = true;
        #endregion

        #region Public Property
        /// <summary>
        /// �t�פ��
        /// </summary>
        public double SpeedPercentage
        {
            set
            {
                if (value <= 1.0 && value > 0.0)
                    m_iSpeedPercentage = value;
            }
        }
        /// <summary>
        /// �[�t��
        /// </summary>
        public int Acc
        {
            set { m_iAcc = value; }
        }
        /// <summary>
        /// ��t��
        /// </summary>
        public int Dec
        {
            set { m_iDec = value; }
        }
        /// <summary>
        /// ���ʼҦ��]�w
        /// </summary>
        public bool IsAbsoulte
        {
            set { m_bIsAbsolute = value; }
        }
        #endregion

        #region Ctor
        protected CCAbstractAxis()
        {
        }
        #endregion

        #region Public Abstract Method
        public abstract void Run();        
        #endregion

        #region Static Method
        protected static double GetAxisPosition(TKUnit.IOTable.AxisType p_Axis)
        {
            if (!Common.CTAPSetup.EnableTK)
                return 0;

            int iPitch = 0, iPulse = 0, iCounter = 0, itemp2 = 0, itemp3 = 0, itemp4 = 0;
            //TK.CCTKform.TK_Motion.CCMotionModule_GetPitch((int)p_Axis, ref iPitch, ref itemp2, ref itemp3, ref itemp4);
            //TK.CCTKform.TK_Motion.CCMotionModule_GetMotorPulse((int)p_Axis, ref iPulse, ref itemp2, ref itemp3, ref itemp4);
            //TK.CCTKform.TK_Motion.CCMotionModule_GetCounter((int)p_Axis, ref iCounter, ref itemp2, ref itemp3, ref itemp4);

            if (iPulse > 0)
                return iCounter * (iPitch / iPulse);
            else
                return 0;
        }

        protected static bool IsRunning(TKUnit.IOTable.AxisType p_Axis)
        {
            //return (TK.CCTKform.TK_Motion.CCMotionModule_IsMotorRunning((int)p_Axis) == 1 ? true : false);
            return false;
        }        
        #endregion

    }

    /// <summary>
    /// �o�O G�AS�AY���b���O�C
    /// </summary>
    public class CC_GSY_Axis : CCAbstractAxis
    {
        #region Private Member
        private double m_dGPosition = 0;
        private double m_dSPosition = 0;
        private double m_dLPosition = 0;        
        #endregion

        #region Ctor
        public CC_GSY_Axis():base()
        {
        }
        #endregion

        #region Public Property
        /// <summary>
        /// G�b���ʦ�m
        /// </summary>
        public double GPosition
        {
            set { m_dGPosition = value; }
        }
        /// <summary>
        /// S�b���ʦ�m
        /// </summary>
        public double SPosition
        {
            set { m_dSPosition = value; }
        }
        /// <summary>
        /// L�b���ʦ�m
        /// </summary>
        public double LPosition
        {
            set { m_dLPosition = value; }
        }
        
        #endregion

        #region Public Method
        /// <summary>
        /// Call C020
        /// </summary>
        public override void Run()
        {/*
            if (m_bIsAbsolute) // ���ﲾ��
            {
                TKUnit.Process.GetSingleton().ProcessCommandForMMICall(String.Format("C020,{0},{1},{2},{3},{4},{5},{6}",
                                                                                                             (int)m_dGPosition,
                                                                                                             (int)m_dSPosition,
                                                                                                             (int)m_dLPosition,
                                                                                                             m_iSpeed * m_iSpeedPercentage,
                                                                                                             m_iAcc,
                                                                                                             m_iDec,
                                                                                                             (m_bIsAbsolute == true ? 1 : 0)));
            }
            else // �۹ﲾ��
            {
                TKUnit.Process.GetSingleton().ProcessCommandForMMICall(String.Format("C020,{0},{1},{2},{3},{4},{5},{6}",
                                                                                                                             (int)(m_dGPosition + GetGAxisPosition()),
                                                                                                                             (int)(m_dSPosition + GetSAxisPosition()),
                                                                                                                             (int)(m_dLPosition + GetLAxisPosition()),
                                                                                                                             m_iSpeed * m_iSpeedPercentage,
                                                                                                                             m_iAcc,
                                                                                                                             m_iDec,
                                                                                                                             (m_bIsAbsolute == true ? 1 : 0)));

            }*/
        }

        /// <summary>
        /// ���o S �b�ثe��m
        /// </summary>
        /// <returns></returns>
        public static double GetSAxisPosition()
        {
            return GetAxisPosition(TKUnit.IOTable.AxisType.Axis_S);
        }

        /// <summary>
        /// �ˬd S �b �O�_�ʧ@
        /// </summary>
        /// <returns></returns>
        public static bool IsSAxisRunning()
        {
            return IsRunning(TKUnit.IOTable.AxisType.Axis_S);
        }

        /// <summary>
        /// ���o G �b�ثe��m
        /// </summary>
        /// <returns></returns>
        public static double GetGAxisPosition()
        {
            return GetAxisPosition(TKUnit.IOTable.AxisType.Axis_G);
        }

        /// <summary>
        /// �ˬd G �b �O�_�ʧ@
        /// </summary>
        /// <returns></returns>
        public static bool IsGAxisRunning()
        {
            return IsRunning(TKUnit.IOTable.AxisType.Axis_G);
        }

        /// <summary>
        /// ���o L �b�ثe��m
        /// </summary>
        /// <returns></returns>
        public static double GetLAxisPosition()
        {
            return GetAxisPosition(TKUnit.IOTable.AxisType.Axis_L);
        }

        /// <summary>
        /// �ˬd L �b �O�_�ʧ@
        /// </summary>
        /// <returns></returns>
        public static bool IsLAxisRunning()
        {
            return IsRunning(TKUnit.IOTable.AxisType.Axis_L);
        }
        #endregion        

    }

    /// <summary>
    /// �o�O C1C2���b���O�C
    /// </summary>
    public class CC_C1C2_Axis : CCAbstractAxis
    {
        #region Private Member
        private double m_dC1C2Position = 0;        
        #endregion

        #region Ctor
        public CC_C1C2_Axis():base()
        {
        }
        #endregion

        #region Public Property
        /// <summary>
        /// C1C2�b���ʦ�m
        /// </summary>
        public double C1C2Position
        {
            set { m_dC1C2Position = value; }
        }
        #endregion

        #region Public Method
        /// <summary>
        /// Call C031
        /// </summary>
        public override void Run()
        {/*
            if (m_bIsAbsolute) // ���ﲾ��
            {
                TKUnit.Process.GetSingleton().ProcessCommandForMMICall(String.Format("C031,{0},{1},{2},{3},{4}",
                                                                                                             (int)m_dC1C2Position,                                                                                                             
                                                                                                             m_iSpeed * m_iSpeedPercentage,
                                                                                                             m_iAcc,
                                                                                                             m_iDec,
                                                                                                             (m_bIsAbsolute == true ? 1 : 0)));
            }
            else // �۹ﲾ��
            {
                TKUnit.Process.GetSingleton().ProcessCommandForMMICall(String.Format("C031,{0},{1},{2},{3},{4}",
                                                                                                                             (int)(m_dC1C2Position + GetC1C2AxisPosition()),                                                                                                                             
                                                                                                                             m_iSpeed * m_iSpeedPercentage,
                                                                                                                             m_iAcc,
                                                                                                                             m_iDec,
                                                                                                                             (m_bIsAbsolute == true ? 1 : 0)));

            }*/
        }

        /// <summary>
        /// ���o C1C1 �b�ثe��m
        /// </summary>
        /// <returns></returns>
        public static double GetC1C2AxisPosition()
        {
            return GetAxisPosition(TKUnit.IOTable.AxisType.Axis_C1C2);
        }

        /// <summary>
        /// �ˬd C1C2 �b �O�_�ʧ@
        /// </summary>
        /// <returns></returns>
        public static bool IsC1C2AxisRunning()
        {
            return IsRunning(TKUnit.IOTable.AxisType.Axis_C1C2);
        }

        #endregion
    }

    /// <summary>
    /// �o�O SA1SA2���b���O�C
    /// </summary>
    public class CC_SA1SA2_Axis : CCAbstractAxis
    {
        #region Private Member
        private double m_dSA1SA2Position = 0;        
        #endregion

        #region Ctor
        public CC_SA1SA2_Axis()
            : base()
        {
        }
        #endregion

        #region Public Property
        /// <summary>
        ///SA1&SA2�b���ʦ�m
        /// </summary>
        public double SA1SA2Position
        {
            set { m_dSA1SA2Position = value; }
        }
        #endregion

        #region Public Method
        /// <summary>
        /// Call C030
        /// </summary>
        public override void Run()
        {/*
            if (m_bIsAbsolute) // ���ﲾ��
            {
                TKUnit.Process.GetSingleton().ProcessCommandForMMICall(String.Format("C030,{0},{1},{2},{3},{4}",
                                                                                                             (int)m_dSA1SA2Position,                                                                                                             
                                                                                                             m_iSpeed * m_iSpeedPercentage,
                                                                                                             m_iAcc,
                                                                                                             m_iDec,
                                                                                                             (m_bIsAbsolute == true ? 1 : 0)));
            }
            else // �۹ﲾ��
            {
                TKUnit.Process.GetSingleton().ProcessCommandForMMICall(String.Format("C030,{0},{1},{2},{3},{4}",
                                                                                                                             (int)(m_dSA1SA2Position + GetSA1SA2AxisPosition()),
                                                                                                                             m_iSpeed * m_iSpeedPercentage,
                                                                                                                             m_iAcc,
                                                                                                                             m_iDec,
                                                                                                                             (m_bIsAbsolute == true ? 1 : 0)));

            }*/
        }

        /// <summary>
        /// ���o SA1SA2 �b�ثe��m
        /// </summary>
        /// <returns></returns>
        public static double GetSA1SA2AxisPosition()
        {
            return GetAxisPosition(TKUnit.IOTable.AxisType.Axis_SA1SA2);
        }

        /// <summary>
        /// �ˬd SA1SA2 �b �O�_�ʧ@
        /// </summary>
        /// <returns></returns>
        public static bool IsSA1SA2AxisRunning()
        {
            return IsRunning(TKUnit.IOTable.AxisType.Axis_SA1SA2);
        }

        #endregion
    }

    /// <summary>
    /// �o�O�伵Bar���b���O�C
    /// </summary>
    public class CC_Bar_Axis : CCAbstractAxis
    {
        #region Private Member
        private double m_dBarPosition = 0;
        private Bar m_BarNumber = Bar.Bar1;
        private Direction m_Direction = Direction.Left; 
        #endregion

        #region Ctor
        public CC_Bar_Axis()
            : base()
        {
        }
        #endregion

        #region Public Property
        public enum Bar { Bar1= 1, Bar2 = 2};
        public enum Direction { Right = 0, Left = 1};

        /// <summary>
        ///Bar�b���ʦ�m
        /// </summary>
        public double BarPosition
        {
            set { m_dBarPosition = value; }
        }
        /// <summary>
        ///Bar�s��
        /// </summary>
        public Bar BarNumber
        {
            set { m_BarNumber = value; }            
        }
        /// <summary>
        ///���ʼҦ�(1->�V������,0->�V�k����)
        /// </summary>
        public Direction MoveDirection
        {
            set { m_Direction = value; }            
        }
        #endregion

        #region Public Method
        /// <summary>
        /// Call C033
        /// </summary>
        public override void Run()
        {
            // C033,B1-B2,Position,1/0: ����Bar��m
            /*TKUnit.Process.GetSingleton().ProcessCommandForMMICall(String.Format("C033,{0},{1},{2}",
                                                                                                             (int)m_dBarPosition,
                                                                                                             (int)m_BarNumber,
                                                                                                             (int)m_Direction));
            */
        }

        /// <summary>
        /// ���o Bar1 �b�ثe��m
        /// </summary>
        /// <returns></returns>
        public static double GetBar1AxisPosition()
        {
            return GetAxisPosition(TKUnit.IOTable.AxisType.Axis_B1);
        }

        /// <summary>
        /// �ˬd Bar1 �b �O�_�ʧ@
        /// </summary>
        /// <returns></returns>
        public static bool IsBar1AxisRunning()
        {
            return IsRunning(TKUnit.IOTable.AxisType.Axis_B1);
        }

        /// <summary>
        /// ���o Bar2 �b�ثe��m
        /// </summary>
        /// <returns></returns>
        public static double GetBar2AxisPosition()
        {
            return GetAxisPosition(TKUnit.IOTable.AxisType.Axis_B2);
        }

        /// <summary>
        /// �ˬd Bar2 �b �O�_�ʧ@
        /// </summary>
        /// <returns></returns>
        public static bool IsBar2AxisRunning()
        {
            return IsRunning(TKUnit.IOTable.AxisType.Axis_B2);
        }

        #endregion
    }

    /// <summary>
    /// �o�O TS���b���O�C
    /// </summary>
    public class CC_TS_Axis : CCAbstractAxis
    {
        #region Private Member
        private double m_dTSPosition = 0;
        #endregion

        #region Ctor
        public CC_TS_Axis()
            : base()
        {
        }
        #endregion

        #region Public Property
        /// <summary>
        ///TS�b���ʦ�m
        /// </summary>
        public double TSPosition
        {
            set { m_dTSPosition = value; }
        }
        #endregion

        #region Public Method
        /// <summary>
        /// Call C060
        /// </summary>
        public override void Run()
        {/*
            if (m_bIsAbsolute) // ���ﲾ��
            {
                TKUnit.Process.GetSingleton().ProcessCommandForMMICall(String.Format("C060,{0},{1},{2},{3},{4}",
                                                                                                             (int)m_dTSPosition,
                                                                                                             m_iSpeed * m_iSpeedPercentage,
                                                                                                             m_iAcc,
                                                                                                             m_iDec,
                                                                                                             (m_bIsAbsolute == true ? 1 : 0)));
            }
            else // �۹ﲾ��
            {
                TKUnit.Process.GetSingleton().ProcessCommandForMMICall(String.Format("C060,{0},{1},{2},{3},{4}",
                                                                                                                             (int)(m_dTSPosition + GetTSAxisPosition()),
                                                                                                                             m_iSpeed * m_iSpeedPercentage,
                                                                                                                             m_iAcc,
                                                                                                                             m_iDec,
                                                                                                                             (m_bIsAbsolute == true ? 1 : 0)));

            }*/
        }

        /// <summary>
        /// ���o TS �b�ثe��m
        /// </summary>
        /// <returns></returns>
        public static double GetTSAxisPosition()
        {
            return GetAxisPosition(TKUnit.IOTable.AxisType.Axis_TS);
        }

        /// <summary>
        /// �ˬd TS �b �O�_�ʧ@
        /// </summary>
        /// <returns></returns>
        public static bool IsTSAxisRunning()
        {
            return IsRunning(TKUnit.IOTable.AxisType.Axis_TS);
        }

        #endregion
    }

    /// <summary>
    /// �o�O TG���b���O�C
    /// </summary>
    public class CC_TG_Axis : CCAbstractAxis
    {
        #region Private Member
        private double m_dTGPosition = 0;
        #endregion

        #region Ctor
        public CC_TG_Axis()
            : base()
        {
        }
        #endregion

        #region Public Property
        /// <summary>
        ///TG�b���ʦ�m
        /// </summary>
        public double TGPosition
        {
            set { m_dTGPosition = value; }
        }
        #endregion

        #region Public Method
        /// <summary>
        /// Call C061
        /// </summary>
        public override void Run()
        {/*
            if (m_bIsAbsolute) // ���ﲾ��
            {
                TKUnit.Process.GetSingleton().ProcessCommandForMMICall(String.Format("C061,{0},{1},{2},{3},{4}",
                                                                                                             (int)m_dTGPosition,
                                                                                                             m_iSpeed * m_iSpeedPercentage,
                                                                                                             m_iAcc,
                                                                                                             m_iDec,
                                                                                                             (m_bIsAbsolute == true ? 1 : 0)));
            }
            else // �۹ﲾ��
            {
                TKUnit.Process.GetSingleton().ProcessCommandForMMICall(String.Format("C061,{0},{1},{2},{3},{4}",
                                                                                                                             (int)(m_dTGPosition + GetTGAxisPosition()),
                                                                                                                             m_iSpeed * m_iSpeedPercentage,
                                                                                                                             m_iAcc,
                                                                                                                             m_iDec,
                                                                                                                             (m_bIsAbsolute == true ? 1 : 0)));

            }*/
        }

        /// <summary>
        /// ���o TG�b�ثe��m
        /// </summary>
        /// <returns></returns>
        public static double GetTGAxisPosition()
        {
            return GetAxisPosition(TKUnit.IOTable.AxisType.Axis_TG);
        }

        /// <summary>
        /// �ˬd Tg �b �O�_�ʧ@
        /// </summary>
        /// <returns></returns>
        public static bool IsTGAxisRunning()
        {
            return IsRunning(TKUnit.IOTable.AxisType.Axis_TG);
        }

        #endregion
    }

    /// <summary>
    /// �o�O TZ���b���O�C
    /// </summary>
    public class CC_TZ_Axis : CCAbstractAxis
    {
        #region Private Member
        private double m_dTZPosition = 0;
        #endregion

        #region Ctor
        public CC_TZ_Axis()
            : base()
        {
        }
        #endregion

        #region Public Property
        /// <summary>
        ///TZ�b���ʦ�m
        /// </summary>
        public double TZPosition
        {
            set { m_dTZPosition = value; }
        }
        #endregion

        #region Public Method
        /// <summary>
        /// Call C062
        /// </summary>
        public override void Run()
        {/*
            if (m_bIsAbsolute) // ���ﲾ��
            {
                TKUnit.Process.GetSingleton().ProcessCommandForMMICall(String.Format("C062,{0},{1},{2},{3},{4}",
                                                                                                             (int)m_dTZPosition,
                                                                                                             m_iSpeed * m_iSpeedPercentage,
                                                                                                             m_iAcc,
                                                                                                             m_iDec,
                                                                                                             (m_bIsAbsolute == true ? 1 : 0)));
            }
            else // �۹ﲾ��
            {
                TKUnit.Process.GetSingleton().ProcessCommandForMMICall(String.Format("C062,{0},{1},{2},{3},{4}",
                                                                                                                             m_dTZPosition + GetTZAxisPosition(),
                                                                                                                             m_iSpeed * m_iSpeedPercentage,
                                                                                                                             m_iAcc,
                                                                                                                             m_iDec,
                                                                                                                             (m_bIsAbsolute == true ? 1 : 0)));

            }*/
        }

        /// <summary>
        /// ���o TZ�b�ثe��m
        /// </summary>
        /// <returns></returns>
        public static double GetTZAxisPosition()
        {
            return GetAxisPosition(TKUnit.IOTable.AxisType.Axis_TZ);
        }

        /// <summary>
        /// �ˬd TZ �b �O�_�ʧ@
        /// </summary>
        /// <returns></returns>
        public static bool IsTZAxisRunning()
        {
            return IsRunning(TKUnit.IOTable.AxisType.Axis_TZ);
        }
        #endregion
    }
}
