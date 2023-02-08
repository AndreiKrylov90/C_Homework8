// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

int[,] SortedArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1)-1; k++)
        {
            for (int j = 0; j < (array.GetLength(1) - 1); j++)
            {
                int temp = array[i, j];
                if (array[i, j] < array[i, j + 1])
                {
                    array[i, j] = array[i, j + 1];
                    array[i, j + 1] = temp;
                }


            }
        }
    }
    return array;
}

int[,] result = SortedArray(array);
Console.WriteLine("Внимание, ваша отсортированная матрица");
PrintArray(result);