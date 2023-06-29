Console.Clear();
float min_value = GetNumberFromUser ("Введите минимальное значение элементов массива: ", "Ошибка ввода");;
float max_value = GetNumberFromUser ("Введите максимальное значение элементов массива: ", "Ошибка ввода");;

///Main///
int size_array = (int) GetNumberFromUser ("Введите число элементов массива: ", "Ошибка ввода");
float[] num_array = GetRandomArray(size_array, min_value, max_value);
float diff_array_num = GetDiffMaxMinNumArray(num_array);
PrintToConsole($"Разница между самым большим и самым маленьким значением в массиве = {diff_array_num}");
//PrintConsoleSumOddIndexNumArray(num_array);
////////

static float GetDiffMaxMinNumArray(float[] user_num)
{
    int temp_index = 0;
    float max = user_num[0];
    float min = user_num[0];

    Console.Write($"В массиве: ");
    Console.Write("[");
    while (temp_index < user_num.Length)
    {
        if(max < user_num[temp_index])
        {
            max = user_num[temp_index];
        }

        if(min > user_num[temp_index])
        {
            min = user_num[temp_index];
        }
  
        if(user_num.Length != temp_index + 1)
            Console.Write($"{user_num[temp_index]}; ");
        else
            Console.Write($"{user_num[temp_index]}");
        temp_index ++;
    }
    Console.WriteLine("] ");
    Console.WriteLine($"Минимальное значение = {min}");
    Console.WriteLine($"Максимальное значение = {max}");
    return (float) Math.Round((max - min), 2);
}

static void PrintToConsole(String user_string)
{
    Console.WriteLine(user_string);
}

static float [] GetRandomArray (int size_array, float min_value , float max_value)
{
    int temp_index = 0;
    float temp_num = 0;
    float [] res = new float [size_array];
    while(temp_index < res.Length)
    {
         temp_num = new Random().NextSingle();
         res[temp_index] = (float) Math.Round(temp_num * (max_value - min_value) + min_value, 2);
        temp_index ++;
    }
    return res;
}

static float GetNumberFromUser (String msg, String msg_error)
{
    while(true)
    {
        Console.Write(msg);
        if(float.TryParse(Console.ReadLine(), out float user_number))
            return user_number;
        Console.Write(msg_error);
    }
}