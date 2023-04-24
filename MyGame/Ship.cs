using GameEngine;
using SFML.System;
using SFML.Window;
using SFML.Graphics;
using SFML.Audio;
using System;


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

        //private const float Speed2 = 0.3f;
        //private const int FireDelay2 = 200;
        //private int _fireTimer2;
        //private int _laser;


        private readonly Sprite _sprite = new();
        
        public Ship()
		{
			_sprite.Texture = Game.GetTexture("Resources/ship.png");
			
			_sprite.Position = new Vector2f(200, 200) /*!> (600, 800)*/;
            //Vector2f !> (600, 800);
            //_sprite.Position = new Vector2f(-Speed, 200);
			//_sprite.Position = new Vector2f(_sprite.Position.X, _sprite.Position.Y);
        }
		public override void Draw()
		{
		Game.RenderWindow.Draw(_sprite);
        }
		public override void Update(Time elapsed)
	    {
            // We don't need to update if we're not drawable.
            //if (!IsDrawable()) return;

            // Update our "timer", and change the frame if we've waited long enough.
            //_msSinceLastFrame += elapsed.AsMilliseconds();

            Vector2f pos = _sprite.Position;
	    	float x = pos.X;
	    	float y = pos.Y;

            int msElapsed = elapsed.AsMilliseconds();			
	    
	    	if (Keyboard.IsKeyPressed(Keyboard.Key.Up)) { y -= Speed * msElapsed; }
	    	if (Keyboard.IsKeyPressed(Keyboard.Key.Down)) { y += Speed * msElapsed; }
	    	if (Keyboard.IsKeyPressed(Keyboard.Key.Left)) { x -= Speed * msElapsed; }
	    	if (Keyboard.IsKeyPressed(Keyboard.Key.Right)) { x += Speed * msElapsed; }
            _sprite.Position = new Vector2f(x, y);
            //Challenge 2
            //{
            //	FloatRect bounds1 = _sprite.GetGlobalBounds();
            //	float spriteX1 = x + bounds1.Width;
            //	float spriteY1 = y + bounds1.Height / 2.0f;
            //	Sprite sprite1 = new Sprite(new Vector2f(spriteX1, spriteY1));
            //	Game.CurrentScene.AddGameObject(sprite1);
            //	
            //}

            if (_fireTimer > 0) { _fireTimer -= msElapsed; }
            if (Keyboard.IsKeyPressed(Keyboard.Key.Space) && _fireTimer <= 0)
			{
				_fireTimer = FireDelay;
				FloatRect bounds = _sprite.GetGlobalBounds();
				float laserX = x + bounds.Width;
				float laserY = y + bounds.Height/2.0f;
				Laser laser = new Laser(new Vector2f (laserX, laserY));
				Game.CurrentScene.AddGameObject(laser);

				//Challenge 3

                float laserX2 = x + bounds.Width;
                float laserY2 = y + bounds.Height;
                Laser laser2 = new Laser(new Vector2f(laserX2, laserY2));
                Game.CurrentScene.AddGameObject(laser2);

                float laserX3 = x + bounds.Width;
                float laserY3 = y + bounds.Height/ 10.0f;
                Laser laser3 = new Laser(new Vector2f(laserX3, laserY3));
                Game.CurrentScene.AddGameObject(laser3);
            }

   //         if (Keyboard.IsKeyPressed(Keyboard.Key.Space) && _fireTimer <= 0)
   //         {
   //             _fireTimer = FireDelay;
   //             FloatRect bounds = _sprite.GetGlobalBounds();
   //             float meteorX = x + bounds.Width;
   //             float meteorY = y + bounds.Height;
   //             Meteor meteor = new Meteor(new Vector2f(meteorX, meteorY));
   //             Game.CurrentScene.AddGameObject(meteor); 
			//}
   //         else { Console.WriteLine("error with meteor check your code"); }
	    }
	}
}