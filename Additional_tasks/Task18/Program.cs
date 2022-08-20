bool x = false;
bool y = false;
bool check(bool first, bool second){

    if (!(x || y) == (!x && !y))
{
    return true;
} 
else
{
    return false;
}
}
int i = 0;
//bool[] checklist = new bool[8];
bool count = true;
while (i < 4)
{
    // checklist[i*2] = check(x, y);
    // count = count && checklist[i*2];
    count = count && check(x,y);
    y = !y;
    // checklist[i*2 + 1] = check(x, y);
    // count = count && checklist[i*2 +1];
    x = x^y;
    count = count && check(x,y);
    i++;
}
// if (checklist.Any == true) System.Console.WriteLine("Statment is true");
// else System.Console.WriteLine("Statment is false");
if (count == true) System.Console.WriteLine("Statment is true");
else System.Console.WriteLine("Statment is false");



