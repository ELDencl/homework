// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.Write("Введите цифру соответствующую дню недели: ");
int num = int.Parse(Console.ReadLine()!);


// if (num == 1)
// {
//     Console.WriteLine("нет");
// }
// if (num == 2)
// {
//     Console.WriteLine("нет");
// }
// if (num == 3)
// {
//     Console.WriteLine("нет");
// }
// if (num == 4)
// {
//     Console.WriteLine("нет");
// }
// if (num == 5)
// {
//     Console.WriteLine("нет");
// }
// if (num == 6)
// {
//     Console.WriteLine("да");
// }
// if (num == 7)
// {
//     Console.WriteLine("да");
// }

if (num < 6)
{
    Console.WriteLine("Этот день рабочий");
}
else if (num <= 7)
{
    Console.WriteLine("Этот день выходной");
}
else
{
    Console.WriteLine("Не знаю такого дня недели");
}