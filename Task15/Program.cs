//Задача 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет,
//является ли этот день выходным.
Console.Clear();

Console.Write("Введите цифру дня недели ");
int number = int.Parse(Console.ReadLine());
if (number > 0 && number < 8)
{
    if (number < 6)
    {
        Console.WriteLine("Выходной день? - Нет!");
    }
    else
    {
        Console.WriteLine("Выходной день? - Да!");
    }
}
else
{
    Console.WriteLine("Неверное значение!"); 
}