using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramBasicsPart4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] x = new int[5];
            Random y = new Random();
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = y.Next(1,100);
            }
            Console.Write("[ "+x[0] +" ,");
            Console.Write(x[1]+ " ,");
            Console.Write(x[2] + " ,");
            Console.Write(x[3] + " ,");
            Console.Write(x[4]+" ]");
            int z = 0;
            for (int i = 0;i < x.Length;i++)
            {
                z = z + x[i];
            }
            double w = z / 5;
            Console.WriteLine("\nSum  " +z);
            Console.WriteLine("Average  " +w);
            Console.ReadKey();  


        }
    }
}
