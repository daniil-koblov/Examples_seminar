Console.Clear();
// Console.WriteLine($"{num1};{num2}"); 
Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
if(num1 % num2 == 0)
{ 
    Console.WriteLine($"Число {num1} кратно числу {num2}"); 
}
else
{
    Console.WriteLine($"Остаток от деления числа {num1} на {num2} равняется {num1 % num2}");
}