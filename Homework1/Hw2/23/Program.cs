String Result (int day){
    if (day == 6 || day == 7){
        return "Да, это выходной, отдыхай";
    }
    else return "Нет, иди на завод";
}
System.Console.Write("Введите номер дня недели: ");
int Day = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Result(Day));