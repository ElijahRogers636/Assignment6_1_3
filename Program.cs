namespace Assignment6_1_3
{
    internal class Program
    {
        // Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.
        static void Main(string[] args)
        {
            int[] intArr = { 0, 2, 3, 4, 0, 6, 7, 0, 9, 10, 11 };
            PrintArray(intArr);
            NestedMoveZerosToBack(intArr);
            PrintArray(intArr);

            Console.WriteLine();
            Console.WriteLine("<========================= New Array ==============================>");
            Console.WriteLine();

            int[] intArr2 = { 1, 2, 0, 4, 0, 11, 7, 0, 32, 10, 0 };
            PrintArray(intArr2);
            MoveZerosToBack(intArr2);
            PrintArray(intArr2);

        }

        // Uses one loop to swap elements O(n)
        static void MoveZerosToBack(int[] arr)
        {
            int count = 0;
            int temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                temp = arr[i];
                if (arr[i] != 0)
                {
                    arr[i] = arr[count];
                    arr[count] = temp;
                    count++;
                }
            }
        }

        // Uses nested loop O(n^2)
        static void NestedMoveZerosToBack(int[] arr)
        {
            for (int i = 0; i < arr.Length-1; i++) 
            {
                int temp = arr[i];
                
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == 0)
                    {
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }

        

        static void PrintArray(int[] arr)
        {

            Console.Write("|");
            foreach (int i in arr)
            {
                Console.Write($" { i } |");
            }
            Console.WriteLine();
        }
    }
}
