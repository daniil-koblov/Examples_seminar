Console.Clear();
Console.Write("Введите номер четверти");
int num = Convert.ToInt32(Console.ReadLine());

if ((num > 0) && (num < 5))
{
    if (num == 1)
    {
      Console.Write("Диапазон координат x > 0 y > 0");  
    }
    else if (num == 2)
    {
      Console.Write("Диапазон координат x > 0 y < 0");  
    }
    else if (num == 3)
    {
      Console.Write("Диапазон координат x < 0 y < 0");  
    }
    else
    {
      Console.Write("Диапазон координат x < 0 y > 0");  
    }
}
else
{
    Console.Write("Вы ввели не правильный номер четверти (нужно от 1 до 4)");
}