/* Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам.
 Первоначальный массив можно ввести с клавиатуры, 
 либо задать на старте выполнения алгоритма.
  При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*/

void SecondArray(string[] array1, string[] array2)
{
    int c = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[c] = array1[i];
            c++;
        }
    }
}
void PrintArray(string[] array)
{
    Console.WriteLine("Слова с длинною до 3х символов:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите планируемое количество слов для записи:");
int length = int.Parse(Console.ReadLine());

string[] arraiIn = new string[length];

for (int i = 0; i < length; i++)
{
    Console.WriteLine($"Введите {i + 1}-е слово для записи:");
    arraiIn[i] = Console.ReadLine();
}

string[] arraiExit = new string[length];
SecondArray(arraiIn, arraiExit);

Console.WriteLine();

PrintArray(arraiExit);