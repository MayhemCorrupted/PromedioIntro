using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio1facil
{
    internal class Variables
    {
        float radio;
        int b;
        int h;
        private float Circle()
        {
            float pi = 3.14f;
            float peri = (2 * pi) * radio; 
            return peri;
        }
        private int Triangle()
        {
            int area = (b * h) / 2;
            return area;
        }
        public string GetData()
        {
            return $"{Circle()} - {Triangle()}";
        }
    }
}
