/* Задача 2: 

Задайте значения M и N. 
Напишите программу, которая найдёт сумму 
натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int GetNumber(string message) {
    bool isCorrect = false;
    int result = 0;
    Console.WriteLine(message);
    while (!isCorrect || result < 1) {
        isCorrect = int.TryParse(Console.ReadLine(), out result);
        if (!isCorrect || result < 1)
            Console.WriteLine("Ввели не натуральное число или оно слишком большое. Введите снова: ");
    }
    return result;
}

int SumInteger(int start, int fin) {
    if (start == fin) {
        return fin;
    } else if (start > fin) {
        start += SumInteger(start - 1, fin);
    } else
        start += SumInteger(start+1, fin);
    return start;
}

Console.WriteLine("Cумма чисел в промежутке между ними: {0}",
    SumInteger(
        GetNumber("Введите первое число"),
        GetNumber("Введите второе число")
    )
);