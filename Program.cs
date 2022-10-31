
//массив m*n
/*
int[,] Create2DRandomArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];                   
    for(int i=0; i < rows; i++)                                
        for(int j=0; j < columns; j++)                         
        {
            newArray[i,j] = new Random().Next(minValue, maxValue +1);
        }
    return newArray;   
}
void Show2DArray (int[,] array)
{
    for(int i=0; i < array.GetLength(0); i++)                                
    {
        for(int j=0; j < array.GetLength(1); j++)                       
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }   
}
Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента");
int max = Convert.ToInt32(Console.ReadLine());
int[,] myArray = Create2DRandomArray(m,n,min,max);
Show2DArray(myArray);

*/


// массив т среднее арифметическое столбцов


/*

int[,] Create2DRandomArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];                   
    for(int i=0; i < rows; i++)                                
        for(int j=0; j < columns; j++)                          
        {
            newArray[i,j] = new Random().Next(minValue, maxValue +1);
        }
    return newArray;   
}
void Show2DArray (int[,] array)
{
    for(int i=0; i < array.GetLength(0); i++)                                
    {
        for(int j=0; j < array.GetLength(1); j++)                       
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }   
}
int[,] SredneAr (int[,] array)
{
    
    for(int i = 0; i < array.GetLength(0); i++)
    {
        double sum = 0;
        double result = 0;
        
        for(int j =0; j < array.GetLength(1); j ++)
        {
            sum = sum + array[j,i];
            result = sum / array.GetLength(1) ;
        }
        Console.WriteLine(result);
    }
    return array;
   
} 
Console.Write("Введите количество строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] myArray= Create2DRandomArray(m , n , min, max);
Show2DArray(myArray);
SredneAr (myArray);


*/

int[,] Create2DRandomArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];                   
    for(int i=0; i < rows; i++)                                
        for(int j=0; j < columns; j++)                         
        {
            newArray[i,j] = new Random().Next(minValue, maxValue +1);
        }
    return newArray;   
}

void Show2DArray (int[,] array)
{
    for(int i=0; i < array.GetLength(0); i++)                                
    {
        for(int j=0; j < array.GetLength(1); j++)                       
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }   
}

void MyNumbers(int[,] array, int num)
{   
    int yes = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i, j] == num)
            {
                yes = num;
            }
            
        }
    }
    if(num == yes)
    {
        Console.WriteLine($"{num} -> такой элемент есть в массиве");
    }  
    else 
    Console.WriteLine($"{num} -> такого элемента нет в массиве");
   
}
Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите свой элемент");
int num = Convert.ToInt32(Console.ReadLine());
int[,] myArray = Create2DRandomArray(m,n,min,max);
Show2DArray(myArray);
MyNumbers(myArray, num);