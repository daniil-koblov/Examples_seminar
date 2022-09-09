// See https://aka.ms/new-console-template for more information
Console.Clear();

void Translate(int n1)
{
    int n2 = n1;
    int l = 0;
    while(n1 > 0)
    {
        n1 = n1 / 2;
        l++;
    }
    int[] arr = new int [l];
    int i = 0;
    for(int b = 0; i < arr.Length; n2 /=2)
    {
        b = n2 % 2;
        arr[arr.Length - i - 1] = b;
        i++;
    }
    for(int ind = 0; ind < arr.Length; ind++)
        Console.Write($"{arr[ind]} ");
}
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
Translate(num);