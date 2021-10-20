using System;


namespace PalindromeProblem
{
    public class Palindrome
    {
        public static bool IsPalindrome(string val){

            
            string reverse = Utils.RevNum(val);

            if (reverse == val)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static long BePalindrome(long val){
            //Works Perfectly for none lycryl numbers

            long param = val;
            string tempS = "";
            long tempL = 0 ;
            long i = 0;
            long paramL = 0;
            string paramStr = param.ToString();

            if (IsPalindrome(paramStr))
            {
                return i;
            }
            else 
            {
                while (IsPalindrome(paramStr) == false)
                {
                    i++;
                    tempS = Utils.RevNum(paramStr);
                    tempL = long.Parse(tempS);
                    paramL = long.Parse(paramStr);
                    tempL = tempL + paramL;
                    paramStr = tempL.ToString();

                }

                return i;
            }
        }

    }
}
