Console.Clear();

double[] array_cord = new double[6];
double result = 0;
///Main///
InitUserCord(array_cord);
result = PointDst3D(array_cord);
Console.WriteLine(result);
/*if(UserNumIsPolindrom(user_num) == true)
    Console.WriteLine($"Число {user_num} является палиндромом");
else
    Console.WriteLine($"Число {user_num} не является палиндромом");*/
///////

static void InitUserCord(double[] user_array)
{
    int index_temp = 0;
    int point_num = 1;
    try
    {
        while(index_temp < 6)
        {
            Console.WriteLine($"Введите кардинату X{point_num}: ");
            user_array[index_temp++] = int.Parse(Console.ReadLine() ?? "");

            Console.WriteLine($"Введите кардинату Y{point_num}: ");
            user_array[index_temp++] = int.Parse(Console.ReadLine() ?? "");

            Console.WriteLine($"Введите кардинату Z{point_num}: ");
            user_array[index_temp++] = int.Parse(Console.ReadLine() ?? "");
            point_num ++;
        }
    }
    catch(Exception exc)
    {
        Console.WriteLine($"Ошибка ввода: {exc.Message}");
    }
}
static double PointDst3D(double[] point_array)
{
    return Math.Round(Math.Sqrt(Math.Pow((point_array[0] - point_array[3]), 2) + Math.Pow((point_array[1] - point_array[4]),2) + Math.Pow((point_array[2] - point_array[5]),2)), 2);
}