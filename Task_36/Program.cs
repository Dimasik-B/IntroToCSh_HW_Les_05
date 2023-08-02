int[] randomArray = ArrayGenerator(7, -13, 13);
Console.WriteLine($"Сума элементов на нечётных индексах массива [{String.Join(", ", randomArray)}] равна {arrayOddNumbersSum(randomArray)}");

int[] ArrayGenerator (int size, int min, int max){
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(min, max + 1);
    return array;
}

int arrayOddNumbersSum (int[] array){
    int sum = 0;
    for(int i = 0; i < array.Length; i++){
        sum += (i % 2 != 0) ? array[i] : 0;
    }
    return sum;
}