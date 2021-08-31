using System;

namespace SmellCode
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] a;
            int r, z;
            a = new int[3, 3];
            int x = 0;
            int h = 0;
            a[0, 0] = -1;
            a[0, 1] = -1;
            a[0, 2] = -1;
            a[1, 0] = -1;
            a[1, 1] = -1;
            a[1, 2] = -1;
            a[2, 0] = -1;
            a[2, 1] = -1;
            a[2, 2] = -1;
            Console.WriteLine();   
            Console.WriteLine("      0    1    2  ");
            Console.WriteLine("  -------------------");
            for (int fila = 0; fila < 3; fila++)
            {
                Console.Write("{0} |",fila);
                for (int columna = 0; columna < 3; columna++)
                    Console.Write("     |");
                Console.WriteLine();
                Console.WriteLine("  -------------------");
            }

           while(x==0 && h<9)
            {
                Console.Write("Ingrese posicion: X  ");
                r = int.Parse(Console.ReadLine());
                Console.Write("Ingrese posicion: Y  ");
                z = int.Parse(Console.ReadLine());
                if(r>2 ||r<0|| z>2||z<0)
                {
                    Console.WriteLine("Posicion invalida");
                }
                else
                {
                    if (a[r, z] != -1)
                    {
                        Console.WriteLine("Posicion Ocupada");
                    }
                    else
                    {
                        Console.WriteLine("Ingrese el valor segun el jugador X=0 y O=1");
                        string linea;
                        linea = Console.ReadLine();
                        a[r, z] = int.Parse(linea);
                        Console.WriteLine();
                        h++;
                    }
                    if (a[0, 0] == 0 && a[0, 1] == 0 && a[0, 2] == 0)
                    {
                        Console.Write("Gano el jugador X");
                        x = 1;
                    }
                    if (a[1, 0] == 0 && a[1, 1] == 0 && a[1, 2] == 0 && x == 0)
                    {
                        Console.Write("Gano el jugador X");
                        x = 1;
                    }
                    if (a[2, 0] == 0 && a[2, 1] == 0 && a[2, 2] == 0 && x == 0)
                    {
                        Console.Write("Gano el jugador X");
                        x = 1;
                    }
                    if (a[1, 0] == 0 && a[1, 0] == 0 && a[2, 0] == 0 && x == 0)
                    {
                        Console.Write("Gano el jugador X");
                        x = 1;
                    }
                    if (a[0, 1] == 0 && a[1, 1] == 0 && a[2, 1] == 0 && x == 0)
                    {
                        Console.Write("Gano el jugador X");
                        x = 1;
                    }
                    if (a[0, 2] == 0 && a[1, 2] == 0 && a[2, 2] == 0 && x == 0)
                    {
                        Console.Write("Gano el jugador X");
                        x = 1;
                    }
                    if (a[0, 0] == 0 && a[1, 1] == 0 && a[2, 2] == 0 && x == 0)
                    {
                        Console.Write("Gano el jugador X");
                        x = 1;
                    }
                    if (a[2, 0] == 0 && a[1, 1] == 0 && a[0, 2] == 0 && x == 0)
                    {
                        Console.Write("Gano el jugador X");
                        x = 1;
                    }
                    if (a[0, 0] == 1 && a[0, 1] == 1 && a[0, 2] == 1 && x == 0)
                    {
                        Console.Write("Gano el jugador X");
                        x = 1;
                    }
                    if (a[1, 0] == 1 && a[1, 1] == 1 && a[1, 2] == 1 && x == 0)
                    {
                        Console.Write("Gano el jugador O");
                        x = 1;
                    }
                    if (a[2, 0] == 1 && a[2, 1] == 1 && a[2, 2] == 1 && x == 0)
                    {
                        Console.Write("Gano el jugador O");
                        x = 1;
                    }
                    if (a[1, 0] == 1 && a[1, 0] == 1 && a[2, 0] == 1 && x == 0)
                    {
                        Console.Write("Gano el jugador O");
                        x = 1;
                    }
                    if (a[0, 1] == 1 && a[1, 1] == 1 && a[2, 1] == 1 && x == 0)
                    {
                        Console.Write("Gano el jugador O");
                        x = 1;
                    }
                    if (a[0, 2] == 1 && a[1, 2] == 1 && a[2, 2] == 1 && x == 0)
                    {
                        Console.Write("Gano el jugador O");
                        x = 1;
                    }
                    if (a[0, 0] == 1 && a[1, 1] == 1 && a[2, 2] == 1 && x == 0)
                    {
                        Console.Write("Gano el jugador O");
                        x = 1;
                    }
                    if (a[2, 0] == 1 && a[1, 1] == 1 && a[0, 2] == 1 && x == 0)
                    {
                        Console.Write("Gano el jugador O");
                        x = 1;
                    }
                    Console.WriteLine();
                    Console.WriteLine("      0    1    2  ");
                    Console.WriteLine("  -------------------");
                    for (int fila = 0; fila < 3; fila++)
                    {
                        Console.Write("{0} |",fila);
                        for (int columna = 0; columna < 3; columna++)
                            Console.Write("  {0} |", (a[fila, columna] == -1 ? " " : (a[fila, columna]).ToString()) + " ");
                        Console.WriteLine();
                        Console.WriteLine("  -------------------");

                    }
                }
                
            }


            if (x == 0)
            {
                Console.WriteLine("Empate");
            }

        }
    }
}