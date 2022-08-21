int n = 3;
int k = 4;
int[,] A = new int[n, k];

void Fill(int[,] A)
{
    for (int i = 0; i < A.GetLength(0); i++)
    {
        for (int j = 0; j < A.GetLength(1); j++)
        {
            A[i, j] = new Random().Next(-100, 100);
            System.Console.Write($"{A[i, j]}    ");
        }
        System.Console.WriteLine();
    }
}
void Change(int[,] A)
{
    for (int i = 0; i < A.GetLength(0); i++)
    {
        for (int j = 0; j < A.GetLength(1); j++)
        {
            if (A[i, j] % 2 == 0)
            {
                A[i, j] = -A[i, j];
            }
            System.Console.Write($"{A[i, j]}    ");
        }
        System.Console.WriteLine();
    }
}

Fill(A);
System.Console.WriteLine();
Change(A);