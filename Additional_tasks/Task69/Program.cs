//69. Найти сумму элементов от M до N, N и M заданы
int Function(int m, int n)
{
    if (m <= n)
    {
        return m + Function(m + 1, n);
    }
    else
    {
        return 0;
    }
}
System.Console.WriteLine(Function(10, 51));
