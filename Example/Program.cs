// Написать программу, которая из имеющегося массива целых чисел формирует массив из четных чисел.
// Первоначальный массив можно ввести с клавиатуры, либо сгенерировать случайным образом. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

int[] CreateArray(int size)
{
    int[] array = new int[size];
    return array;
}

int[] FillArray(int[] array, int leftBound, int rightBound)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(leftBound, rightBound);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
int[] EvevNumberArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    int[] resultArray = new int[count];
    count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            resultArray[count] = array[i];
            count++;
        }
    }
    return resultArray;
}
int[] array1 = CreateArray(8);
FillArray(array1, 0, 10);
PrintArray(array1);
PrintArray(EvevNumberArray(array1));
