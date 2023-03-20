using GameEngine;
using SFML.System;

namespace MyGame
{
    class GameScene : Scene
    {
        public GameScene()
        {
            Ship ship = new Ship();
            AddGameObject(ship);

            Meteor_Spawner meteor_Spawner = new Meteor_Spawner();
            AddGameObject(meteor_Spawner);
        }
    }
}