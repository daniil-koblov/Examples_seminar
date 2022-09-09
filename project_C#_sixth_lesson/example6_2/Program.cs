// Проверка на существование треугольника, при условии, что 3 введенных числа являются его сторонами.
Console.Clear();

void Triangle(int a, int b, int c)
{
    if(a < b + c && b < a + c && c < a + b) Console.WriteLine($"Треугольник со сторонами {a} {b} {c} существует");
    else Console.WriteLine($"Треугольник со сторонами {a} {b} {c} не существует");
}

Console.WriteLine("Введите три стороны треугольника");
Console.WriteLine("Введите первую сторону треугольника");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую сторону  треугольника");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третью сторону  треугольника");
int num3 = Convert.ToInt32(Console.ReadLine());
Triangle(num1, num2, num3);