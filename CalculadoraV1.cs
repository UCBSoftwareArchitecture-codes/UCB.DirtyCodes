using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int v1 = 0;
            int v2 = 0;
            string r;
            int r2 = 0;
            do { 
                Console.WriteLine("+. sumar");
                Console.WriteLine("-. restar");
                Console.WriteLine("*. multiplicar");
                Console.WriteLine("/. dividir");
                Console.Write("elija una funcion");
                r = Console.ReadLine();
                string opcion = Convert.ToString(r);
                Console.WriteLine("ingrese los numeros");
                Console.Write("v1 :");
                v1 = int.Parse(Console.ReadLine());
                Console.WriteLine("v2: ");
                v2 = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case "+":
                        Console.WriteLine("el resultado de la suma es");
                        r2 = v1 + v2;
                        Console.WriteLine("{0}+{1}={2}", v1, v2, r2);
                        break;

                    case "-":
                        Console.WriteLine("el resultado de la resta es");
                        r2 = v1 - v2;
                        Console.WriteLine("{0}-{1}={2}", v1, v2, r2);
                        break;
                    case "*":
                        Console.WriteLine("el resultado de la multiplicacion es");
                        r2 = v1 * v2;
                        Console.WriteLine("{0}*{1}={2}", v1, v2, r2);
                        break;
                    case "/":
                        Console.WriteLine("el resultado de la multiplicacion es");
                        r2 = v1 / v2;
                        Console.WriteLine("{0}/{1}={2}", v1, v2, r2);
                        break;

                }
                    Console.Write("n¿Desea Continuar? s/n: ");
                     r = Console.ReadLine();
            } while (r == "s");

        }
    }
}