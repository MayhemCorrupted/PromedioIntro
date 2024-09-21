using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio1facil
{
    internal class AreaTriangulo
    {
        int b;
        int h;
        public AreaTriangulo(int b, int h)
        {
            this.b = b;
            this.h = h;
        }

        private int Triangle()
        {
            int area = (b * h) / 2;
            return area;
        }
        public string GetData()
        {
            return $"{Triangle()}";
        }
    }
}
