//Задача 3: Задайте произвольный массив. 
//Выведете его элементы, начиная с конца. 
//Использовать рекурсию, не использовать циклы.

char[] array = {'!','т','е','в','и','р','П'};

void Print (char[] array, int i)
{
    if(i < 0) return;
    Console.Write(array[i]);
    Print(array, i - 1);
}

Print(array, array.Length - 1);
