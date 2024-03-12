//Задача 1: Задайте значения M и N. 
//Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
//Использовать рекурсию, не использовать циклы.

void Numbers (int min, int max)
{
    if(max<min) return;
    Numbers(min, max-1);
    Console.Write($"{max} ");
}

Console.WriteLine("Введите натуральное число M (Начало отрезка)");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное число N (Конец отрезка)");
int n = Convert.ToInt32(Console.ReadLine());

if(n>m){
Numbers(m, n);
} else {
    Console.WriteLine("Число N должно быть больше M");
}
