System.Console.Write("Введите число для проверки: ");
int n = Convert.ToInt32(Console.ReadLine());
int a = 6;
int check(int number, int del){
    return (number % del);

}
if (check(n, a) == 0) System.Console.WriteLine("Число " + n + " делится без остатка на " + a);
else System.Console.WriteLine("Число " + n + " делится на " + a + " с остатком " + check(n, a));