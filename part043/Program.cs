// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/


double FindCoordX(double b1, double k1, double b2, double k2)
{
    return (b2 - b1) / (k1 - k2);
}
double FindCoordY(double b1, double k1, double b2, double k2)
{
    return k1 * (b2 - b1) / (k1 - k2) + b1;
}

Console.WriteLine("Введите координаты линий:");
Console.Write("Введите координаты точки b1: ");
double cB1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки k1: ");
double cK1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки b2: ");
double cB2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки k2: ");
double cK2 = Convert.ToInt32(Console.ReadLine());
if (cK1 == cK2 && cB1 == cB2)
{
Console.WriteLine("Прямые одного размера.");
return;
}
if (cK1 == cK2) 
{
Console.WriteLine("Прямые являются параллельными.");
return;
}
double x = FindCoordX(cB1, cK1, cB2, cK2); x = Math.Round(x,2,MidpointRounding.ToZero);
double y = FindCoordY(cB1, cK1, cB2, cK2); y = Math.Round(x,2,MidpointRounding.ToZero);

y = Math.Round(x,2,MidpointRounding.ToZero);
Console.WriteLine($"b1 = {cB1}, k1 = {cK1}, b2 = {cB2}, k2 = {cK2} -> ({x};{y})");
