// 55. Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
int m = 3;
int n = 4;
int[,] array = new int[m, n];

static void FillArrayRamdom(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-100, 100);
            System.Console.Write($"{matrix[i, j]} ");
        }
        System.Console.WriteLine();
    }
}
List<double> MiddleEveryColumn(int[,] matrix)
{
    List<double> middleList = new List<double>() { };
    double summCurrentColumn = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            summCurrentColumn += matrix[i, j];
        }
        middleList.Add(Math.Round(summCurrentColumn / matrix.GetLength(0), 2));
        summCurrentColumn = 0;
    }
    return middleList;
}
FillArrayRamdom(array);
System.Console.WriteLine($"Cредние арифметические: ({string.Join(", ", MiddleEveryColumn(array))})");
