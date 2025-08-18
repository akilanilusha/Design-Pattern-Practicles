using System;

namespace shapeDecorator;

interface Shape
{
    void draw();
}

class Rectangle : Shape
{
    public void draw()
    {
        Console.WriteLine("Draw rectangle");
    }
}

class Circle : Shape
{
    public void draw()
    {
        Console.WriteLine("Draw Circle");
    }
}

abstract class ShapeDecorator : Shape
{

    private Shape tempShape;

    public ShapeDecorator(Shape newShape)
    {
        this.tempShape = newShape;
    }

    public virtual void draw()
    {
        tempShape.draw();
    }
}

class RedShapeDecorator : ShapeDecorator
{
    public RedShapeDecorator(Shape newShape) : base(newShape)
    {

    }

    public override void draw()
    {
        base.draw();
        Console.WriteLine("Red Border add");
    }

}


class GreenShapeDecorator : ShapeDecorator
{
    public GreenShapeDecorator(Shape newShape) : base(newShape)
    {

    }

    public override void draw()
    {
        base.draw();
        Console.WriteLine("Green Border add");
    }

}