using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace GrundernaOOP
{
    //Creating "Triangel" class.
    internal class Triangel
    {
        //Adding the fields for the Triangel.
        private double _height;
        private double _bottom;
        private double _hypotenusan;

        //Creating a constuctor with parameters.
        public Triangel(double height, double bottom, double hypotenusan) 
        {   
            //initializing parameters.
            _height = height;
            _bottom = bottom;
            _hypotenusan = hypotenusan;
        }
        //A method for calculatiing the volume.
        public double getVolume()
        {

            return (((_bottom * _height)/2) * _height)/3;
        }

        //A method for calculatiing the area.
        public double getArea()
        {
            return (_bottom * _height)/2;
        }
        //A method for calculatiing the circumference.
        public double getOmkrets()
        {
            return _bottom + _height + _hypotenusan;
        }
    }
}
