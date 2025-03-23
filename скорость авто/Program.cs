// See https://aka.ms/new-console-template for more information
Console.WriteLine("С какой скоростью Вы едете?");
double speed = double.Parse(Console.ReadLine());
if (speed <= 90) Console.WriteLine("Скорость автомобиля допустима на данном участке");
else if (speed>90 & speed<= 90+40) Console.WriteLine("Штраф - 500 рублей");
else if (speed > 90 + 40 & speed <= 90 + 60) Console.WriteLine("Штраф - 1500 рублей");
else if (speed > 90 + 60 & speed <= 90 + 80) Console.WriteLine("Штраф - 2500 рублей или лишение прав на 4 месяца");
else Console.WriteLine("Штраф - 5000 рублей или лишение прав на полгода");