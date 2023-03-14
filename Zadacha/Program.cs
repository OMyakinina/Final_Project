// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа.
// Пример:
// "hello", "2", ":-)"] -> ["2", ":-)"]

string[] firstArray = new string[3] { "Hello", "2", "%-)" };
string[] secondArray = new string[firstArray.Length];
void NewArray(string[] firstArray, string[] secondArray)
{
    int count = 0;
    for (int i = 0; i < firstArray.Length; i++)
    {
        if (firstArray[i].Length <= 3)
        {
            secondArray[count] = firstArray[i];
            count++;
        }
    }
}
void PrintArray(string[] firstArray)
{
    for (int i = 0; i < firstArray.Length; i++)
    {
        Console.Write($"{firstArray[i]} ");
    }
    Console.WriteLine();
}
NewArray(firstArray, secondArray);
PrintArray(secondArray);

