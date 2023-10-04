namespace GrundernaOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5.Here we create two object "circle1 & circle2" with
            //the parameters(argument?) 5 & 6.

            Circle circle1 = new Circle(5);
            Circle circle2 = new Circle(6);

            //circleCircumf, cirkelVolume
            //6.Here we are calling the "getArea" method to printout the results.
            Console.WriteLine($"Arean för circel1 är:     {circle1.getArea():0.##}cm\n" +
                              $"Omkretsen för circel1 är: {circle1.circleCircumf():0.##}cm\n" +
                              $"Volymen för circel1 är:   {circle1.cirkelVolume():0.##} kubikenheter");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Arean för circel2 är:     {circle2.getArea():0.##}cm\n" +
                              $"Omkretsen för circel2 är: {circle2.circleCircumf():0.##}cm\n" +
                              $"Volymen för circel2 är:   {circle2.cirkelVolume():0.##} kubikenheter");

            Console.ReadKey();
        }
    }
}