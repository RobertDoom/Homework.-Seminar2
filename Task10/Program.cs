//Задача 10. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();

Console.Write("Введите трехзначное число ");
int number = int.Parse(Console.ReadLine());

if (99 < number && number < 1000)
{
    int result = (number / 10) % 10;
    Console.WriteLine($"Вторая цифра числа - {result}"); 
}
else if (-1000 < number && number < -99)
{
    int result = (-number / 10) % 10;
    Console.WriteLine($"Вторая цифра числа - {result}");
}    
else
{
   Console.WriteLine("Неверное число!"); 
}