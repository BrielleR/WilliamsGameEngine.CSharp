using GameEngine;
using SFML.System;
using SFML.Window;
using SFML.Graphics;


/*
 * Part one of Goal Sheet 13 : Class for space ship
 * Maintence Log:
 * Date:         Done:
 * 3/13/23       Started working on class but have 56 errors, now 36 errors, now 5 - just the names of the funtions all ahve errors.
 */
namespace MyGame
{	
	class Ship : GameObject
	{
		private const float Speed = 0.3f;
		private const int FireDelay = 200;
		private int _fireTimer;
		private readonly Sprite _sprite = new Sprite();
		public Ship()
		{
			_sprite.Texture = Game.GetTexture("Resources/ship.png");
			_sprite.Position = new Vector2f(100, 100);
		}

		public override void Draw()
		{
		Game.RenderWindow.Draw(_sprite);
		}
		public override void Update(Time elapsed)
	    {
	    	Vector2f pos = _sprite.Position;
	    	float x = pos.X;
	    	float y = pos.Y;
	    
	    	int msElapsed = elapsed.AsMilliseconds();			
	    
	    	if (Keyboard.IsKeyPressed(Keyboard.Key.Up)) { y -= Speed * msElapsed; }
	    	if (Keyboard.IsKeyPressed(Keyboard.Key.Down)) { y += Speed * msElapsed; }
	    	if (Keyboard.IsKeyPressed(Keyboard.Key.Left)) { x -= Speed * msElapsed; }
	    	if (Keyboard.IsKeyPressed(Keyboard.Key.Right)) { x += Speed * msElapsed; }
			_sprite.Position = new Vector2f(x, y);

			if (_fireTimer > 0) { _fireTimer -= msElapsed; }

			if(Keyboard.IsKeyPressed(Keyboard.Key.Space) && _fireTimer <= 0)
			{
				_fireTimer = FireDelay;
				FloatRect bounds = _sprite.GetGlobalBounds();
				float laserX = x + bounds.Width;
				float laserY = y + bounds.Height;
				Laser laser = new Laser(new Vector2f (laserX, laserY));
				Game.CurrentScene.AddGameObject(laser);
			}
	    }
	}
}