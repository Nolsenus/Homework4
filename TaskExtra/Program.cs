int[] RandomArray(int size, int rangeLow, int rangeHigh) {
    int[] result = new int[size];
    for (int i = 0; i < size; ++i) {
        result[i] = new Random().Next(rangeLow, rangeHigh);
    }
    return result;
}

void SelectionSort (int[] arr) {
    for(int i = 0; i < arr.Length - 1; ++i) {
        int maxI = i;
        for(int j = i + 1; j < arr.Length; ++j) {
            if(arr[j] > arr[maxI]) {
                maxI = j;
            }
        }
        int temp = arr[i];
        arr[i] = arr[maxI];
        arr[maxI] = temp;
    }
}

void PrintIntArray (int[] array) {
    for (int i = 0; i < array.Length - 1; ++i) {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine(array[array.Length - 1]);
}

Console.Write("Введите натуральное число - размер массива: ");
try{
    int size = Convert.ToInt32(Console.ReadLine());
    if(size > 0){
        int[] arr = RandomArray(size, 1, 11);
        PrintIntArray(arr);
        SelectionSort(arr);
        PrintIntArray(arr);
    } else {
        Console.WriteLine("Вы ввели не натуральное число.");
    }
} catch {
    Console.WriteLine("Вы ввели не целое число.");
}