using GameEngine;
using SFML.Graphics;
using SFML.System;
using SFML.Window;
using GameEngine;
using SFML.System;
using SFML.Window;
using SFML.Graphics;
using SFML.Audio;
using System;

namespace MyGame
{
    internal class MyGame : GameObject
    {
        private const float Speed = 0.3f;
        private const int WindowWidth = 800;
        private const int WindowHeight = 600;

        private const string WindowTitle = "My Awesome Game";

        private static void Main(string[] args)
        {
            // Initialize the game.
            Game.Initialize(WindowWidth, WindowHeight, WindowTitle);

            // Create our scene.
            GameScene scene = new GameScene();
            Game.SetScene(scene);

            // Run the game loop.
            Game.Run();

            //object elapsed = null;
            ////int Time elapsed = 0;
            //Update(Time elapsed);


        }
        
        public override void Update(Time elapsed)
        {          
            GameScene.Position = new Vector2f(200, 300) /*!> (600, 800)*/;
            Vector2f pos = GameScene.Position;
            float x = pos.X;
            float y = pos.Y;

            int msElapsed = elapsed.AsMilliseconds();

            if (Keyboard.IsKeyPressed(Keyboard.Key.Up)) { y -= Speed * msElapsed; }
            if (Keyboard.IsKeyPressed(Keyboard.Key.Down)) { y += Speed * msElapsed; }
            if (Keyboard.IsKeyPressed(Keyboard.Key.Left)) { x -= Speed * msElapsed; }
            if (Keyboard.IsKeyPressed(Keyboard.Key.Right)) { x += Speed * msElapsed; }
            GameScene.Position = new Vector2f(x, y);
        }
        //public override void Draw()
        //{
        //    Game.RenderWindow.Draw(GameScene);
        //}
    }
}