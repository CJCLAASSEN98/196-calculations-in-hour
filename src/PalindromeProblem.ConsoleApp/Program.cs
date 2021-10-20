using System;
using System.IO;
using System.Diagnostics;


namespace PalindromeProblem
{
    class Program
    {   
        static void Main(string[] args)
        
        {
            
            string num = "196";
            bool pal = Palindrome.IsPalindrome(num);
            string tempv = "";
            string revN = "";
            long i = 0;
            var watch = System.Diagnostics.Stopwatch.StartNew();


            StreamWriter sw = new StreamWriter(@"Iterations.txt");
            sw.WriteLine("The numer is {0}", num);
            sw.WriteLine("-----------------------");
            sw.WriteLine("The Application started at {0:HH:mm:ss.fff}", DateTime.Now);



            while(pal == false && watch.ElapsedMilliseconds <= 3600000)
            {
                if (pal)
                {
                    System.Console.WriteLine(num);
                    break;
                }
                else
                {


                    revN = Utils.RevNum(num);
                    tempv = Utils.AddString(num, revN);
                    System.Console.WriteLine(tempv);
                    num = tempv;
                    pal = Palindrome.IsPalindrome(num);
                    i++;
                    sw.WriteLine("Iteration {0} || Value {1}", i, num);
                    sw.WriteLine("=====================================================");
                    sw.WriteLine("Iteration {0} TimeStamp {1:HH:mm:ss.fff}",i, DateTime.Now);
                    sw.WriteLine("_____________________________________________________");


                    
                }

                if (pal){sw.Close();}
            }







          




        }




        
    } 
}
