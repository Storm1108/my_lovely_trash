System.Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int i =0;
while (i <= 2*N)
{
    System.Console.Write((-N + i) + ", ");
    i++;
}