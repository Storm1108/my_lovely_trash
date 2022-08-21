 System.Console.Write("Введите число A: ");
int sum =0;
int A = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < A; i++)
{
   sum+=(i+1);
}
 System.Console.WriteLine($" Сумма равна {sum}");