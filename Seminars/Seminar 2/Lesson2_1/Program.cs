// 1. 11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98


int n = new Random().Next(100, 1000);
System.Console.WriteLine(n);

int a = n / 100; 

int b = n % 10;

System.Console.WriteLine(a*10+b);



