public static class Library
{
    public static void FillArray(int[,] array)
    {
        for (int i =0; i<array.GetLength(0); i++)
        {
            for (int j =0; j<array.GetLength(1);j++)
            {
                array[i, j] = new Random().Next(1, 100);
            }
        }
    }
    public static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j =0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j]+" ");
            }
            Console.WriteLine();
        }
    }
    public static void StreamlineArray(int[,] array)
    {
        //int[,] newArray = new int[3,3];
        int temp;
        for (int i=0; i< array.GetLength(0); i++)
        {
            for (int j=0; j < array.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(0); k++)
                {
                    for (int l = 0; l< array.GetLength(1); l++)
                    {
                        if (array[k, l] < array[i, j])
                        {
                            temp = array[i, j];
                            array[i, j] = array[k, l];
                            array[k, l] = temp;
                        }
                    }
                }
            }
        }
        //return array;
    }
}