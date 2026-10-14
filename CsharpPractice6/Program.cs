namespace CsharpPractice6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(MyMath.Sum(1, 100));
            Console.WriteLine(MyMath.Mult(10, 5));
            Console.WriteLine(MyMath.Abs(-102));
            Console.WriteLine(MyMath.Abs(-52.123812));

            Product product = new Product("김치", 5000);
            Console.WriteLine(product.name + product.price);
        }
    }
}
