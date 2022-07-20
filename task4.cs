using System;
class Program4
{
    private const char Symbol = '*';
    private const char EmptySymbol = ' ';
    private const int DoublingLengthValue = 2;
    private const int NumberFirstSymbol = 1;
    static void Main()
    {
        int NumberTriangles;
        Console.Write("Введите количество треугольников: ");
        while (!int.TryParse(Console.ReadLine(), out NumberTriangles) || NumberTriangles <= 0)
            Console.Write("Ошибка! Вы ввели 0, отрицательное или не числовое значение," +
            Environment.NewLine + "попробуйте ещё раз: ");


        for (int b = 0; b <= NumberTriangles; b++)
            for (int countSymbol = NumberFirstSymbol; countSymbol <= b; countSymbol++)
                Console.WriteLine(new string(EmptySymbol, NumberTriangles - countSymbol) + new string(Symbol, countSymbol * DoublingLengthValue - NumberFirstSymbol));
    }
}