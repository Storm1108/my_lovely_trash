// 44. Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы
double b1 = 6;
double k1 = -3;
double b2 = 4;
double k2 = 4;
double x = 0;
double y = 0;
//k1*x + b1 = k2*x + b2 --> x = (b2 - b1)/(k1 - k2)
x = Math.Round((b2 - b1)/(k1 - k2), 2);
y = Math.Round(k1*x + b1, 2);
System.Console.WriteLine($"Координаты пересечения прямых y = {k1}*x + {b1} и y = {k2}*x + {b2}: ({x}; {y})");