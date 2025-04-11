using System;

public static class MatrixExtensions
{
    public static SquareMatrix Transpose(this SquareMatrix matrix)
    {
        SquareMatrix transposedMatrix = new SquareMatrix(matrix.size);
        for (int row = 0; row < matrix.size; ++row)
        {
            for (int column = 0; column < matrix.size; ++column)
            {
                transposedMatrix.dataOfMatrix[row, column] = matrix.dataOfMatrix[column, row];
            }
        }
        return transposedMatrix;
    }

    public static int Trace(this SquareMatrix matrix)
    {
        int diagonalSum = 0;
        for (int index = 0; index < matrix.size; ++index)
        {
            diagonalSum += matrix.dataOfMatrix[index, index];
        }
        return diagonalSum;
    }
}
