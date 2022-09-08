// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
int m = 3;
int n = 3;
int[,] array = new int[m, n];
System.Console.Write("Введите координаты числа для поиска в виде:'Номер строки,Номер столбца', например 3,3: ");
string temp = Console.ReadLine();
int x = Convert.ToInt32(temp[0].ToString());
int y = Convert.ToInt32(temp[2].ToString());
bool checkExistance(int x, int y, int rows, int coll)
{
    if (0 <= x && x < rows && 0 <= y && y < coll)
    {
        return true;
    }
    else
    {
        return false;
    }
};
void Fill(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
            System.Console.Write($"{matrix[i, j]} ");
        }
        System.Console.WriteLine();
    }
}
Fill(array);
System.Console.WriteLine();
void DisplayElement(int[,] matrix)
{
    if (checkExistance(x,y,n,m))
    {
        System.Console.WriteLine($"Число на позиции ({x}, {y}) - это {array[x,y]}");
    }
    else
    {
        System.Console.WriteLine("Такого числа нет в массиве");
    }
}
DisplayElement(array);
