double n = 12311;
int nchar(double number, int pos){
     string copy = number.ToString();
     int N = copy.Length;
     number = number / Math.Pow(10, N - pos);
     return Convert.ToInt32(number) % 10;
}
if (nchar(n, 1) * 10 + nchar(n, 2) == nchar(n, 5) * 10 + nchar(n, 4)) 
System.Console.WriteLine("Number " + n + " is palindrom");
else
System.Console.WriteLine("Number " + n + " is not a palindrom");
