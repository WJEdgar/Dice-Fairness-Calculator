using System;

namespace D4_Fairness_Calculation
{
    class Program
        {
        static void Main(string[] args)
        {
            int[] x = new int[20];
            int No1 = 0;
            int No2 = 0;
            int No3 = 0;
            int No4 = 0;
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Please enter roll number {0}", i + 1);
                x[i] = Convert.ToInt32(Console.ReadLine());
                if (x[i] == 1)
                {
                    No1++;

                }
                else if (x[i] == 2)
                {
                    No2++;
                }
                else if (x[i] == 3)
                {
                    No3++;
                }
                else if (x[i] == 4)
                {
                    No4++;
                }
            }
            Console.WriteLine("{0} {1} {2} {3}", No1, No2, No3, No4);
            int Expected = 5;
            double Diff1 = ((No1 - Expected) * (No1 - Expected)) / Expected;
            double Diff2 = ((No2 - Expected) * (No2 - Expected)) / Expected;
            double Diff3 = ((No3 - Expected) * (No3 - Expected)) / Expected;
            double Diff4 = ((No4 - Expected) * (No4 - Expected)) / Expected;
            double Sum = (Diff1 + Diff2 + Diff3 + Diff3);
            Console.WriteLine(Sum);
            double[] Crit = { 6.251,7.815,9.348,11.345,16.266};
            if (Sum <= Crit[0])
                    {
                        Console.WriteLine("this dice is fair");
                    }
            else if (Sum < Crit[1])
                    {
                        Console.WriteLine("The Dice is acceptably fair");

                    }
            else if (Sum >= Crit[1])
                    {
                Console.WriteLine("The dice shows some bias, test again");
                    }
            Console.ReadLine();



        }
        }
        }