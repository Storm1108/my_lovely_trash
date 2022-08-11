int n = new Random().Next(9, 100);
int Max(int arg1, int arg2) {
    if (arg1 > arg2) {
        return arg1;
    }
    else return arg2;
}
System.Console.WriteLine("Наиболшая цифра числа " + n + " это " + Max(n / 10, n % 10));