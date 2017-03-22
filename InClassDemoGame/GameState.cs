using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace InClassDemoGame
{
	class GameState : IComponent
	{
		Ball ball1;
		Ball ball2;


		public GameState (Texture2D b1, Texture2D b2)
		{
			//Create two ball instances, that have a texture and a position 
			ball1 = null;
			ball2 = null;
		}

		public void Draw (SpriteBatch spriteBatch)
		{
			//Draw both balls
			ball1.Draw (spriteBatch);
			ball2.Draw (spriteBatch);
		}

		public void Update (float dt)
		{
			//Update both balls
			ball2.Update (dt);
			ball1.Update (dt);
		}
	}
}