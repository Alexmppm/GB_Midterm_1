// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
//  длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
//  либо задать на старте выполнения алгоритма.
//  При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] arr = { "Hello", "2", "world", ":-)", "12345679", "111" };


// Метод возвращает массив строк, длинны меньше или равно заданной
string[] GetStringsLessL(string[] inputArr, int maxLength)
{
    int len = 0;
    for (int i = 0; i < inputArr.Length; i++)
    {
        if (inputArr[i].Length <= maxLength)
        {
            len += 1;
        }
    }

    string[] result = new string [len];
    int k = 0;

    for (int i = 0; i < inputArr.Length; i++)
    {
        if (inputArr[i].Length <= maxLength)
        {
            
            result[k] = inputArr[i];
            k += 1;
        }
    }

    return result;
}

// Метод печатает массив
void Print1DArr(string[] inputArr)
{
    Console.Write("[");
    for (int i = 0; i < inputArr.Length - 1; i++)
    {
        Console.Write(inputArr[i] + ", ");
    }
    Console.WriteLine(inputArr[inputArr.Length - 1]+"]");
}


string [] newArray = GetStringsLessL(arr, 3);
Print1DArr(newArray);
