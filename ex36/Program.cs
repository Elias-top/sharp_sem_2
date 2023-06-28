Console.Clear();
int min_value = GetNumberFromUser ("Введите минимальное значение элементов массива: ", "Ошибка ввода");;
int max_value = GetNumberFromUser ("Введите максимальное значение элементов массива: ", "Ошибка ввода");;

///Main///
int size_array = GetNumberFromUser ("Введите число элементов массива: ", "Ошибка ввода");
int[] num_array = GetRandomArray(size_array, min_value, max_value);
PrintConsoleOddIndexNumArray(num_array);
////////

static void PrintConsoleOddIndexNumArray(int[] user_num)
{
    int temp_index = 0;
    int temp_sum = 0;

    Console.Write($"Сумма чисел стоящих на нечетных индексах в массиве: ");
    Console.Write("[");
    while (temp_index < user_num.Length)
    {
        if(temp_index % 2 != 0)
        {
            temp_sum += user_num[temp_index];
        }
        if(user_num.Length != temp_index + 1)
            Console.Write($"{user_num[temp_index]},");
        else
            Console.Write($"{user_num[temp_index]}");
        temp_index ++;
    }
    Console.Write("] ");
    Console.WriteLine($"= {temp_sum}");

}

static int [] GetRandomArray (int size_array, int min_value , int max_value)
{
    int temp_index = 0;
    int [] res = new int [size_array];
    while(temp_index < res.Length)
    {
        res[temp_index] = new Random().Next(min_value, max_value + 1);
        temp_index ++;
    }
    return res;
}

static int GetNumberFromUser (String msg, String msg_error)
{
    while(true)
    {
        Console.Write(msg);
        if(int.TryParse(Console.ReadLine(), out int user_number))
            return user_number;
        Console.Write(msg_error);
    }
}