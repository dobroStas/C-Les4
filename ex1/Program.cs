// // Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// // 7 -> 28
// // 4 -> 10
// // 8 -> 36

int Promt()
{
    Console.WriteLine("Введите число:");
    return Convert.ToInt32(Console.ReadLine());
}

int SumNums(int number)
{
    int sum = 0;
    for (int i = 0; i <= number; i++)
        sum += i;
    return sum;
}
// int a = Promt();
// Console.WriteLine(SumNums(a));




// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5


int AmountNum(int number)
{
    int count = 1;
    while (number / 10 != 0)
        {
            number = number / 10;
            count ++;
            
        }
    
    return count;
}
// int a = Promt();
// Console.WriteLine(AmountNum(a));




// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120



int ProdNums(int number)
{
    int prod = 1;
    for (int i = 1; i <= number; i++)
        prod *= i;
    return prod;
}

// int a = Promt();
// Console.WriteLine(ProdNums(a));

// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


int [] CreateArray(int size)
{
    int [] array = new int [size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
    return array;
}

 int [] res = CreateArray(Promt());
Console.WriteLine($"[{String.Join("|", res)}]");