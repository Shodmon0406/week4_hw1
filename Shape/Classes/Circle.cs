namespace Shape.Classes;

public class Circle
{
    double _radius = 1;
    string _color = "red";
    public Circle()
    {

    }
    public Circle(double radius)
    {
        _radius = radius;
    }
    public Circle(double radius, string color)
    {
        _radius = radius;
        _color = color;
    }
    public double Radius { get => _radius; set => _radius = value; }
    public string Color { get => _color; set => _color = value; }
    public override string ToString()
    {
        return $"Circle: radius = {_radius}, color = {_color}";
    }
    public double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}
