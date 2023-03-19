using System;

namespace lesson2
{
    class Program
    {
        static int ReadInt ()
        {
            try
            {
                var valueText = Console.ReadLine();
                return Int32.Parse(valueText);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Введите корректное числовое значение");
                return -1;

            }

        }
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите размер массива");
            var l = ReadInt ();
            if (l > 1)
            {
                Console.WriteLine("yes");
                var array = new int[l];

                Console.WriteLine("Введите последовательно элементы массива");
                for (int i = 0; i < l; i++)
                {
                    array[i] = ReadInt();
                }

                var max1 = array[0];
                var max2 = array[0];

                for (int i = 0; i < l; ++i)
                {
                    if (array[i] > max1)
                    {
                        max1 = array[i];
                    }
                }

                for (int i = 0; i < l; ++i)
                {
                    if (array[i] > max2 && array[i] != max1)
                    {
                        max2 = array[i];
                    }
                }

                Console.WriteLine("максимальное значение = " + max1);
                Console.WriteLine("второе максимальное значение = " + max2);
            }

            else
            {
                Console.WriteLine("Введите целое положительное число, больше 1");
            }


        }
    }
}
