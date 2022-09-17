// 59. В прямоугольной матрице найти строку с наименьшей суммой элементов.

int n = 5;
int m = 5;
int[,] array = new int[n, m];
void Fill(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
        }
    }
}
void PrintDoubleArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]} ");
        }
        System.Console.WriteLine();
    }
}
int MinIndex(int[] array)
{
    int min = array[0];
    int index = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        if (min > array[i])
        {
            min = array[i];
            index = i;
        }
    return index;
}

int[] FillStringSummary(int[,] matrix)
{
    int[] summary = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            summary[i] += matrix[i, j];
        }
    }
    return summary;
}
Fill(array);
PrintDoubleArray(array);

System.Console.WriteLine();
System.Console.WriteLine("Строка " + (MinIndex(FillStringSummary(array)) + 1));