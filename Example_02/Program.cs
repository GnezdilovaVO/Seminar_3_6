﻿using static Library;
int[,] arrayA = new int[3, 3];
int[,] arrayB = new int[3, 3];
FellArray(arrayA);
FellArray(arrayB);
PrintArray(arrayA);
Console.WriteLine();
PrintArray(arrayB);
Console.WriteLine();
// int[,] sumArray = SumArray(arrayA, arrayB);
// PrintArray(sumArray);
Console.WriteLine();
int[,] multiArray = MultiArray(arrayA, arrayB);
PrintArray(multiArray);
Console.WriteLine();
int[,] transArray = TransArray(multiArray);
PrintArray(transArray);
