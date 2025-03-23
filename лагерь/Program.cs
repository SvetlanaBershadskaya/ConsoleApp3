// See https://aka.ms/new-console-template for more information
Console.Write("Какой ты по счету в шеренге?");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0) Console.WriteLine("Твой номер 2");
else Console.WriteLine("Твой номер 1");