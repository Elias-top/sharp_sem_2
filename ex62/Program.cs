Console.Clear();
int row_count_user = 4;
int colum_count_user = 4;

int[,] user_array = new int [row_count_user, colum_count_user];

SetSpiralUserArray(user_array);
PrintMultiArrayToConsole(user_array);

static void SetSpiralUserArray(int[,] arr)
{
    int Ibeg = 0, Ifin = 0, Jbeg = 0, Jfin = 0;

    int k = 1;
    int i = 0;
    int j = 0;

    int N = 4;
    int M = 4;

    while (k <= N * M){
        arr[i,j] = k;
        if (i == Ibeg && j < M - Jfin - 1)
            ++j;
        else if (j == M - Jfin - 1 && i < N - Ifin - 1)
            ++i;
        else if (i == N - Ifin - 1 && j > Jbeg)
            --j;
        else
            --i;

        if ((i == Ibeg + 1) && (j == Jbeg) && (Jbeg != M - Jfin - 1)){
            ++Ibeg;
            ++Ifin;
            ++Jbeg;
            ++Jfin;
        }
        ++k;
    }
    Console.WriteLine($"k = {k}");
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
