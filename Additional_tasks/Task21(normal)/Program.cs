int n = 15351;
int nchar(int number, int pos)
{
    string copy = number.ToString();
    int N = copy.Length;
    return Convert.ToInt32(copy[N - pos]);
}
if (nchar(n, 1) * 10 + nchar(n, 2) == nchar(n, 5) * 10 + nchar(n, 4))
    System.Console.WriteLine("Number " + n + " is palindrom");
else
    System.Console.WriteLine("Number " + n + " is not a palindrom");