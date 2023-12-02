//Задача 2: Задайте массив заполненный случайными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

void FillArray (int [] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array [index] = new Random ().NextInt (100, 1000);
        index ++;
    }
}

void PrintArray (int [] array){
    for (int index = 0; index < array.Length; index ++){
        Console.Write (array [index]+" ");
    }
    Console.WriteLine();
}

Console.WriteLine ("Enter length of array: ");
int length = Convert.ToInt32 (Console.ReadLine());
int [] array = new int [length];
FillArray (array);
PrintArray (array);

int count = 0;
int index = 0;
while (index < length){
if (array [index] % 2 == 0){
    count ++;
    index++;
    }
    else{
        index++;
    }
}
Console.WriteLine($"Count even numbers: {count}");




