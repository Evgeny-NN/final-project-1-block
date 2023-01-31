
string[] array1 = new string[] { "Mazda", "Kia", "BMW", "Lada", "47", ":-)", "ОГО" };

string[] CreateSecondArray(string[] array1)         // метод заполнения второго массива из содержимого первого 
{                                                   // массива согласно условиям задачи
    string[] array2 = new string[array1.Length];
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
    return array2;
}
void ShowArray(string[] array)      // метод вывода полученного массива
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
string[] myArray = CreateSecondArray(array1);
ShowArray(myArray);