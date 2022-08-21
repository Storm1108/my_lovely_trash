//  38. Найти сумму чисел одномерного массива стоящих на нечетной позиции
int[] A = new int[10];
int sum = 0;
void Fill(int[] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        Array[i] = new Random().Next(0, 10);
    }
}

void Check(int[] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        if (i % 2 != 0)
        {
            sum += A[i];
        }
    }
}
Fill(A);
System.Console.WriteLine($"Массив: [{String.Join("; ", A)}]");
Check(A);
System.Console.WriteLine(sum);
