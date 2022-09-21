using ShapesLibrary;
using System;
using System.Reflection.Metadata;

namespace InputLibrary
{
    public class InputEngine
    {
        public List<Shape> Shapes { get; set; }

        public enum ShapeTypes
        {
            Circle,
            Rectangle,
            Triangle
        }

        public InputEngine(List<Shape> shapes)
        {
            Shapes = shapes;
        }
        public void Run()
        {
            Console.WriteLine("Chose what to do.");
            Console.WriteLine("Random - Enter how many random shapes would you like to create");
            Console.WriteLine("Console - Enter number of shapes you want to add,then list the shapes");
            Console.WriteLine("File - Read figures from a file");
            Console.WriteLine("If you are finished enter \"Exit\"");

            var input = Console.ReadLine();
            while (input != "Exit")
            {
                if (input == "Random")
                {
                    GenerateRandomShapes();
                }
                if (input == "Console")
                {
                    GenerateShapesFromConsole();
                }
                if (input == "File")
                {
                    GenerateShapesFromFile();
                }
                Console.WriteLine("Chose other command or type Exit");
                input = Console.ReadLine();
            }
        }

        public void GenerateRandomShapes()
        {
            Console.WriteLine("Enter number of shapes to be created");
            int numberOfShapes = int.Parse(Console.ReadLine());

            Random random = new Random();
            Type type = typeof(ShapeTypes);
            Array types = type.GetEnumValues();


            for (int i = 0; i < numberOfShapes; i++)
            {
                int shapeType = random.Next(types.Length);
                if (shapeType == 0)
                {
                    var radius = random.Next(1,100);

                    Circle randomCircle = new Circle(radius);
                    Shapes.Add(randomCircle);
                    Console.WriteLine($"Added {randomCircle}");
                }
                else if (shapeType == 1)
                {
                    var sideA = random.Next(1, 100);
                    var sideB = random.Next(1, 100);
                    var sideC = random.Next(1, 100);

                    Triangle randomTriangle = new Triangle(sideA,sideB,sideC);
                    Shapes.Add(randomTriangle);
                    Console.WriteLine($"Added {randomTriangle}");
                }
                else if(shapeType == 2)
                {
                    var sideA = random.Next(1, 100);
                    var sideB = random.Next(1, 100);

                    Rectangle randomRectangle = new Rectangle(sideA, sideB);
                    Shapes.Add(randomRectangle);
                    Console.WriteLine($"Added {randomRectangle}");
                }
            }
        }

        public void GenerateShapesFromConsole()
        {
            Console.WriteLine("Enter how many shapes you would like to create then enter them in the console");
            int numberOfShapes = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfShapes; i++)
            {
                var paramseters = Console.ReadLine();
                var typeOfShape = paramseters.Split()[0];
                if (typeOfShape == "Triangle")
                {
                    var userTriangle = new Triangle(paramseters);
                    Shapes.Add(userTriangle);
                }
                else if (typeOfShape == "Rectangle")
                {
                    var userRectangle = new Rectangle(paramseters);
                    Shapes.Add(userRectangle);
                }
                else if (typeOfShape == "Circle")
                {
                    var userCircle = new Circle(paramseters);
                    Shapes.Add(userCircle);
                }
                else
                {
                    Console.WriteLine($"{typeOfShape} is not supported yet");
                }
            }
        }

        public void GenerateShapesFromFile()
        {
            string[] shapesToCreate = File.ReadAllLines("C:\\Users\\Ginko\\source\\repos\\ShapesApp\\Shapes\\Shapes.txt");

            foreach (var line in shapesToCreate)
            {
                var type = line.Split()[0];
                if (type == "Triangle")
                {
                    var userTriangle = new Triangle(line);
                    Shapes.Add(userTriangle);
                }
                else if (type == "Rectangle")
                {
                    var userRectangle = new Rectangle(line);
                    Shapes.Add(userRectangle);
                }
                else if (type == "Circle")
                {
                    var userCircle = new Circle(line);
                    Shapes.Add(userCircle);
                }
                else
                {
                    Console.WriteLine($"{type} is not supported yet");
                }
            }
        }
    }
}