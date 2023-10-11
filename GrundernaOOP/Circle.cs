using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace GrundernaOOP
{
    //1.Start with creating the class circle and 
    //adding a field with the name "_radie"
    internal class Circle
    {
        // double radie;
        private double _radie;


        //2.Then we are creating the constructor and adding the "radie" parameter.
        public Circle(double radie)
        {
            //3.here we assagin the parameters (radie) to the variabels (_radie)
            this._radie = radie;


        }
        //4.We create the method "getArea" to do the math.
        public double getArea()
        {
            double pi = Math.PI;
            //Here we calculate the are of radie and put it in the area
            double area = _radie * _radie * pi;
            return area;
        }

        //A method for calculating the circumference
        public double circleCircumf()
        {
            //double pi = Math.PI;
            return 2 * Math.PI * _radie;
        }

        //A method for calculating the volume
        public double cirkelVolume()
        {
            double pi = Math.PI;
            return (4 * pi * _radie * _radie * _radie) / 3;
        }
    }
}
