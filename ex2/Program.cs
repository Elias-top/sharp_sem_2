//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Clear();
int user_num = 0;

Console.Write("Введите трехзначное число: ");
user_num = int.Parse(Console.ReadLine() ?? "");

if(user_num > 999 || user_num < 100)
{
    Console.WriteLine($"Число {user_num} не является трехзначным");
}
else
{
    Console.WriteLine($"Вторая цифра числа {user_num} -> {(user_num / 10) % 10}");
}