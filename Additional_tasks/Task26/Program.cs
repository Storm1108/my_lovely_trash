System.Console.Write("Введите число A: ");
double A = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите показатель B: ");
int B = Convert.ToInt32(Console.ReadLine());
double all = 1;
for (int i = 0; i < B; i++)
{
    all = all * A;
}
System.Console.WriteLine($" Степень равна {all}");