string number = "1e3e1";
bool res(string str){
    string first = str.Remove(2);
    string last = str.Remove(0, 3);
    string last1 = new string(last.ToCharArray().Reverse().ToArray());
    if (first == last1)
    {
        return true;
    }
    else return false;
}
System.Console.WriteLine("Number " + number + " is palindrom: " + res(number));
