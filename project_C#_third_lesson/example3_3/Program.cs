Console.Clear();
Console.WriteLine("Прграмма принимает на вход координтаы двух точек и выводит расстояние между ними в 2D пространстве");
bool repeat = true;
/* int[] pointA = new int[2];
int[] pointB = new int[2]; */

/* void distanceCount(int[] point1, int[] point2)
{
    double distance = Math.Sqrt(Math.Pow((point2[0] - point1[0]),2 ) + Math.Pow((point2[1] - point1[1]),2 ));
    distance = Math.Round(distance,2);
    Console.WriteLine($"Расстояние между двумя точками равно{distance}");
} */

while(repeat)
{
    Console.Write("Введите координаты первой точки А: ");
    Console.Write("Введите х: ");
    int xa = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите у: ");
    int ya = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите координаты первой точки В: ");
    Console.Write("Введите х: ");
    int xb = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите у: ");
    int yb = Convert.ToInt32(Console.ReadLine());

    double distance = Math.Sqrt(Math.Pow((xb - xa),2) + Math.Pow((yb - ya),2));
    Console.Write("Для продолжения нажмите 'ENTER'. Для выхода 'E', затем 'ENTER'");
    string? decision = Console.ReadLine();

    if (decision?.ToLower() == "e")
    {
        repeat = false;
    }
    Console.WriteLine(distance);
}