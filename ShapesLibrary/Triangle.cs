namespace ShapesLibrary
{
    public class Triangle : Shape
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

        private float sideC;

        public float SideC
        {
            get { return sideC; }
            set { sideC = value; }
        }


        public override float CalculatePerimeter()
        {
            float perimeter = sideA + sideB + sideC;
            return perimeter;
        }

        public override string ToString()
        {
            return $"Triangle {sideA} {sideB} {sideC}";
        }

        public Triangle(float sideA, float sideB, float sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public Triangle(string parameters)
        {
            var splitParameters  = parameters.Split();
            SideA = float.Parse(splitParameters[1]);
            SideB = float.Parse(splitParameters[2]);
            SideC = float.Parse(splitParameters[3]);
        }
    }
}
