internal class Program
{
    static void Main(string[] args)
    {
        Vehichle car = new Car();
        car.Move();
    }
}


class Vehichle
{
    virtual public void Move()
    {
        Console.WriteLine("Vehichle :: Move");
    }
}

class Car : Vehichle
{
    override public void Move()
    {
        Console.WriteLine("Car :: Move");
    }
}