using System;

/// <summary>
/// Summary description for Class1
/// </summary>
/// 
namespace MyGame
{
	class Ship : GameObject
	{
		private readonly Sprite _sprite = new Sprite();

		Ship()
		{
			_sprite.Texture = Game.GetTextrue("");
			_sprite.Position = new Vector2f(100, 100);
		}
		public override Draw();
		{
		Game.RenderWindow.Draw(_sprite);
		}
	public override Update(Time elapsed)
	{
		Vector2f pos = _sprite.Position;
		float x = pos.X;
		float y = pos.Y;

		int msElapsed = elapsed.AsMilisecond();


	}

	}
}