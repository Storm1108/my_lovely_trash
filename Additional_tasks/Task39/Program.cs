// 39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
int[] A = new int[9];
void Fill(int[] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        Array[i] = new Random().Next(0, 10);
    }
}

int[] Multiplication(int[] Array)
{
    int[] multi = new int[Array.GetLength(0) / 2];
    for (int i = 0; i < Array.GetLength(0) / 2; i++)
    {
        multi[i] = Array[i] * Array[Array.GetLength(0) - i - 1];
    }
    return multi;
}
Fill(A);
System.Console.WriteLine($"Массив: [{String.Join("; ", A)}]");
System.Console.WriteLine($"Произведения чисел: [{String.Join("; ", Multiplication(A))}]");