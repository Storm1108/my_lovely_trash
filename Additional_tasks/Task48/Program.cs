/*Задача 48. Показать двумерный массив размером m×n заполненный целыми числами*/
int m = 3;
int n = 4;
int[,] arr = new int[m, n];

static void FillArrayRamdom(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(-100, 100);
            System.Console.Write($"{arr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}


FillArrayRamdom(arr);