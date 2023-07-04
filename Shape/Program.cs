using Shape.Classes;

Circle circle = new Circle(2, "blue");
Cylinder cylinder = new Cylinder(5, 2, "gold");
System.Console.WriteLine(circle.ToString());
System.Console.WriteLine(cylinder.ToString());
circle.Color = "yellow";
circle.Radius = 4;
cylinder.Color = "red";
cylinder.Height = 3.5;
cylinder.Radius = 4;
System.Console.WriteLine(circle.ToString());
System.Console.WriteLine(cylinder.ToString());
System.Console.WriteLine(circle.GetArea());
System.Console.WriteLine(cylinder.GetVolume());