int DigitSum(int number) {
    if (number < 0) {
        number = -number;
    }
    int sum = number % 10;
    while (number / 10 > 0) {
        number /= 10;
        sum += number % 10;
    }
    return sum;
}

try{
    Console.Write("Введите целое число: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"{a} -> {DigitSum(a)}");
} catch {
    Console.Write("Вы ввели не целое число.");
}