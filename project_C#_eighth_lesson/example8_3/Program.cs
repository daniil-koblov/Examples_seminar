// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
Console.Clear();

int m = new Random().Next(1, 4);
int n = new Random().Next(1, 4);
int[,] number = new int[m, n];
void FillArray(int[,] num)
{
    for (int i = 0; i < num.GetLength(0); i++)
    {
        for (int j = 0; j < num.GetLength(1); j++)
        {
            num[i, j] = new Random().Next(1, 10);
        }
    }
}
void PrintArray(int[,] num)
{
    for (int i = 0; i < num.GetLength(0); i++)
    {
        for (int j = 0; j < num.GetLength(1); j++)
        {
            Console.Write($" |{num[i, j]}| ");
        }
        Console.WriteLine();
    }
}
FillArray(number);

PrintArray(number);

int[] array = new int[10];
for (int strings = 0; strings < number.GetLength(0); strings++)
{
    for (int table = 0; table < number.GetLength(1); table++)
    {
        array[number[strings, table]] = array[number[strings, table]] + 1;
    }
}
for(int i = 0; i < 10;  i++)
{
    Console.WriteLine($"Количество чисел {i} : " + array[i]);
}

// 2 вариант
Console.WriteLine();
Console.WriteLine("2 вариант");

int m2 = new Random().Next(1, 4);
int n2 = new Random().Next(1, 4);
int[,] num = new int[m2, n2];
int max = 0;
for (int i = 0; i < num.GetLength(0); i++)
{
    for (int j = 0; j < num.GetLength(1); j++)
    {
        num[i, j] = new Random().Next(1, 10);
        Console.Write($"{num[i, j]} ");
        if (num[i, j] > max) max = num[i, j];
    }
    Console.WriteLine();
}

for (int z = 0; z <= max; z++)
{
    int count = 0;
    for (int i = 0; i < num.GetLength(0); i++)
    {
        for (int j = 0; j < num.GetLength(1); j++)
        {
            if (num[i, j] == z)
            {
                count++;
            }
        }
    }
    if (count != 0) Console.WriteLine($"{z} - {count} раз");
}