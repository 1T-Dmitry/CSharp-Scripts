using MatrixMath;;

Matrix matrix1 = new Matrix(new float[,] 
{
    {2, 3, 1},
    {4, 5, 2}, 
    {6, 7, 3}
});

Matrix matrix2 = new Matrix(new float[,]
{
    {3, 5, 7},
    {0, 2, 3},
    {-2, 9, 8}
});


Matrix matrix3 = Matrix.Transpose(matrix2);
Matrix.PrintMatrix(matrix2);
Console.WriteLine();
Matrix.PrintMatrix(matrix3);
