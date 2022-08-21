 System.Console.Write("Введите число A: ");
double sum = 1;
int A = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < A; i++)
{
   sum *= (i+1);
}
 System.Console.WriteLine($"Производение равно {sum}");