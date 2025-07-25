using System;

namespace Factory;

class Person
{
    public int id { get; set; }
    public string name { get; set; }

    public Person(int id, string name)
    {
        this.id = id;
        this.name = name;
    }
}


