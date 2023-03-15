using GameEngine;

namespace MyGame
{
    class GameScene : Scene
    {
        public GameScene()
        {
            Ship ship = new Ship();
            AddGameObject(ship);
            Meteor_Spawner meteorSpawner = new Meteor_Spawner();
                AddGameObject(meteorSpawner);
        }
    }
}