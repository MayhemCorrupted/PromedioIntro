using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio1facil
{
    internal class DeterminarTriangulo
    {
        int angle1;
        int angle2;
        public DeterminarTriangulo(int angle1, int angle2)
        {
            this.angle1 = angle1;
            this.angle2 = angle2;
        }

        private int AngleTriangle()
        {
            int angle3 = angle1 - angle2;
            return angle3;
        }
        public string GetData()
        {
            return $"{AngleTriangle()}";
        }
    }
}
