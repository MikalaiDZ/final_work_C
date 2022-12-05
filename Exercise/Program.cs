// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.Clear();

string[] ArrayStr()
{
    Console.WriteLine($"Ввод элементов : ");
    int count = 0;
    string[] arrStr = new string[count];
    string? str = string.Empty;

    do
    {

        str = Console.ReadLine();
        if (str != null)
        {
            count++;
            string[] arrStrTemp = new string[count];
            for (int i = 0; i < arrStrTemp.Length - 1; i++)
                arrStrTemp[i] = arrStr[i];
            arrStrTemp[count - 1] = str;
            arrStr = arrStrTemp;


        }
    } while (str != "");
    return arrStr;
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length-1; i++)
    {
        if (i != arr.Length - 2) Console.Write($"'{arr[i]}', ");
        else Console.Write($"'{arr[i]}'");
    }
    Console.Write("]");
}

string[] SimplifiedArray(string[] arrStr)
{
    int size = 0;
    string[] simArr = new string[size];
    string? word = string.Empty;

    for (int i = 0; i < arrStr.Length; i++)
    {
        word = arrStr[i];

        if (word.Length < 4)
        {
            size++;
            string[] arrTemp = new string[size];

            for (int j = 0; j < arrTemp.Length - 1; j++)

                arrTemp[j] = simArr[j];
            arrTemp[size - 1] = word;
            simArr = arrTemp;
        }
    }
    return simArr;
}


string[] arrStr = ArrayStr();
PrintArray(arrStr);
Console.Write(" -> ");
string[] simplifiedArray = SimplifiedArray(arrStr);
PrintArray(simplifiedArray);