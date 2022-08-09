
System.Console.WriteLine("------------ Задача 2 --------------");
int a = 6;
int b = 6;
int c = 6;
if (a>b && a>c){
    System.Console.WriteLine("First nubmer - " + a + " - is bigger than other");
}
else if (a<b && b>c) System.Console.WriteLine("Second nummber - " + b + " - is bigger than other");
else if (c>a && c>b) System.Console.WriteLine("Third nummber - " + c + " - is bigger than other");
else if (c == a && a == b) System.Console.WriteLine("These numbers are equal");