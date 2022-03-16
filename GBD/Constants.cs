using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BWM01
{
    static class Constants
    {
        public const int SUCCESS = 0;
        public const int FAILURE = -1;

        public const short AxisX = 2;
        public const short AxisY = 1;
        public const short AxisZ = 3;
        public const short AxisC = 4;
        public const short AxisW = 5;
        public const short LinearEncoder = 10;

        public const short WireLengthEncoder = 9;

        public const int ZeroOrigin = 0;

        public const int Clockwise = 0;
        public const int CounterClockwise = 1;


        // XYZC 轴JOG运动速度可以考虑写在 sys.config 配置文件中，此处不需要硬编码
        public const double XVelocity = 10;
        public const double YVelocity = 12;
        public const double ZVelocity = 6;
        public const double CVelocity = 6;
        public const double WVelocity = 4;

        public const double ZSlowSpeed = 2;

        //public const double Acceleration = 0.1;
        public const double Acceleration = 0.0625;
        public const double Smooth = 0.9;
        public const short SmoothTime = 25;
        public const double VelStart = 20;

        public const double UnitVelocity = 1;

        // XYZC每转脉冲数、丝杆导程、C轴齿轮比
        public const int XPulsesPerCircle = 5000;
        public const int YPulsesPerCircle = 5000;
        public const int ZPulsesPerCircle = 10000;
        public const int CPulsesPerCircle = 20000;
        public const int WEncoderPulsesPerCircle = 1000;


        public const int XPitchPerCircle = 10;
        public const int YPitchPerCircle = 10;
        public const int ZPitchPerCircle = 10;

        public const double CircleAngle = 360.0;
        public const double NintyDegrees = 90.0;
        public const double PIAngle = 180;

        public const double CZeroOffset = 126.63;
        public const double WStepAngle = 1.8;
        public const int WSubdivision = 64;

        public const int WPulsesPerCircle = (int)(CircleAngle / WStepAngle * WSubdivision);

        public const double WEncoderRadius = 10.0;
        public const double WEncoderPitchPerCircle = 2 * Math.PI * WEncoderRadius;

        public const int CGearRatio = 2;



        // 语言标识，1表示中文，2表示英文
        public const int Chinese = 1;
        public const int English = 2;


        public const int GPOValue = 65535;

        public const int SEARCH_HOME = -200000;
        public const int HOME_OFFSET = 2500;
        //public const int HOME_OFFSET = 0;
    }
}
