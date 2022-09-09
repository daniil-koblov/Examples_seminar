// Задача на разворот массива
Console.Clear();
/* int [,] arr = new int [3,4];

arr.GetLength(0);
arr.GetLength(1); */

void Reverse(int[] a)
{
    for(int i = 0; i < a.Length; i++)
    {
        int random = new Random().Next(1, 100);
        a[i] = random;
        Console.Write($"{a[i]} ");
    }
    Console.WriteLine();
    int rev = 0;
    if(a.Length % 2 == 0)
    {
        for(int i = 0; i < a.Length / 2; i++)
        {
            rev = a[a.Length - i - 1];
            a[a.Length - i - 1] = a[i];
            a[i] = rev;
        }
        for(int i = 0; i < a.Length; i++) 
            Console.Write($"{a[i]} ");
    }
    else
    {
        for(int i = 0; i <= a.Length / 2; i++)
        {
            if(i < a.Length / 2)
            {
                rev = a[a.Length - i - 1];
                a[a.Length - i - 1] = a[i];
                a[i] = rev;
            }
            else a[i] += 0;           
        }
        for(int i = 0; i < a.Length; i++)
            Console.Write($"{a[i]} ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите длинну массива");
int len = Convert.ToInt32(Console.ReadLine());
int[] array = new int [len];
Reverse(array);
