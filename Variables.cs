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
        int days;
        int angle1;
        int angle2;
        public Variables(float radio, int b, int h,int days, int angle1, int angle2)
        {
           this.radio = radio;
           this.b = b;
           this.h = h;
           this.days = days;
           this.angle1 = angle1;
           this.angle2 = angle2;
        }
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
        private int DaysToWeeks()
        {            
            int weeks = days / 7;            
            return weeks;            
        }
        private int DaysToYears()
        {
            int years = days / 365;
            return years;
        }
        private int AngleTriangle()
        {
            int angle3 = angle1 - angle2;
            return angle3;
        }
        public string GetData()
        {
            return $"{Circle()} - {Triangle()} - {DaysToWeeks()} - {DaysToYears()} - {AngleTriangle()}";
        }
    }
}
