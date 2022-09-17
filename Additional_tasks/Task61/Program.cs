// 61. Найти произведение двух матриц
void FillRandom(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(-10, 10);
        }
    }
}
void FillKeyboard(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
}
void PrintDoubleArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]} ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}
void Multiply(int[,] a, int[,] b, int[,] result)
{
    if (a.GetLength(1) == b.GetLength(0))
    {
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < b.GetLength(1); j++)
            {
                for (int p = 0; p < b.GetLength(0); p++)
                {
        
                    result[i, j] += a[i, p] * b[p, j];
                }
            }
        }
    }
    else
    {
        System.Console.WriteLine("Матрицы не умножить");
    }
}
int ai = 2;         //Число строк 1 матрицы 
int aj = 3;         //Число столбцов 1 матрицы
int bi = 3;         //Число строк 2 матрицы
int bj = 3;         //Число столбцов 2 матрицы
int[,] a = new int[ai,aj];
int[,] b = new int[bi,bj];
int[,] result = new int[a.GetLength(0), b.GetLength(1)];
// FillKeyboard(a);         //Можно раскомментировать и закоментировать FillRandom и вводить с клавиатуры посимвольно по строкам
FillRandom(a);                   
PrintDoubleArray(a);
// FillKeyboard(b);
FillRandom(b);              //Можно раскомментировать и закоментировать FillRandom и вводить с клавиатуры посимвольно по строкам
PrintDoubleArray(b);
Multiply(a, b, result);
PrintDoubleArray(result);

