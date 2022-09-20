//Задача 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();

Console.Write("Введите число ");
int number = Math.Abs(int.Parse(Console.ReadLine()));
if (number > 99)
{
    while (number > 999)
    {
        number = number / 10;
    }
    int result = number % 10;
    Console.WriteLine($"Третья цифра числа - {result}");
}
else
{
        Console.WriteLine("Третьей цифры нет!"); 
}