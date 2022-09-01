Console.Clear();
Console.Write("Введите координаты точки");
Console.Write("Введите х: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите у: ");
int y = Convert.ToInt32(Console.ReadLine());

if ((x == 0) || (y == 0))
{
    Console.Write("Координаты не должны равнятся нулю.");
}
else if ((x > 0) && (y > 0))
{
    Console.Write("Точка в первой четверти.");
}
else if ((x > 0) && (y < 0))
{
    Console.Write("Точка во второй четверти.");
}
else if ((x < 0) && (y < 0))
{
    Console.Write("Точка в третьей четверти.");
}
else
{
    Console.Write("Точка в четвертой четверти.");
}