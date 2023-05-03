using System;
using SplashKitSDK;

namespace CustomProgram
{
    public class Program
    {
        // Create new drawer instance
        private static Drawer myDrawer = new Drawer();

        public static void Main()
        {
            // Create new winow
            Window window = new Window("Pong", 800, 800);

            do
            {
                // standard splashkit protocols
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen();

                //Draw background
                SplashKit.FillRectangle(Color.Black, 0, 0, 800, 800);

                switch (myDrawer.Page)
                {
                       

                    case 0:

                        // Draw mode selection screen
                        myDrawer.StartupScreen();

                        // Manage input options via mouse click
                        // Listen for mouse click
                        if (SplashKit.MouseClicked(MouseButton.LeftButton))
                        {
                            // Configure mouse click location 1 parameters
                            if (SplashKit.MouseY() > 280 && SplashKit.MouseY() < 370)
                            {
                                if (SplashKit.MouseX() > 255 && SplashKit.MouseX() < 545)
                                {
                                    // Configure mouse click on location 1 output
                                    myDrawer.Page = 1;
                                }
                            }
                            // Configure mouse click location 2 parameters
                            if (SplashKit.MouseY() > 430 && SplashKit.MouseY() < 520)
                            {
                                if (SplashKit.MouseX() > 255 && SplashKit.MouseX() < 545)
                                {
                                    // Configure mouse click on location 2 output
                                    myDrawer.Page = 2;
                                }
                            }
                        }

                        break;

                    case 1:

                        // Draw multiplayer color selection screen
                        myDrawer.MultiplayerSelectionScreen();

                        // Configure input options for player 2
                        if (SplashKit.KeyTyped(KeyCode.AKey)) { myDrawer.Player_2_Bar.Color = SplashKit.RandomRGBColor(255); }
                        if (SplashKit.KeyTyped(KeyCode.DKey)) { myDrawer.Player_2_Bar.Color = SplashKit.RandomRGBColor(255); }
                        // Configure input options for player 1
                        if (SplashKit.KeyTyped(KeyCode.RightKey)) { myDrawer.Player_1_Bar.Color = SplashKit.RandomRGBColor(255); }
                        if (SplashKit.KeyTyped(KeyCode.LeftKey)) { myDrawer.Player_1_Bar.Color = SplashKit.RandomRGBColor(255); }
                        // Configure input option to continue to next frame
                        if (SplashKit.KeyTyped(KeyCode.ReturnKey)) { myDrawer.Page = 3; }
                        // Configure input option to return to startup frame
                        if (SplashKit.KeyTyped(KeyCode.EscapeKey)) { myDrawer.Page = 0; }

                        break;

                    case 2:

                        // Draw singleplayer color selection screen
                        myDrawer.SinglePlayerSelectionScreen();

                        // Configure input options for player
                        if (SplashKit.KeyTyped(KeyCode.LeftKey)) { myDrawer.Player_1_Bar.Color = SplashKit.RandomRGBColor(255); }
                        if (SplashKit.KeyTyped(KeyCode.RightKey)) { myDrawer.Player_1_Bar.Color = SplashKit.RandomRGBColor(255); }
                        // Configure input option to continue to next frame
                        if (SplashKit.KeyTyped(KeyCode.ReturnKey)) { myDrawer.Page = 4; }
                        // Configure input option to return to startup frame
                        if (SplashKit.KeyTyped(KeyCode.EscapeKey)) { myDrawer.Page = 0; }

                        break;

                    case 3:

                        // Draw a multiplayer game
                        myDrawer.MultiPlayerGame();
                        // Draw directions for input option
                        SplashKit.DrawText("Press Space to Start", Color.White, 325, 350);
                        // Configure input option to start game
                        if (SplashKit.KeyTyped(KeyCode.SpaceKey)) { myDrawer.Page = 5; }
                        // Configure input option to return to color selection
                        if (SplashKit.KeyTyped(KeyCode.EscapeKey)) { myDrawer.Page = 1; }

                        break;

                    case 4:

                        // Draw a singleplayer game
                        myDrawer.SinglePlayerGame();
                        // Draw directions for input option
                        SplashKit.DrawText("Press Space to Start", Color.White, 325, 350);
                        // Configure input option to start game
                        if (SplashKit.KeyTyped(KeyCode.SpaceKey)) { myDrawer.Page = 6; }
                        // Configure input option to return to color selection
                        if (SplashKit.KeyTyped(KeyCode.EscapeKey)) { myDrawer.Page = 2; }

                        break;

                    case 5:

                        // Draw a multiplayer game
                        myDrawer.MultiPlayerGame();
                        // Configure input options for player 1
                        if (SplashKit.KeyDown(KeyCode.LeftKey) && myDrawer.Player_1_Bar.X > 0) { myDrawer.Player_1_Bar.MoveLeft(); }
                        if (SplashKit.KeyDown(KeyCode.RightKey) && myDrawer.Player_1_Bar.X < 700) { myDrawer.Player_1_Bar.MoveRight(); }
                        // Configure input options for player 2
                        if (SplashKit.KeyDown(KeyCode.AKey) && myDrawer.Player_2_Bar.X > 0) { myDrawer.Player_2_Bar.MoveLeft(); }
                        if (SplashKit.KeyDown(KeyCode.DKey) && myDrawer.Player_2_Bar.X < 700) { myDrawer.Player_2_Bar.MoveRight(); }
                        // Configure input option for pause functionality
                        if (SplashKit.KeyTyped(KeyCode.EscapeKey)) { myDrawer.Page = 7; }

                        // Manage game continuity ie.whether ball is still in play or not
                        if (myDrawer.ball.Y > 0 && myDrawer.ball.Y < 800)
                        {
                            // allow ball movement when ball is still within bounds
                            myDrawer.ball.BallMovement(myDrawer.Player_2_Bar, myDrawer.Player_1_Bar);

                        } else
                        {
                            // initialize 'winner' variable
                            Bar winner;
                            // Find winner of game and let it be the value for the 'winner' variable
                            if (myDrawer.ball.Y < 0) { winner = myDrawer.Player_1_Bar; } else { winner = myDrawer.Player_2_Bar; }
                            // Draw win screen
                            myDrawer.DrawWinner(winner, true);
                            // Reset bar positions
                            myDrawer.Player_1_Bar.Reset();
                            myDrawer.Player_2_Bar.Reset();
                            // Configure continuity option - resets game
                            if (SplashKit.KeyTyped(KeyCode.SpaceKey))
                            {
                                // Send program to frame before game start
                                myDrawer.Page = 3;
                                // Reset ball position and momentum
                                myDrawer.ball.ResetBall();
                                // Update score for winner 
                                winner.Score += 1;

                            }

                        }

                        break;

                    case 6:

                        // Draw singleplayer game
                        myDrawer.SinglePlayerGame();
                        // Configure input options for player
                        if (SplashKit.KeyDown(KeyCode.LeftKey) && myDrawer.Player_1_Bar.X > 0) { myDrawer.Player_1_Bar.MoveLeft(); }
                        if (SplashKit.KeyDown(KeyCode.RightKey) && myDrawer.Player_1_Bar.X < 700) { myDrawer.Player_1_Bar.MoveRight(); }
                        // Configure input option for pause functionality
                        if (SplashKit.KeyTyped(KeyCode.EscapeKey)) { myDrawer.Page = 8; }
                        // Manage game continuity ie.whether ball is still in player or not
                        if (myDrawer.ball.Y > 0 && myDrawer.ball.Y < 800)
                        {
                            // Allow ball movement when ball is still within bounds
                            myDrawer.ball.BallMovement(myDrawer.Ai_Bar, myDrawer.Player_1_Bar);
                            // Allow AI bar movement when ball is still within bounds
                            myDrawer.Ai_Bar.Movement(myDrawer.ball);
                        } else
                        {
                            // Initialize 'winner' variable
                            Bar winner;
                            // Find winner of game and let it be the value for the 'winner' variable
                            if (myDrawer.ball.Y < 0) { winner = myDrawer.Player_1_Bar; } else { winner = myDrawer.Ai_Bar; }
                            // Draw win screen
                            myDrawer.DrawWinner(winner, false);
                            // Reset bar positions
                            myDrawer.Player_1_Bar.Reset();
                            myDrawer.Ai_Bar.Reset();
                            // Configure continuity option - resets game
                            if (SplashKit.KeyTyped(KeyCode.SpaceKey))
                            {
                                // Send program to frame before game start
                                myDrawer.Page = 4;
                                // Reset ball position and momentum
                                myDrawer.ball.ResetBall();
                                // Update score for winner
                                winner.Score += 1;

                            }

                        }

                        break;

                    case 7:
                        // Draw Pause screen
                        myDrawer.PauseScreen();
                        // Configure input to return to game
                        if (SplashKit.KeyTyped(KeyCode.SpaceKey)) { myDrawer.Page = 5; }

                        // Configure input to return to startup screen
                        if (SplashKit.KeyTyped(KeyCode.EscapeKey)) 
                        { 
                            // Return to startup page
                            myDrawer.Page = 0;
                            // Reset both player bars
                            myDrawer.Player_1_Bar.Reset();
                            myDrawer.Player_2_Bar.Reset();
                            // Reset ball
                            myDrawer.ball.ResetBall();
                        }

                        break;

                    case 8:
                        // Draw Pause screen
                        myDrawer.PauseScreen();
                        // Configure input to return to game
                        if (SplashKit.KeyTyped(KeyCode.SpaceKey)) { myDrawer.Page = 6; }

                        //Configure input to return to startup screen
                        if (SplashKit.KeyTyped(KeyCode.EscapeKey)) 
                        { 
                            // Return to startup page
                            myDrawer.Page = 0; 
                            // Reset both player and ai bars
                            myDrawer.Player_1_Bar.Reset();
                            myDrawer.Ai_Bar.Reset();
                            // Reset ball
                            myDrawer.ball.ResetBall();
                        }

                        break;
                }

                SplashKit.RefreshScreen();

            } while (!window.CloseRequested);

        }
    }
}
