Console.Clear();
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int count = 1;

while(count <= num)
{
    Console.Write($"{count*count} ");
    count++;
}
Console.WriteLine();