// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
if (number <= 99)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    char[] array = number.ToString().ToCharArray();
    Console.WriteLine(array[2]);
}