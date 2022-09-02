Console.Clear();
Console.Write("Введите многозначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int temp = 10;
bool isTrue = true;
while(num > 0)
{
    if(temp < num % 10)
    {   
        isTrue = false;
    }
    temp = num % 10;
    num /= 10;
}
if(isTrue)
Console.WriteLine("Число упорядоченное");
else
Console.WriteLine("Число неупорядоченное");