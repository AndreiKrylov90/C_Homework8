// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


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

var array1 = GenerateArray(4, 3, 1, 5);
Console.WriteLine("Внимание, ваша 1 матрица");
PrintArray(array1);

var array2 = GenerateArray(3, 4, 1, 5);
Console.WriteLine("Внимание, ваша 2 матрица");
PrintArray(array2);

int[,] MultiplicationOfMatrix(int[,] array1, int[,] array2)
{
    int[,] arrayNew = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0 ; k < array1.GetLength(1); k++)
            {
            arrayNew[i, j] = arrayNew[i, j] + array1[i, k] * array2[k, j];
            }
        }
    }
    return arrayNew;
}

int[,] result = MultiplicationOfMatrix(array1, array2);
Console.WriteLine("Внимание, произведение ваших матриц");
PrintArray(result);
