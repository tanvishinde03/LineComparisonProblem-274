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
            CalculateLength length_One = new CalculateLength(4, 8, 3, 5);
            double length = length_One.Calculate();
            CalculateLength length_Two = new CalculateLength(5, 8, 4, 6);
            double length_ = length_Two.CalculateTwo();

            if (length.Equals(length_))
                Console.WriteLine("Both line are equal");
            else
                Console.WriteLine("Both lines are not equal");

            Console.ReadLine();
        }
    }
}