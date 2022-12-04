/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 4 */ 

Console.WriteLine("Введите числа через запятую: ");
string userInput = Console.ReadLine();
int count = 0;
int j = 0;
for (int i = 0; i < userInput.Length; i++)
{
    if (userInput[i] != ',') count++;
}
string[] array = new string[count + 1];
for (int i = 0; i < userInput.Length; i++)
{
    if (userInput[i] != ',')
    {
        array[j] += userInput[i];
    }
    else j++;
}
int amountPositiveNumbers = 0;
for (int i = 0; i < array.Length; i++)
{
    if (Convert.ToInt32(array[i]) > 0) amountPositiveNumbers++;
}
Console.WriteLine(amountPositiveNumbers); 

/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

double bFirst = ReadInt("Введите значение b1: ");
double kFirst = ReadInt("Введите значение k1: ");
double bSecond = ReadInt("Введите значение b2: ");
double kSecond = ReadInt("Введите значение k2: ");
if (kFirst == kSecond && bFirst == bSecond)
{
    Console.WriteLine("Прямые совпадают");
}
else if (kFirst == kSecond)
{
    Console.WriteLine("Прямые параллельны, у них нет точки пересечения");
}
else 
{
    double x = (bSecond - bFirst) / (kFirst - kSecond);
    double y = kSecond * x + bSecond;
    Console.WriteLine($"(" + x + "; " + y + ")");
}
int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
