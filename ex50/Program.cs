Console.Clear();
int row_count_user = GetNumberFromUser ("Введите количество строк: ", "Ошибка ввода");
int colum_count_user = GetNumberFromUser ("Введите количество столбцов: ", "Ошибка ввода");
int user_position_row = GetNumberFromUser ("Введите номер строки: ", "Ошибка ввода");
int user_position_colum = GetNumberFromUser ("Введите номер столбца: ", "Ошибка ввода");

int[,] user_array = GetUserNumArray(row_count_user, colum_count_user);
PrintArrayToConsole(user_array);
int result = GetNumArray(user_array, user_position_row, user_position_colum);
if(result == -1)
{
    Console.WriteLine($"Элемента со строкой {user_position_row} и столбцом {user_position_colum} нету");
}
else
{
    Console.WriteLine($"{result}");
}

static int GetNumArray(int[,] array, int position_row, int position_colum)
{
    if(position_row <= (array.GetLength(0) - 1) && position_colum <= (array.GetLength(1) - 1))
    {
        return array[position_row, position_colum];
    }
    return -1;

}
static void PrintArrayToConsole(int[,] array)
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
