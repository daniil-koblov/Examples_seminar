// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5
Console.Clear();

int m = new Random().Next(1, 10);
int n = new Random().Next(1, 10);
int[,] num = new int [m,n];
for(int i = 0; i < num.GetLength(0); i++)
{
    for(int j = 0; j < num.GetLength(1); j++)
    {
        num[i, j] = i + j;
        Console.Write($"{num[i, j]} ");
    }
    Console.WriteLine();
}