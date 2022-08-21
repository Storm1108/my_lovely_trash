// 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

int[] A = new int[8];
for (int i = 0; i < 8; i++)
{
    A[i] = new Random().Next(0, 2);
}
System.Console.WriteLine($"Массив: [{String.Join("; ", A)}]");