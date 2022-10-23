Console.Write("Введите значение b1: ");
int b1 = int.Parse(Console.ReadLine() ?? "");
double b11 = (double)b1;

Console.Write("Введите  значение k1: ");
int k1 = int.Parse(Console.ReadLine() ?? "");
double k11 = (double)k1;

Console.Write("Введите значение b2: ");
int b2 = int.Parse(Console.ReadLine() ?? "");
double b22 = (double)b2;

Console.Write("Введите значение k2: ");
int k2 = int.Parse(Console.ReadLine() ?? "");
double k22 = (double)k2;

double x = (b22 - b11) / (k11 - k22);
double y1 = k11 * x + b11;
double y2 = k22 * x + b22;
double Delta = Math.Abs(y1 - y2);

if (Delta < 0.00001)
{
    Console.WriteLine($"Точка пересечения прямых: ({x}; {y1})");
}
else
{
    Console.WriteLine("Точек пересечения нет.");
}
