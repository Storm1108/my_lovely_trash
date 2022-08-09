
// int n = new Random().Next(0, 100000);
int n = 341430;
System.Console.WriteLine("Входное число: " + n);
void Third (int N)
{
    // System.Console.WriteLine(number);
    string number = N.ToString();
    if (number.Length > 2){
        string number1 = number.Remove(3);
        int cut = Convert.ToInt32(number1);
        int third = cut % 10;
        System.Console.WriteLine("Третья цифра числа " + N + " это " + third);
    }
    else {
        System.Console.WriteLine("Третьей цифры числа " + N + " не существует");
    }
}
 Third(n);
