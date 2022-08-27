// 43. Написать программу преобразования десятичного числа в двоичное

int Num10th = 3;
int Num2th(int Num10th)
{
    Console.WriteLine("Число в 10-ричной системе исчисления: " + Num10th);
    if (Num10th == 0 || Num10th == 1)
    {
        return Num10th;
    }
    else
    {
        int ammout2th = 0;
        for (int Num10thCopy = Num10th; Num10thCopy != 1; Num10thCopy = Num10thCopy / 2)
        {
            ammout2th++;
        }
        int[] Parts = new int[ammout2th + 1];
        int count = 0;
        while (Num10th != 1)
        {
            Parts[ammout2th - count] = Num10th % 2;
            //System.Console.Write(Parts[ammout2th - count] + " ");
            Num10th = Num10th / 2;
            count++;
        }
        Parts[ammout2th - count] = 1;
        System.Console.WriteLine();
        return Convert.ToInt32(string.Join("", Parts));
    }
}
System.Console.WriteLine($"Число в двоичной системе исчисления: {Num2th(Num10th)}");