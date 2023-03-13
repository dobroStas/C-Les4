



// =========  Задача 25:

//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int Promt()
{
    Console.WriteLine("Введите число:");
    return Convert.ToInt32(Console.ReadLine());
}


int MathPow(int num1, int num2)

{

    int res = 1;
    for(int i = 0; i <= num2 - 1; i++)
    {
        res *= num1;
    }
    return res;
}



// int a = Promt();
// int b = Promt();
// Console.WriteLine(MathPow(a, b));


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

int SumNumb(int num)
{
int summ = 0;
int res = 0;
while (num > 0)
{
    res = num % 10;
    num = num / 10;
    summ += res;
}
return summ;
}

// int a = Promt();
// Console.WriteLine(SumNumb(a));




// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]



int [] CreateArray(int size)
{
    int [] array = new int [size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next();
    }
    return array;
}
int size = 8;
int [] res = CreateArray(size);
Console.WriteLine($"[{String.Join(", ", res)}]");