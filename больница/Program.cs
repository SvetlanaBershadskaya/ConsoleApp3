// See https://aka.ms/new-console-template for more information
Console.Write("Какой ты в очереди по счету?");
int number = Convert.ToInt32(Console.ReadLine());
int time = -20;
for (int a = 1; a <= number; a += 2)
{
    time += 20;
}

if (time >= 60 & time<540)
{
            int hour = time / 60;
            int min = time - 60 * hour;
            Console.WriteLine($"Осталось ждать {hour} часа {min} минут");
}
        else if (time>540) Console.WriteLine("Идите домой");
        else Console.WriteLine($"Осталось ждать {time} минут");