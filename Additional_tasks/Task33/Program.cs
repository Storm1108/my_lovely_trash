// 33. Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
int[] A = new int[12];
int SumPlus = 0;
int SumMin = 0;
void ArrayAction(int[] A)
{
    for (int i = 0; i < A.GetLength(0); i++)
    {
        A[i] = new Random().Next(-10 , 10);
        if (A[i] > 0)
        {
            SumPlus += A[i];
        }
        else
        {
            SumMin += A[i];
        }
    }
}
ArrayAction(A);
System.Console.WriteLine($"Массив: [{String.Join("; ", A)}]");
System.Console.WriteLine($"Сумма всех положителных элементов массива: {SumPlus}");
System.Console.WriteLine($"Сумма всех отрицательных элементов массива: {SumMin}");