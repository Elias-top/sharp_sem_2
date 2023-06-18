// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear();
int user_num_day = 0;
int []free_days = {6, 7};

while(true)
{
    Console.Write("Введите число равное дню недели: ");
    bool result = int.TryParse(Console.ReadLine(), out user_num_day);

    if((user_num_day > 7 || user_num_day < 1) || result == false)
    {
        Console.WriteLine($"Число не является корректным для дня недели. Попробуйте заново!");
    }
    else
    {
        if(user_num_day == free_days[0] || user_num_day == free_days[1])
            Console.WriteLine($"День недели под цифрой {user_num_day} является выходным");
        else
            Console.WriteLine($"День недели под цифрой {user_num_day} не является выходным");
        break;
    }
}