// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
Console.Clear();

int m = new Random().Next(1, 4);
int n = new Random().Next(1, 4);
int[,] num = new int[m, n];
for (int i = 0; i < num.GetLength(0); i++)
{
    for (int j = 0; j < num.GetLength(1); j++)
    {
        num[i, j] = new Random().Next(1, 10);
        Console.Write($"{num[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine("Измененный массив.");
if (m > 1)
{
    int reverse = 0;
    int help = 1;
    for (int j = 0; j <= num.GetLength(1) - 1; j++)
    {
        reverse = num[m - 1, n - help];
        num[m - 1, n - help] = num[0, j];
        num[0, j] = reverse;
        help++;
    }
}
else
{
    int reverse = 0;
    int help = 1;
    if (num.GetLength(1) % 2 == 0)
    {
        for (int j = 0; j < num.GetLength(1) / 2; j++)
        {
            reverse = num[0, n - help];
            num[0, n - help] = num[0, j];
            num[0, j] = reverse;
            help++;
        }
    }
    else
    {
        for (int j = 0; j <= num.GetLength(1) / 2; j++)
        {
            reverse = num[0, n - help];
            num[0, n - help] = num[0, j];
            num[0, j] = reverse;
            help++;
        }
    }
}
for (int i = 0; i < num.GetLength(0); i++)
{
    for (int j = 0; j < num.GetLength(1); j++)
    {
        Console.Write($"{num[i, j]} ");
    }
    Console.WriteLine();
}