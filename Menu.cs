using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio1facil
{
    internal class Menu
    {
        public void ExecuteCode()
        {
            Panel();
        }
        private void Panel()
        {
            int option;
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("Elija que bloques quiere ver");
                Console.WriteLine("1. Variables");
                Console.WriteLine("2. If");
                Console.WriteLine("3. Switch");
                Console.WriteLine("4. While");
                Console.WriteLine("5. For");
                Console.WriteLine("0. Salir");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 0:
                        loop = false;
                        break;
                    case 1:

                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                    case 5:

                        break;
                    default:
                        Console.WriteLine("Valor incorrecto, elija una opción correcta :v");
                        break;
                }
            }
        }
        private void Variable()
        {
            Variables variables = new Variables();
            int option;
            Console.WriteLine("Elija la opción");
            Console.WriteLine("1. Perímetro de un circulo");
            Console.WriteLine("2. Área de triángulo");
            Console.WriteLine("3. Días a años y semanas");
            Console.WriteLine("4. Ángulos de triángulo");
            Console.WriteLine("5. Promedio TLS");
            Console.WriteLine("0. Retroceder");
            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 0:
                    Panel();
                    break;
                case 1:
                    
                    break;
                case 2:

                    break;
                case 3:

                    break;
                case 4:

                    break;
                case 5:

                    break;
                default:
                    Console.WriteLine("xd");
                    Variable();
                    break;
            }

        }
    }
}
