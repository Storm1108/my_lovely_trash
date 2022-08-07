 //  14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
 //14 -> нет 
 //46 -> нет 
//161 -> да


System.Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int ost_1 = a % 7;
int ost_2 = a % 23;

if (ost_1 == 0 && ost_2 == 0) {
    System.Console.WriteLine("Да");
}
else System.Console.WriteLine("Нет");
