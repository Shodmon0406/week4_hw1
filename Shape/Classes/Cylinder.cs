namespace Shape.Classes;

public class Cylinder : Circle
{
    double _height = 1;
    public Cylinder()
    {
        
    }
    public Cylinder(double height)
    {
        _height = height;
    }
    public Cylinder(double height, double radius)
    {
        _height = height;
        base.Radius = radius;
    }
    public Cylinder(double height, double radius, string color)
    {
        _height = height;
        base.Radius = radius;
        base.Color = color;
    }
    public double Height { get => _height; set => _height = value; }
    public override string ToString()
    {
        return $"Cylinder: radius: {base.Radius}, height: {_height}, color: {base.Color}";
    }
    public double GetVolume()
    {
        return base.GetArea() * _height;
    }
}
