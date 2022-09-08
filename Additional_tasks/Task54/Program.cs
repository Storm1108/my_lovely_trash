// 54. В матрице чисел найти сумму элементов главной диагонали
int n = 4;
int[,] matrix = new int[n, n];

void FillArrayRamdom(int[,] arr)
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
int SummMainDiagonal(int[,] matrix)
{
    var summ = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        summ += matrix[i, i];
    }
    return summ;
}

FillArrayRamdom(matrix);
System.Console.WriteLine(SummMainDiagonal(matrix));;
