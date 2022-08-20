System.Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < N; i++)
{
    System.Console.WriteLine($" {i+1} ---> {(i+1)*(i+1)*(i+1)}");
}