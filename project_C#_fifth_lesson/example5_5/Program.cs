// See https://aka.ms/new-console-template for more information
Console.Clear();

void FillArray(int[] a)
{
    for(int i = 0; i < a.Length; i++)
    {
        int random = new Random().Next(1, 124);
        a[i] = random;
        Console.Write($"{a[i]} ");
    }
    Console.WriteLine();
    int count = 0;
    for(int i = 0; i < a.Length; i++)
    {
        if(a[i] > 9 && a[i] < 100) count++;
        else count+=0;
    }
    Console.WriteLine($"Кол-во элементов в промежутке от 10 до 99 равно {count}");
}

Console.WriteLine("Введите длинну массива");
int len = Convert.ToInt32(Console.ReadLine());
int[] array = new int [len];
FillArray(array);