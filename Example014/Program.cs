// Задача 3: Напишите программу, которая перевернёт одномерный массив
// (первый элемент станет последним, второй – предпоследним и т.д.)

void FillArray (int [] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array [index] = new Random ().Next (0, 50);
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

for (int index = length-1; index >= 0; index --){
    Console.Write (array [index] + " ");
}