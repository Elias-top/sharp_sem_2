//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Clear();
int user_num = 0;
int temp_start_num = 0;

Console.Write("Введите число: ");
user_num = int.Parse(Console.ReadLine() ?? "");

if(user_num < 100)
{
    Console.WriteLine($"Число {user_num} не имеет 3 цифру");
}
else
{
    temp_start_num = user_num;
    
    while(user_num > 999)
    {
        user_num /= 10;
    }

    Console.WriteLine($"3 цифра числа {temp_start_num} -> {user_num % 10}");
}