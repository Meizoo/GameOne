using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;

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
}
