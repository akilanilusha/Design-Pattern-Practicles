using System;

namespace Factory;


interface Ishape
{
    void Draw();
}

class Circle : Ishape
{
    public void Draw()
    {
        Console.WriteLine("Drawing a Circle");
    }
}

class Square : Ishape
{
    public void Draw()
    {
        Console.WriteLine("Drawing a Square");
    }
}

class Rectangle : Ishape
{
    public void Draw()
    {
        Console.WriteLine("Drawing a Rectangle");
    }
}

class Shape
{
    public static Ishape CreateShape(string shapename)
    {
        if (shapename == "circle")
        {
            return new Circle();
        }
        else if (shapename == "rectangle")
        {
            return new Rectangle();
        }
        else if (shapename == "squre")
        {
            return new Square();
        }

        return null;
    }
}
