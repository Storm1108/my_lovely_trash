// 49. Показать двумерный массив размером m×n заполненный вещественными числами
int m = 3;
int n = 4;
double[,] array = new double[m, n];

void FillArray(double[,] enteryArray)
{
    for (int i = 0; i < enteryArray.GetLength(0); i++)
    {
        for (int j = 0; j < enteryArray.GetLength(1); j++)
        {
            enteryArray[i, j] = (new Random().NextDouble()) * 200 - 100;
            System.Console.Write($"{Math.Round(enteryArray[i, j], 1)} ");
        }
        System.Console.WriteLine();
    }
}

FillArray(array);