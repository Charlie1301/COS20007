using System;
using SplashKitSDK;

namespace CustomProgram
{
    internal class Ball
    {

        private double _y = 395;

        private double _x = 395;

        private readonly int _radius = 10;

        private double y_momentum = 1;

        private double x_momentum = 0;

        private int _bounce = 0;


        public double Y { get { return _y; } set {  _y = value; } }
        
        public double X { get { return _x; } set { _x = value; } }

        public int Radius { get { return _radius; } }


        public void BallMovement(Bar bar1, Bar bar2)
        {

            if (_x <= 0) { x_momentum *= -1; }
            if (_x >= 800) { x_momentum *= -1; }

            Check_Y_Direction(bar1, bar2);
            _y += (0.05 * y_momentum);

            Check_X_Direction(bar1, bar2);
            _x += (0.05 * x_momentum);



        }

        public void Check_Y_Direction(Bar bar1, Bar bar2) 
        { 
        
            if (y_momentum == -1)
            {

                if (_x < (bar1.X + 100) && _x > bar1.X)
                {

                    if (_y < 30 && _y > 10)
                    {
                        y_momentum *= -1;
                        _bounce = 1;
                    }

                }

            } else if (y_momentum == 1)
            {

                if (_x < (bar2.X + 100) && _x > bar2.X)
                {

                    if (_y > 770 && _y < 790)
                    {
                        y_momentum *= -1;
                        _bounce = -1;
                    }

                }

            }

        }

        public void Check_X_Direction(Bar bar1, Bar bar2)
        {

            if (_bounce != 0)
            {

                if (_bounce == -1)
                {

                    switch(_x + 5)
                    {

                        case double n when (n >= bar2.X && n < (bar2.X + 10)):

                            x_momentum = -2.5;
                            break;

                        case double n when (n >= (bar2.X + 10) && n < (bar2.X + 20)):

                            x_momentum = -2;
                            break;

                        case double n when (n >= (bar2.X + 20) && n < (bar2.X + 30)):

                            x_momentum = -1.5;
                            break;

                        case double n when (n >= (bar2.X + 30) && n < (bar2.X + 40)):

                            x_momentum = -1;
                            break;

                        case double n when (n >= (bar2.X + 40) && n < (bar2.X + 45)):

                            x_momentum = -0.5;
                            break;

                        case double n when (n >= (bar2.X + 45) && n <= (bar2.X + 55)):

                            x_momentum = 0;
                            break;

                        case double n when (n > (bar2.X + 55) && n <= (bar2.X + 60)):

                            x_momentum = 0.5;
                            break;

                        case double n when (n > (bar2.X + 60) && n <= (bar2.X + 70)):

                            x_momentum = 1;
                            break;

                        case double n when (n > (bar2.X + 70) && n <= (bar2.X + 80)):

                            x_momentum = 1.5;
                            break;

                        case double n when (n > (bar2.X + 80) && n <= (bar2.X + 90)):

                            x_momentum = 2;
                            break;

                        case double n when (n > (bar2.X + 90) && n <= (bar2.X + 100)):

                            x_momentum = 2.5;
                            break;
                    }

                }

                if (_bounce == 1)
                {

                    switch (_x + 5)
                    {

                        case double n when (n >= bar1.X && n < (bar1.X + 10)):

                            x_momentum = -2.5;
                            break;

                        case double n when (n >= (bar1.X + 10) && n < (bar1.X + 20)):

                            x_momentum = -2;
                            break;

                        case double n when (n >= (bar1.X + 20) && n < (bar1.X + 30)):

                            x_momentum = -1.5;
                            break;

                        case double n when (n >= (bar1.X + 30) && n < (bar1.X + 40)):

                            x_momentum = -1;
                            break;

                        case double n when (n >= (bar1.X + 40) && n < (bar1.X + 45)):

                            x_momentum = -0.5;
                            break;

                        case double n when (n >= (bar1.X + 45) && n <= (bar1.X + 55)):

                            x_momentum = 0;
                            break;

                        case double n when (n > (bar1.X + 55) && n <= (bar1.X + 60)):

                            x_momentum = 0.5;
                            break;

                        case double n when (n > (bar1.X + 60) && n <= (bar1.X + 70)):

                            x_momentum = 1;
                            break;

                        case double n when (n > (bar1.X + 70) && n <= (bar1.X + 80)):

                            x_momentum = 1.5;
                            break;

                        case double n when (n > (bar1.X + 80) && n <= (bar1.X + 90)):

                            x_momentum = 2;
                            break;

                        case double n when (n > (bar1.X + 90) && n <= (bar1.X + 100)):

                            x_momentum = 2.5;
                            break;
                    }

                }

                _bounce = 0;

            }

        }

        public void ResetBall()
        {
            _x = 395;
            _y = 395;
            x_momentum = 0;
            y_momentum = 1;
        }

    }
}
