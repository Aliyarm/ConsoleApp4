using System;
using System.Linq;

namespace LB2_IT
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] z = new int[13];

            Random rand = new Random();
            for (int i = 0; i < z.Length; i++)
                z[i] = rand.Next(-100, 100);
            for (int i = 0; i < z.Length; i++)
            {
                Console.Write(z[i] + " ");
            }

            bool sign = z[0] > 0 ? (true) : (false);
            //true полож false отр
            for (int i = 0; i < z.Length - 1; i++)
            {
                if (sign == true)
                    for (int j = i + 1; sign == true; j++)
                    {
                        if (z[j] > 0)
                        {
                            z[j] = 0;
                        }
                        else if (z[j] < 0)
                        {
                            sign = !sign;
                        }

                    }
                else if (sign == false)
                    for (int j = i + 1; sign == false; j++)
                    {
                        if (z[j] < 0)
                        {
                            z[j] = 0;
                        }
                        else if (z[j] > 0)
                        {
                            sign = !sign;
                        }

                    }
                sign = !sign;
            }

            Console.WriteLine("Вывод отсортированного массива");
            for (int i = 0; i < z.Length; i++)
            {
                Console.Write(z[i] + " ");
            }
            Console.ReadLine();
        }
    }
}