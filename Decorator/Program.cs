using Decorator;

Pizza pizza = new MasallaDecorator(new CheesDecorator(new PlainPizza()));
Console.WriteLine("Cost: " + pizza.getCost());
pizza.printDescription();
