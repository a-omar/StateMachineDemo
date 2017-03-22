using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace InClassDemoGame
{
	public class Ball : IComponent
	{
		Texture2D ball;
		Vector2 position;
		IStateMachine process;

		public Ball (Texture2D b ,Vector2 pos)
		{
			this.ball = b;
			this.position = pos;

			//Define the behavior of the object ball through the statemachine
			this.process = new Repeat (new Seq (new Timer (0.5f), new Call (() => this.position.X += this.position.X * 0.5f)));
			//this.process = new Repeat (new Seq (new Timer(0.5f), new CallIf (()=> this.position.X < 500 , () => this.position.X += this.position.X * 0.5f)));

		}

		public void Draw (SpriteBatch spriteBatch)
		{
			//Draw the texture at a the given position  
			spriteBatch.Draw (ball, position);
		}

		public void Update (float dt)
		{
			//Update the statemachines 
			this.process.Update (dt);

		}
	}
}
