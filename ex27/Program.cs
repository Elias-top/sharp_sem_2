Console.Clear();

int user_num = 0;

///Main///
InitUserNumPow(ref user_num);

PrintConsoleSumOfNum(user_num);
////////

static void InitUserNumPow(ref int user_num)
{
    while(true)
    {
        try
        {
            Console.WriteLine("Введите число: ");
            user_num = int.Parse(Console.ReadLine() ?? "");
            return;
        }
        catch(Exception exc)
        {
            Console.WriteLine($"Ошибка ввода: {exc.Message}");
        }
    }
}
static void PrintConsoleSumOfNum(int user_num)
{
    int temp_num = user_num;
    int temp_sum = 0;

    while (user_num > 0)
    {
        temp_sum += user_num % 10;
        user_num /= 10;
    }
    Console.WriteLine($"Сумма цифр числа {temp_num} = {temp_sum}");
}