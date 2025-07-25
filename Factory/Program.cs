using Factory;

string? shapename;

// Console.Write("Enter Shape Name ");
// shapename = Console.ReadLine();

// Ishape shape = Shape.CreateShape(shapename);

// shape.Draw();

while (true)
{
    Console.WriteLine("Enter Person Name");
    string personName = Console.ReadLine();
    Person person = new Person_Factory().createPerson(personName);

    Console.WriteLine($"{person.name} - {person.id} created");
}

