// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
int[] A = new int[123];
int count = 0;
void Fill(int[] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        Array[i] = new Random().Next(0, 1000);
    }
}

void Check(int[] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        if ((A[i] < 100) && (A[i] > 9))
        {
            count++;
        }
    }
}
Fill(A);
//System.Console.WriteLine($"Массив: [{String.Join("; ", A)}]");
Check(A);
System.Console.WriteLine($"В массиве {count} чисел из отрезка [10,99]");

