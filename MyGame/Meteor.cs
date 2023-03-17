using GameEngine;
using SFML.Graphics;
using SFML.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    internal class Meteor : GameObject
    {
        private const float Speed = 0.25f;
        private readonly Sprite _sprite = new Sprite();
        public Meteor(Vector2f pos)
        {
            _sprite.Texture = Game.GetTexture("Resources/meteor.png");
            _sprite.Position = pos;
            AssignTag("meteor");
            SetCollisionCheckEnabled(true);
        }
        public override void Draw()
        {
            Game.RenderWindow.Draw(_sprite);
        }
        public override void Update(Time elapsed)
        {
            int msElapsed = elapsed.AsMilliseconds();
            Vector2f pos = _sprite.Position;
            //if (pos.X > Game.RenderWindow.Size.X)

            if (pos.X < _sprite.GetGlobalBounds().Width * -1)
            {
                MakeDead();
            }
            else
            {
                //int msElapsed = elapsed.AsMilliseconds();
                //_sprite.Position = new Vector2f(pos.X + Speed * msElapsed, pos.Y);
                _sprite.Position = new Vector2f(pos.X - Speed * msElapsed, pos.Y);
            }
        }
        public override FloatRect GetCollisionRect()
        {
            return _sprite.GetGlobalBounds();
        }
        public override void HandleCollision(GameObject otherGameObject)
        {
            if (otherGameObject.HasTag("laser"))
            {
                otherGameObject.MakeDead();
            }
            Vector2f pos = _sprite.Position;
            pos.X = pos.X + (float)_sprite.GetGlobalBounds().Width / 2.0f;
            pos.Y = pos.Y + (float)_sprite.GetGlobalBounds().Height / 2.0f;
            Explosion explosion = new Explosion(pos);
            Game.CurrentScene.AddGameObject(explosion);
            MakeDead();
        }
    }
}

