using System;
using SplashKitSDK;

namespace CustomProgram
{
    public class Program
    {
        private static Drawer myDrawer = new Drawer();
        public static void Main()
        {

            Window window = new Window("Pong", 800, 801);

            do
            {

                SplashKit.ProcessEvents();
                SplashKit.ClearScreen();
                myDrawer.draw();
                if (SplashKit.KeyTyped(KeyCode.SpaceKey) && myDrawer.Page == 0) { 
                    myDrawer.Page = 1;
                }
                if (myDrawer.Page == 1)
                {
                    if (SplashKit.KeyDown(KeyCode.LeftKey) && myDrawer.PlayerBar.X > 0) { myDrawer.PlayerBar.MoveLeft(); }
                    if (SplashKit.KeyDown(KeyCode.RightKey) && myDrawer.PlayerBar.X < 700) { myDrawer.PlayerBar.MoveRight(); }
                    if (SplashKit.KeyTyped(KeyCode.EscapeKey)) { myDrawer.Page = 2; }
                    if (myDrawer.Ball.Y > 0 && myDrawer.Ball.Y < 800 && myDrawer.Page != 2)
                    {
                        myDrawer.Ball.Movement(myDrawer.PlayerBar, myDrawer.AiBar);
                        myDrawer.AiBar.Movement(myDrawer.Ball);
                    } else
                    {
                        bar winner;
                        if (myDrawer.Ball.Y < 0) { winner = myDrawer.PlayerBar; } else { winner = myDrawer.AiBar; }
                        myDrawer.DrawWinner(winner);
                        if (SplashKit.KeyTyped(KeyCode.SpaceKey))
                        {
                            myDrawer.Page = 0;
                            myDrawer.Ball.ResetBall();
                            winner.Score += 1;
                        }
                    }
                    
                } else if (myDrawer.Page == 0)
                {
                    SplashKit.DrawText("Press the SpaceBar to start", Color.Black, 300, 370);
                } else if (myDrawer.Page == 2)
                {
                    myDrawer.PauseScreen();

                    if (SplashKit.KeyTyped(KeyCode.EscapeKey))
                    {
                        myDrawer.PlayerBar.Score = 0;
                        myDrawer.AiBar.Score = 0;
                        myDrawer.PlayerBar.Reset();
                        myDrawer.AiBar.Reset();
                        myDrawer.Page = 0;
                    }

                    if (SplashKit.KeyTyped(KeyCode.SpaceKey))
                    {
                        myDrawer.Page = 1;
                    }

                }
                SplashKit.RefreshScreen();

            } while (!window.CloseRequested);

        }
    }
}
