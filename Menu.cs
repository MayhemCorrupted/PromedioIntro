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
                        Variable();
                        break;
                    case 2:
                        Condiciones();
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
        #region Bloques
        private void Variable()
        {
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
                    Console.WriteLine("Retrocediendo. . .");                 
                    break;
                case 1:
                    Ejercicio1();
                    break;
                case 2:
                    Ejercicio2();
                    break;
                case 3:
                    Ejercicio3();
                    break;
                case 4:
                    Ejercicio4();
                    break;
                case 5:
                    Ejercicio5();
                    break;
                default:
                    Console.WriteLine("xd");
                    break;
            }

        }
        private void Condiciones()
        {
            int option;
            Console.WriteLine("Elija que ejercicios");
            Console.WriteLine("1. Divisible entre 6 y/o 9");
            Console.WriteLine("2. Año bisiesto");
            Console.WriteLine("3. Dias de mes");
            Console.WriteLine("4. Lados de triangulo");
            Console.WriteLine("5. Par o impar");
            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Ejercicio6();
                    break;
                case 2:

                    break;
                case 3:

                    break;
                case 4:

                    break;
                case 5:

                    break;
                default: Console.WriteLine("Xd");
                    break;
            }
        }
        #endregion
        #region Ejercicios
        private void Ejercicio1()
        {
            float option;
            Console.WriteLine("Escribe el radio para calcular el perimetro");
            option = float.Parse(Console.ReadLine());

            Circulo circulo = new Circulo(option);
            Console.WriteLine($"el perimetro es {circulo.GetData()}");

        }
        private void Ejercicio2() 
        {
            int b;
            int h;
            Console.WriteLine("Area del triángulo");
            Console.WriteLine("Ponga la base del triángulo");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ahora la altura del triángulo");
            h = int.Parse(Console.ReadLine());

            AreaTriangulo area = new AreaTriangulo(b, h);
            Console.WriteLine($"El área del triángulo es {area.GetData()}");
        }
        private void Ejercicio3()
        {
            int days;
            Console.WriteLine("Diga el número de días");
            days = int.Parse(Console.ReadLine());

            Dias dias = new Dias(days);
            Console.WriteLine(dias.GetData());
        }
        private void Ejercicio4()
        {
            int angle1;
            int angle2;
            Console.WriteLine("Escribe un ángulo");
            angle1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ahora el otro ángulo");
            angle2 = int.Parse(Console.ReadLine());

            DeterminarTriangulo angulo = new DeterminarTriangulo(angle1, angle2);

            if (angle1 + angle2 < 180) Console.WriteLine($" el tercer ángulo es {angulo.GetData()}");
            else Console.WriteLine("No es un triángulo");

        }
        private void Ejercicio5()
        {
            int nota1;
            int nota2;
            int nota3;

            Console.WriteLine("Escribe tu primera nota");
            nota1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ahora tu segunda nota");
            nota2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Y por ultimo tu tercera nota");
            nota3 = int.Parse(Console.ReadLine());

            int prom = (nota1 + nota2 + (nota3 * 2)) / 4;
            NotaTLS promedio = new NotaTLS(nota1, nota2, nota3);

            if (prom <= 20) Console.WriteLine($"Tu promedio es {promedio.GetData()}");
            else Console.WriteLine("TU promedio es 20");
        }
        private void Ejercicio6()
        {
            int valor;
            Console.WriteLine("Ponga un valor para saber si es divisible entre 6 y/o 9");
            valor = int.Parse(Console.ReadLine());

            if (valor % 6 == 0 && valor % 9 == 0) Console.WriteLine($"{valor} es divisible entre 6 y 9");
            else if (valor % 6 == 0 && valor % 9 != 0) Console.WriteLine($"{valor} es divisible entre 6 pero no con 9");
            else if (valor % 6 != 0 && valor % 9 == 0) Console.WriteLine($"{valor} es divisible no es divisible entre 6 pero si con 9");
            else Console.WriteLine("No es divisible entre 6 y 9");

        }
        #endregion
    }
}
