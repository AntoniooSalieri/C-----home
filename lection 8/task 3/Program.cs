int[,] matrixA = {
    {1 ,2},
    {2, 1},
    {3, 2},
    {6, 8}
};
int[,] matrixB = {
    {1 ,3, 1, 1},
    {2, 1, 1, 2},
};

int lineA = matrixA.GetLength(0),
    lengthA = matrixA.GetLength(1),
    lineB = matrixB.GetLength(0),
    lengthB = matrixB.GetLength(1);

if (lineA != lengthB){
    Console.WriteLine ("error");
}
else{

    for (int i = 0; i <  lineA; i++){
        for (int j = 0; j < lineA; j++){
            int summ = 0;
            for (int k = 0; k < lengthA; k++){
                summ += matrixA[i, k] * matrixB[k,j];
            }
        Console.Write($"{summ} ");
        }
    Console.WriteLine();
    }
}