using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c2b14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    if (j == 10)
                    {
                        Console.WriteLine("{0} x{1} = {2}", i, j, i * j);
                    }
                    else
                        if (i * j >= 10)
                    {
                        Console.WriteLine("{0} x {1} = {2}", i, j, i * j);
                    }
                    else
                        Console.WriteLine("{0} x {1} =  {2}", i, j, i * j);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
