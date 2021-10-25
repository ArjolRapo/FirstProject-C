using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Teorema_e_pitagores
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Vendosi numrin e pare: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vendosi numrin e dyte: ");
            b = Convert.ToInt32(Console.ReadLine());
            double c = (a * a) + (b * b);
            c = Math.Sqrt(c);
            Console.WriteLine("Vlera e hipotenuzes me katetet {0} , {1} eshte: {2}", a, b, c);
            Console.ReadLine();
        }
    }
}
