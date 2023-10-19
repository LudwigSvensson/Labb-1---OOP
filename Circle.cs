using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_1___OOP
{
    public class Circle
    {
        public float _pi = 3.141f;
        public int _radius;
        public Circle(int radius)
        {
            _radius = radius;            
        }       
        public void getArea()
        {
             
            float area = _radius * _radius * _pi;
            Console.WriteLine($"Om radien på cirkeln är {_radius} så blir arean: " + area);
        }
        public void getOmkrets ()
        {
            float O = (2 * _pi * _radius);                        
            Console.WriteLine($"Om radien på cirkeln är {_radius}, så är omkretsen: {O}");
        }
    }
}
