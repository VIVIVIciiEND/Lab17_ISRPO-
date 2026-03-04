// See https://aka.ms/new-console-template for more information
Console.WriteLine("определение оценки по баллам ");
Console.Write("введите количество баллов");
int score = Convert.ToInt32(Console.ReadLine());
string grade ;
int numricGrade;
if ( score >= 91 && score <= 100)
{
    grade = "5";
    numricGrade = 5 ;
}
else if(score >= 71 && score <= 90)
{
    grade = "4";
    numricGrade = 4 ;
}
else if(score >=51  && score <= 70)
{
    grade ="3" ;
    numricGrade = 3 ;
}
else if(score >= 0 && score <= 50)
{
    grade ="2" ;
    numricGrade = 2 ;
}
else
{
    grade = "Ошибка";
    numricGrade = 0;
    Console.WriteLine("ошибка баллы должны быть вуше 0");
    return;

}
Console.WriteLine("результат");
Console.WriteLine($"баллы {score}");
Console.WriteLine($"оценка {grade}({numricGrade})");