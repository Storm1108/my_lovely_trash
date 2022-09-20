//71. Написать программу вычисления функции Аккермана
int Function(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return Function(m-1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return Function(m-1, Function(m, n-1));
    }
    else return 0;
}
System.Console.WriteLine(Function(2,3));

