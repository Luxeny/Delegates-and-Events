using System;

public delegate SquareMatrix MatrixOperation(SquareMatrix matrix);

public static class MatrixOperations
{
    public static readonly MatrixOperation Diagonalize = delegate(SquareMatrix matrix)
    {
        SquareMatrix result = new SquareMatrix(matrix.size);
        for (int i = 0; i < matrix.size; i++)
        {
            result.dataOfMatrix[i, i] = matrix.dataOfMatrix[i, i];
        }
        return result;
    };

    public static SquareMatrix ApplyOperations(SquareMatrix matrix, params MatrixOperation[] operations)
    {
        SquareMatrix result = matrix;
        foreach (var operation in operations)
        {
            result = operation(result);
        }
        return result;
    }
}