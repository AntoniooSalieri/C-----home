int m = 5,
    n = 5;

int[,] array = new int[m, n];

Random random = new Random();

void FillArray(int[,] arr, int row = 0, int column = 0){
    if (column < arr.GetLength(1)){
        arr[row, column] = random.Next(1, 10);;
        FillArray(arr, row, column + 1);
    }
    else{
        if (row + 1 < arr.GetLength(0)){      //почему -1?
            FillArray(arr, row + 1, 0);
        }
    }
}


void PrintArray(int[,] arr){
    for (int i = 0; i < arr.GetLength(0); i++){
        for (int j = 0; j < arr.GetLength(1); j++){
            Console.Write(arr[i, j]);
        }
        Console.WriteLine();
    }
    
}


FillArray(array);
PrintArray(array);