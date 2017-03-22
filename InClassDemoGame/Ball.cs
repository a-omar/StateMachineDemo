using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace InClassDemoGame
{
	public class Ball : IComponent
	{
		// Define the instance variables for the ball 
		// Idealy the ball should have a texture and a position, and a 
		// statemachine instance to define the behavior of the instance.



		//Define the arguments for the constructor
		public Ball ()
		{
			//Define the behavior of the object ball through the statemachine
			//The ball should repeat a sequence of two statemachines timer and a call
			//The call instance moves the object horizontally or vertically

		}

		public void Draw (SpriteBatch spriteBatch)
		{
			//Draw the texture at a the given position  

		}

		public void Update (float dt)
		{
			//Update the statemachines 


		}
	}
}
