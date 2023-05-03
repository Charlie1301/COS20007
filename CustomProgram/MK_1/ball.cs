using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;

namespace CustomProgram
{
    internal class ball
    {

        private double _y = 401;

        private double _x = 401;

        private int radius = 10;

        private int y_direction = 1;

        private int x_direction = 0;

        private int bounce = 0;


        public double Y { get { return _y; } set { _y = value; } }
        public double X { get { return _x; } set { _x = value; } }

        public int Radius { get { return radius; } }


        public void Movement(Player player, ai Ai) {

            if (_x <= 0) { x_direction *= -1; }

            if (_x >= 800) { x_direction *= -1; }

            Check_Y_Direction(player, Ai);

            _y += (0.05 * y_direction);

            Check_X_Direction(player, Ai);

            _x += (0.05 * x_direction);


        }

        public void Check_Y_Direction(Player player, ai Ai)
        {

            if (y_direction == -1) {

                if (_x < (Ai.X + 100) && _x > Ai.X) { 
                
                    if (_y < 30 && _y > 10)
                    {
                        y_direction = 1;
                        bounce = 1;
                    }

                }
            
            } else if (y_direction == 1) {
         
                if (_x < (player.X + 100) && _x > player.X )
                {
                 
                    if (_y > 780 && _y < 790)
                    {
                        y_direction = -1;
                        bounce = -1;
                    }

                }
            
            }



        }

        public void Check_X_Direction(Player player, ai Ai)
        {
            if (bounce != 0)
            {
                if (bounce == -1)
                {

                    switch (_x + 5)
                    {
                        case double n when (n >= player.X && n < (player.X + 20)):
                            x_direction = -2;
                            break;
                        case double n when (n >= (player.X + 20) && n < (player.X + 40)):
                            x_direction = -1;
                            break;
                        case double n when (n >= (player.X + 40) && n <= (player.X + 60)):
                            x_direction = 0;
                            break;
                        case double n when (n > (player.X + 60) && n <= (player.X + 80)):
                            x_direction = 1;
                            break;
                        case double n when (n > (player.X + 80) && n <= (player.X + 100)):
                            x_direction = 2;
                            break;
                    }

                }

                if (bounce == 1)
                {

                    switch (_x + 5)
                    {
                        case double n when (n >= Ai.X && n < (Ai.X + 20)):
                            x_direction = -2;
                            break;
                        case double n when (n >= (Ai.X + 20) && n < (Ai.X + 40)):
                            x_direction = -1;
                            break;
                        case double n when (n >= (Ai.X + 40) && n <= (Ai.X + 60)):
                            x_direction = 0;
                            break;
                        case double n when (n > (Ai.X + 60) && n <= (Ai.X + 80)):
                            x_direction = 1;
                            break;
                        case double n when (n > (Ai.X + 80) && n <= (Ai.X + 100)):
                            x_direction = 2;
                            break;
                    }

                }

                bounce = 0;

            }
        }

        public void ResetBall()
        {
            _x = 401;
            _y = 401;
            x_direction = 0;
            y_direction = 1;
        }

    }
}
