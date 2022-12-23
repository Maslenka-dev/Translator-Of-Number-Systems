using System;

namespace ConverterBetweenSystemsOfNumerations
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Я тупой дурачек который написал метод, возводящий число в степень, вместо того чтобы банально заюзать метод Pow из класса Math
            // Тот самый метод, возводящий число в степень
            int Degree(int value, int degree)
            {
                int result = value;
                if (degree == 1) { return result; }
                else if (degree == 0) { return 1; }
                else
                {
                    for (int i = 0; i < degree; i++)
                    {
                        if (i == 1) { result *= 1; }
                        else { result *= value; }
                    }
                    return result;
                }
            }
            // Скудный выбор
            Console.WriteLine("Введите цифру 1, если хотите перевести число из двоичной системы в десятичную");
            Console.WriteLine("Или введите 2, если хотите перевести число из десятичной системы в двоичную: ");
            int Choice = int.Parse(Console.ReadLine());
            if (Choice == 1)
            {
                ConvertFromBinaryCodeIntoDecimalCode();
                Console.WriteLine();
                Console.Read();
            }
            else if (Choice == 2)
            {
                ConvertFromDecimalCodeIntoBinaryCode();
                Console.WriteLine();
                Console.Read();
            }
            else
            {
                Console.WriteLine("ТЫ ТУПОЙ ВВЕДИ ЦИФЕРКУ 1 ИЛИ 2!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            }
            // В этом говне описана конвертация из двоичной системы в десятичную
            void ConvertFromBinaryCodeIntoDecimalCode()
            {
                Console.WriteLine("введите число в двоичной системе: ");
                string BinaryCodeString = Console.ReadLine();
                int[] BinaryCode = new int[BinaryCodeString.Length];

                /* Здесь я определил цикл который позволяет не вводить индекс массива прежде чем его описать,
                 * да и в целом описать массив одной строчкой */
                for (int i = 0; i < BinaryCodeString.Length; i++)
                {
                    string ConvertFromCharToString = Convert.ToString(BinaryCodeString[i]);
                    int NumberInArray = int.Parse(ConvertFromCharToString);
                    BinaryCode[i] = NumberInArray;
                }
                
                int DecimalCode = 0;
                int ValueOfLengthOfArray = BinaryCode.Length - 1;
                int ValueOfLengthOfArray2 = ValueOfLengthOfArray;
                int ValueOfEnumeration = -1;

                Console.WriteLine();
                Console.WriteLine("--------------------------------------------------");
                // Основной цикл
                while (true)
                {
                    if (ValueOfEnumeration == ValueOfLengthOfArray) { break; }
                    Console.WriteLine($"\tValueOfLengthOfArray: {ValueOfLengthOfArray2}");
                    int NumberToDegree = (int)Math.Pow(2, ValueOfLengthOfArray2);
                    Console.WriteLine($"\tNumberToDegree: {NumberToDegree}");
                    int Result = BinaryCode[ValueOfEnumeration + 1] *= NumberToDegree;
                    Console.WriteLine($"\tResult: {Result}");
                    DecimalCode += Result;
                    Console.WriteLine(DecimalCode);
                    ValueOfEnumeration++;
                    ValueOfLengthOfArray2--;
                }
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine();
                Console.WriteLine($"Ответ: {DecimalCode}");
            }
            // В этом говне описана конвертация из десятичной системы в двоичную
            void ConvertFromDecimalCodeIntoBinaryCode()
            {
                Console.WriteLine();
                Console.WriteLine("Введите число в десятичной системе: ");
                int DecimalCode = int.Parse(Console.ReadLine());
                Console.WriteLine();

                /* Описал CheckedResult, чтобы он первый пробежался по циклу и узнал сколько итераций потребуется,
                 * для того чтобы значение нашего числа при делении на 2 дошло до нуля */
                int CheckedResult = DecimalCode;
                int Result = DecimalCode;
                int Reminder = 0;
                int Enumeration = 0;
                
                while (CheckedResult != 0)
                {     
                    CheckedResult = CheckedResult /= 2;
                    Enumeration++;
                }

                Console.WriteLine("--------------------------------------------------");
                int[] BinaryCodeArray = new int[Enumeration];
                // Основной цикл
                while (Enumeration != 0)
                {
                    Enumeration--;
                    Reminder = Result % 2;
                    Result = Result /= 2;
                    Console.WriteLine($"Reminder: {Reminder}");
                    Console.WriteLine($"Result: {Result}");
                    BinaryCodeArray[Enumeration] = Reminder;
                }
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine();
                Console.WriteLine("Ответ: ");
                for (int i = 0; i < BinaryCodeArray.Length; i++)
                {
                    Console.Write(BinaryCodeArray[i]);
                }
                Console.WriteLine();
            }
        }
    }
}