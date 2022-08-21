int n = 14973;
int count = n;
int i = 0;
while (count != 0)
{
    count = count/10;
    i ++ ;
}
System.Console.WriteLine($"В числе {n} - {i} цифр(ы)");