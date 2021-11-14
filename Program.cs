using System;
using System.Collections.Generic;

namespace LB3_IT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину масссива:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            Random rand = new();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-100, 100); // присваиваем в массив с индексом i рандомное число в диапазоне от -100 до 10
                Console.Write(array[i] + " ");
            }

            List<int> numbers = new();
            numbers.AddRange(array);

            public numbers.Sort(Comparison<T> comparison);

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }


            
            int newLength = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != 0)
                    newLength++;
            }
            int[] newArray = new int[newLength];
            int newIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != 0)
                {
                    newArray[newIndex] = array[i];
                    newIndex++;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Вывод преобразованного массива:");
            for (int i = 0; i < newArray.Length; i++)
            {
                Console.Write(newArray[i] + " ");
            }
            Console.ReadLine();
        }
    }
}