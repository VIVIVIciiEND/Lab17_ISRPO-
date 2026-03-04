// See https://aka.ms/new-console-template for more information
Console.WriteLine("таблица умножения");
Console.Write("введите числа для таблицы умножения");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"таблицы умножения для {number}");
for (int i =  1 ; i <= 10 ; i++)
{
    int result = number * i ;
    Console.WriteLine($"{number}*{i} =  {result}");
}
Console.WriteLine("конец программы ");