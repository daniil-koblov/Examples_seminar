// See https://aka.ms/new-console-template for more information
Console.Clear();

void FillArray(int[] a)
{
    for(int i = 0; i < a.Length; i++)
    {
        int random = new Random().Next(-20, 20); 
        a[i] = random;
        Console.Write($"{a[i]} ");
    }
    Console.WriteLine();
    Console.WriteLine("Введите искомое число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int b = 0;
    for(int i = 0; i < a.Length; i++)
    {
        if(num == a[i] | num == -a[i]) b++;
        else b += 0;
    }
    if(b > 0) Console.WriteLine("Число есть в массиве.");
    else Console.WriteLine("Числа нет в массиве.");
}

Console.WriteLine("Введите длинну массива");
int len = Convert.ToInt32(Console.ReadLine());
int[] array = new int [len];
FillArray(array);