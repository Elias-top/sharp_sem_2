Console.Clear();

int user_num = 0;

///Main///
InitUserNum(ref user_num);

if(UserNumIsPolindrom(user_num) == true)
    Console.WriteLine($"Число {user_num} является палиндромом");
else
    Console.WriteLine($"Число {user_num} не является палиндромом");
///////

static void InitUserNum(ref int user_num)
{
    try
    {
        Console.WriteLine("Введите число: ");
        user_num = int.Parse(Console.ReadLine() ?? "");

        if(((user_num / 10000) > 9) || ((user_num / 10000) == 0))
            throw new Exception("Число не пятизначное");
    }
    catch(Exception exc)
    {
        Console.WriteLine($"Ошибка ввода: {exc.Message}");
    }
}
static bool UserNumIsPolindrom(int user_num)
{
    int[] num_array = new int[4];

    num_array[0] = user_num / 10000;
    num_array[1] = (user_num / 1000) % 10;
    num_array[2] = (user_num / 10) % 10;
    num_array[3] = user_num % 10;

    if(num_array[1] == num_array[2] && num_array[0] == num_array[3])
        return true;
    else
        return false;
}