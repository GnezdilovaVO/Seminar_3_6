using static Library;
int[,] array = new int[3,3];
FillArray(array);
PrintArray(array);
Console.WriteLine();
//int[,] newArray = StreamlineArray(array);
StreamlineArray(array);
PrintArray(array);