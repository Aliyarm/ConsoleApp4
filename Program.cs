using System;

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

            bool sign = array[0] > 0; //задаём переменную sign, которая проверяет знак первого(нулевого) элемента массива
            
            for (int i = 0; i < array.Length - 1; i++) // который перебирает массив array с шагом в один, начиная с нулевого элемента, до элемента равного количеству элементов
            {
                if (sign == true && array[i] != 0) //так как sign - булевое значение, в случае если он равен true и проверяемый элемент не равен нулю, то выполняется цикл for
                    for (int j = i + 1; sign == true && j < array.Length; j++) // который 
                    {
                        if (array[j] > 0)
                        {
                            array[j] = 0;
                        }
                        else if (array[j] < 0)
                        {
                            sign = !sign;
                        }
                    }
                else if (sign == false && array[i] != 0)
                    for (int j = i + 1; sign == false && j < array.Length; j++)
                    {
                        if (array[j] < 0)
                        {
                            array[j] = 0;
                        }
                        else if (array[j] > 0)
                        {
                            sign = !sign;
                        }
                    }
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