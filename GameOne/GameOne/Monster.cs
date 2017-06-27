using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;

namespace GameOne
{
	class Monster : Entity
	{
		public Monster(
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
	}
}
