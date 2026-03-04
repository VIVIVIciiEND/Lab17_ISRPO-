// See https://aka.ms/new-console-template for more information
Console.WriteLine("Выбор одежды на учебу или дома");
Console.WriteLine("Введите место положение");

int temperature = Convert.ToString(Console.ReadLine());
if ( temperature == "дома")
{
    Console.WriteLine("Наденьте домашнюю одежду");
}
else
{
    Console.WriteLine("Надеть школьную форму");
}
Console.WriteLine("Хорошего дня");