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
    if(a.Length % 2 == 0)
    {
        for(int i = 0; i < a.Length / 2; i++)
        Console.Write($"{a[i] * a[a.Length - i - 1]} ");
    }
    else
    {
        for(int i = 0; i <= a.Length / 2; i++)
        {
            if(i < a.Length / 2) a[i] = a[i] * a[a.Length - i - 1];
            else a[i] += 0;
            Console.Write($"{a[i]} ");
        }
    }
    Console.WriteLine();
}
Console.WriteLine("Введите длинну массива");
int len = Convert.ToInt32(Console.ReadLine());
int[] array = new int [len];
FillArray(array);