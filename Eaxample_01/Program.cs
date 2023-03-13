using static Library;
int arrayLength = GetLength("Задайте длину массива: ");
int[] array = new int [arrayLength];
FeelArray(array);
Console.WriteLine(PrintArray(array));
int[] newArray = ReturnArray(array);
Console.WriteLine(PrintArray(newArray));





