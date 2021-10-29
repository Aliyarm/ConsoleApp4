using System;
using System.Collections.Generic;
using System.Linq;

namespace LB3_IT
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = Convert.ToInt32(Console.ReadLine());           
            //int[] array = new int[n];

            int[] array = new int[10] { -1, -2, -3, 4, 5, 6, -7, 8, 9, -10 };
            //Random rand = new();
            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = rand.Next(-100, 100);
            //    Console.Write(array[i] + " ");
            //}

            bool sign = array[0] > 0;
            //если сигн тру, ищем отрицательное, если сигн фолс то ищем положительное
            for (int i = 0; i < array.Length - 1; i++)
            {
                int j = i + 1;
                if (array[i] == 0)
                {
                    //sign = !sign;
                }
                else if (sign == true)
                {
                    if (array[j] > 0)
                    {
                        array[j] = 0;
                    }
                }
                else if (sign == false)
                {
                    if (array[j] < 0)
                    {
                        array[j] = 0;
                    }
                }
                sign = !sign;
            }

            Console.WriteLine();
            Console.WriteLine("Вывод отсортированного массива");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.ReadLine();
            //Console.WriteLine(newArray);
        }
    }
}