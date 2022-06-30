// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите 5-ти значное число: ");
int number = Convert.ToInt32(Console.ReadLine());

while (number < 9999 || number > 100000)
{
    Console.Write("Ты где-то обсчитался\nДавай заново: ");
    number = Convert.ToInt32(Console.ReadLine());
}

string numberString = number.ToString();

if (numberString[0] == numberString[4] && numberString[1] == numberString[3])
{
    Console.Write("\nУра-победа!\n{0} - это палиндром!", numberString);
}
else
{
    Console.Write("\nНет\n{0} - это не палиндром\nМожет в следующий раз?", numberString);
}