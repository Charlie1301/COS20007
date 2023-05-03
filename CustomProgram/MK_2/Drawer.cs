using System;
using SplashKitSDK;

namespace CustomProgram
{
    internal class Drawer
    {
        // create page variable to manage frames
        private int _page = 0;
        // create two player instances and an ai instance to allow for all game modes
        private readonly Player _player1 = new Player(770, "Player 1");
 
        private readonly Player _player2 = new Player(10, "Player 2");

        private readonly Ai _ai = new Ai("AI");
        // create a single ball instance
        private readonly Ball _ball = new Ball();

        // drawer constructor requires nothing
        public Drawer() { }

        // allow all instance variables to have public getters
        // allow only the _page variable to have a public setter
        public int Page { get { return _page; } set { _page = value; } }

        public Player Player_1_Bar { get { return _player1; } }

        public Player Player_2_Bar { get { return _player2; } }

        public Ai Ai_Bar { get { return _ai; } }

        public Ball ball { get { return _ball; } }


  

        public void DrawWinner(Bar winner, bool mode)
        {
            // 'winner' variable allows the function to know who won the round
            // 'mode' variable allows the function to know whether game is in multiplayer mode or singleplayer mode

            // Placeholders requires since the score cannot be updated here due to the loop
            int ai_win_point_placeholder = 0;
            int player_1_win_point_placeholder = 0;
            int player_2_win_point_placeholder = 0;
            // provides a variable for the print winner to be centered
            int x_value = 0;
            // update placeholder value and apply x_value
            switch (winner.Name)
            {
                case "AI":

                    ai_win_point_placeholder = 1;
                    x_value = 365;
                    break;

                case "Player 1":

                    player_1_win_point_placeholder = 1;
                    x_value = 340;
                    break;

                case "Player 2":

                    player_2_win_point_placeholder = 1;
                    x_value = 340;
                    break;
            }
            // Draw winner name
            SplashKit.DrawText($"{winner.Name} Wins!!", Color.White, x_value, 370);
            // Draw input option to continue to next round
            SplashKit.DrawText("Press the SpaceBar to continue", Color.White, 280, 410);
            // Draw player 1 score
            SplashKit.DrawText($"Player 1 Score: {(_player1.Score + player_1_win_point_placeholder).ToString()}", Color.White, 330, 520);
            // Draw either player 2 score or ai score depending on game mode
            if (mode)
            {
                SplashKit.DrawText($"Player 2 Score: {(_player2.Score + player_2_win_point_placeholder).ToString()}", Color.White, 330, 250);
            }

            if (!mode)
            {
                SplashKit.DrawText($"AI Score: {(_ai.Score + ai_win_point_placeholder).ToString()}", Color.White, 360, 250);
            }
        }

        public void PauseScreen()
        {
            // Draw text showing the game is paused
            SplashKit.DrawText("PAUSED", Color.White, 375, 350);
            // Draw directions to input options - resume game and restart game
            SplashKit.DrawText("Press Space to resume", Color.White, 315, 450);
            SplashKit.DrawText("Press Escape to restart game", Color.White, 290, 500);
        }

        public void StartupScreen()
        {

            //Draw Multiplayer button 
            SplashKit.FillRectangle(Color.White, 250, 275, 300, 100);
            SplashKit.FillRectangle(Color.Black, 255, 280, 290, 90);
            SplashKit.DrawText("Multiplayer", Color.White, 355, 325);

            // Draw Singleplayer button
            SplashKit.FillRectangle(Color.White, 250, 425, 300, 100);
            SplashKit.FillRectangle(Color.Black, 255, 430, 290, 90);
            SplashKit.DrawText("Singleplayer", Color.White, 352, 475);
            // Draw two player bars for aesthetic
            SplashKit.FillRectangle(Color.White, _player1.X, _player1.Y, 100, 20);
            SplashKit.FillRectangle(Color.Black, _player1.X + 2.5, _player1.Y + 2.5, 95, 15);

            SplashKit.FillRectangle(Color.White, _player2.X, _player2.Y, 100, 20);
            SplashKit.FillRectangle(Color.Black, _player2.X + 2.5, _player2.Y + 2.5, 95, 15);

        }

        public void MultiplayerSelectionScreen()
        {

            // Draw input directions
            SplashKit.DrawText("player 1 use arrows to change color", Color.White, 260, 550);
            SplashKit.DrawText("player 2 use 'a' and 'd' keys to change color", Color.White, 225, 200);
            SplashKit.DrawText("press enter to continue", Color.White, 307.5, 650);

            // Draw dummy bar 1
            SplashKit.FillRectangle(Color.White, 250, 300, 300, 60);
            SplashKit.FillRectangle(_player2.Color, 257.5, 307.5, 285, 45);

            // Draw dummy bar 2
            SplashKit.FillRectangle(Color.White, 250, 440, 300, 60);
            SplashKit.FillRectangle(_player1.Color, 257.5, 447.5, 285, 45);

        }

        public void SinglePlayerSelectionScreen()
        {

            // Draw input directions
            SplashKit.DrawText("Use arrow keys to change color", Color.White, 280, 200);
            SplashKit.DrawText("Press enter to continue", Color.White, 300, 650);

            //Draw dummy bar
            SplashKit.FillRectangle(Color.White, 250, 370, 300, 60);
            SplashKit.FillRectangle(_player1.Color, 260, 380, 280, 40);

        }

        public void SinglePlayerGame()
        {

            // Draw ball
            SplashKit.FillRectangle(Color.White, _ball.X, _ball.Y, _ball.Radius, _ball.Radius);

            // Draw player bar
            SplashKit.FillRectangle(Color.White, _player1.X, _player1.Y, 100, 20);
            SplashKit.FillRectangle(_player1.Color, _player1.X + 2.5, _player1.Y + 2.5, 95, 15);

            // Draw AI bar
            SplashKit.FillRectangle(Color.White, _ai.X, _ai.Y, 100, 20);
            SplashKit.FillRectangle(_ai.Color, _ai.X + 2.5, _ai.Y + 2.5, 95, 15);

        }

        public void MultiPlayerGame()
        {

            // Draw ball
            SplashKit.FillRectangle(Color.White, _ball.X, _ball.Y, _ball.Radius, _ball.Radius);

            // Draw player 1 bar
            SplashKit.FillRectangle(Color.White, _player1.X, _player1.Y, 100, 20);
            SplashKit.FillRectangle(_player1.Color, _player1.X + 2.5, _player1.Y + 2.5, 95, 15);

            // Draw player 2 bar
            SplashKit.FillRectangle(Color.White, _player2.X, _player2.Y, 100, 20);
            SplashKit.FillRectangle(_player2.Color, _player2.X + 2.5, _player2.Y + 2.5, 95, 15);

        }

    }
}
