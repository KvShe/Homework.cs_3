// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите положительное число: ");
int n = Convert.ToInt32(Console.ReadLine());

while (n < 1)
{
    Console.Write("\nМы это уже проходили\nДавай, я в тебя верю!\n\nНа этот раз введи положительное: ");
    n = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Таблица кубов:");

for (int score = 1; score <= n; score++)
{
    Console.WriteLine("Куб от {0} = {1}", score, Math.Pow(score,3));
}