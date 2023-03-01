public class Shape
{
    private string _color;

    public string GetColor()
    {
        return _color;
    }
    public void SetColor(string color) //Don't need SetColor becuase the color is set in each shape's constructor.
    {
        _color = color;
    }

    public Shape(string color)
    {
        _color = color;
    }

    public virtual double GetArea() 
    //Would make more sense to have this be an abstract class by using "abstract" instead of "virutal" (must also use "abstract" in Line 1 between public and class)
    {
        return 0;
    }
}