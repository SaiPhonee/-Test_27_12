// Написать программу, которая из имеющегося массива целых чисел формирует массив из четных чисел.
// Первоначальный массив можно ввести с клавиатуры, либо сгенерировать случайным образом. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

int[] CreateArray(int size)
{
    int[] array=new int[size];
    return array;
}

int[] FillArray(int[] array, int leftBound, int rightBound)
{
    for(int i=0; i<array.Length; i++)
    {
        array[i]= new Random().Next(leftBound, rightBound);
    }
    return array;
}
