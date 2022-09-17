//58. Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить,
// что это невозможно (в случае, если матрица не квадратная).
int n = 4;
int m = 5;
int[,] array = new int[n, m];
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
bool CheckIfSquare(int[,] matrix)
{
    if (matrix.GetLength(0) == matrix.GetLength(1))
    {
        return true;
    }
    else return false;
}
int[,] Transponate(int[,] matrix)
{
    if (CheckIfSquare(matrix))
    {
        int[,] temp = new int[matrix.GetLength(0), matrix.GetLength(1)];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                temp[j, i] = matrix[i, j];
            }
        }
        return temp;
    }
    else
    {
        System.Console.WriteLine("Заданный массив не квадратный");
        return matrix;
    }
}
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
PrintArray(Transponate(array));
