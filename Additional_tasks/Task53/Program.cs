//№ 53 В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет

int m = 10;
int n = 10;
int[,] array = new int[m, n];
System.Console.Write("Введите требуемое для поиска число: ");
int a = Convert.ToInt32(Console.ReadLine());

void Fill(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
            System.Console.Write($"{arr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}
Fill(array);
System.Console.WriteLine();
void DisplayElement(int[,] arr)
{
    bool checkExistance = false;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == a)
            {
                System.Console.Write($"({i}, {j}) ");
                checkExistance = true;
            }
        }
    }
    if (!checkExistance)
    {
        System.Console.WriteLine("Такого числа нет в массиве");
    }
}
DisplayElement(array);
