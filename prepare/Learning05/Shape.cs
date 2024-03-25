public abstract class Shape
//Add the color member variable and a getter and setter for it.
{
    private string _color;
    public Shape(string color)
    {
        _color = color;
    }
    public string GetColor()
    {
        return _color;
    }
    //Create a constructor that accepts the color and set its.
    public void SetColor (string color)
    {
        _color = color;
    }
    //Create a virtual method for GetArea().
    public abstract double GetArea();
}