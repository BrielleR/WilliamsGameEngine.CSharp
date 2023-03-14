﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameEngine;
using SFML.System;
using SFML.Window;
using SFML.Graphics;
using System;
using System.Runtime.CompilerServices;
using System.Linq.Expressions;

namespace MyGame
{
    internal class Laser : GameObject
    {
        private const float Speed = 1.2f;
        private readonly Sprite _sprite = new Sprite();

        public Laser(Vector2f pos)
        {
            _sprite.Texture = Game.GetTexture("Resources/laser.png");
            _sprite.Position = pos;
            AssignTag("laser");
        }
        public override void Draw()
        {
            Game.RenderWindow.Draw(_sprite);
        }
        public override void Update(Time elapsed)
        {
            int mselapsed =elapsed.AsMilliseconds();
            Vector2f pos = _sprite.Position;
            if (pos.X > Game.RenderWindow.Size.X)
            {
                MakeDead();
            }
            else
            {
                int msElapsed = elapsed.AsMilliseconds();
                _sprite.Position = new Vector2f(pos.X + Speed * msElapsed, pos.Y);
            }
        }
    }
}
