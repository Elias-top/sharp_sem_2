Console.Clear();

int count_num_array = 5;
int[] num_array = new int[count_num_array];
int min_value = 100;
int max_value = 999;
int num_value = 4;
///Main///
InitRandomArray(num_array, min_value, max_value);

PrintConsoleEvenNumArray(num_array);
////////

static void InitRandomArray(int[] user_num_array, int user_min_value, int user_max_value)
{
    int temp_index = 0;

    while(true)
    {
        try
        {
            while(temp_index < user_num_array.Length)
            {
                user_num_array[temp_index] = new Random().Next(user_min_value, user_max_value + 1);
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
static void PrintConsoleEvenNumArray(int[] user_num)
{
    int temp_index = 0;
    int temp_count_even = 0;

    Console.Write($"Количество четных чисел в массиве: ");
    Console.Write("[");
    while (temp_index < user_num.Length)
    {
        if(user_num[temp_index] % 2 == 0)
        {
            temp_count_even ++;
        }
        if(user_num.Length != temp_index + 1)
            Console.Write($"{user_num[temp_index]},");
        else
            Console.Write($"{user_num[temp_index]}");
        temp_index ++;
    }
    Console.Write("] ");
    Console.WriteLine($"= {temp_count_even}");

}