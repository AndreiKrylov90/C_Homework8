// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int[,] GenerateArray(int m, int n, int min, int max)
{
    int[,] array = new int[m, n];
    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = random.Next(min, max + 1);
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j].ToString("0.#") + "\t");
        Console.WriteLine();
    }
}

var array = GenerateArray(3, 4, 0, 9);
Console.WriteLine("Внимание, ваша матрица");
PrintArray(array);

int[] SumOfLines(int[,] array)
{
    int[] lineSum = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            lineSum[i] = lineSum[i] + array[i, j];
    }
    return lineSum;
}
var sums = SumOfLines(array);

int MinofSums(int[] sumOfLines)
{
    int minNumber = 0;
    int min = sumOfLines[0];
    for (int i = 0; i < sumOfLines.Length; i++)
    {
        if (sumOfLines[i] < min)
        {
            min = sumOfLines[i];
            minNumber = i;
        }
    }

    return minNumber+1;
}

int minLine = MinofSums(sums);
Console.WriteLine($"Минимальная сумма находится в {minLine} строке");









