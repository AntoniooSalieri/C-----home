
bool Finder(int[,] array, int m, int n){
    m --;
    n --;
    if (n < array.GetLength(0)){
        if (m < array.GetLength(1)){
            Console.WriteLine( array[n, m]);
            return true;
        }
        else return false;
    }
    else return false;
}

int[,] arrayForTest = {
        {0, 0, 0},
        {0, 0, 0}
};
int mTest = 3;
int nTest = 2;

Console.WriteLine(Finder(arrayForTest, mTest, nTest));