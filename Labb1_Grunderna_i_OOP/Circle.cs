using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_Grunderna_i_OOP
{
    internal class Circle
    {
        float _pi = 3.141f;
        int _radius;
        public Circle(float pi, int radius)
        {
            _pi = pi;
            _radius = radius;
        }

        public void getArea()
        {
            float areaCircle = _radius * _radius *_pi;
            Console.WriteLine("Arean på cirkeln är : {0:F2}", areaCircle);
        }
    }
}
