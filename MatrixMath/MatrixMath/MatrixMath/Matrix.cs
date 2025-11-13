namespace MatrixMath
{
    public class Matrix
    {
        private float[,] _array;

        public Matrix(float[,] array)
        {
            _array = array;
        }

        public Matrix Determinant(Matrix matrix)
        {
            throw new NotImplementedException();
        }

        public Matrix Minor(Matrix matrix)
        {
            throw new NotImplementedException();
        }

        public Matrix Multiply(Matrix matrix1, Matrix matrix2)
        {
            throw new NotImplementedException();
        }

        public static Matrix Subtract(Matrix matrix1, Matrix matrix2)
        {
            Matrix newMatrix = new Matrix(new float[matrix1._array.GetLength(0), matrix1._array.GetLength(1)]);

            if (matrix1._array.Length != matrix2._array.Length)
            {
                throw new ArgumentException("The matrices are different in size");
            }

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
            Matrix newMatrix = new Matrix(new float[matrix1._array.GetLength(0), matrix1._array.GetLength(1)]);

            if (matrix1._array.Length != matrix2._array.Length)
            {
                throw new ArgumentException("The matrices are different in size");
            }
            
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
