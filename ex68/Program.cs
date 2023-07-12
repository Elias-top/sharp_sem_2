Console.Clear();
int user_num_1 = 0;
int user_num_2 = 0;

user_num_1 = GetNumberFromUser("Задайте число N", "Ошибка ввода");
user_num_2 = GetNumberFromUser("Задайте число M", "Ошибка ввода");

Console.WriteLine($"A({user_num_1},{user_num_2}) = {Akkerman(user_num_1, user_num_2)}");


static int Akkerman(int num_1, int num_2)
{
    if (num_1 == 0) 
        return num_2 + 1;
    if (num_1 > 0 && num_2 == 0) 
        return Akkerman(num_1 - 1, 1);
    else 
        return Akkerman(num_1 - 1, Akkerman(num_1, num_2 - 1));
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