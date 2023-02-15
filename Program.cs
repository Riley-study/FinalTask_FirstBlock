// Написать программу, которая из имеющегося массива строк формирует массив из строк, длинна которых меньше либо равна трем символом. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

using static System.Console;
Clear();

string[] InitArray = { "Hellow", "3k", "4679", "Russia", "24" , "_"};
PrintArray(InitArray);
Write("  =>  ");

int countLengthNewArray = CountElementsLessThenFour(InitArray);
// WriteLine(countLengthNewArray); для проверки коррекной работы метода

if (countLengthNewArray < 1)
{
    WriteLine("[]");
}
else
{
    string[] ArrayLessThenFourSymbles = ReternElementsLessThenFourSymbles(InitArray, countLengthNewArray);
    PrintArray(ArrayLessThenFourSymbles);

}




/////////////////////////////////////////////////////Methods/////////////////////////////////////////

// Метод, считающий количество элементов в массиве, длинна которых строго меньше четырех

int CountElementsLessThenFour(string[] inArray)
{
    int count = 0;
    int lengthElement;
    for (int i = 0; i < inArray.Length; i++)
    {
        lengthElement = inArray[i].Length;
        if (lengthElement < 4) count++;
    }
    return count;
}

// Метод, который из заданного массива строк формирует массив из строк, длинна которых меньше либо равна трем символам
string[] ReternElementsLessThenFourSymbles(string[] inArray, int newArrayLength)
{
    string[] result = new string[newArrayLength];
    int lengthElement;
    int m = 0;
    for (int i = 0; i < inArray.Length; i++)
    {
        
        lengthElement = inArray[i].Length;
        if (lengthElement < 4)
        {
            result[m] = inArray[i];
            m++;
        }

    }
    return result;
}

//Метод, который выводит на печать строчный массив
void PrintArray(string[] inArray)
{
    Write("[");
    for (int i = 0; i < inArray.Length - 1; i++)
    {
        Write($"{inArray[i]}, ");
    }
    Write($"{inArray[inArray.Length - 1]}]");
}