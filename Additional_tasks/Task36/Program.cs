// 36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
int[] A = new int[10];
int even = 0;
int uneven = 0;
void Fill(int[] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        Array[i] = new Random().Next(100, 1000);
    }
}
void Check(int[] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        if (A[i] % 2 == 0)
        {
            even++;
        }
        else
        {
            uneven++;
        }
    }
}
Fill(A);
System.Console.WriteLine($"Массив: [{String.Join("; ", A)}]");
Check(A);
System.Console.WriteLine($"В массиве {even} четных чисел и {uneven} нечетных");
