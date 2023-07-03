Console.Clear();
float count_user = GetNumberFromUser ("Введите количество элементов, которых необходимо ввести пользователю: ", "Ошибка ввода");

float[] user_array = GetUserNumArray((int)count_user);
int posit_count_from_array = GetCountPositiveNumArray(user_array);
PrintToConsole($"В массиве [{string.Join("," , user_array)}] количество положительных значений = {posit_count_from_array}");

static int GetCountPositiveNumArray(float[] user_num)
{
    int temp_index = 0;
    int positive_count = 0;

    while (temp_index < user_num.Length)
    {
        if(temp_index < user_num.Length && user_num[temp_index] > 0)
        {
            positive_count ++;
        }

        temp_index ++;
    }

    return positive_count;
}

static void PrintToConsole(String user_string)
{
    Console.WriteLine(user_string);
}

static float [] GetUserNumArray (int size_array)
{
    int temp_index = 0;
    float temp_num = 0;
    float []user_array = new float [size_array];
    while(temp_index < user_array.Length)
    {
        user_array[temp_index] = GetNumberFromUser ($"Введите {temp_index + 1} элемент массива: ", "Ошибка ввода");
        temp_index ++;
    }
    return user_array;
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