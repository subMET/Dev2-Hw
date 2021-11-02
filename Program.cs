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

int[] AlwaysBiggerMk2(int[] Arr_V4_1) // Создаёт массив из Arr_V4_1, где удаляет из массива все элементы нарушающие порядок возрастания.
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
            Arr_V4_2[++C4] = Arr_V4_1[j4_1];
        }
        ++j4_1;
    }
    ++C4;
    int[] Arr_V4_3 = new int[C4];
    for (int j4_2 = 0; j4_2 < C4;)
    {
        Arr_V4_3[j4_2] = Arr_V4_2[j4_2];
        ++j4_2;
    }
    return Arr_V4_3;
}

int[] CutAboveNumberMk2(int[] Arr_V5_1, int Num_5) // Создаёт на основе массива Arr_V5_1 массив, где нет чисел больше Num_5.
{
    int L5 = Arr_V5_1.Length;
    int C5 = 0;
    int[] Arr_V5_2 = new int[L5];
    for (int j5_1 = 0; j5_1 < L5;)
    {
        if (Arr_V5_1[j5_1] <= Num_5)
        {
            Arr_V5_2[C5] = Arr_V5_1[j5_1];
            ++C5;
        }
        ++j5_1;
    }
    int[] Arr_V5_3 = new int[C5];
    for (int j5_2 = 0; j5_2 < C5;)
    {
        Arr_V5_3[j5_2] = Arr_V5_2[j5_2];
        ++j5_2;
    }
    return Arr_V5_3;
}

int[] AlterSign(int[] Arr_V6_1, int flag6_1) // Создаёт на основе массива Arr_V6_1 массив, где у соседних элементов чередуется знак. Перменная flag6_1 указывает что делать с нулями (1 - считать за положительное число, 0 - удалять нули, -1 - считать за отрицательное число)
{
    int L6 = Arr_V6_1.Length;
    int C6 = 0;
    int[] Arr_V6_2 = new int[L6];
    bool flag6_2;
    if (flag6_1 == 1)
    {
        if (Arr_V6_1[0] >= 0) { flag6_2 = true; }
        else { flag6_2 = false; }
        Arr_V6_2[0] = Arr_V6_1[0];
        for (int j6_1 = 1; j6_1 < L6;)
        {
            if (flag6_2 == true)
            {
                if (Arr_V6_1[j6_1] < 0)
                {
                    Arr_V6_2[++C6] = Arr_V6_1[j6_1];
                    flag6_2 = !flag6_2;
                }
                ++j6_1;
            }
            else
            {
                if (Arr_V6_1[j6_1] >= 0)
                {
                    Arr_V6_2[++C6] = Arr_V6_1[j6_1];
                    flag6_2 = !flag6_2;
                }
                ++j6_1;
            }
        }
    }
    if (flag6_1 == -1)
    {
        if (Arr_V6_1[0] > 0) { flag6_2 = true; }
        else { flag6_2 = false; }
        Arr_V6_2[0] = Arr_V6_1[0];
        for (int j6_2 = 1; j6_2 < L6;)
        {
            if (flag6_2 == true)
            {
                if (Arr_V6_1[j6_2] <= 0)
                {
                    Arr_V6_2[++C6] = Arr_V6_1[j6_2];
                    flag6_2 = !flag6_2;
                }
                ++j6_2;
            }
            else
            {
                if (Arr_V6_1[j6_2] > 0)
                {
                    Arr_V6_2[++C6] = Arr_V6_1[j6_2];
                    flag6_2 = !flag6_2;
                }
                ++j6_2;
            }
        }
    }
    if (flag6_1 == 0)
    {
        int[] Arr_V6_3 = new int[L6];
        int C6_0 = 0;
        for (int j6_3 = 0; j6_3 < L6;)
        {
            if (Arr_V6_1[j6_3] != 0)
            {
                Arr_V6_3[C6_0++] = Arr_V6_1[j6_3];
            }
            ++j6_3;
        }
        int[] Arr_V6_4 = new int[C6_0];
        for (int j6_4 = 0; j6_4 < C6_0;)
        {
            Arr_V6_4[j6_4] = Arr_V6_3[j6_4];
            ++j6_4;
        }
        if (Arr_V6_4.Length == 0) { return Arr_V6_4; }
        if (Arr_V6_4[0] < 0) { flag6_2 = false; }
        else { flag6_2 = true; }
        int[] Arr_V6_5 = new int[C6_0];
        Arr_V6_5[0] = Arr_V6_4[0];
        for (int j6_5 = 1; j6_5 < C6_0;)
        {
            if (flag6_2 == true)
            {
                if (Arr_V6_4[j6_5] < 0)
                {
                    Arr_V6_5[++C6] = Arr_V6_4[j6_5];
                    flag6_2 = !flag6_2;
                }
                ++j6_5;
            }
            else
            {
                if (Arr_V6_4[j6_5] > 0)
                {
                    Arr_V6_5[++C6] = Arr_V6_4[j6_5];
                    flag6_2 = !flag6_2;
                }
                ++j6_5;
            }
        }
        ++C6;
        int[] Arr_V6_6 = new int[C6];
        for (int j6_6 = 0; j6_6 < C6;)
        {
            Arr_V6_6[j6_6] = Arr_V6_5[j6_6];
            ++j6_6;
        }
        return Arr_V6_6;
    }
    return Arr_V6_2;
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

Arr_B2 = CutAboveNumberMk2(Arr_B2, 8);
Console.WriteLine(" ");
Console.Write("Массив, состоящий из элементов не больше 8: ");
if (Arr_B2.Length == 0) { Console.Write("пустой. Все элементы в изначальном массиве больше 8."); }
else { PrintArray(Arr_B2); }

int flag_result = 0; // 1 - метод считает 0 положительным числом, -1 - отрицательным, 0 - удаляет нули из массива.
Arr_B3 = AlterSign(Arr_B3, flag_result);
Console.WriteLine(" ");
Console.Write("Массив, с чередующимся знаком: ");
if ((flag_result == 0) && (Arr_B3.Length == 0)) { Console.Write("пустой. Все элементы в изначальном массиве равны 0. Метод удаляет нули."); }
else { PrintArray(Arr_B3); }