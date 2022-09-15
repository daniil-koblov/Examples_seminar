// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1
Console.Clear();

int m = new Random().Next(1, 10);
int n = new Random().Next(1, 10);
int[,] num = new int [m,n];
for(int i = 0; i < num.GetLength(0); i++)
{
    for(int j = 0; j < num.GetLength(1); j++)
    {
        num[i, j] = new Random().Next(1, 10);
        Console.Write($"{num[i, j]} ");
    }
    Console.WriteLine();
}
