// 63. Сформировать трехмерный массив не повторяющимися двузначными числами
// показать его построчно на экран выводя индексы соответствующего элемента
int[,,] array = new int[2, 2, 2];
void FillRandom(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                do
                {
                    arr[i, j, k] = new Random().Next(10, 100) ;
                } while (!CheckOriginality(arr, i, j, k));
            }
        }
    }
}
void PrintTrippleArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                System.Console.Write($"{array[i, j, k]} ({i}, {j}, {k}) ");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}
bool CheckOriginality(int[,,] array, int iPos, int jPos, int kPos)     
 //проверяет оригинальность одного элемента относительно стоящих перед ним по порядку заполниения
 // Можно было сделать сильно проще просто все перебрав, но я решил оптимизировать на случай работы с бОлшими массивами
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0) && count < (iPos * 100 + jPos * 10 + kPos); i++)
    {
        for (int j = 0; j < array.GetLength(1) && count < (iPos * 100 + jPos * 10 + kPos); j++)
        {
            for (int k = 0; k < array.GetLength(2) && count < (iPos * 100 + jPos * 10 + kPos); k++)
            {
                count = i * 100 + j * 10 + k;
                if (array[iPos, jPos, kPos] == array[i, j, k])
                {
                    if (!(i == iPos && j == jPos && k==kPos))       //запутался в булевых операциях и просто сделал еще один if
                    {
                    return false;
                        
                    }
                }
                //System.Console.WriteLine(array[i, j, k] + " // " + array[iPos, jPos, kPos] + " // " + count + " // " + (iPos * 100 + jPos * 10 + kPos));
            }
        }
    }
    return true;
}
FillRandom(array);
PrintTrippleArray(array);
