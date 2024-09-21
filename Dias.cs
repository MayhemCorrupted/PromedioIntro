using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio1facil
{
    internal class Dias
    {
        int days;       
        public Dias(int days)
        {
            this.days = days;           
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

        public string GetData()
        {            
            return $"Semanas: {DaysToWeeks()}, años: {DaysToYears()}";
        }
    }
}
