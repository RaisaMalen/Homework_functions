/*Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.*/

int FindSum (int digit){
    int sum = 0;
    while (digit > 0){
        int num = digit % 10;
        digit /= 10;
        sum += num;}
    return sum;
    }

while (true){
    Console.WriteLine ("Enter integer number or 'q' to Exit: ");
    string number = Console.ReadLine ();
    if (number == "q"){
        break;
        }
        Console.WriteLine ("Enter integer number or 'q' to Exit: ");
        int digit = Convert.ToInt32 (Console.ReadLine());
        if (FindSum (digit) % 2 == 0){
            break;
    }
}
