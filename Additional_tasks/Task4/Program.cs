int Max(int arg1, int arg2) {
    if (arg1 > arg2) {
        return arg1;
    }
    else return arg2;
}
int a = 8;
int b = 9;
int c =10;
System.Console.WriteLine(Max(Max(a, c), Max(a, b)));