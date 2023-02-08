// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.WriteLine("Введите сторону матрицы");
if (!int.TryParse(Console.ReadLine(), out int n) || n < 1)
{
    Console.WriteLine("Введено нецелое или отрицательное число или 0");
    return;
}

int[,] array = new int[n, n];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
        array[i, j] = 0;
}

int count = 1;
for (int k = 0; k <= n / 2; k++)
{
    for (int j = k; j < n - k; j++)
        array[k, j] = count++;
    for (int i = 1 + k; i < n - k; i++)
        array[i, n - 1 - k] = count++;
    for (int j = n - 2 - k; j >= k; j--)
        array[n - 1 - k, j] = count++;
    for (int i = n - 2 - k; i > k; i--)
        array[i, k] = count++;
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

PrintArray(array);

