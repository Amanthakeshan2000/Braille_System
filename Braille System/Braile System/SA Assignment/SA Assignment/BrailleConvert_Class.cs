using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA_Assignment
{
    internal class BrailleConvert_Class
    {
        static string passValue;
        public static string pass1
        {
            set 
            { 
                passValue = value;

                // Braille conversion
                string[] braille = {"⠚", "⠁", "⠃", "⠉", "⠙",  // 0-4
             "⠑", "⠋", "⠛", "⠓", "⠊" };

                string brailleNum = "";
                foreach (char digit in passValue.ToString())
                {
                    int index = int.Parse(digit.ToString());
                    brailleNum += braille[index];
                }

                // Output braille number
                passValue = Convert.ToString(brailleNum);
            }

            get 
            { 
                return passValue;
            }
        } 
        

    }
}
