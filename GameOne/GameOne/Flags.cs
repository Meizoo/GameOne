using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOne
{
	struct Flags
	{
		public Flags(
			bool isVisible,
			bool isPushable,
			bool isTargetable,
			bool isOnGround)
		{
			this.IsVisible    = isVisible;;
			this.IsPushable   = isPushable;;
			this.IsTargetable = isTargetable;
			this.IsOnGround   = isOnGround; ;
		}

		public bool IsVisible;
		public bool IsPushable;
		public bool IsTargetable;
		public bool IsOnGround;
	}
}
