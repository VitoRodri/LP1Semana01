using System;

namespace TiposVarios
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=2;
            uint b=120U;
            long c=-32L;
            ulong d=40UL;
            char symbol='\u00B1';
            char zero='\u00D8';
            float e=3.49f;
            double f= 40.2e-30;
            Console.WriteLine("variaveis inteiras:"+a+","+b+","+c+","+d);
            Console.WriteLine("variaveis char:"+symbol+","+zero);
            Console.WriteLine("variaveis reais:"+e+","+f);

        }
    }
}
