int[] RandomArrayOfSizeEight(int rangeLow, int rangeHigh) {
    int[] result = new int[8];
    for (int i = 0; i < 8; ++i) {
        result[i] = new Random().Next(rangeLow, rangeHigh);
    }
    return result;
}

void PrintIntArray(int[] arr) {
    for(int i = 0; i < arr.Length - 1; ++i) {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine(arr[arr.Length - 1]);
}

PrintIntArray(RandomArrayOfSizeEight(1, 11));