// Задача 64: Задайте значение N. Напишите программу, которая выведет все чётные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "4, 2"
// N = 8 -> "8, 6, 4, 2,"

Console.Write("Загадайте чёткое натуральное число, на котором всё закончится: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
EvenToLow(number, count);
int i = 1;
while (i <= numNum)
{
    if(i % 2 == 0){
        Console.WriteLine(i);
    }
    i++;
}

void EvenToLow(int n, int count)
{
    if (count > n)
    {
        return;
    }
    else
    {
        EvenToLow(n, count + 1);
        Console.Write(count + " ");
    }
}
