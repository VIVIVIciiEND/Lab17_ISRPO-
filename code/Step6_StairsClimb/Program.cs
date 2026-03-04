// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

Console.WriteLine("подьем по лестнице");
Console.Write("на какой этаж нужно подняться");
int targetFloor = Convert.ToInt32(Console.ReadLine());
int currentFloor = 1 ;
Console.WriteLine("начинайем подъем");
while (currentFloor < targetFloor)
{
    currentFloor++;
    Console.WriteLine($"поднялись на {currentFloor} этаж");

}
Console.WriteLine($"вы достигли {targetFloor} этажа");
Console.WriteLine("конец программы");