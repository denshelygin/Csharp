// Задача: Написать программу которая из имеющегося массива строкформирует массив из строк,
//длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
//либо задать на старте выполнения алгоритма. При решении задачи не рекомендуется пользоваться коллекциями
//лучше обойтись исключительно массивами.
string[] array1 = new string[5] {"hello", "555", "logitech", "878787", "qq"};
string[] array2 = new string[array1.Length];
int count = 0;
void SecondArrayWithIF(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArrayWithIF(array1, array2);
PrintArray(array2);
