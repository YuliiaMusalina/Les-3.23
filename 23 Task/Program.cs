﻿int number = ReadInt("Ведите число: ");
int i = 1;

while(i <= number)
{
    Console.Write(Sqr(i) + " ");
    i++;
}

int Sqr(int a)
{
    return a * a * a;
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
