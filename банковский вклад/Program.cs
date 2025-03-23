// See https://aka.ms/new-console-template for more information
Console.WriteLine("Выберете вклад:\n 1) На 1 год под 7% годовых\n 2) На 3 года под 8% годовых\n 3) На 5 лет под 10% годовых\n");
int option = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Какую сумму Вы хотите положить (в рублях)?");
double money = double.Parse(Console.ReadLine());
if (option == 1) Console.WriteLine($"Прибыль по Вашему вкладу составит:{(money * 7 * (1)) / 100} рублей");
else if (option == 2) Console.WriteLine($"Прибыль по Вашему вкладу составит:{(money * 8 * (3)) / 100} рублей");
else Console.WriteLine($"Прибыль по Вашему вкладу составит:{(money * 10 * (5)) / 100} рублей");
