using System;
using System.Collections.Generic;
using System.Linq;

namespace guess_num
{
    class Guess
    {
        public class GuessFuc
        {
            public bool GuessNum(string num, string trueNum)
            {
                int a = 0;
                int b = 0;
                string ans = trueNum;

                for (int i = 0; i < trueNum.Length; i++){
                    if (ans.Contains(num[i]))
                    {
                        b++;
                        for(int j = 0; j < ans.Length; j++)
                        {
                            if(num[i] == ans[j])
                            {
                                ans = ans.Remove(j, 1);
                                break;
                            }
                        }
                    }
                    if (num[i] == trueNum[i])
                    {
                        a++;
                    }
                }
                //Console.WriteLine(a +""+ b);
                b -= a;
                Console.WriteLine(a + "A" + b + "B");
                if (a == 4)
                {
                    return false;
                }
                else
                {
                    return true;
                }
                
            }
        }



        static void Main(string[] args)
        {
            GuessFuc guessFuc = new GuessFuc();
            string x;
            int trueNum = new Random().Next(9999);
            string y;
            if(trueNum > 1000)
            {
                y = trueNum.ToString();
            }else if (trueNum > 100)
            {
                y = "0" + trueNum.ToString();
            }
            else if (trueNum > 10)
            {
                y = "00" + trueNum.ToString();
            }
            else
            {
                y = "000" + trueNum.ToString();
            }
            Console.WriteLine("true number: " + y);
            do
            {
                x = Console.ReadLine();

                try
                {
                    if (int.Parse(x) > 10000 || int.Parse(x) < 0)
                    {
                        Console.WriteLine("wrong");
                        continue;
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("wrong");
                    continue;
                }
            } while (
                guessFuc.GuessNum(x, y)
            );
        }
    }
}
