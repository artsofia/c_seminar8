using System;
using MyLib;

namespace tasks;
class Program
{
    static void Main(string[] args)
    {
        void Task54()
        {
            int rows = MyLib.MyLibClass.Input("Введите кол-во строк: ");
            int columns = MyLib.MyLibClass.Input("Введите кол-во столбцов: ");
            int[,] numbers = new int[rows, columns];

            MyLib.MyLibClass.FillArray(numbers, 0, 9);
            MyLib.MyLibClass.PrintArray(numbers);

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    for (int k = 0; k < numbers.GetLength(1) - j - 1; k++)
                    {
                        if (numbers[i, k] < numbers[i, k + 1])
                        {
                            int temporary = numbers[i, j];
                            numbers[i, j] = numbers[i, k + 1];
                            numbers[i, k + 1] = temporary;
                        }
                    }
                }
            }
            Console.WriteLine();
            MyLib.MyLibClass.PrintArray(numbers);
        }


        void Task56()
        {
            int rows = 4;
            int columns = 6;
            int[,] numbers = new int[rows, columns];

            MyLib.MyLibClass.FillArray(numbers, 0, 9);
            MyLib.MyLibClass.PrintArray(numbers);

            int countRows = 0;
            int sumRows = 0;
            int minSumRows = 0;

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    sumRows += numbers[i, j];
                }

                if (sumRows <= minSumRows)
                {
                    minSumRows = sumRows;
                    countRows = i;
                }
                Console.WriteLine($"Сумма строки {i + 1} = {sumRows}");
            }
            Console.WriteLine();
            Console.WriteLine($"Сумма элементов = {minSumRows}");
        }


        void Task58()
        {
            
        }


        // Проверка кода. 
        Console.Clear();
        int task = MyLib.MyLibClass.Input("Введите номер задачи: ");
        switch (task)
        {
            case 54:
                Task54();
                break;
            case 56:
                Task56();
                break;
            case 58:
                Task58();
                break;
            default:
                Console.WriteLine("Ошибка ввода");
                break;
        }
    }
}