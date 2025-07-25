using System;

namespace Decorator;

interface Pizza
{
    void printDescription();

    float getCost();
}

class PlainPizza : Pizza
{
    public void printDescription()
    {
        Console.WriteLine("this is a plain Pizza");
    }

    public float getCost()
    {
        return 2000;
    }
}


abstract class ToppingDecorator : Pizza
{

    private Pizza tempPizza;

    public ToppingDecorator(Pizza newPizza)
    {
        this.tempPizza = newPizza;
    }

    public virtual void printDescription()
    {
        tempPizza.printDescription();
    }

    public virtual float getCost()
    {
        return tempPizza.getCost();
    }
}

class CheesDecorator : ToppingDecorator
{
    public CheesDecorator(Pizza newPizza) : base(newPizza)
    {
    }

    public override float getCost()
    {
        return base.getCost() + 200;
    }

    public override void printDescription()
    {
        base.printDescription();
        Console.WriteLine("Chees adding");

    }
}

class MasallaDecorator : ToppingDecorator
{
    public MasallaDecorator(Pizza newPizza) : base(newPizza) { }

    public override float getCost()
    {
        return base.getCost() + 500;
    }

    public override void printDescription()
    {
        base.printDescription();
        Console.WriteLine("Masalla adding");

    }
}