// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] GenerateArray(int m, int n, int l)
{
    int[,,] array = new int[m, n, l];
    Random random = new Random();

    int[] numbers = new int[m * n * l];
    for (int i = 0; i < numbers.Length; i++)
    {
        int currentNumber = random.Next(10, 100);
        if (numbers.Contains(currentNumber)) i--;
        else numbers[i] = currentNumber;
    }

    int t = 0;

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = numbers[t++];
            }

    return array;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i}, {j}, {k}) ");

            }
            Console.WriteLine();
        }


    }
}

var array = GenerateArray(3, 2, 3);
Console.WriteLine("Внимание, параметры вашей трехмерной матрицы, в скобках указан индекс (координаты)");
PrintArray(array);