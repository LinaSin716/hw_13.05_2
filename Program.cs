namespace hw_13._05_2
{
    // только морзе
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку (только русский алфавит без ё и пробелы): ");
            string str = Console.ReadLine();

            num_4.ToRus toRus = new num_4.ToRus();
            num_3.ToMorse toMorse = new num_3.ToMorse();

            Console.WriteLine($"на Морзе: {toMorse.StrToMorse(str)}");
            Console.WriteLine($"обратно: {toRus.StrToRus(toMorse.StrToMorse(str))}");

            Console.WriteLine("\nВведите строку на морзе (буквы разделять пробелом, а слова /): ");
            str = Console.ReadLine();

            Console.WriteLine($"на Русский: {toRus.StrToRus(str)}");
            Console.WriteLine($"обратно: {toMorse.StrToMorse(toRus.StrToRus(str))}");
        }
    }
}