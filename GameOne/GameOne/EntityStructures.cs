namespace GameOne
{
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

	struct Lives
	{
		public Lives(short current, short maximal)
		{
			this.Maximal = maximal;
			this.Current = current;
		}

		public short Maximal;
		public short Current;
	}

	struct Health
	{
		public Health(short current, short maximal)
		{
			this.Maximal = maximal;
			this.Current = current;
		}

		public short Maximal;
		public short Current;
	}
}
