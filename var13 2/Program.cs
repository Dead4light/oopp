// See https://aka.ms/new-console-template for more information
using var13_2;

Console.WriteLine("Hello, World!");



    static void Main(string[] args)
    {
        Coefficient[] coeffs = { new Coefficient(0, 0, 1.2), new Coefficient(1, 2, 3.4), new Coefficient(2, 1, 5.6) };

        SparseMatrix matrix = new SparseMatrix(3, coeffs);

        Console.WriteLine("Original Matrix:");
        matrix.PrintMatrix();

        // Зміна окремих складових частин об'єкта
        matrix.ChangeCoefficient(1, 1, 1, 9.9);

        Console.WriteLine("\nMatrix after changing coefficient:");
        matrix.PrintMatrix();
    }

Main(args);
