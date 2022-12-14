// Решение в группах задач:
// Задача 32: Напишите функцию замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

// Задача 33: Задайте массив. Напишите функцию, которая определяет, присутствует ли заданное число в массиве.
// решать без встроенных функций
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да


// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

// Задача 100: 10000<N<30000. нужно получить разбиение всех чисел от 2 до N на простые множители

bool IsSimple(int number)
{
    if (number <= 1) return false;
    for (int j = 2; j < number; j++)     //попытка разделить i на j
    {
        if (number % j == 0)
        {
            return false;    
        }
    }
    return true;
}

int N = 30000;
int k = 0;
int[] A = new int[30000];
for (int i = 2; i <= N; i++)    //перебор числел i от 2 до N
{
    if (IsSimple(i))
    {
        A[k] = i;
        k++;
    }
}

string SimpleMod(double number)
{
    int k = 0;
    string answer = number + " ---> 1";
    while (k <= N/2)
    {
        if (number % A[k] == 0)
        {
            number = number / A[k];
            answer += " * " + A[k];
        }
        else
        {
            k++;
        }
    }
    return answer;
}
for (double s = 2; s <= N; s++)
{
    System.Console.WriteLine(SimpleMod(s));
}
