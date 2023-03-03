using System;

namespace ArgInt2Hex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write number");
            string input =Console.ReadLine();
            int number;
          
            bool Parsabel =Int32.TryParse(input, out number);
            if (Parsabel)
            {
                Console.WriteLine("Number is  int");
                Console.WriteLine("Hexadecimal: {0:x}",number);
            }
            else
            {
                Console.WriteLine("Number is not int");
            }
            
        }
    }
}
