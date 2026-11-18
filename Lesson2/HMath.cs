using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    internal class HMath:Lesson1.MMath
    {
        void test()
        {
            IsEven(2);

            Average(new int[] {1, 2, 3, 4, 5, 6});

            IsPalindrome("Madam");
            
        }
    }
}
