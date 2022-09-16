// **Задача 51:** Задайте двумерный массив. 
// Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
Console.Clear();

int m = new Random().Next(1, 10);
int n = new Random().Next(1, 10);
int[,] num = new int [m,n];
int sum = 0;
for(int i = 0; i < num.GetLength(0); i++)
{
    for(int j = 0; j < num.GetLength(1); j++)
    {
        num[i, j] = new Random().Next(1, 10);
        if(i == j) sum += num[i, j];
        Console.Write($"{num[i, j]} ");
    }
    Console.WriteLine();   
}
Console.WriteLine(sum);