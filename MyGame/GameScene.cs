using GameEngine;
using SFML.System;
using SFML.Window;

namespace MyGame
{
    internal class GameScene : Scene
    {
        //private const float Speed = 0.3f;
        private int _lives = 3;
        private int _score;
        internal static Vector2f Position;

        public GameScene()
        {
            Ship ship = new Ship();
            AddGameObject(ship);

            Meteor_Spawner meteor_Spawner = new Meteor_Spawner();
            AddGameObject(meteor_Spawner);

            Score score = new Score(new Vector2f(10.0f, 10.0f));
            AddGameObject(score);
        }
        public int GetScore()
        {
            return _score;
        }
        public void IncreaseScore()
        {
            ++_score;
        }

        public int GetLives()
        {
            return _lives;
        }
        public void DecreaseLives()
        {
            --_lives;
            if(_lives == 0)
            {
                GameOverScene gameOverScene = new GameOverScene(_score);
                Game.SetScene(gameOverScene);
            }
        }
        //public override void Update(Time elapsed)
        //{
        //    // We don't need to update if we're not drawable.
        //    //if (!IsDrawable()) return;

        //    // Update our "timer", and change the frame if we've waited long enough.
        //    //_msSinceLastFrame += elapsed.AsMilliseconds();
        //    GameScene.Position = new Vector2f(200, 200) /*!> (600, 800)*/;
        //    Vector2f pos = GameScene.Position;
        //    float x = pos.X;
        //    float y = pos.Y;

        //    int msElapsed = elapsed.AsMilliseconds();

        //    if (Keyboard.IsKeyPressed(Keyboard.Key.Up)) { y -= Speed * msElapsed; }
        //    if (Keyboard.IsKeyPressed(Keyboard.Key.Down)) { y += Speed * msElapsed; }
        //    if (Keyboard.IsKeyPressed(Keyboard.Key.Left)) { x -= Speed * msElapsed; }
        //    if (Keyboard.IsKeyPressed(Keyboard.Key.Right)) { x += Speed * msElapsed; }
        //    GameScene.Position = new Vector2f(x, y);
        //}
    }
}