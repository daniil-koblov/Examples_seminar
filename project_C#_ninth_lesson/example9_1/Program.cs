// // Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"
Console.Clear();

int[] FillArray(int a)
{
    int b = 1;
    int[] array = new int[a];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        array[i] = b;
        b++;
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите число в промежутке равное или больше 1.");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 0)
{
    Console.WriteLine($"Натуральные числа от 1 до {n}");
    int[] num = FillArray(n);
    PrintArray(num);
}
else Console.WriteLine("Число должно быть равно или больше 1.");
