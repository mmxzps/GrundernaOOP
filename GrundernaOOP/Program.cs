namespace GrundernaOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5.Here we create an object "circle1" with the value "circle constructor" and
            //parameters 5 & 6.
            Circle circle1 = new Circle(5);
            Circle circle2 = new Circle(6);

            //6.Here we are calling the "getArea" method to printout the results.
            Console.WriteLine($"Arean för circel1 är {circle1.getArea():0.##}\n"+
                              $"Arean för circel2 är {circle2.getArea():0.##}");

            Console.ReadKey();
        }
    }
}