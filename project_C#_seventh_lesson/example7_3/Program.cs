// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
Console.Clear();

int m = new Random().Next(1, 10);
int n = new Random().Next(1, 10);
int[,] num = new int [m,n];
for(int i = 0; i < num.GetLength(0); i++)
{
    for(int j = 0; j < num.GetLength(1); j++)
    {
        num[i, j] = new Random().Next(1, 10);
        if(i % 2 == 0 && j % 2 == 0) num[i, j] *= num[i, j];
        Console.Write($"{num[i, j]} ");
    }
    Console.WriteLine();
}