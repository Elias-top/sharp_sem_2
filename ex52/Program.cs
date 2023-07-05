Console.Clear();
int row_count_user = GetNumberFromUser ("Введите количество строк: ", "Ошибка ввода");
int colum_count_user = GetNumberFromUser ("Введите количество столбцов: ", "Ошибка ввода");
float []result_average_array = new float [colum_count_user];

int[,] user_array = GetUserNumArray(row_count_user, colum_count_user);
PrintMultiArrayToConsole(user_array);
GetColumsAverage(user_array, result_average_array);
PrintResultAverageArrayToConsole(result_average_array);

static void GetColumsAverage(int[,] array, float []result_array)
{
    int temp_average_result = 0;
    float temp_sum = 0;

    for(int j = 0; j < array.GetLength(1); j++)
    {
        for(int i = 0; i < array.GetLength(0); i++)
        {
            temp_sum += array[i,j];
        }
        result_array[j] = temp_sum / array.GetLength(0);
        temp_sum = 0;
    }
}
static void PrintMultiArrayToConsole(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

static void PrintResultAverageArrayToConsole(float[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Среднее арефметическое столбца {i} = {Math.Round(array[i], 2)}");
    }
}

static int [,] GetUserNumArray (int count_row, int count_colum)
{
    int [,]user_array = new int [count_row, count_colum];
    for(int i = 0; i < user_array.GetLength(0); i++)
    {
        for(int j = 0; j < user_array.GetLength(1); j++)
        {
            user_array[i, j] = new Random().Next(1, 100);
        }
    }

    return user_array;
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
