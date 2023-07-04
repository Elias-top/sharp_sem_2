Console.Clear();
int row_count_user = GetNumberFromUser ("Введите количество строк: ", "Ошибка ввода");
int colum_count_user = GetNumberFromUser ("Введите количество столбцов: ", "Ошибка ввода");

float[,] user_array = GetUserNumArray(row_count_user, colum_count_user);
PrintDoubleArrayToConsole(user_array);

static void PrintDoubleArrayToConsole(float[,] array)
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

static float [,] GetUserNumArray (int count_row, int count_colum)
{
    float [,]user_array = new float [count_row, count_colum];
    for(int i = 0; i < user_array.GetLength(0); i++)
    {
        for(int j = 0; j < user_array.GetLength(1); j++)
        {
            user_array[i, j] = (float)Math.Round(new Random().NextSingle(), 2);
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