Console.Clear();

void FillArray(int[] a)
{
    int length = a.Length;
    if(length > 0)
    {
        for(int i = 0; i < a.Length; i++)
            {
                int random = new Random().Next(0, 2); 
                a[i] = random;
                Console.Write($"{a[i]} ");
            }
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine("Длинна должна быть равна 1 или больше.");
    }
}

Console.WriteLine("Введите длинну массива");
int len = Convert.ToInt32(Console.ReadLine());
int[] array = new int [len];
FillArray(array);