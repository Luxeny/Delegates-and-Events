using System;

public static class MatrixExtensions
{
    public static SquareMatrix Transpose(this SquareMatrix matrix)
    {
        SquareMatrix result = new SquareMatrix(matrix.size);
        for (int i = 0; i < matrix.size; i++)
        {
            for (int j = 0; j < matrix.size; j++)
            {
                result.dataOfMatrix[i, j] = matrix.dataOfMatrix[j, i];
            }
        }
        return result;
    }

    public static int Trace(this SquareMatrix matrix)
    {
        int trace = 0;
        for (int i = 0; i < matrix.size; i++)
        {
            trace += matrix.dataOfMatrix[i, i];
        }
        return trace;
    }
}