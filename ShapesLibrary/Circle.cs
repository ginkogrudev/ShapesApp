namespace ShapesLibrary
{
    public class Circle : Shape
    {
        private float radius;

        public float Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public override float CalculatePerimeter()
        {
            float perimeter = (float)(2 * Math.PI * radius); 
            return  perimeter;
        }

        public override string ToString()
        {
            return $"Circle {Radius}";
        }

        public Circle(float radius)
        {
            Radius = radius;
        }

        public Circle(string parameters)
        {
            var splitParameters = parameters.Split();
            Radius = float.Parse(splitParameters[1]);
        }
    }
}
