string inputString = Console.ReadLine() + " ";


bool IsNumber(char X){
    char[] numbersChar = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};

    for (int j = 0; j < 10; j++){

            if (X == numbersChar[j]){
            return true;
            }
    }
    
    return false;
}

int Skip(int index, string x){
    
        bool check = true;
        while (check == true){
            index++;
            check = IsNumber(x[index]);     
        }
    return index;
}

int PositiveNumbersCounter(string text){

    int count = 0;

    for (int i = 0; i < text.Length; i++){
        if (text[i] == '-'){
            i = Skip(i, text);
        }
        if (IsNumber(text[i]) == true && text[i] != '0'){
            count++;
            i = Skip(i, text);
        }

        //Console.WriteLine(i);
    }

    return count;
}

Console.WriteLine(PositiveNumbersCounter(inputString));