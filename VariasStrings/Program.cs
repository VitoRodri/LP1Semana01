using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string a="This is the \u0009 first string \u000A";
            string b=@"This is the \t second string \n";
            string c="\"This is the third string\"";
            string d=@"""This is the fifth string""";
            Console.WriteLine(a+"\u000A"+b+"\u000A"+c+"\u000A"+d);
        }
    }
}
