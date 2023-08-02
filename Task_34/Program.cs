int[] randomArray = ArrayGenerator(13, 100, 999);
Console.WriteLine($"Количество чётных чисел в массиве [{String.Join(", ", randomArray)}] равно {EvenNumbersCounter(randomArray)}");

int[] ArrayGenerator (int size, int min, int max){
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(min, max + 1);
    return array;
}

int EvenNumbersCounter (int[] array){
    int count = 0;
    foreach(int el in array){
        if (el % 2 == 0) count++;
    }
    return count;
}