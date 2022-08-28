// 45. Показать числа Фибоначчи
int[] fibbonachiFill(){
    int[] fibCurrent = new int[200];
    fibCurrent[0] = 1;
    fibCurrent[1] = 1;
    for (int count = 2; fibCurrent[count] > 0; count++)
    {
        {
            fibCurrent[count] = fibCurrent[count-1] + fibCurrent[count-2];
        }
    }
    return fibCurrent;
}
void arrayPrint(int[] array){
    System.Console.Write($"Массив: ( {string.Join(", ", array)})");
}
arrayPrint(fibbonachiFill());
List<int> fibbonachi = new List<int>() {1, 1};
