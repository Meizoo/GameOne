﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
// Struct, Entity, mockups of Player, Monster, Npc
namespace GameOne
{
    abstract class Entity
    {
        protected string Name;

        protected bool IsVisible;
        protected bool IsPushable;
        protected bool IsTargetable;

        protected bool IsOnGround;

        protected Gravity Gravity;
        protected Description Description;
        protected Velocity Velocity;
        protected Size Size;
        protected Vector2 Position;
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
        public Player() : base()
        {

        }
        public void Jumping(bool hasJumped)
        {
            
            if (HasJumped)
                while (!IsOnGround)
                {

                }

        }
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
=======
=======
>>>>>>> a50464414d69fcd1d7f73719d0cc70584f182cce
=======
>>>>>>> a50464414d69fcd1d7f73719d0cc70584f182cce

namespace GameOne
{
	abstract class Entity
	{
		public Entity(
				string name,
				Flags flags,
				Gravity gravity,
				Description description,
				Velocity velocity,
				Size size,
				Vector2 position
			)
		{
			this.Name = name;
			this.Flags = flags;
			this.Gravity = gravity;
			this.Description = description;
			this.Velocity = velocity;
			this.Size = size;
			this.Position = position;
		}

		protected string Name;
		protected Flags Flags;
		protected Gravity Gravity;
		protected Description Description;
		protected Velocity Velocity;
		protected Size Size;
		protected Vector2 Position;
	}
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> a50464414d69fcd1d7f73719d0cc70584f182cce
=======
>>>>>>> a50464414d69fcd1d7f73719d0cc70584f182cce
=======
>>>>>>> a50464414d69fcd1d7f73719d0cc70584f182cce
}
