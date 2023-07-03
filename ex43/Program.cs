Console.Clear();
float [] cross_point = new float [2];
float b1 = GetNumberFromUser ("Введите коэффициент b1 первой прямой: ", "Ошибка ввода");
float k1 = GetNumberFromUser ("Введите коэффициент k1 первой прямой: ", "Ошибка ввода");
float b2 = GetNumberFromUser ("Введите коэффициент b2 первой прямой: ", "Ошибка ввода");
float k2 = GetNumberFromUser ("Введите коэффициент k2 первой прямой: ", "Ошибка ввода");
int result = GetPointLineCrossArray(cross_point, b1, k1, b2, k2);

if(result == 1)
    PrintToConsole($"Пересечение прямых в точке = ({string.Join("," , cross_point)})");

static int GetPointLineCrossArray(float [] cross_point_array, float b1, float k1, float b2, float k2)
{
    if(k1 == k2)
    {
        PrintToConsole($"Прямые параллельны");
    }
    else if(k1 == k2 && b1 == b2)
    {
        PrintToConsole($"Прямые совпадают");
    }
    else
    {
        cross_point_array[0] = (b2-b1)/(k1-k2);
        cross_point_array[1] = (k1*(b2-b1))/(k1-k2)+b1;
        return 1;
    }
    return 0;
}

static void PrintToConsole(String user_string)
{
    Console.WriteLine(user_string);
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