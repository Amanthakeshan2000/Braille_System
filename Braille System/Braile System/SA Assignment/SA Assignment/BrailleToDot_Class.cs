using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA_Assignment
{
    internal class BrailleToDot_Class
    {
        static string passValue1;
        public static string pass2
        {
            set
            {
                passValue1 = value;

             int number = Convert.ToInt32(passValue1);

                int[] brailleDots = { 0, 0, 0, 0, 0, 0 }; // Initialize array to count dots in Braille

                while (number > 0)
                {
                    int digit = number % 10; // Get the rightmost digit of the number
                    if (digit == 1)
                    {
                        brailleDots[1]++; // Increment the top-left dot
                    }
                    else if (digit == 2)
                    {
                        brailleDots[0]++; // Increment the top-left dot
                        brailleDots[1]++; // Increment the middle-left dot
                    }
                    else if (digit == 3)
                    {
                        brailleDots[0]++; // Increment the top-left dot
                        brailleDots[1]++; // Increment the middle-left dot
                    }
                    else if (digit == 4)
                    {
                        brailleDots[0]++; // Increment the top-left dot
                        brailleDots[1]++; // Increment the middle-left dot
                        brailleDots[2]++; // Increment the bottom-left dot
                    }
                    else if (digit == 5)
                    {

                        brailleDots[0]++; // Increment the top-left dot
                        brailleDots[2]++; // Increment the bottom-left dot
                    }
                    else if (digit == 6)
                    {
                        brailleDots[0]++; // Increment the top-left dot
                        brailleDots[1]++; // Increment the middle-left dot
                        brailleDots[2]++; // Increment the bottom-left dot
                    }
                    else if (digit == 7)
                    {
                        brailleDots[0]++;
                        brailleDots[0]++; // Increment the top-left dot
                        brailleDots[1]++; // Increment the middle-left dot
                        brailleDots[2]++; // Increment the bottom-left dot
                    }
                    else if (digit == 8)
                    {
                        brailleDots[1]++; // Increment the middle-left dot
                        brailleDots[2]++; // Increment the bottom-left dot
                        brailleDots[3]++; // Increment the top-right dot
                    }
                    else if (digit == 9)
                    {
                        brailleDots[0]++; // Increment the top-left dot
                        brailleDots[3]++; // Increment the top-right dot
                    }
                    else if (digit == 0)
                    {
                        brailleDots[0]++; // Increment the top-left dot
                        brailleDots[1]++; // Increment the top-left dot
                        brailleDots[2]++; // Increment the bottom-left dot

                    }
                    number /= 10; // Remove the rightmost digit from the number
                }

                int totalDots = 0;
                foreach (int dotCount in brailleDots)
                {
                    totalDots += dotCount;
                }

                passValue1= Convert.ToString($"{totalDots}");
            }

            get
            {
                return passValue1;
            }
        }
    }
}
