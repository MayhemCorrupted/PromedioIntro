using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio1facil
{
    internal class NotaTLS
    {    
        int nota1;
        int nota2;
        int nota3;
        public NotaTLS(int nota1, int nota2, int nota3)
        {
            this.nota1 = nota1;
            this.nota2 = nota2;
            this.nota3 = nota3;
        }             
   
        private int TLSscore()
        {
            int promedio = (nota1 + nota2 + (nota3 * 2)) / 4;
            return promedio;           
        }       
        public string GetData()
        {
            return $"{TLSscore()}";
        }
    }
}
