// See https://aka.ms/new-console-template for more information
Console.Clear();
int[] arrayRandom = new int[12];

for(int i = 0; i < arrayRandom.Length; i++)
{
    arrayRandom[i] = new Random().Next(-10, 10);
    Console.Write($"{arrayRandom[i]} ");
}

int sumPositive = 0;
int sumNegative = 0;
for(int i = 0; i < arrayRandom.Length; i++)
{
    if(arrayRandom[i] >= 0)
        sumPositive += arrayRandom[i];
    else
        sumNegative += arrayRandom[i];
}
Console.WriteLine();
Console.WriteLine($"Сумма положительных цифр равна {sumPositive}, а отрицательных {sumNegative}");