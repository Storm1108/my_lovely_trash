String name(int day, string[] week) {
    return week[day-1];
}

string[] OurWeek = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
System.Console.Write("Enter day of week: ");
int Wday = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Week day with number " + Wday + " is " + name(Wday, OurWeek));