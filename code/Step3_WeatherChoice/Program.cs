// See https://aka.ms/new-console-template for more information
Console.WriteLine("Выбор одежды по погоде");
Console.WriteLine("Введите текущую температурку (℃)");

int temperature = Convert.ToInt32(Console.ReadLine());
if ( temperature >= 20)
{
    Console.WriteLine("Наденьте легкую одежду");
}
else
{
    Console.WriteLine("Надеть теплую одежду");
}
Console.WriteLine("Хорошего дня");