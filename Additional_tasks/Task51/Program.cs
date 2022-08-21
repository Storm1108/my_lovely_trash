// №51 Задать двумерный массив следующим правилом: Aₘₙ = m+n
int m = 3;
int n = 4;
int[,] arr = new int [m, n];

void Fill(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = i + j + 2;
            System.Console.Write($"{arr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}
Fill(arr);