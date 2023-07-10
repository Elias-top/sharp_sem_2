Console.Clear();

int row_count_user_1 = 0;
int colum_count_user_1 = 0; 
int row_count_user_2 = 0;
int colum_count_user_2 = 0; 

GetMatrMultiplRowColum(ref row_count_user_1, ref colum_count_user_1, ref row_count_user_2, ref colum_count_user_2);

int[,] user_array_1 = GetUserNumArray(row_count_user_1, colum_count_user_1);
int[,] user_array_2 = GetUserNumArray(row_count_user_2, colum_count_user_2);

Console.WriteLine("Массив 1:");
PrintMultiArrayToConsole(user_array_1);

Console.WriteLine("Массив 2:");
PrintMultiArrayToConsole(user_array_2);

int[,] result = MultiplicationArray(user_array_1, user_array_2);

Console.WriteLine("Результат умножения:");
PrintMultiArrayToConsole(result);


static int[,] MultiplicationArray(int[,] array_1, int[,] array_2)
{
    int temp_max_sum = 0;
    int temp_sum = 0;

    int [,]user_array = new int [array_1.GetLength(0), array_2.GetLength(1)];

    for (var i = 0; i < array_1.GetLength(0); i++)
    {
        for (var j = 0; j < array_2.GetLength(1); j++)
        {
            user_array[i, j] = 0;

            for (var k = 0; k < array_1.GetLength(1); k++)
            {
                user_array[i, j] += array_1[i, k] * array_2[k, j];
            }
        }
    }

    return user_array;
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

void GetMatrMultiplRowColum(ref int count_row_1, ref int count_colum_1, ref int count_row_2, ref int count_colum_2)
{
    int temp_row_1 = 0;
    int temp_colum_1 = 0;
    int temp_row_2 = 0;
    int temp_colum_2 = 0;
    while(true)
    {
        temp_row_1 = GetNumberFromUser ("Введите количество строк первой матрицы: ", "Ошибка ввода");
        temp_colum_1 = GetNumberFromUser ("Введите количество столбцов первой матрицы: ", "Ошибка ввода");

        temp_row_2 = GetNumberFromUser ("Введите количество строк второй матрицы: ", "Ошибка ввода");
        temp_colum_2 = GetNumberFromUser ("Введите количество столбцов второй матрицы: ", "Ошибка ввода");

        if(temp_colum_1 != temp_row_2)
            Console.WriteLine("Необходимо, чтобы кол-во столбцов первой матрицы совпадало с кол-вом строк второй матрицы");
        else
        {
            count_row_1 = temp_row_1;
            count_colum_1 = temp_colum_1;
            count_row_2 = temp_row_2;
            count_colum_2 = temp_colum_2;
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
            user_array[i, j] = new Random().Next(1, 10);
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
