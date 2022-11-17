/* Задача 1:

Задайте значение N. 
Напишите программу, которая выведет все натуральные числа 
в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

int GetNumber(string message) {
    bool isCorrect = false;
    int result = 0;
    Console.WriteLine(message);
    while (!isCorrect) {
        isCorrect = int.TryParse(Console.ReadLine(), out result);
        if (!isCorrect) 
            Console.WriteLine("Ввели не число или оно слишком большое. Введите заново: ");
    }
    return result;
}

void Integers(int num) {
    Console.Write("{0} ", num);
    if (num != 1)
        Integers(num - 1);
}

Integers(
    GetNumber("Сколько натуральных чисел показать?")
);