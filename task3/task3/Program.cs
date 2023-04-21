using System;
using System.Threading;

namespace task3
{
    class Program
    {
        //функция создания массива
        public static int[] CreateArr()
        {
            //создание  массива по данным пользователя
            Console.Write("Enter size of array: ");
            int sizeofarr = Convert.ToInt32(Console.ReadLine());
            int[] values = new int[sizeofarr];

            //запись элементов 
            Console.WriteLine("Enter array: ");
            for (int i = 0; i < sizeofarr; i++)
            {
                Console.Write($"Element {i + 1}: ");
                values[i] = int.Parse(Console.ReadLine());
            }
            return values;
        }

        public static int Chooser(int choose, OnedimensionalArray array1, OnedimensionalArray array2)
        {
            if (choose == 1)
            {
                // сложения массивов
                if (array1.GetSize() == array2.GetSize())
                {
                    array1.Add(array2);
                    Console.WriteLine("Array 1 + Array 2: ");
                    array1.Print();
                    return 0;
                }
                else
                {
                    Console.WriteLine("Enter Arrays with the same size");
                    Thread.Sleep(3000);
                    Environment.Exit(0);
                    return 1;
                }
            }
            else if (choose == 2)
            {
                //вычитание массивов
                if (array1.GetSize() == array2.GetSize())
                {
                    array1.Subtract(array2);
                    Console.WriteLine("Array 1 - Array 2: ");
                    array1.Print();
                    return 0;
                }
                else
                {
                    Console.WriteLine("Enter Arrays with the same size");
                    Thread.Sleep(3000);
                    Environment.Exit(0);
                    return 1;
                }
            }
            else if (choose == 3)
            {
                //умножение 
                Console.WriteLine("Enter multiplier: ");
                int multiplier = Convert.ToInt32(Console.ReadLine());
                array1.Multiply(multiplier);
                Console.WriteLine("Array 1 * your num: ");
                array1.Print();
                return 0;
            }
            else if (choose == 4)
            {
                //возврат размера массива
                Console.WriteLine("Enter number of array to know it's size: ");
                if (Convert.ToInt32(Console.ReadLine()) == 1)
                {
                    Console.WriteLine("Size of first array: "+ Convert.ToString(array1.GetSize()));
                }
                if(Convert.ToInt32(Console.ReadLine()) == 2)
                {
                    Console.WriteLine("Size of second array: " + Convert.ToString(array2.GetSize()));
                }
                else
                {
                    Console.WriteLine("Error");
                }
                return 0;
            }
            else if (choose == 5)
            {
                //возврат типа данных массива
                Console.WriteLine("Enter number of array to know it's type: ");
                if (Convert.ToInt32(Console.ReadLine()) == 1)
                {
                    Console.WriteLine("Type of first array: " + Convert.ToString(array1.GetType()));
                }
                if (Convert.ToInt32(Console.ReadLine()) == 2)
                {
                    Console.WriteLine("Type of second array: " + Convert.ToString(array2.GetType()));
                }
                else
                {
                    Console.WriteLine("Error");
                }
                return 0;
            }
            else if(choose == 0)
            {
                //выход
                Environment.Exit(0);
                return 1;
            }
            else
            {
                Console.WriteLine("Error");
                return 0;
            }
        }
        static void Main(string[] args)
        {
            //создание экземпляров класса массив
            OnedimensionalArray array1 = new OnedimensionalArray();
            array1.Create(CreateArr());
            OnedimensionalArray array2 = new OnedimensionalArray();
            array2.Create(CreateArr());

            //вывод массивов
            Console.WriteLine("Array 1: ");
            array1.Print();
            Console.WriteLine("Array 2: ");
            array2.Print();
            Console.WriteLine("Enter 0 for Exit");
            Console.WriteLine("Enter 1 for Array Addition");
            Console.WriteLine("Enter 2 for Array Substaction");
            Console.WriteLine("Enter 3 for Array Multiplication");
            Console.WriteLine("Enter 4 for Array Size");
            Console.WriteLine("Enter 5 for Array Type");
            int choose = Convert.ToInt32(Console.ReadLine());
            while (Chooser(choose, array1, array2)== 0)
            {
                Console.WriteLine("\n\nEnter 0 for Exit");
                Console.WriteLine("Enter 1 for Array Addition");
                Console.WriteLine("Enter 2 for Array Substaction");
                Console.WriteLine("Enter 3 for Array Multiplication");
                Console.WriteLine("Enter 4 for Array Size");
                Console.WriteLine("Enter 5 for Array Type");
                choose = Convert.ToInt32(Console.ReadLine());
                Chooser(choose, array1, array2);
            }
        }
    }
}
