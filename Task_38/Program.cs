int[] randomArray = ArrayGenerator(13, 1, 69);
int max = findMax(randomArray);
int min = findMin(randomArray);
int diff = max - min;
Console.WriteLine($"разница между максимальным и минимальным элементов массива [{String.Join(", ", randomArray)}] => {max} - {min} = {diff}");

int[] ArrayGenerator (int size, int min, int max){
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(min, max + 1);
    return array;
}

int findMax (int[] array){
    int max = array[0];
    foreach(int el in array){
        max = el > max ? el : max;
    }
    return max;
}

int findMin (int[] array){
    int min = array[0];
    foreach(int el in array){
        min = el < min ? el : min;
    }
    return min;
}

