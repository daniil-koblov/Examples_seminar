Console.Clear();

int num1 = new Random().Next(100, 1000);
Console.WriteLine(num1);
int num2 = num1 / 100;
int num3 = num1 % 10;

Console.WriteLine($"{num2}{num3}");
