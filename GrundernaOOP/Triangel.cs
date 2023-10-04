using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace GrundernaOOP
{
    internal class Triangel
    {
        public double _height { get; set; }
        public double _bottom { get; set; }
        public double _hypotenusan { get; set; }
        public Triangel(double height, double bottom, double hypotenusan) 
        { 
            this._height = height;
            this._bottom = bottom;
            this._hypotenusan = hypotenusan;
        }
        public double getVolume()
        {

            return (((_bottom * _height)/2) * _height)/3;
        }

        public double getArea()
        {
            return (_bottom * _height)/2;
        }

        public double getOmkrets()
        {
            return _bottom + _height + _hypotenusan;
        }
    }
}
