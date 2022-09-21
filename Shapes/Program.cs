using ShapesLibrary;
using OutputLibrary;
using InputLibrary;

List<Shape> Shapes = new List<Shape>();
InputEngine InputEngine = new InputEngine(Shapes);
OutputEngine OutputEngine = new OutputEngine(Shapes);


InputEngine.Run();
OutputEngine.Run();