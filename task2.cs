using System;
class Program2
{
    private const char SymbolOfTriangle = '*';
    private const int FirstNumber = 0;
    static void Main()
    {
        int UserNumber;
        Console.Write("Введите произвольное положительное число N и нажмите Enter" +
        Environment.NewLine + "N равно: ");
        while (!int.TryParse(Console.ReadLine(), out UserNumber) || UserNumber <= 0)
            Console.Write("Ошибка! Вы ввели 0, отрицательное или не числовое значение," +
            Environment.NewLine + "попробуйте ещё раз: ");

        string symbol = SymbolOfTriangle.ToString();

        for (int countSymbol = FirstNumber; countSymbol < UserNumber; countSymbol++)
            Console.WriteLine(symbol.PadLeft(countSymbol + 1, SymbolOfTriangle));
    }
}