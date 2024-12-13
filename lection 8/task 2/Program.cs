int[,] testArray = new int[8, 5];

Random random = new Random();

void FillArrayRec(int[,] arr, int line = 0, int position = 0){
    if (position < arr.GetLength(1)){
        arr[line, position] = random.Next(0, 10);
        FillArrayRec(arr, line, position+1);
    }
    else if (line + 1 < arr.GetLength(0)){
        FillArrayRec(arr, line + 1, position = 0);
    }
}

void PrintArrayRec(int[,] arr, int line = 0, int position = 0){
    if (position < arr.GetLength(1)){
        Console.Write($"{arr[line, position]} ");
        PrintArrayRec(arr, line, position + 1);
    }
    else if (line + 1 < arr.GetLength(0)){
        Console.WriteLine();
        PrintArrayRec(arr, line + 1, 0);
    }
}

int FindLineSummRec(int[,] arr, int line, int position = 0){
    int summLine = 0;
    if (position + 1 < arr.GetLength(1)){
        summLine = arr[line, position] + FindLineSummRec(arr, line, position+1);
        return summLine;
    }
    else return arr[line, arr.GetLength(1) - 1];    
}

(int minR, int minIdR) FindMinLineInArray(int[,] arr, int line = 0){
    int min = FindLineSummRec(arr, 0),
        minId = 0;
    for (int i = 1; i < arr.GetLength(0); i ++){
        if (FindLineSummRec(arr, i)<min) {
            min = FindLineSummRec(arr, i);
            minId = i;
        }
    }
    return (min, minId);
}

FillArrayRec(testArray);
PrintArrayRec(testArray);
var result = FindMinLineInArray(testArray);
Console.WriteLine();
Console.WriteLine($"summ = {result.minR} ; id = {result.minIdR} .");
Console.WriteLine(result.GetType());