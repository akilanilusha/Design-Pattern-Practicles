
using singelton;

Singelton s1 = Singelton.Instance;
Singelton s2 = Singelton.Instance;

if (s1 == s2)
{
    Console.WriteLine("Singelton work");
}
else
{
    Console.WriteLine("Singelton not work");

}
