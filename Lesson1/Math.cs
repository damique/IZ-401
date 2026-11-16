using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    internal class Math
    {
        public double Sum(int[] numbers)
        {
            double sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
        }
    }
}
