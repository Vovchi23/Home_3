/* Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.*/

Console.Clear();

int x1, y1, x2, y2, z1, z2;

while (true)
{
    Console.Write("Введите координату Х точки А: ");
    try
    {
        x1 = Convert.ToInt32(Console.ReadLine()!);
        break;
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода! {exc.Message} Попробуйте повторно ввести целое число: ");
    }
}
while (true)
{
    Console.Write("Введите координату Y точки А: ");
    try
    {
        y1 = Convert.ToInt32(Console.ReadLine()!);
        break;
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода! {exc.Message} Попробуйте повторно ввести целое число: ");
    }
}
while (true)
{
    Console.Write("Введите координату Z точки А: ");
    try
    {
        z1 = Convert.ToInt32(Console.ReadLine()!);
        break;
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода! {exc.Message} Попробуйте повторно ввести целое число: ");
    }
}
while (true)
{
    Console.Write("Введите координату Х точки B: ");
    try
    {
        x2 = Convert.ToInt32(Console.ReadLine()!);
        break;
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода! {exc.Message} Попробуйте повторно ввести целое число: ");
    }
}
while (true)
{
    Console.Write("Введите координату Y точки B: ");
    try
    {
        y2 = Convert.ToInt32(Console.ReadLine()!);
        break;
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода! {exc.Message} Попробуйте повторно ввести целое число: ");
    }
}
while (true)
{
    Console.Write("Введите координату Z точки B: ");
    try
    {
        z2 = Convert.ToInt32(Console.ReadLine()!);
        break;
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода! {exc.Message} Попробуйте повторно ввести целое число: ");
    }
}

double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
double resultRound = Math.Round(result, 2);
Console.Write($"A ({x1},{y1},{z1}); B ({x2},{y2},{z2}) --> {resultRound}");
