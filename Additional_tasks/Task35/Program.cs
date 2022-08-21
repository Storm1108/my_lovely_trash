// 35. Определить, присутствует ли в заданном массиве, некоторое число
int n = 10;
int[] A = new int[n];
System.Console.Write("Введите требуемое для поиска число: ");
int a = Convert.ToInt32(Console.ReadLine());

void Fill(int[] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        arr[i] = new Random().Next(0, 10);
    }
}
bool existance = false;
void Check(int[] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if (arr[i] == a)
        {
            existance = true;
        }
    }
    if (existance)
    {
        System.Console.WriteLine("Этот элемент есть в массиве");
    }
    else
    {
         System.Console.WriteLine("Этого элемента в массиве нет");
    }
}

Fill(A);
System.Console.WriteLine($"Массив: [{String.Join("; ", A)}]");
Check(A);