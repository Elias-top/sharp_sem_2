Console.Clear();
int row_count_user = GetNumberFromUser ("Введите количество строк: ", "Ошибка ввода");
int colum_count_user = GetNumberFromUser ("Введите количество столбцов: ", "Ошибка ввода");

int[,] user_array = GetUserNumArray(row_count_user, colum_count_user);
Console.WriteLine("Не отсортированный массив:");
PrintMultiArrayToConsole(user_array);
SortRowArray(user_array);
Console.WriteLine("Отсортированный массив:");
PrintMultiArrayToConsole(user_array);

static void SortRowArray(int[,] array)
{
    int temp = 0;
    int temp_index = 0;
    int s = -1;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        while(temp_index != array.GetLength(1))
        {
            for(int j = 0; j < array.GetLength(1) - 1; j++)
            {
                if (array[i, j]*s > array[i, j + 1]*s)
                {
                    temp = array[i, j + 1];
                    array[i, j + 1] = array[i, j];
                    array[i, j] = temp;
                }
            }
            temp_index ++;
        }
        temp_index = 0;
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
