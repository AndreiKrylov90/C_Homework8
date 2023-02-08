// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] array = new int[4, 4];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
        array[i, j] = 0;
}

void GenerateSpiralArray(int m, int n)
{
    int max = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            if (array[i, j] > max) max = array[i, j];

    if (array[m, n] == 0)
    {
        array[m, n] = max + 1;
        if (max < 10)
        {
            if (n < 3 && m < 4 && n >= 0 && m >= 0) GenerateSpiralArray(m, n + 1);
            if (n < 4 && m < 3 && n >= 0 && m >= 0) GenerateSpiralArray(m + 1, n);
            if (n < 4 && m < 4 && n > 0 && m >= 0) GenerateSpiralArray(m, n - 1);
            if (n < 4 && m < 4 && n >= 0 && m > 0) GenerateSpiralArray(m - 1, n);
        }
        else
        {
            if (n < 4 && m < 4 && n >= 0 && m > 0) GenerateSpiralArray(m - 1, n);
            if (n < 3 && m < 4 && n >= 0 && m >= 0) GenerateSpiralArray(m, n + 1);
            if (n < 4 && m < 3 && n >= 0 && m >= 0) GenerateSpiralArray(m + 1, n);
            if (n < 4 && m < 4 && n > 0 && m >= 0) GenerateSpiralArray(m, n - 1);
        }



    }
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

GenerateSpiralArray(0, 0);
PrintArray(array);

