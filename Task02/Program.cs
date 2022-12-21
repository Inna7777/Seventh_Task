//Напишите программу, которая на вход принимает позиции элемента 
 //в двумерном массиве, и возвращает значение этого элемента или же указание, 
 //что такого элемента нет.

int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число");
        }
    }

    return result;
}
int[,] TowArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rnd.Next(10,99);
        }
    } 
    return array;
}
/*nt NumSearch(int[,] matrix)
{
    int num;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
            count+=matrix[i, i];
    }
    return count;
}*/
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }

    Console.WriteLine();
}

int rows = GetNumber("Введите количество строк:");
int columns = GetNumber("Введите количество столбцов:");
int[,] array = TowArray(rows, columns);
int l = GetNumber("Введите номер строки элемента");
int n = GetNumber("Введите номер столбца элемента");
PrintArray(array);
if ((l > rows ^ n > columns)^(l > rows && n > columns))
{
    Console.WriteLine("такого элемента в массиве нет");
}
else
{
    Console.WriteLine(array[l-1,n-1]);
}

