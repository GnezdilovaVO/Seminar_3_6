public static class Library
{
    public static void FellArray(int[,] array)
    {
        for (int i =0; i < array.GetLength(0); i++)
        {
            for (int j =0; j < array.GetLength(1); j++)
            {
                array[i ,j] = new Random().Next(0, 5);
            }
        }
    }
    public static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i,j]+" ");
            }
            Console.WriteLine();
        }
    }
    public static int[,] SumArray(int[,] array1, int[,] array2)
    {
        int[,] resultArray = new int[3, 3];
        for (int i = 0; i < resultArray.GetLength(0); i++)
        {
            for (int j =0; j < resultArray.GetLength(1); j++)
            {
                resultArray[i, j] = array1[i, j] + array2[i, j];
            }
        }
        return resultArray;
    }
    public static int[,] MultiArray(int[,] array1, int[,] array2)
    {
        int temp=0;
        int[,] multiArray= new int[3 ,3];
        for (int i=0; i < multiArray.GetLength(0); i++)
        {
            for(int j=0; j < multiArray.GetLength(1); j++)
            {
                for (int k =0; k < array1.GetLength(0); k++)
                {
                   temp = temp + array1[i,k]*array2[j,k];
                }
                multiArray[i, j] = temp;
                temp = 0;
            }
        }
        return multiArray;
    }
    public static int[,] TransArray(int[,] array1)
    {
        int[,] transArray = new int[3, 3];
        for (int i=0; i < transArray.GetLength(0); i++)
        {
            for (int j =0; j < transArray.GetLength(1); j++)
            {
                transArray[i, j] = array1[j, i];
            }
        }
        return transArray;
    } 
}