using System;

namespace PalindromeProblem
{
    public class Utils
    {
        public static string RevNum(string str)
        {

            string  revString = "";
            for(int i=str.Length-1; i>=0; i--)
            {
                revString = revString + str[i];
            }
            return revString;
        }

        public static string AddString(string num1, string num2)
        {
            if(num1.Length > num2.Length)
            {
                string t = num1;
                num1 = num2;
                num2 = t;
            }

            string str = "";
            int n1 = num1.Length, n2 = num2.Length;
            int diff = n2 - n1;
            int carry = 0;

            for(int i = n1 -1; i >= 0; i--)
            {
                int sum = ((int)(num1[i] - '0') + (int)(num2[i + diff]-'0') + carry);
                str += (char)(sum % 10 + '0');
                carry = sum / 10;
            }

            for(int i = n2 - n1 - 1; i >= 0; i--)
            {
                int sum = ((int)(num2[i] - '0') + carry);
                str += (char)(sum % 10 + '0');
                carry = sum / 10 ;
            }

            if (carry > 0) str += (char)(carry + '0');

            char[] ch2 = str.ToCharArray();
            Array.Reverse(ch2);
            return new string(ch2);
        }
    }
}
