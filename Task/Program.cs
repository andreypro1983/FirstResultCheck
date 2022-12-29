// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте исполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.Clear();
Console.Write("Введите размерность исходного массива: ");
int arrSize = Convert.ToInt32(Console.ReadLine());
int countSymbols = 3;
string[] userArray = FillArrayFromUser(arrSize);
PrintArray(userArray);
Console.Write(" -> ");
if (FindCountElementsArrayLengthLessNumber(userArray, countSymbols) != 0) PrintArray(GetArrayElementsLengthLessNumber(userArray, countSymbols));
else Console.Write("[]");

string[] FillArrayFromUser(int arrSize)
{
    string[] array = new string[arrSize];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите значение {i} элемента исходного массива: ");
        array[i] = Console.ReadLine();
        Console.WriteLine();

    }
    return array;
}
string[] GetArrayElementsLengthLessNumber(string[] inputArray, int lengthElement)
{
    string[] newArray = new string[FindCountElementsArrayLengthLessNumber(inputArray, lengthElement)];
    int k = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= lengthElement)
        {
            newArray[k] = inputArray[i];
            k++;
        }
    }
    return newArray;
}

int FindCountElementsArrayLengthLessNumber(string[] inputArray, int lengthElement)
{
    int count = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= lengthElement) count++;
    }
    return count;
}

void PrintArray(string[] inputArray)
{

    for (int i = 0; i < inputArray.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i != inputArray.Length - 1) Console.Write("\"" + inputArray[i] + "\", ");
        else Console.Write("\"" + inputArray[i] + "\"]");
    }
}



