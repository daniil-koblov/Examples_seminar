Console.Clear();

void Mult(int a)
{
    if(a >= 0)
    {
        int sum = 1;
        for(int i = 1; i <= a; i++)
        {
            sum = sum * i;
        }
        Console.WriteLine(sum);
    }
    else
    {
        Console.WriteLine("Вы ввели число неверно");
    }
   
}       

Console.WriteLine("Введите целое число А: ");
int A = Convert.ToInt32(Console.ReadLine());
Mult(A);