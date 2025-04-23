using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana05_FunAlgr13126
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int suma;
            Console.Write("Ingrese numero: ");
            num = int.Parse(Console.ReadLine());
            suma = 0;
            for (int x = 1; x < num; x++)
            {
                if (num % x == 0)
                {
                    suma = suma + x;
                }
            }
            if(num == suma)
            {
                Console.WriteLine("Si es perfecto");
            }
            else
            {
                Console.WriteLine("No es perfecto");
            }
            Console.ReadKey();
        }
    }
}
