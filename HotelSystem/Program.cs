using HotelBillingSystem;

class Program
{
    static void Main(string[] args)
    {
        IBill bill = new BarLoungeDecorator(new RoomCharge("double"));
        Console.WriteLine("Room charge: " + bill.getCost()); // ✅ correct
    }
}
