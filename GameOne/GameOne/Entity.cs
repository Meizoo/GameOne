using System;
>>>>>>> 845128443e4ce5e2a397b180b44d9bf4c1bde7d9

using Microsoft.Xna.Framework;
// Struct, Entity, mockups of Player, Monster, Npc
namespace GameOne
{
	abstract class Entity
	{
		private string Name;

		private bool IsVisible;
		private bool IsPushable;
		private bool IsTargetable;

		private bool IsOnGround;

		private Gravity Gravity;
		private Description Description;
		private Velocity Velocity;
		private Size Size;
		private Vector2 Position;
	}

	struct Gravity
	{
		public Gravity(double current, double acceleration, double maximal = MaximalDefault)
		{
			this.Maximal = maximal;
			this.Acceleration = acceleration;
			this.Current = current;
		}

		public double Maximal;
		public double Current;
		public double Acceleration;

		private const double MaximalDefault = 128;
	}

	struct Description
	{
		public Description(string shortDesc, string longDesc)
		{
			this.Short = shortDesc;
			this.Long = longDesc;
		}

		public string Short;
		public string Long;
	}

	struct Velocity
	{
		public Velocity(double current, double minimal = DefaultMinimal, double maximal = DefaultMaximal)
		{
			this.Maximal = maximal;
			this.Current = current;
			this.Minimal = minimal;
		}

		public double Maximal;
		public double Current;
		public double Minimal;

		private const double DefaultMaximal = 128;
		private const double DefaultMinimal = 0;
	}

	struct Size
	{
		public Size(int width, int height)
		{
			this.Width = width;
			this.Height = height;
		}

		public int Width;
		public int Height;
	}

	class Player : Entity
	{



		private bool HasJumped;
		private double JumpVelocity;
	}

	class Monster : Entity
	{

	}

	class NPC : Entity
	{

	}

	class Item
	{

	}
<<<<<<< HEAD
>>>>>>> 845128443e4ce5e2a397b180b44d9bf4c1bde7d9
=======
>>>>>>> 845128443e4ce5e2a397b180b44d9bf4c1bde7d9
}
