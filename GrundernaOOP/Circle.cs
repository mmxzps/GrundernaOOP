using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace GrundernaOOP
{
    //1.Start with creating the class circle and 
    //adding a field with the name "radie1"
    internal class Circle
    {
       // double radie;
        public double radie { get; set; }


        //2.Then we are creating the constructor and adding the "radiePar1" parameters(argument?).
        public Circle(double radiePar1)
        {
            //3.here we assagin the parameters (radiePa1) to the variabels (radie1)
            this.radie = radiePar1;


        }
        //4.We create the method "getArea" to do the math.
        public double getArea()
        {
            double pi = Math.PI;
            //Here we calculate the are of radie1 and put it in the area1
            double area = radie * radie * pi;

            return area;

            //With this the result will be printed out when the method is called.
            // Console.WriteLine($"Arean för radien är : {area:0.##}");
        }
        //A method for calculating the circumference
        public double circleCircumf()
        {
            double pi = Math.PI;
            return 2 * pi * radie;
        }

        //A method for calculating the volume
        public double cirkelVolume()
        {
            double pi = Math.PI;
            return (4 * pi * radie * radie * radie) / 3;
        }
    }
}
