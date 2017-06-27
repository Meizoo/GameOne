using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;

namespace GameOne
{
	class Player : Entity
	{
		public Player(
				string name,
				Flags flags,
				Gravity gravity,
				Description description,
				Velocity velocity,
				Size size,
				Vector2 position
			) : base(name, flags, gravity, description, velocity, size, position)
		{
			
		}

		private Lives Lives;
		private bool HasJumped;
		private double JumpVelocity;
	}
}
