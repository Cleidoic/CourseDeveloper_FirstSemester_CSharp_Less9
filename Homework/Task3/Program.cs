/* Задача 3: 

Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
using System;

int GetNumber(string message) {
    bool isCorrect = false;
    int result = 0;
    Console.WriteLine(message);
    while (!isCorrect) {
        isCorrect = int.TryParse(Console.ReadLine(), out result);
        if (!isCorrect)
            Console.WriteLine("Это не положительное число или оно слишком большое. Введите снова: ");
    }
    return result;
}

long AckermannFunction(int m, long n) {
    if (m == 0)
        return n += 1;
    if (n == 0)
        return AckermannFunction(m - 1, 1);    
    return AckermannFunction(m - 1, (AckermannFunction(m, n - 1)));
}

int m = GetNumber("Введите первый аргумент от 0 до 3: ");
int n = GetNumber("Введите второй аргумент: ");

Console.WriteLine("Получили: {0}", AckermannFunction(m, n));