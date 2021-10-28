using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[23];
            Random rand = new();
            for (int i = 0; i < array.Length; i++)
                array[i] = rand.Next();

            int[] array = new List(i); // Преобразование в список
            array.RemoveAt(n); // Удаление элемента

            int b = array.ToArray(); // Преобразование в массив

            //int[] array = new int[] { 1, 2, 3, 4, 5 };

            //if (!int.TryParse(Console.ReadLine(), out int index))
            //{
            //    Console.WriteLine("Некорректный индекс");
            //    return;
            //}

            //if (index < 0 || index >= array.Length)
            //{
            //    Console.WriteLine("Индекс за пределами массива");
            //    return;
            //}

            //// вариант удаления выбранного элемента с созданием нового массива
            //int[] newArray = new int[array.Length - 1];
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (i < index)
            //    {
            //        newArray[i] = array[i];
            //    }
            //    else if (i > index)
            //    {
            //        newArray[i - 1] = array[i];
            //    }
            //    Console.WriteLine(newArray);
            //}
        }
    }
}