namespace GrundernaOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5.Here we create an object "circle1" with the value "circle constructor" and
            //parameters 5 & 6.
            Circle circle1 = new Circle(5, 6);

            //6.Here we are calling the "getArea" method to printout the results.
            circle1.getArea();
        }
        //1.Start with creating the class circle and 
        //adding two variabels with the name radie1 & radie2.
        class Circle
        {
            double radie1;
            double radie2;

        //2.Then we are creating the constructor inside the class and
        //adding the "radiePar1 & radiePar2" parameters.
            public Circle(double radiePar1, double radiePar2)
            {
               //3.here we assagin the parameters (radiePa1 & 2) to the variabels (radie1 & 2)
                this.radie1 = radiePar1;
                this.radie2 = radiePar2;

            }
        //4.We create the method "getArea" inside the class, to do the math.
            public void getArea()
            {
                double pi = Math.PI;
                //Here we calculate the are of radie1 and put it in the area1
                double area1 = radie1 * radie1 * pi;
                //Here we calculate the are of radie2 and put it in the area2
                double area2 = radie2 * radie2 * pi;
                //With this the result will be printed out when the method is called.
                Console.WriteLine($"Arean för radie1 är : {area1:0.##}");
                Console.WriteLine($"Arean för radie2 är : {area2:0.##}");
            }
        }
    }
}