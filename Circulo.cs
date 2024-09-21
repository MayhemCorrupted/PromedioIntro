using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio1facil
{
    internal class Circulo
    {
        float radio;
        public Circulo(float radio)
        {
            this.radio = radio;
        }
        private float Circle()
        {
            float pi = 3.14f;
            float peri = (2 * pi) * radio;
            return peri;
        }
        public string GetData()
        {
            return $"{Circle()}";
        }
    }
}
