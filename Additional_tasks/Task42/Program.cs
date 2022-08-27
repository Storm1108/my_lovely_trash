// 42. Определить сколько чисел больше 0 введено с клавиатуры
int CountMore = 0;
int CountAll = 0;
string current = string.Empty;
while (current != "Exit" && current != "exit")
{
    current = Console.ReadLine();
    bool success = Int32.TryParse(current, out int x); 
    if (success)
    {
        if (x > 0)
        {
            CountMore++;
            CountAll++;
        }
        else
        {
            CountAll++;
        };
    }
    else
    {
        if (current != "Exit" && current != "exit")
        {
            Console.WriteLine("Введите целое число или Exit для выхода и подсчета разультата.");
        }

    }

}
System.Console.WriteLine($"Среди введенных {CountAll} чисел есть {CountMore} положительных");