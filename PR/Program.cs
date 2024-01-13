using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите количество строк в массиве: ");
        int n = int.Parse(Console.ReadLine());

        string[] array = new string[n];

        Console.WriteLine("Введите строки массива:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Строка {i + 1}: ");
            array[i] = Console.ReadLine();
        }

        string[] newArray = FilterStrings(array);

        Console.WriteLine("Новый массив из строк, длина которых меньше или равна 3 символам:");
        for (int i = 0; i < newArray.Length; i++)
        {
            Console.WriteLine($"Строка {i + 1}: {newArray[i]}");
        }
    }

    static string[] FilterStrings(string[] inputArray)
    {
        int count = 0;

        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= 3)
            {
                count++;
            }
        }

        string[] outputArray = new string[count];
        int index = 0;

        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= 3)
            {
                outputArray[index] = inputArray[i];
                index++;
            }
        }

        return outputArray;
    }
}