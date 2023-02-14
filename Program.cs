// Написать программу, которая из имеющегося массива строк формирует массив из строк, длинна которых меньше либо равна трем символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

using static System.Console;
Clear();

string[] InitArray = {"Hellow", "34", "1", "ghjk", "uuu"};

int countLengthNewArray = CountElementsLessThenFour(InitArray);
WriteLine(countLengthNewArray);












/////////////////////////////////////////////////////Methods/////////////////////////////////////////

// Метод, считающий количество элементов в массиве, длинна которых строго меньше четырех

int CountElementsLessThenFour(string[] inArray)
{
    int count = 0;
    int lengthElement;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        lengthElement = inArray[i].Length;
        if (lengthElement < 4) count++;
    }
    return count;
}