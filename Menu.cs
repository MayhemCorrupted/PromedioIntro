using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

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
                Console.WriteLine("3. Switch (xd)");
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
                        Console.WriteLine("Xd");
                        break;
                    case 4:
                        Bloque4();
                        break;
                    case 5:
                        Bloque5();
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
                    Ejercicio7();
                    break;
                case 3:
                    Ejercicio8();
                    break;
                case 4:
                    Ejercicios9();
                    break;
                case 5:
                    Ejercicio10();
                    break;
                default: Console.WriteLine("Xd");
                    break;
            }
        }
        private void Bloque4()
        {
            int option;
            Console.WriteLine("Elija el ejercicio");
            Console.WriteLine("1. Tabla de multiplicar");
            Console.WriteLine("2. Suma de número impares");
            Console.WriteLine("3. Cantidad de digitos");
            Console.WriteLine("4. Cantidad de digitos pares");
            option = int.Parse(Console.ReadLine());

            switch(option)
            {
                case 1:
                    Ejercicio15();
                    break;
                case 2:
                    Ejercicio16();
                    break;
                case 3:
                    Ejercicio17();
                    break;
                case 4:
                    Ejercicio18();
                    break;
                default:
                    Console.WriteLine("xd");
                    break;
            }
        }
        private void Bloque5()
        {
            int option;
            Console.WriteLine("Elija un ejercicio");
            Console.WriteLine("1. Resta de los números del -1 al -n");
            Console.WriteLine("2. Factorial");
            Console.WriteLine("3. Serie Fibonacci (fetucinni)");
            option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Ejercicio19();
                    break;
                case 2:
                    Ejercicio20();
                    break;
                case 3:
                    Ejercicio21();
                    break;
                default:
                    Console.WriteLine("xd");
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
        private void Ejercicio7()
        {
            int valor;
            Console.WriteLine("escribe el año para saber si es bisiesto");
            valor = int.Parse(Console.ReadLine());

            if (valor % 4 == 0)
            {
                if (valor % 100 == 0)
                {
                    if (valor % 400 == 0) Console.WriteLine("Es bisiesto");

                    else Console.WriteLine("No es bisiesto");                    
                }
                else Console.WriteLine("No es bisiesto");                
            }
            else Console.WriteLine("No es bisiesto");
        }
        private void Ejercicio8()
        {
            int mes;
            Console.WriteLine("Ponga el mes");
            mes = int.Parse(Console.ReadLine());

            if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12) Console.WriteLine("Tiene 31 dias");
            else if (mes == 4 || mes == 6 || mes == 9 || mes == 11) Console.WriteLine($"Tiene 30 dias");
            else if (mes == 2) Console.WriteLine("Tiene 28 o 29 dias (depende si es bisiesto)");
        }
        private void Ejercicios9()
        {
            int lado1;
            int lado2;
            int lado3;
            Console.WriteLine("Escriba el primer lado");
            lado1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el segundo lado");
            lado2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el tercer lado");
            lado3 = int.Parse(Console.ReadLine());
            if (lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1) Console.WriteLine("Es un triangulo");
            else Console.WriteLine("No es triangulo");
        }
        private void Ejercicio10()
        {
            int number;
            Console.WriteLine("Escribe un número para saber si es impar");
            number = int.Parse(Console.ReadLine());

            if (number % 2 == 0) Console.WriteLine("Es par");
            else Console.WriteLine("No es par");

        }
       
        private void Ejercicio15()
        {
            int valor;
            int multiplo = 0;
            Console.WriteLine("Escriba el número que quiere saber la multiplicación");
            valor = int.Parse(Console.ReadLine());

            while (multiplo < 12)
            {
                int temp = valor * multiplo;
                multiplo++;
                Console.WriteLine($"{valor} * {multiplo} = {temp}");
            }
        }
        private void Ejercicio16()
        {
            int valor;
            int impar = 0;
            Console.WriteLine("Escribe el número para sumarlo consecutivamente");
            valor = int.Parse(Console.ReadLine());

            while (impar < valor)
            {
                int temp = 0;
                temp++;

                if (temp % 2 != 0)                   
                {
                    impar += temp;
                }
                
            }
            Console.WriteLine($"{impar}");
        }
        private void Ejercicio17()
        {
            int valor;
            int contar = 0;

            Console.WriteLine("Escribe un valor para contarlo");
            valor = int.Parse(Console.ReadLine());

            while (0 < valor)
            {                
                valor /= 10;
                contar++;
                
            }
            Console.WriteLine($"el valor tiene {contar} digito/s");
        }
        private void Ejercicio18()
        {
            int valor;
            int contar = 0;

            Console.WriteLine("Escribe un valor para contarlo si son pares");
            valor = int.Parse (Console.ReadLine());

            while (0 < valor)
            {
                valor /= 10;
                if(valor % 2 == 0) contar++;
            }
            Console.WriteLine($"El valor tiene {contar} digito/s pares");
        }
        private void Ejercicio19()
        {
            int valor;
            int resta = 0;

            Console.WriteLine("Escribe un valor negativo");
            valor = int.Parse(Console.ReadLine());

            for (int i = -1; valor <= i; i--)
            {
                resta -= i;                
                Console.WriteLine($"{resta}");
            }
        }
        private void Ejercicio20()
        {
            int valor;
            int factorial = 1;

            Console.WriteLine("Escribe el valor para sacar factorial");
            valor = int.Parse(Console.ReadLine());

            for (int i = 1; i <= valor; i++)
            {
                factorial *= i;
            }
            Console.WriteLine($"el factorial de {valor} es {factorial}");
        }
        private void Ejercicio21()
        {
            int valor;
            int a = 0;
            int b = 1;
            Console.WriteLine("Escriba un número para la serie fibonacci");
            valor = int.Parse(Console.ReadLine());

            Console.WriteLine("Serie fibonacci: ");
            for (int i = 0; i <= valor; i++)
            {
                int temp = a + b;
                a = b;
                b = temp;
                Console.WriteLine($"{a} + {b} = {temp}");
            }
        }
        #endregion
    }
}
