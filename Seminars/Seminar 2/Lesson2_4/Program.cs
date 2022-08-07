// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());

if ((b*b) == a || (a*a) == b)
{
    Console.WriteLine ("Да, одно число является квадратом другого");
} 
else
{
    Console.WriteLine ("Нет, ни одно число не является квадратом другого");
}