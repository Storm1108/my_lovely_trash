
// 12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно



int n1 = 50, m1 = 5;
int n2 = 19, m2 = 4;

int a = n1 % m1;

if (a == 0) System.Console.Write("Кратно"); 
else System.Console.WriteLine("Не кратно, остаток: " + a);

System.Console.WriteLine();

int b = n2 % m2;

if (b == 0) System.Console.Write("Кратно"); 
else System.Console.WriteLine("Не кратно, остаток: " + b);