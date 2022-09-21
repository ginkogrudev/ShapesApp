namespace ShapesLibrary
{
    public class Rectangle : Shape
    {
		private float sideA;

		public float SideA
		{
			get { return sideA; }
			set { sideA = value; }
		}

		private float sideB;

		public float SideB
		{
			get { return sideB; }
			set { sideB = value; }
		}

		public override float CalculatePerimeter()
		{
			float perimeter = (SideA + SideB)* 2;
			return perimeter;
		}

		public override string ToString()
		{
			return $"Rectangle {SideA} {SideB}";
		}

		public Rectangle(float sideA,float sideB)
		{
			SideA = sideA;
			SideB = sideB;
		}

		public Rectangle(string parameters)
		{
            var splitParameters = parameters.Split();
            SideA = float.Parse(splitParameters[1]);
            SideB = float.Parse(splitParameters[2]);
        }
	}
}
