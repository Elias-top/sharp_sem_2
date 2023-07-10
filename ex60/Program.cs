﻿Console.Clear();
int user_first_size = GetNumberFromUser ("Введите размер первого массива: ", "Ошибка ввода");
int user_second_size = GetNumberFromUser ("Введите размер массивов(-а) входящего в первый массив: ", "Ошибка ввода");
int user_third_size = GetNumberFromUser ("Введите размер массива массивов(-а): ", "Ошибка ввода");

int[,,] user_array = GetUserNumArray(user_first_size, user_second_size, user_third_size);
Console.WriteLine("Массив:");
PrintMultiArrayToConsole(user_array);

static void PrintMultiArrayToConsole(int[,,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(1); k++)
            {
                Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

static int CheckExistNumArray (int [,,]temp_array, int num)
{
    for(int i = 0; i < temp_array.GetLength(0); i++)
    {
        for(int j = 0; j < temp_array.GetLength(1); j++)
        {
            for(int k = 0; k < temp_array.GetLength(2); k++)
            {
                if(temp_array[i, j, k] == num)
                    return -1;
            }
        }
    }
    return num;
}
static int [,,] GetUserNumArray (int first_size, int second_size, int third_size)
{
    int [,,]user_array = new int [first_size, second_size, third_size];
    int temp_res = -1;
    int num_rand = 0;
    for(int i = 0; i < user_array.GetLength(0); i++)
    {
        for(int j = 0; j < user_array.GetLength(1); j++)
        {
            for(int k = 0; k < user_array.GetLength(2); k++)
            {
                while (temp_res == -1)
                {
                    num_rand = new Random().Next(10, 100);
                    temp_res = CheckExistNumArray(user_array, num_rand);
                }
                user_array[i, j, k] = num_rand;
                temp_res = -1;
            }
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
