public static class Library
{
    public static int GetLength(string text)
    {
        Console.WriteLine(text);
        return Convert.ToInt32(Console.ReadLine());
    }
    public static void FeelArray(int[] array1)
    {
        for (int i = 0; i < array1.Length; i++)
        {
            array1[i] = new Random().Next(1, 100);
        }
    }
    public static string PrintArray(int[] array2)
    {
        string elArray = String.Empty;
        for (int i =0; i < array2.Length; i++)
        {
            elArray = elArray + array2[i] + " ";
        }
        return elArray;
    }
    public static int[] ReturnArray(int[] array3)
    {
        int arrayLength1 = array3.Length;
        //int[] returnArray = new int[arrayLength1];
        int temp = 0;
        for  (int i = 0; i <= arrayLength1/2; i++)
        {
            temp = array3[arrayLength1-1];
            array3[arrayLength1-1] = array3[i];
            array3[i] = temp;
            arrayLength1 = arrayLength1 -1; 
        }
        return array3;
    }
}