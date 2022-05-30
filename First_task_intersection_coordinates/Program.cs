// Найти точку пересечения двух прямых заданных уравнением 
// y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы.
Console.Clear();
Console.WriteLine("Для ввода коорднат принимаются только целые числа!");
Console.Write("Введите координату k1 = ");
int k1 = int.Parse(Console.ReadLine()?? "");
Console.Write("Введите координату k2 = ");
int k2 = int.Parse(Console.ReadLine()?? "");
Console.Write("Введите координату b1 = ");
int b1 = int.Parse(Console.ReadLine()?? "");
Console.Write("Введите координату b2 = ");
int b2 = int.Parse(Console.ReadLine()?? "");
int x = (b2-b1)/(k1-k2);
Console.WriteLine($"Координаты x = {x}");
int y= k1* (b2-b1)/(k1-k2)+b1;
Console.WriteLine($"Координаты y = {y}");

