Console.Clear();
 int row_count_user = 0;
 int colum_count_user = 0; 

GetRectRowColum(ref row_count_user, ref colum_count_user);

int[,] user_array = GetUserNumArray(row_count_user, colum_count_user);
Console.WriteLine("Массив:");
PrintMultiArrayToConsole(user_array);

int result = GetBiggestSumRowArray(user_array);
Console.WriteLine($"Наибольшая сумма строки в массие = {result} ");


static int GetBiggestSumRowArray(int[,] array)
{
    int temp_max_sum = 0;
    int temp_sum = 0;

    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1) ; j++)
        {
            temp_sum += array[i,j];

            if(temp_sum > temp_max_sum)
            {
                temp_max_sum = temp_sum;
            }
        }
        temp_sum = 0;
    }
    return temp_max_sum;
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

void GetRectRowColum(ref int count_row, ref int count_colum)
{
    int temp_row = 0;
    int temp_colum = 0;
    while(true)
    {
        temp_row = GetNumberFromUser ("Введите количество строк: ", "Ошибка ввода");
        temp_colum = GetNumberFromUser ("Введите количество столбцов: ", "Ошибка ввода");

        if(temp_row == temp_colum)
            Console.WriteLine("Необходимо задать прямоугольный массив (количесво строк не равно количесвту столбцов)");
        else
        {
            count_row = temp_row;
            count_colum = temp_colum;
            break;
        }
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
