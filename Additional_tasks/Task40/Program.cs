//40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

double[] A = new double[10];
void Fill(double[] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        Array[i] = Math.Round(new Random().NextDouble() * 200 - 100, 3);
    }
}

double[] MaxMinFind(double[] Array)
{
    double[] MaxMin = new double[2];
    MaxMin[0] = Array[0];
    MaxMin[1] = Array[0];
    for (int i = 0; i < Array.GetLength(0) - 1; i++)
    {
        if (Array[i] > MaxMin[0])
        {
            MaxMin[0] = Array[i];
        }
        if (Array[i] < MaxMin[1])
        {
            MaxMin[1] = Array[i];
        }
    }
    return MaxMin;
}
Fill(A);
System.Console.WriteLine($"Массив: [{String.Join("; ", A)}]");
System.Console.WriteLine($"Разница чисел: [{MaxMinFind(A)[0] - MaxMinFind(A)[1]}]");