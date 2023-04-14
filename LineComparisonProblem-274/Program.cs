using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblem_274
{
    public class Program
    {
        static void Main(string[] args)
        {
            //CompareLines Length2 = new CompareLines(9, 1, 2, 3);
            //double _Length = Length2.LineComppare();

            //CompareLines Length3 = new CompareLines(4, 5, 6, 7);
            //double Length = Length3.LineComppare();


            //if (_Length.CompareTo(Length2) == 0)

            //    Console.WriteLine("Equal");

            //else if (Length.CompareTo(Length2) > 0)

            //    Console.WriteLine("Line one is greater");
            //else
            //    Console.WriteLine("Line two is greater");
            //Console.ReadKey();

            CompareMethod line = new CompareMethod();            //UC4
            line.CompareToAndEqualsTo();
            Console.ReadLine();
        }
    }

}
