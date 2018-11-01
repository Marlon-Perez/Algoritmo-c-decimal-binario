using System;

namespace _2doparcial2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Console.Write("Ingrese número a convertir en decimal: ");
            int nro = Convert.ToInt32(Console.ReadLine());
            string[] nros = new string [32];

            string binario = "";
            if (nro > 0)
            {
                while (nro > 0)
                {
                    if (nro%2 == 0)
                    {
                        binario= "0";
                        nros[i]= binario;
                        i = i + 1;
                    }
                    else
                    {
                        binario= "1";
                        nros[i]= binario;
                        i = i + 1;
                    }
                    nro = (int) (nro/2);
                }
                // Console.WriteLine($"{binario}");
            }
            for (int e = i; e != 0; e--)
            {
                Console.Write($"{nros[e]}");
            }
            Console.Write($"{nros[0]}");
           
        }
    }
}
