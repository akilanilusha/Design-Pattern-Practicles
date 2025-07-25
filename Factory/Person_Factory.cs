using System;

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
class Person_Factory
{
    private int _personId = 0;

    public Person createPerson(string personName)
    {
        _personId++;
        return new Person(_personId, personName);
    }
}
