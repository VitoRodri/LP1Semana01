using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            double xx=0.12345;
            int ii=18;
            Console.WriteLine("{0:f2}\u000A",xx);
            Console.WriteLine("{0:p1}\u000A",xx);
            Console.WriteLine("{0:x}\u000A",ii);
            Console.WriteLine("{0:c}\u000A",ii);
            string a="This is the \u0009 first string \u000A";
            string b=@"This is the \t second string \n";
            string c="\"This is the third string\"";
            string d=@"""This is the fifth string""";
            Console.WriteLine(a+"\u000A"+b+"\u000A"+c+"\u000A"+d);

            int x=5;
            int y=5;
            string e="what comes after d "+4;
            string f="Fantastic!!!!<"+3;
            string g=$"X is a number just like{x}";
            string h=$"Y hates X so Y subtracted X {x-y} and died";
            string j=String.Format("P{1},i{0}",9,0);
            Console.WriteLine(e+"\u000A"+f+"\u000A"+g+"\u000A"+h+"\u000A"+j);
            Console.WriteLine(@"This is the last string of exercise {0}",x);
        }
    }
}
