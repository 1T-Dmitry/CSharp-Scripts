namespace MatrixMath
{
    public class Matrix
    {
        private float[,] _array;

        public Matrix(float[,] array)
        {
            _array = array;
        }

        public static float Determinant(Matrix matrix)
        {
            int n = matrix._array.GetLength(0);

            if (n != matrix._array.GetLength(1))
                throw new ArgumentException("The matrix must be square");

            if (n == 1)
                return matrix._array[0, 0];
            if (n == 2)
                return matrix._array[0, 0] * matrix._array[1, 1]
                    - matrix._array[0, 1] * matrix._array[1, 0];

            float det = 0;

            for (int j = 0; j < n; j++)
            {
                float minor = GetMinor(matrix, 0, j);
                float sign = (j % 2 == 0) ? 1 : -1;
                det += sign * matrix._array[0, j] * minor;
            }

            return det;
        }

        public static Matrix CreateSubMatrix(Matrix matrix, int rowToRemove, int colToRemove)
        {
            int n = matrix._array.GetLength(0);

            Matrix newMatrix = new Matrix(new float[n - 1, n - 1]);

            int resultRow = 0;
            for (int i = 0; i < n; i++)
            {
                if (i == rowToRemove) continue;

                int resultCol = 0;
                for (int j = 0; j < n; j++)
                {
                    if (j == colToRemove) continue;

                    newMatrix._array[resultRow, resultCol] = matrix._array[i, j];
                    resultCol++;
                }
                resultRow++;
            }

            return newMatrix;
        }

        public static float GetMinor(Matrix matrix, int row, int col)
        {
            Matrix subMatrix = CreateSubMatrix(matrix, row, col);
            return Determinant(subMatrix);
        }

        public static Matrix Multiply(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1._array.GetLength(1) != matrix2._array.GetLength(0))
                throw new ArgumentException("The number of columns in the first matrix must be " +
                    "equal to the number of rows in the second matrix");

            int rows = matrix1._array.GetLength(0);
            int cols = matrix2._array.GetLength(1);
            int common = matrix1._array.GetLength(1);

            Matrix newMatrix = new Matrix(new float[rows, cols]);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    float sum = 0;
                    for (int k = 0; k < common; k++)
                    {
                        sum += matrix1._array[i, k] * matrix2._array[k, j];
                    }
                    newMatrix._array[i, j] = sum;
                } 
            }

            return newMatrix;
        }

        public static Matrix Subtract(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1._array.Length != matrix2._array.Length)
                throw new ArgumentException("The matrices are different in size");

            Matrix newMatrix = new Matrix(new float[matrix1._array.GetLength(0), matrix1._array.GetLength(1)]);

            for (int i = 0; i < matrix1._array.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1._array.GetLength(1); j++)
                {
                    newMatrix._array[i, j] = matrix1._array[i, j] - matrix2._array[i, j];
                }
            }

            return newMatrix;
        }

        public static Matrix Sum(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1._array.Length != matrix2._array.Length)
                throw new ArgumentException("The matrices are different in size");

            Matrix newMatrix = new Matrix(new float[matrix1._array.GetLength(0), matrix1._array.GetLength(1)]);

            for (int i = 0; i < matrix1._array.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1._array.GetLength(1); j++)
                {
                    newMatrix._array[i, j] = matrix1._array[i, j] + matrix2._array[i, j];
                }
            }

            return newMatrix;
        }

        public static Matrix Transpose(Matrix matrix)
        {
            Matrix newMatrix = new Matrix(new float[matrix._array.GetLength(0), matrix._array.GetLength(1)]);

            for (int i = 0; i < matrix._array.GetLength(0); i++)
            {
                for (int j = 0; j < matrix._array.GetLength(1); j++)
                {
                    newMatrix._array[i, j] = matrix._array[j, i];
                }
            }

            return newMatrix;
        }

        public static void PrintMatrix(Matrix matrix)
        {
            for (int i = 0; i < matrix._array.GetLength(0); i++)
            {
                for(int j = 0; j < matrix._array.GetLength(1); j++)
                {
                    Console.Write($"{matrix._array[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
