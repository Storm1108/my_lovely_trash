char nchar(int number, int pos) //сделал для Task21
{
    string copy = number.ToString();
    return copy[pos];
}
int sum = 0;
int n = 6767;           //вводить число сюда
char temp = '0';
for (int i = 0; i < (n.ToString().Length); i++)
{
    temp = nchar(n, i);
    sum = sum + Convert.ToInt32(temp.ToString());
}
System.Console.WriteLine($"Сумма числе числа {n} равна {sum}");