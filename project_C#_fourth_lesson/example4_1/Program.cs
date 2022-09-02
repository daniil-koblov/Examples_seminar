// Напишите программу, которая принимает число А и выдает сумму от чисел от 1 до А.
Console.Clear();
void SumOneToA(int a)
{
    int sum = 0;
    for(int i = 1; i <= a; i++)
    {
        sum = sum + i;
    }
    Console.WriteLine(sum);
}

Console.Write("Введите число A: ");
int num1 = Convert.ToInt32(Console.ReadLine());
SumOneToA(num1);

Console.Write("Введите число B: ");
int num2 = Convert.ToInt32(Console.ReadLine());
SumOneToA(num2);

Console.Write("Введите число C: ");
int num3 = Convert.ToInt32(Console.ReadLine());
SumOneToA(num3);