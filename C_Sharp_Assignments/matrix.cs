using System;

public class Matrix
{
    static int[,] arr1; // Matrix for option 1
    static int[,] arr2;
    static int[,] arr3;

    public static void Main()
    {
        string userInput;
        int row1 = 0, col1 = 0, row2 = 0, col2 = 0;

        while (true)
        {
            Console.WriteLine("\n1. Create Matrix");
            Console.WriteLine("2. Display Matrix");
            Console.WriteLine("3. Matrix Addition");
            Console.WriteLine("4. Matrix Subtraction");
            Console.WriteLine("5. Matrix Multiplication");
            Console.WriteLine("6. Matrix Transpose");
            Console.WriteLine("7. Exit\n");

            Console.WriteLine("Enter Choice:");
            userInput = Console.ReadLine();
            int choice = Convert.ToInt32(userInput);

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Creating Matrix:");
                    CreateMatrix(ref row1, ref col1, out arr1);
                    break;

                case 2:
                    Console.WriteLine("Matrix is:");
                    DisplayMatrix(row1, col1, arr1);
                    break;

                case 3:
                    Console.WriteLine("Enter First Matrix:");
                    CreateMatrix(ref row1, ref col1, out arr1);
                    Console.WriteLine("Enter Second Matrix:");
                    CreateMatrix(ref row2, ref col2, out arr2);
                    Console.WriteLine("First Matrix is:");
                    DisplayMatrix(row1, col1, arr1);
                    Console.WriteLine("Second Matrix is:");
                    DisplayMatrix(row2, col2, arr2);
                    Console.WriteLine("Matrix Addition:");
                    MatrixAddition(row1, col1, row2, col2, arr1, arr2);
                    
                    // Implement matrix addition here
                    break;

                case 4:
                    Console.WriteLine("Enter First Matrix:");
                    CreateMatrix(ref row1, ref col1, out arr1);
                    Console.WriteLine("Enter Second Matrix:");
                    CreateMatrix(ref row2, ref col2, out arr2);
                    Console.WriteLine("First Matrix is:");
                    DisplayMatrix(row1, col1, arr1);
                    Console.WriteLine("Second Matrix is:");
                    DisplayMatrix(row2, col2, arr2);
                    Console.WriteLine("Matrix Subtraction:");
                    MatrixSubtraction(row1, col1, row2, col2, arr1, arr2);
                    // Implement matrix subtraction here
                    break;

                case 5:
                    Console.WriteLine("Enter First Matrix:");
                    CreateMatrix(ref row1, ref col1, out arr1);
                    Console.WriteLine("Enter Second Matrix:");
                    CreateMatrix(ref row2, ref col2, out arr2);
                    Console.WriteLine("First Matrix is:");
                    DisplayMatrix(row1, col1, arr1);
                    Console.WriteLine("Second Matrix is:");
                    DisplayMatrix(row2, col2, arr2);
                    Console.WriteLine("Matrix Multiplication is:");
                    MatrixMultiplication(row1, col1, row2, col2, arr1, arr2);
                    break;

                case 6:
                    CreateMatrix(ref row1, ref col1, out arr1);
                    DisplayMatrix(row1, col1, arr1);
                    Console.WriteLine("Transpose of Matrix is:");
                    TransposeMatrix(row1, col1, arr1);
                    break;

                case 7:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }
        }
    }

    // Method to create a matrix
    public static void CreateMatrix(ref int rows, ref int columns, out int[,] matrix)
    {
        Console.Write("Enter the Rows of Matrix: ");
        rows = int.Parse(Console.ReadLine());
        Console.Write("Enter the Columns of Matrix: ");
        columns = int.Parse(Console.ReadLine());
        matrix = new int[rows, columns];

        Console.WriteLine("Enter the Matrix:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"Enter value at [{i}][{j}]: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    public static void MatrixAddition(int row1,int col1,int row2,int col2,int[,]arr1,int[,]arr2)
    {
        int[,] arr3 = new int[row1, col1];
        if (row1 == row2 && col1 == col2)
        {
            for(int i=0;i<row1;i++)
            {
                for(int j=0;j<col1;j++)
                {
                    arr3[i, j] = arr1[i, j] + arr2[i, j];
                }
            }
            DisplayMatrix(row1, col1, arr3);
        }
        else
        {
            Console.WriteLine("Addition Can't be Perform , Matrix Size is not Same.....!");
        }
    }

    public static void MatrixSubtraction(int row1, int col1, int row2, int col2, int[,] arr1, int[,] arr2)
    {
        int[,] arr3 = new int[row1, col1];
        if (row1 == row2 && col1 == col2)
        {
            for (int i = 0; i < row1; i++)
            {
                for (int j = 0; j < col1; j++)
                {
                    arr3[i, j] = arr1[i, j] - arr2[i, j];
                }
            }
            DisplayMatrix(row1, col1, arr3);
        }
        else
        {
            Console.WriteLine("Subtraction Can't be Perform , Matrix Size is not Same.....!");
        }
    }

    public static void TransposeMatrix(int row1,int col1,int[,]arr1)
    {
        int[,] arr3 = new int[col1, row1];
        for (int i=0;i<row1;i++)
        {
            for(int j=0;j<col1;j++)
            {
                arr3[j, i] = arr1[i, j];
            }
           
         }
        DisplayMatrix(col1, row1, arr3);
    }

    public static void MatrixMultiplication(int row1, int col1, int row2, int col2, int[,] arr1, int[,] arr2)
    {
        int[,] arr3 = new int[row1, col1];
        if (row2 == col1)
        {
            for (int i = 0; i < row1; i++)
            {
                for (int j = 0; j < row2; j++)
                {
                    arr3[i, j] = 0;
                    for (int k = 0; k < 2; k++)
                    {
                        arr3[i, j] += arr1[i, k] * arr2[k, j];
                    }
                }
            }
            DisplayMatrix(row2, col1, arr3);
        }
        else
        {
            Console.WriteLine("Multiplication Can't be Perform , Matrix Size is not Same.....!");
        }
    }

    // Method to display a matrix
    public static void DisplayMatrix(int rows, int columns, int[,] matrix)
    {

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
