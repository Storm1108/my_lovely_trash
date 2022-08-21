int m = 3;
int n = 4;
double[,] A = new double[m, n];
for (int i = 0; i < A.GetLength(0); i++)
{
    for (int j = 0; j < A.GetLength(1); j++)
    {
        A[i, j] = (new Random().NextDouble()) * new Random().Next(-100, 100);
        System.Console.Write($"{A[i, j]}    ");
    }
    System.Console.WriteLine();
}
