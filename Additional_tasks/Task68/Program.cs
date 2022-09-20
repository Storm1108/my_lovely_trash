//68. Показать натуральные числа от M до N, N и M заданы
string Function(int m, int n)
{
    if (m <= n)
    {
        return $"{m} " + Function(m + 1, n);
    }
    else
    {
        return "Введите числа в правильном порядке";
    }
}
System.Console.WriteLine(Function(50, 10));
