// 45. Показать числа Фибоначчи

List<int> fibbonachi = new List<int>() { 1, 1 };
void fillList(List<int> fibonachiList)
{
    for (int count = 1; fibonachiList[count] > 0; count++)
    {
        fibonachiList.Add(fibonachiList[count] + fibonachiList[count - 1]);
    }
    fibonachiList.RemoveAt(fibonachiList.Count - 1);
}
fillList(fibbonachi);
System.Console.WriteLine($"Список: ({string.Join(", ", fibbonachi)})");
