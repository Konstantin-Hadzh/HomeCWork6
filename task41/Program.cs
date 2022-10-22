/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/


Console.Write("Введите числа, отделяя их запятой: ");
int[] numbersInArray = StringInNumbers(Console.ReadLine());
int[] StringInNumbers(string input)
{
    int count = 1;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ',')
        {
            count++;
        }
    }

    int[] numbersInArray = new int [count];
    int index = 0;

    for (int i = 0; i < input.Length; i++)
    {
        string box = "";

        while (input [i] != ',')
        {
        if(i != input.Length - 1)
        {
            box += input [i].ToString();
            i++;
        }
        else
        {
            box += input [i].ToString();
            break;
        }
        }
        numbersInArray[index] = Convert.ToInt32(box);
        index++;
    }
    return numbersInArray;
}

int num = 0;
for (int i = 0; i < numbersInArray.Length; i++)
{
    if (numbersInArray[i] > 0)
    {
        num++;
    }
}
Console.WriteLine();
Console.WriteLine($" количество чисел больше 0 равно: {num}");