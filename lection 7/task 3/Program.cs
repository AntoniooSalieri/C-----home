void FillArray (int[,] array){
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            array[i, j] = random.Next(1, 10);
        }
    }
}

void PrintArray (int[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write(array[i,j]);
        }
    Console.WriteLine();
    }
}

void FindAndPrintMean (int[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
    double mean = array[i, 0];
        for (int j = 1; j < array.GetLength(1); j++){
        mean = mean + array[i, j];
        }
    mean = mean / array.GetLength(1);
    Console.WriteLine($"mean for line i = {mean}");
    }
}

int[,] testArray = new int[10, 10];

FillArray(testArray);
PrintArray(testArray);
FindAndPrintMean(testArray);