using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKata
{
    public class RomanNumeralsHelper
    {

        //Create a RomanNumerals class that can convert a roman numeral to and from an integer value.
        //It should follow the API demonstrated in the examples below.
        //Multiple roman numeral values will be tested for each helper method.
        // https://www.codewars.com/kata/51b66044bce5799a7f000003/train/csharp

        public static string ToRoman(int n)
        {
            return ToRoman(n, "");
        }

        public static string ToRoman(int n, string str = "")
        {

            if(n >= 1000)
            {
                n -= 1000;
                str += 'M';
            } else if(n >= 500)
            {
                n-= 500;
                str += 'D';
            }
            else if (n >= 100)
            {
                n-= 100;
                str += 'C';
            }
            else if(n >= 50)
            {
                n -= 50;
                str += 'L';
            }
            else if(n >= 10)
            {
                n -= 10;
                str += 'X';
            }
            else if(n >= 5)
            {
                n -= 5;
                str += 'V';
            }
            else if(n == 4)
            {
                n -= 4;
                str.Insert(str.Length - 1, "I");
            }
            else if(n >= 1)
            {
                n--;
                str += 'I';
            }


            if (n != 0)
            {
                return ToRoman(n, str);
            }
            else
            {
                return str;
            }
        }

        public static int FromRoman(string romanNumeral)
        {
            return 0;
        }

    }
}
