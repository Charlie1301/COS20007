using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;

namespace CustomProgram
{
    internal class Drawer
    {
        private int page = 0;

        private readonly Player _player = new Player("Player 1");

        private readonly ai _ai = new ai("AI");

        private readonly ball _ball = new ball();

        public Drawer() { }

        public int Page { get { return page; } set { page = value; } }

        public Player PlayerBar { get { return _player; } }
        public ai AiBar { get { return _ai; } }

        public ball Ball { get { return _ball; } }

        public void draw()
        {
            // Draw Ball
            SplashKit.FillRectangle(Color.Black, _ball.X, _ball.Y, _ball.Radius, _ball.Radius);

            // Draw Bars
            SplashKit.FillRectangle(Color.Black, _player.X, _player.Y, 100, 10);
            SplashKit.FillRectangle(Color.Black, _ai.X, _ai.Y, 100, 10);

        }

        public void DrawWinner(bar winner)
        {

            int ai_win_point = 0;
            int player_win_point = 0;

            int x_value = 0;

            if (winner.Name == "AI")
            {
                x_value = 375;
                ai_win_point = 1;
            } else
            {
                player_win_point = 1;
                x_value = 350;
            }

            SplashKit.DrawText($"{winner.Name} Wins!!", Color.Black, x_value, 380);

            SplashKit.DrawText("Press the SpaceBar to continue", Color.Black, 300, 410);

            SplashKit.DrawText((_player.Score + player_win_point).ToString(), Color.Black, 390, 450);

            SplashKit.DrawText((_ai.Score + ai_win_point).ToString(), Color.Black, 390, 350);
        }

        public void PauseScreen()
        {
            SplashKit.DrawText("PAUSED", Color.Black, 450, 350);
            SplashKit.DrawText("Press Space to resume", Color.Black, 400, 450);
            SplashKit.DrawText("Press Escape to restart game", Color.Black, 350, 500);
        }

    }
}
