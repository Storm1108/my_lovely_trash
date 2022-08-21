// 34. Написать программу замену элементов массива на противоположные
int[] A = new int[12];
void Fill(int[] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        Array[i] = new Random().Next(-10, 10);
    }
}
void ChangeOpposite(int[] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        Array[i] = -Array[i];
    }
}
Fill(A);
System.Console.WriteLine($"Массив: [{String.Join("; ", A)}]");
ChangeOpposite(A);
System.Console.WriteLine($"Новый массив: [{String.Join("; ", A)}]");