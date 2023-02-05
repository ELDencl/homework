// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Clear();

Console.WriteLine("Введите число: ");
int Num = int.Parse(Console.ReadLine()!);

int n = 1;
int Num2 ;

// здесь проверяем является ли число 3х значным
if (Num / 100 > 0)  
{
    while (Num / n > 999)
    {
        n = n * 10;
    }
    Num2 = (Num / n) % 10;
    Console.WriteLine(Num2);
}
else 
{
    Console.WriteLine("В числе нет третьей цифры");
}