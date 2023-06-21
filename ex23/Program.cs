Console.Clear();

int user_num = 0;

///Main///
InitUserNum(ref user_num);

PrintConsoleCubeTable(user_num);
////////

static void InitUserNum(ref int user_num)
{
    try
    {
        Console.WriteLine("Введите число: ");
        user_num = int.Parse(Console.ReadLine() ?? "");
    }
    catch(Exception exc)
    {
        Console.WriteLine($"Ошибка ввода: {exc.Message}");
    }
}
static void PrintConsoleCubeTable(int user_num)
{
    int temp_index = 1;
    while(temp_index <= user_num)
    {
        Console.Write($"{Math.Pow(temp_index, 3)}, ");
        temp_index++;
    }
}