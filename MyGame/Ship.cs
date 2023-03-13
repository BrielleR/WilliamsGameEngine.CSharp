using GameEngine;
using SFML.System;
using SFML.Window;
using SFML.Graphics;
using System;
using System.Runtime.CompilerServices;

/*
 * Part one of Goal Sheet 13 : Class for space ship
 * Maintence Log:
 * Date:         Done:
 * 3/13/23       Started working on class but have 56 errors, now 36 errors, now 5 - just the names of the funtions all ahve errors.
 */
namespace MyGame
{
	class Ship //GameObject
	{
		private readonly Sprite _sprite = new Sprite();
		Ship()
		{
			_sprite.Texture = Game.GetTexture("Resources/ship.png");
			_sprite.Position = new Vector2f(100, 100);
		}
	
		public override void Draw()
		{
		Game.RenderWindow.Draw(_sprite);
		}
		public override void Update(Time elapsed, int speed)
	    {
	    	Vector2f pos = _sprite.Position;
	    	float x = pos.X;
	    	float y = pos.Y;
	    
	    	int msElapsed = elapsed.AsMilliseconds();			
	    
	    	if (Keyboard.IsKeyPressed(Keyboard.Key.Up)) { y -= speed * msElapsed; }
	    	if (Keyboard.IsKeyPressed(Keyboard.Key.Down)) { y += speed * msElapsed; }
	    	if (Keyboard.IsKeyPressed(Keyboard.Key.Left)) { x -= speed * msElapsed; }
	    	if (Keyboard.IsKeyPressed(Keyboard.Key.Right)) { x += speed * msElapsed; }
			_sprite.Position = new Vector2f(x, y);
	    }
        public override void Update(Time elapsed, int speed)
        {
            Vector2f pos = _sprite.Position;
            float x = pos.X;
            float y = pos.Y;

            int msElapsed = elapsed.AsMilliseconds();

            if (Keyboard.IsKeyPressed(Keyboard.Key.Up)) { y -= speed * msElapsed; }
            if (Keyboard.IsKeyPressed(Keyboard.Key.Down)) { y += speed * msElapsed; }
            if (Keyboard.IsKeyPressed(Keyboard.Key.Left)) { x -= speed * msElapsed; }
            if (Keyboard.IsKeyPressed(Keyboard.Key.Right)) { x += speed * msElapsed; }
            _sprite.Position = new Vector2f(x, y);
        }
    }
}
       