using System;
class Program1
{
    static void Main()
    {
        int UserNumberA;
        Console.Write("Введите длину стороны A и и нажмите Enter" +
        Environment.NewLine + " Длина стороны A равна: ");

        while (!int.TryParse(Console.ReadLine(), out UserNumberA) || UserNumberA <= 0)

            Console.Write("Ошибка! Вы ввели 0, отрицательное или не числовое значение," +
            Environment.NewLine + "попробуйте ещё раз: ");

        int UserNumberB;
        Console.Write("Введите длину стороны В и нажмите Enter" +
        Environment.NewLine + " Длина стороны В равна: ");

        while (!int.TryParse(Console.ReadLine(), out UserNumberB) || UserNumberB <= 0)

            Console.Write("Ошибка! Вы ввели 0, отрицательное или не числовое значение," +
            Environment.NewLine + "попробуйте ещё раз: ");

        int RectangleArea = UserNumberA * UserNumberB;

        Console.WriteLine("Вы ввели:" +
        Environment.NewLine + "А = {0}" +
        Environment.NewLine + "B = {1}" +
        Environment.NewLine + "Площадь = {2}",
        UserNumberA, UserNumberB, RectangleArea);
    }
}