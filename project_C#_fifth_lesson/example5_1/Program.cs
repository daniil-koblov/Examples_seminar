// See https://aka.ms/new-console-template for more information
Console.Clear();

string str1 = "Hello";
string str2 = "world";

// string str3 = string.Concat(str1, str2, "####");

int[] values = new int[] {1, 2, 3, 4, 5};
string str3 = string.Join("*", values);

Console.WriteLine(str3);