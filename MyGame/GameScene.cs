using GameEngine;
using SFML.System;

namespace MyGame
{
    class GameScene : Scene
    {
        private int _score;
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
    }
}