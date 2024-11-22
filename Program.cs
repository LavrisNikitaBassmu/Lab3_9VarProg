using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество элементов в массиве: ");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        Console.WriteLine("Введите элементы массива:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Элемент [{i}]: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        bool result = CheckAlternatingSigns(array);
        Console.WriteLine(result ? "TRUE" : "FALSE");
    }

    static bool CheckAlternatingSigns(int[] array)
    {
        if (array.Length == 0)
            return false;

        bool isPositive = array[0] > 0;

        for (int i = 1; i < array.Length; i++)
        {
            if ((array[i] > 0) == isPositive)
            {
                return false;
            }

            isPositive = array[i] > 0;
        }

        return true;
    }
}