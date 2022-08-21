// № 52 В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты


int m = 4;
int n = 4;
int[,] arr = new int [m, n];

void Fill2(int[,] arr)
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
Fill2(arr);
System.Console.WriteLine();
void Fill(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if ((i + 1) % 2 == 0 && (j + 1) % 2 == 0)
                 arr[i, j] = arr [i, j] * arr [i, j];
             System.Console.Write($"{arr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}
Fill(arr);
