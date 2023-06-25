Console.Clear();

int user_num = 0;
int user_pow = 0;

///Main///
InitUserNumPow(ref user_num, ref user_pow);

PrintConsolePowUserNum(user_num, user_pow);
////////

static void InitUserNumPow(ref int user_num, ref int user_pow)
{
    while(true)
    {
        try
        {
            Console.WriteLine("Введите число: ");
            user_num = int.Parse(Console.ReadLine() ?? "");
            Console.WriteLine("Введите степень числа: ");
            user_pow = int.Parse(Console.ReadLine() ?? "");
            return;
        }
        catch(Exception exc)
        {
            Console.WriteLine($"Ошибка ввода: {exc.Message}");
        }
    }
}
static void PrintConsolePowUserNum(int user_num, int pow)
{
    Console.Write($"Результат возведение числа {user_num} в степень {pow} = {Math.Pow(user_num, pow)} ");
}