Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if ((b*b) == a || (a*a) == b)
{
    Console.WriteLine ("Да, одно число является квадратом другого");
} 
else
{
    Console.WriteLine ("Нет, ни одно число не является квадратом другого");
}