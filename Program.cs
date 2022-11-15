// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Пример: 0, 7, 8, -2, -2 -> 2
//         1, -7, 567, 89, 223-> 4
/*
int [] CreativeNewArray(int size)
{
    int [] array = new int[size];
    Console.Write("\n");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите элемент массива под индексом {i}: ");
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}  
void ShowArroy(int [] array)
{   
    Console.Write($"Вы ввели следующие числа: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ",");
    }
    Console.Write("\b \b");
}
int SumPositiveElem(int [] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            sum++;
        }
    }
    return sum;
}

Console.Write("Cколько чисел будет содержать Ваш массив?\n> Введите кол-во: "); 
int size = Convert.ToInt32(Console.ReadLine());
if(size <= 0)
{
    Console.Write("К сожалению, сегодня я не в настроении генерировать такой массив :(. Дайте мне свыкнуться с этой мыслью и повторите попытку!"); 
}
else
{
int [] newArray = CreativeNewArray(size);
ShowArroy(newArray);
if(SumPositiveElem(newArray) == 0)
{
    Console.Write($"\nСреди них нет числ больше 0, сожалею, чего-то Вам сегодня ну прям не везет :(");
}
else
{
    Console.Write($"\nСреди них {SumPositiveElem(newArray)}, больше 0");
}
}
*/
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями:
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// Пример: b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
/*
void LineInterSearch(double b1, double k1, double b2, double k2)
{
    double searchX = (b2 - b1) / (k1 - k2);
    double searchY = k1*searchX + b1;
    if((k1*searchX + b1) == (k2*searchX + b2))
    {
        Console.Write($"Точка пересечений линий: ({searchX}; {searchY})");
    }
    else
    {
        Console.Write("Ого! У Ваших прямых точек пересечения - нет :(");
    }
}

Console.Write("Введите значение для b1: "); 
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение для k1: "); 
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение для b2: "); 
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение для k2: "); 
double k2 = Convert.ToInt32(Console.ReadLine());
LineInterSearch(b1, k1, b2, k2);
*/