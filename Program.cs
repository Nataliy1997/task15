// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
Console.Clear();
Console.WriteLine(" Введи цифру: ");
int dayNumber=int.Parse(Console.ReadLine()!);
if (dayNumber==6||dayNumber==7)
{
    Console.Write($"Этот день недели выходной");
}
else if (dayNumber<1||dayNumber>7)
{
    Console.Write("Нет такого дня недели");
}
else
{
    Console.Write("Не выходной");
}
