Console.Clear();

int user_num = 0;
int[] num_array = new int[8];
///Main///
InitUserArray(num_array);

PrintConsoleUserArray(num_array);
////////

static void InitUserArray(int[] user_num_array)
{
    int temp_index = 0;

    while(true)
    {
        try
        {
            while(temp_index < user_num_array.Length)
            {
                Console.WriteLine($"Введите элемент масива №{temp_index}");
                user_num_array[temp_index] = int.Parse(Console.ReadLine() ?? "");
                temp_index ++;
            }
            return;
        }
        catch(Exception exc)
        {
            Console.WriteLine($"Ошибка ввода: {exc.Message}");
        }
    }
}
static void PrintConsoleUserArray(int[] user_num)
{
    int temp_index = 0;
    Console.Write("[");
    while (temp_index < user_num.Length - 1)
    {
        Console.Write($"{user_num[temp_index]},");
        temp_index ++;
    }
    Console.Write($"{user_num[temp_index++]}");
    Console.WriteLine("]");
}