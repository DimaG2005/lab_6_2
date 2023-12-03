using System;

public class MathOperations
{
    // Overloaded Add method for integers
    public int Add(int a, int b)
    {
        return a + b;
    }

    // Overloaded Add method for double values
    public double Add(double a, double b)
    {
        return a + b;
    }

    // Overloaded Add method for arrays of integers
    public int[] Add(int[] array1, int[] array2)
    {
        if (array1.Length != array2.Length)
        {
            throw new ArgumentException("Arrays must have the same length");
        }

        int[] result = new int[array1.Length];
        for (int i = 0; i < array1.Length; i++)
        {
            result[i] = array1[i] + array2[i];
        }

        return result;
    }

    // Overloaded Add method for matrices
    public int[,] Add(int[,] matrix1, int[,] matrix2)
    {
        if (matrix1.GetLength(0) != matrix2.GetLength(0) || matrix1.GetLength(1) != matrix2.GetLength(1))
        {
            throw new ArgumentException("Matrices must have the same dimensions");
        }

        int[,] result = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix1.GetLength(1); j++)
            {
                result[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }

        return result;
    }

    // You can add more overloaded methods for other operations and data structures

    // Example usage:
    public static void Main()
    {
        MathOperations math = new MathOperations();

        // Example of using the Add method for integers
        Console.WriteLine(math.Add(5, 3));

        // Example of using the Add method for double values
        Console.WriteLine(math.Add(2.5, 3.7));

        // Example of using the Add method for arrays of integers
        int[] array1 = { 1, 2, 3 };
        int[] array2 = { 4, 5, 6 };
        int[] resultArray = math.Add(array1, array2);
        Console.WriteLine(string.Join(", ", resultArray));

        // Example of using the Add method for matrices
        int[,] matrix1 = { { 1, 2 }, { 3, 4 } };
        int[,] matrix2 = { { 5, 6 }, { 7, 8 } };
        int[,] resultMatrix = math.Add(matrix1, matrix2);

        for (int i = 0; i < resultMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < resultMatrix.GetLength(1); j++)
            {
                Console.Write(resultMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
