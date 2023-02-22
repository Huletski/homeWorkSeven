//task1 Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

/*


int[,] NewArr(int rows, int columns, int lower, int hightest)
{
    int[,] array = new int[rows, columns];
    Random random = new Random();
    
    for (int a = 0; a < array.GetLength(0); a++)
    {
        for (int b = 0; b < array.GetLength(1); b++)

        array[a,b] = random.Next(lower, hightest);
    }

    return array;
}

int InputInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

void OutputArray(int[,] array){
    for (int a = 0; a < array.GetLength(0); a++)
    {
       for (int b = 0; b < array.GetLength(1); b++)

        Console.Write($"{array[a,b]} \t");
        Console.WriteLine();
    }
}

void ResultArithmetic(int[,] array)
{
    double sum = 0;
    for (int a = 0; a < array.GetLength(1); a++)
    {
        for (int b = 0; b < array.GetLength(0); b++)

            sum = sum + array[b,a];

        Console.Write($"{Math.Round(sum/array.GetLength(0),2)} \t");
        sum = 0;
    }
}


int row = InputInt("Enter the number of rows: ");
int col = InputInt("Enter the number of columns: ");
int low = 1;
int high = 10;

int[,] array = NewArr(row, col, low, high);

OutputArray(array);
Console.WriteLine();
ResultArithmetic(array);



*/




//task2 Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

/*

int[,] NewArray(int row, int colum, int low, int high)
{
    int[,] array = new int[row, colum];
    Random random = new Random();

    for (int a = 0; a < array.GetLength(0); a++)
    {
        for (int b = 0; b < array.GetLength(1); b++)
            array[a,b] = random.Next(low, high);
    }

    return array;
}

int InputArray(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

void OutputArray(int[,] array)
{
    for (int a = 0; a < array.GetLength(0); a++)
    {
        for (int b = 0; b < array.GetLength(1); b++)

        Console.Write($"{array[a,b]} \t");
        Console.WriteLine();
    }
}

int[,] SortArray(int[,] array)
{
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        { 
    
             for (int j = array.GetLength(1)-1; j > 0; j--)
             { 
                if (array[i,j]>array[i,j-1])
                {
                temp = array[i,j-1];
                array[i,j-1] = array[i,j];
                array[i,j] = temp;
                }
            }
        }
    }

    return array;
}


int row = InputArray("Enter the number of rows: ");
int col = InputArray("Enter the number of columns: ");
int low = 1;
int high = 10;

int[,] array = NewArray(row, col, low, high);


OutputArray(array);
Console.WriteLine();
OutputArray(SortArray(array));


*/





//task3 В прямоугольной матрице найти строку с наименьшей суммой элементов.

/*
int[,] NewArr(int row, int col, int low, int high)
{
    int[,] array = new int[row, col];
    Random random = new Random();

    for (int a = 0; a < array.GetLength(0); a++)
    {
        for (int b = 0; b < array.GetLength(1); b++)
        array[a,b] = random.Next(low, high);
    }

    return array;
}

int InputInt(string message)
{
    Console.Write(message);

    return int.Parse(Console.ReadLine());
}

void OutputArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
       
        for (int j = 0; j < array.GetLength(1); j++)

        Console.Write($"{array[i,j]}\t");
        Console.WriteLine();
    }
}

int MinimalSumRow(int[,] array)
{
    int sum = 0;
    int minSum = 0;
    int minIndex = 1;


    for (int a = 0; a < array.GetLength(0); a++)
    {
        for (int b = 0; b < array.GetLength(1); b++)
        {
            sum += array[a,b];
        }
        if (a  == 0) minSum = sum;

        if (sum<minSum)
        {
            minSum = sum;
            minIndex = a+1;
        }
        
    sum = 0;
    }

    return minIndex;
}


int row = InputInt("Enter the number of rows: ");
int col = InputInt("Enter the number of columns: ");
int low = 1;
int high = 10;

int[,] array = NewArr(row, col, low, high);

OutputArray(array);

Console.WriteLine();
Console.WriteLine($"Minimal sum of number in line #: {MinimalSumRow(array)}");

*/
