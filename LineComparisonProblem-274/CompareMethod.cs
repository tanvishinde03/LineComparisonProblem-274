﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblem_274
{
    public class CompareMethod
    {
      public void CompareToAndEqualsTo()
        {
           CompareLines line = new CompareLines(1, 2, 3, 5);
            double length1 = line.LineComppare();
            Console.WriteLine("Length of 1st Line : " + length1);

            CompareLines line2 = new CompareLines(1, 2, 3, 4);
            double length2 = line2.LineComppare();
            Console.WriteLine("Length of 2nd Line : " + length2);

            if (length1.CompareTo(length2) == 0)
            {
                Console.WriteLine("Both Line Are Equal");
            }
            else if (length1.CompareTo(length2) > 0)
            {
                Console.WriteLine("1st Line is greter");
            }
            else
            {
                Console.WriteLine("2nd Line is greter");
            }
        }
    }
    }


