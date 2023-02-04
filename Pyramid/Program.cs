using System;
using System.ComponentModel;
using System.Xml.Schema;
using System.Linq;
using System.Runtime.InteropServices;

namespace pyramid;

internal class Program
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int max = n * 2 - 1;
        int mid = (max + 1) / 2;
        for (int i = 1; i <= n; i++)
        {
            int a = i * 2 - 1;
            for (int k = 0; k < mid - i; k++)
            {
                Console.Write(" ");
            }
            for (int j = 0; j < a; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}

