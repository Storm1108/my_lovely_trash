// 50. В двумерном массиве n×k заменить четные элементы на противоположные
int n = 3;
int k = 4;
int [,] arr = new int[n, k];


void Fill(int[,] arr)
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
Fill(arr);
System.Console.WriteLine();

void NewMethod(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] % 2 == 0)
            {
                arr[i, j] = -arr[i, j];
            }
            System.Console.Write($"{arr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

NewMethod(arr);