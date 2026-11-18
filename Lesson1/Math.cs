using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    public class Math
    {
        public double Sum(int[] numbers)
        {
            double sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        public double Max(int[] numbers)
        {
            double max = 0;
            foreach(int number in numbers)
            {
                if(number > max)
                    max = number;
            }
            return max;
        }

        public double Min(int[] numbers)
        {
            double min = numbers[0];
            foreach (int number in numbers)
            { 
                if (number < min)
                    min = number;
            }
            return min;
        }

        public double factorial(int number)
        {
            double result = 1;
            for (int i = number; i >= 1; i--)
                result *= i;
            return result;
        }

        // Homework
        public bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        public double Average(int[] numbers)
        {
            double sum = 0;
            for (int i = 0; i < numbers.Length; i++)
                sum += numbers[i];
            return sum / numbers.Length;
        }

        public bool IsPalindrome(string word)
        {
            if (string.IsNullOrEmpty(word))
                return false;
            string cleaned = word.ToLower().Replace(" ", "");
            int left = 0;
            int right = cleaned.Length - 1;

            while (left < right)
            {
                if (cleaned[left] != cleaned[right])
                    return false;
                left++;
                right--;
            }
            return true;
        }




    }
}
