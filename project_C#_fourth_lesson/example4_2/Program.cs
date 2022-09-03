Console.Clear();
void Sum(int a)
{
    string num = Convert.ToString(a);
    int len = num.Length;
    Console.WriteLine(len);
}

Console.WriteLine("Введите целое число А: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Sum(num1);

Console.WriteLine("Введите целое число B: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Sum(num2);

Console.WriteLine("Введите целое число C: ");
int num3 = Convert.ToInt32(Console.ReadLine());
Sum(num3);