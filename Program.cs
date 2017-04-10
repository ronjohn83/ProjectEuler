using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DigitFifthPowers());
            Console.Read();
        }


        private static int DigitFifthPowers()
        {
          
            int result = 0;

            for (int i = 2; i < 355000; i++)
            {
                double powerSum = 0;
                int number = i;
                while (number > 0)
                {
                    int digit = number % 10;
                    powerSum += Math.Pow(digit, 5);


                    number /= 10;
                }

                if (powerSum == i)
                    result += i;
            }

            return result;
       
        }

        private static void DigitFifthPowersTest()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            int sum = 0;
            double digitSum = 0;
            string digits = string.Empty;
            int listTotal;
            List<int> list = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    for (int k = 0; k < 10; k++)
                    {
                        for (int l = 0; l < 10; l++)
                        {
                            for (int m = 0; m < 10; m++)
                            {
                                digitSum = Math.Pow(i, 5) +
                                           Math.Pow(j, 5) +
                                           Math.Pow(k, 5) +
                                           Math.Pow(l, 5) +
                                           Math.Pow(m, 5);


                                digits = i.ToString() + j.ToString() + k.ToString() + 
                                        l.ToString() + m.ToString();

                                if (digitSum.ToString() == digits)
                                {
                                    int n = Convert.ToInt32(digits);
                                    sum += n;
                                    list.Add(n);
                                    listTotal = list.Sum();
                                }
                            }
                        }
                    }
                }
            }

            stopwatch.Stop();
        }
    }
}
