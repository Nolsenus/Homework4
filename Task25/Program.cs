double Power(double a, int b) {
    double result = a;
    for (int i = 1; i < b; ++i) {
        result *= a;
    }
    return result;
}

try{
    Console.Write("Введите число для возведения в степень: ");
    double a = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите натуральное число - степень: ");
    int b = Convert.ToInt32(Console.ReadLine());
    if(b < 1) {
        Console.WriteLine("Вы ввели не натуральное число.");
    } else {
        Console.WriteLine($"{a}, {b} -> {Power(a,b)}");
    }
} catch {
    Console.WriteLine("Вы ввели что-то неправильное.");
}