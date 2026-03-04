// See https://aka.ms/new-console-template for more information
Console.WriteLine("калькулятор чаевых");
Console.Write("Введите сумму счета (руб)");
double bill = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите процент чаевых ( например 10)");
double tipPercent = Convert.ToDouble(Console.ReadLine());
double tipAmount = bill * ( tipPercent / 100);
double totalAmount = bill + tipAmount;
Console.WriteLine("\nРезультат");
Console.WriteLine($"сумма света {bill} руб");
Console.WriteLine($"чаевые ({tipPercent} {tipAmount})");
Console.WriteLine($"итог к оплате {totalAmount}");
Console.WriteLine("спасибо за использование калькулятора");
