using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1000ArasıAsalSayiBulma_08012021
{
    class Program
    {
        static void Main(string[] args)
        {
            //2-10.000 arasındaki tüm asal sayıları bulunuz.
            bool control = false;
            for (int i = 2; i < 10000; i++)
            {
                control = false;
                for (int j = 2; j < i; j++)
                {
                    if ((i%j==0))
                    {
                        control = true;
                        break;
                    }
                }
                if (!control)
                    Console.WriteLine(i + " ");
            }
            Console.ReadKey();
        }
    }
}
