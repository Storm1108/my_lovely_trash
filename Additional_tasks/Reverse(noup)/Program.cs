int n = 4;
int m = 5;
int[,] array = new int[n, m];
int[,] arrayReversed = new int[array.GetLength(1), array.GetLength(0)];
void Fill(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
            System.Console.Write($"{arr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

void Transponate(int[,] matrix, int[,] temp)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            temp[j, i] = matrix[i, j];
        }
    }
    
};

void PrintArray(int[,] array)
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
Fill(array);
System.Console.WriteLine();
Transponate(array, arrayReversed);
PrintArray(arrayReversed);
System.Console.WriteLine();
Transponate(arrayReversed, array);
PrintArray(array);
System.Console.WriteLine();
Transponate(array, arrayReversed);
PrintArray(arrayReversed);

