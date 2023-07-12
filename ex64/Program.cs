﻿Console.Clear();
int user_num = 0;

user_num = GetNumberFromUser("Задайте число N", "Ошибка ввода");
PrintNaturalNumArray(user_num);

static int PrintNaturalNumArray(int num)
{
    if(num == 0)
        return 1;

    Console.Write($"{num}, ");

    return PrintNaturalNumArray(num - 1);
}

static int GetNumberFromUser (String msg, String msg_error)
{
    while(true)
    {
        Console.WriteLine(msg);
        if(int.TryParse(Console.ReadLine(), out int user_number))
            return user_number;
        Console.Write(msg_error);
    }
}
