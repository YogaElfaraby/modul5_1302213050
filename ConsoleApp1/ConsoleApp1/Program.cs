using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Penjumlahan.JumlahTigaAngka<long>(12, 34, 56);
        }


        public class Penjumlahan
        {
            public static void JumlahTigaAngka<T>(T a, T b, T c)
            {
                Console.WriteLine((dynamic)a + (dynamic)b + (dynamic)c);

            }
        }
    }
}