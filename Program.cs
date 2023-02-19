void PrintArray(String[] array){
    foreach(var elem in array){
        Console.WriteLine(elem);
    }
}

void Main(){
    String [] init_array = {"2r2f","....","gg","hello","my","world","!!!"};
    int count = 0;
    bool [] filter_array = new bool[init_array.Length];

    Console.WriteLine("Start array: ");
    Console.ForegroundColor = ConsoleColor.Blue;
    PrintArray(init_array);
    Console.ResetColor();

    for(int i=0; i < init_array.Length; i++){
        filter_array[i]  = init_array[i].Length <= 3;
        count += init_array[i].Length <= 3 ? 1 : 0;
    }
    String[] finish_array = new String[count];

    for(int i=0; i < init_array.Length; i++){
        if(filter_array[i]){
            finish_array[finish_array.Length - count] = init_array[i];
            count --;
        }
    }
    Console.WriteLine("Filred array elements with lenght less or equal 3: ");
    Console.ForegroundColor = ConsoleColor.Green;
    PrintArray(finish_array);
    Console.ResetColor();

}

Main();