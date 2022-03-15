using System;
namespace Sort2DArray
{
    class Program
    {
        public static void display2DArray(int[,] array, int colSize, int rowSize)
        {
            for (int i = 0; i < rowSize; i++)
            {
                for (int j = 0; j < colSize; j++)
                {
                    Console.Write(array[i, j] + " ");
                    if (j == colSize - 1)
                    {
                        Console.WriteLine("\n");
                    }
                }
            }
            Console.WriteLine("\n");
        }

        public static void display1DArray(int[] array, int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("\n");
        }

        public static void ascendingSort(int[] array, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
        public static void descendingSort(int[] array, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    if (array[i] < array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }


        public static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Row Size");
            int rowSize = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Column Size");
            int colSize = int.Parse(Console.ReadLine());

            int[,] array2D = new int[rowSize, colSize];

            for (int i = 0; i < rowSize; i++)
            {
                for (int j = 0; j < colSize; j++)
                {
                    Console.WriteLine($"Please Enter number at position [Row: {i} , Column: {j}]");
                    array2D[i, j] = int.Parse(Console.ReadLine());
                }
            }

            display2DArray(array2D, colSize, rowSize);

            int array1DSize = colSize * rowSize;
            int[] array1D = new int[array1DSize];

            int index = 0;

            //Here i'm filling the 1D-array with elements from 2D-array so it can be sorted easily
            for (int i = 0; i < rowSize; i++)
            {
                for (int j = 0; j < colSize; j++)
                {
                    array1D[index++] = array2D[i, j];
                }
            }

            display1DArray(array1D, array1DSize);

            descendingSort(array1D, array1DSize);

            display1DArray(array1D, array1DSize);

            index = 0;

            //After Sorting the 1D-array we fill 2D-array with the sorted elements.
            for (int i = 0; i < rowSize; i++)
            {
                for (int j = 0; j < colSize; j++)
                {
                    array2D[i, j] = array1D[index++];
                }
            }

            display2DArray(array2D, colSize, rowSize);

        }
    }
}
