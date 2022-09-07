// See https://aka.ms/new-console-template for more information
Console.Clear();

void FillArray(int[] a)
{
    for(int i = 0; i < a.Length; i++)
    {
        int random = new Random().Next(-2147483648, 2147483647); 
        a[i] = random;
        Console.Write($"{a[i]} ");
    }
    Console.WriteLine();
}
void ReplaceArray(int[] a)
{
    for(int i = 0; i < a.Length; i++)
    {
        a[i] *= -1;
        Console.Write($"{a[i]} ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите длинну массива");
int len = Convert.ToInt32(Console.ReadLine());
int[] array = new int [len];
FillArray(array);
ReplaceArray(array);