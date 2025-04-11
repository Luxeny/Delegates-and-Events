using System;

public delegate SquareMatrix MatrixOperation(SquareMatrix matrix);

public static class MatrixOperations
{
    public static readonly MatrixOperation Diagonalize = delegate(SquareMatrix matrix)
    {
        SquareMatrix diagonalMatrix = new SquareMatrix(matrix.size);
        for (int diagonalIndex = 0; diagonalIndex < matrix.size; ++diagonalIndex)
        {
            diagonalMatrix.dataOfMatrix[diagonalIndex, diagonalIndex] = matrix.dataOfMatrix[diagonalIndex, diagonalIndex];
        }
        return diagonalMatrix;
    };

    public static SquareMatrix ApplyOperations(SquareMatrix matrix, params MatrixOperation[] operations)
    {
        SquareMatrix processedMatrix = matrix;
        foreach (MatrixOperation operation in operations)
        {
            processedMatrix = operation(processedMatrix);
        }
        return processedMatrix;
    }
}
