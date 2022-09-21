using ShapesLibrary;
using System.Linq;

namespace OutputLibrary
{
    public class OutputEngine
    {
        public List<Shape> Shapes { get; set; }

        public OutputEngine(List<Shape> shapes)
        {
            Shapes = shapes;
        }

        public void Run()
        {
            Console.WriteLine("Chose what to do.");
            Console.WriteLine("List - Lists all shapes");
            Console.WriteLine("Delete - Chose which shape to delete");
            Console.WriteLine("Duplicate - Chose which shape to duplicate");
            Console.WriteLine("Store - Store current Shapes in file");
            Console.WriteLine("If you are finished enter \"Exit\"");

            var input = Console.ReadLine();
            while (input != "Exit")
            {
                if (input == "List")
                {
                    ListShapes();
                }
                else if (input == "Delete")
                {
                    DeleteShape();
                }
                else if (input == "Duplicate")
                {
                    DuplicateShape();
                }
                else if (input == "Store")
                {
                    StoreShapesInFile();
                }
                Console.WriteLine("Chose other command or type Exit");
                input = Console.ReadLine();
            }
        }

        public void ListShapes()
        {
            foreach (var shape in Shapes)
            {
                Console.WriteLine(shape);
            }
        }

        public void DeleteShape()
        {
            Console.WriteLine("Which shape to delete?");
            var input = Console.ReadLine();

            foreach (var shape in Shapes)
            {
                if(shape.ToString() == input)
                {
                    Shapes.Remove(shape);
                    break;
                }
            }
        }

        public void DuplicateShape()
        {
            Console.WriteLine("Which shape to duplicate?");
            var input = Console.ReadLine();

            foreach (var shape in Shapes)
            {
                if (shape.ToString() == input)
                {
                    Shapes.Add(shape);
                    break;
                }
            }
        }

        public void StoreShapesInFile()
        {
            using StreamWriter file = new("Shapes.txt", append: true);

            File.WriteAllLines("C:\\Users\\Ginko\\source\\repos\\ShapesApp\\Shapes\\Shapes.txt", Shapes.Select(s => s.ToString()));

            Console.WriteLine("Saved Shapes in Shapes.txt");
        }
    }
}