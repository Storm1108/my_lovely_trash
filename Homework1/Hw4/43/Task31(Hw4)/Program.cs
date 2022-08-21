int[] A = new int[8];
for (int i = 0; i < 8; i++)
{
    A[i] = new Random().Next(0, 10);
}
System.Console.WriteLine($"Массив: [{String.Join("; ", A)}]");