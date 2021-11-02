void FillArray(int[] Arr_V1, int min1, int max1) // Заполняет пустой массив случайными целыми числами от min1 до max1
{
    int L1 = Arr_V1.Length;
    for (int j1 = 0; j1 < L1;)
    {
        Arr_V1[j1] = new Random().Next(min1, max1 + 1);
        ++j1;
    }
}

void PrintArray(int[] Arr_V2) // Печатает массив в терминале.
{
    int L2 = Arr_V2.Length;
    for (int j2 = 0; j2 < L2;)
    {
        Console.Write(Arr_V2[j2] + " ");
        ++j2;
    }
}

void CopyArray(int[] Arr_V3_1, int[] Arr_V3_2) // Копирует заполненный массив Arr_V3_1 в пустой массив той же длинны Arr_V3_2
{
    int L3 = Arr_V3_1.Length;
    for (int j3 = 0; j3 < L3;)
    {
        Arr_V3_2[j3] = Arr_V3_1[j3];
        ++j3;
    }
}

int[] AlwaysBiggerMk2 (int[] Arr_V4_1) // Удаляет из массива Arr_V4_1 все элементы нарушающие порядок возрастания.
{
    int L4 = Arr_V4_1.Length;
    int C4 = 0;
    int max1 = Arr_V4_1[0];
    int[] Arr_V4_2 = new int[L4];
    Arr_V4_2[0] = max1;
    for (int j4_1 = 1; j4_1 < L4;)
    {
        if (Arr_V4_1[j4_1] > max1)
        {
            max1 = Arr_V4_1[j4_1];
            Arr_V4_2[++C4]=Arr_V4_1[j4_1];
        }
        ++j4_1;
    }
    ++C4;
    int[] Arr_V4_3 = new int[C4];
    for (int j4_2 = 0; j4_2 < C4;)
    {
        Arr_V4_3[j4_2]=Arr_V4_2[j4_2];
        ++j4_2;
    }
    return Arr_V4_3;
}

Console.WriteLine("Введите длину массива.");
int N = Convert.ToInt32(Console.ReadLine());
int[] Arr_A = new int[N];
int[] Arr_B1 = new int[N];
int[] Arr_B2 = new int[N];
int[] Arr_B3 = new int[N];
Console.WriteLine("Введите минимальное число.");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число.");
int maxValue = Convert.ToInt32(Console.ReadLine());
FillArray(Arr_A, minValue, maxValue);
CopyArray(Arr_A, Arr_B1);
CopyArray(Arr_A, Arr_B2);
CopyArray(Arr_A, Arr_B3);

Console.Write("Изначальный массив: ");
PrintArray(Arr_A);

Arr_B1 = AlwaysBiggerMk2(Arr_B1);
Console.WriteLine(" ");
Console.Write("Возрастающий массив: ");
PrintArray(Arr_B1);