System.Console.Clear(); 
int max = 3;     
string[] array1 = { "05", "214", "Armenia", ":-), afr2, " };
Solving(array1, max);
string[] array2 = { "5065", "123, Russia, Pash, 34" };
Solving(array2, max);
string[] array3 = { "a2321", "a05", "asdqw", "2003" };
Solving(array3, max);

int CountItems(string[] arr, int max)
{
    int count = 0;                                      
    for (int i = 0; i < arr.Length; i++)               
    {
        if (arr[i].Length <= max) count++;              
    }
    return count;                                       
}
string[] NewArray(string[] arr, int max)
{
    int newArrayLenght = CountItems(arr, max);         
    string[] newArray = new string[newArrayLenght];     
    int newArrayIndex = 0;                              
    for (int i = 0; i < arr.Length; i++)                
    {
        if (arr[i].Length <= max)                       
        {
            newArray[newArrayIndex] = arr[i];           
            newArrayIndex++;                            
        }
    }
    return newArray;                                    
}
void PrintArray(string[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write('"');
        System.Console.Write(array[i]);
        System.Console.Write('"');
        if (i < array.Length - 1) System.Console.Write(", ");
    }
    System.Console.Write("]");
}
void Solving(string[] arr, int max)
{
    string[] newArray = NewArray(arr, max);
    PrintArray(arr);
    System.Console.Write(" → ");
    PrintArray(newArray);
    System.Console.WriteLine();
}
