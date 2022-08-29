Console.Clear();
// Console.WriteLine($"{num1};{num2}");
Console.WriteLine("Проверка введенного числа на кратность 7 и 23 одновременно"); 
Console.WriteLine("Введите число");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = 7;
int num3 = 23;
int res = num1 % num2 | num1 % num3;
if (res == 0)
{ 
    Console.WriteLine($"Число {num1} кратно числу {num2} и {num3} одновременно"); 
}
else
{
    Console.WriteLine($"Число {num1} не кратно {num2} и {num3} одновременно");
}
Console.WriteLine($"Остаток от деления {num1} на {num2} равен {num1 % num2}");
Console.WriteLine($"Остаток от деления {num1} на {num3} равен {num1 % num3}");