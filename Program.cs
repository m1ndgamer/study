using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int index;
            #region Задание 1
            // a
            bool isTrue = true;
            int num1 = -10;
            uint num1u = 10;
            float num2 = 20.0f;
            double num3 = 30.0;
            decimal num4 = 40.0m;
            long long1 = -9_223_372_036_854_775_807;
            ulong long2 = 18_446_744_073_709_551_615;
            short short1 = 343;
            ushort short2 = 434;
            char sym1 = 's';
            byte value1 = 23;
            sbyte value2 = -23;
            // b
            num2 = num1;
            long1 = num1;
            num1 = sym1;
            long2 = short2;
            long1 = value1;

            num3 = Convert.ToDouble(isTrue);
            short1 = Convert.ToInt16(long1);
            value2 = sbyte.Parse("16");
            sym1 = Convert.ToChar(num1);
            num1u = Convert.ToUInt32(num4);
            // c
            num1 = 25;
            object obj = num1;
            num1 = (int)obj;
            // d
            var hello = "Hello!";
            // e
            bool? isFalse = null;
            bool tester = isFalse ?? true;
            if (isFalse.HasValue)
            {
                Console.WriteLine(isFalse.Value);
            }
            else
            {
                Console.WriteLine("Is null");
            }
            Console.WriteLine(tester);
            // f
            //var sym2 = 'f';
            //sym2 = 34;
            #endregion
            #region Задание 2
            // a
            string line1 = "line one";
            string line2 = "line 2";
            string line3 = "line 3";
            Console.WriteLine(line1 == line2);
            // b
            line1 += " ";
            Console.WriteLine(string.Concat(line1, line2));
            Console.WriteLine(line1 = string.Copy("line ONE"));
            Console.WriteLine($"Строка line2 содержит '2': {line2.Contains("2")}");
            foreach (var elem in line3.Split(new char[] { ' ' }))
            {
                Console.WriteLine(elem);
            }
            line3 = line3.Insert(6, " (three)");
            line2 = line2.Replace("line", "");
            // c
            string line4 = null;
            if (string.IsNullOrEmpty(line4))
            {
                Console.WriteLine($"NULL равен пустой строке?: {line4 == String.Empty}");
                Console.WriteLine($"Строка содержит null.");
            }
            // d
            StringBuilder line5 = new StringBuilder("Xa345mari");
            line5.Remove(2, 3);
            line5.Insert(6, "n");
            Console.WriteLine(line5.ToString());
            #endregion
            #region Задание 3
            // a
            const int Size = 10;
            int[,] matrix = new int[Size, Size];
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    matrix[i, j] = random.Next(1, 10);
                    Console.Write($"{matrix[i, j]} \t");
                }
                Console.Write("\n\n");
            }
            // b
            string[] lines = new string[Size]
            {
                "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine",
            };
            Console.WriteLine($"Длина массива: {lines.Length}");
            foreach (var elem in lines)
            {
                Console.Write($"{elem} ");
            }
            Console.WriteLine();
            Console.Write($"Введите индекс элемента: ");
            while (!int.TryParse(Console.ReadLine(), out index) || index >= Size || index < 0);
            Console.Write($"Введите значение элемента: ");
            lines[index] = Console.ReadLine();
            Console.WriteLine($"Новый массив:");
            foreach (var elem in lines)
            {
                Console.Write($"{elem} ");
            }
            Console.WriteLine();
            // c
            float[][] floatArr = new float[3][] { new float[2], new float[3], new float[4] };
            for (var i = 0; i < floatArr.Length; i++)
            {
                for (var j = 0; j < floatArr[i].Length; j++)
                {
                    Console.WriteLine($"Введите элемент [{i}][{j}]:");
                    while (!float.TryParse(Console.ReadLine(), out floatArr[i][j]));
                }
            }
            Console.WriteLine();
            foreach (var row in floatArr)
            {
                foreach (var elem in row)
                {
                    Console.Write($"{elem}\t");
                }
                Console.WriteLine();
            }
            // d
            var line = "A first symbol";
            var numbers = new int[] { 41, 62, 23, 14, 45, 96, 12, 17, 88, 90, 19 };
            #endregion
            #region Задание 4
            // a
            (int first, string second, char third, string fourth, ulong fifth) tuple = (1, "second element", 'c', "four", 5);
            // b
            Console.WriteLine(tuple);
            Console.WriteLine($"1: {tuple.first}, 3: {tuple.third}, 4: {tuple.fourth}");
            // c
            var (number, text, sym, word, digit) = tuple;
            // (var number, var text, var sym, var word, var digit) = tuple;
            (int first, string second) tuple2 = (100, "tuple 2");
            // d
            Console.WriteLine(Object.Equals(tuple, tuple2));
            #endregion
            #region Задание 5
            (int, int, int, char) LocalFunction(int[] arr, string source)
            {
                int minElement = arr[0], maxElement = arr[0], arraySum = 0;
                for (var i = 1; i < arr.Length; i++)
                {
                    if (arr[i] < minElement)
                    {
                        minElement = arr[i];
                    }
                    if (arr[i] > maxElement)
                    {
                        maxElement = arr[i];
                    }
                    arraySum += arr[i];
                }
                return (minElement, maxElement, arraySum, source[0]);
            }
            Console.WriteLine(LocalFunction(numbers, line));
            #endregion
            #region Задание 6
            void TestChecked()
            {
                checked
                {
                    int checkedNumber = Int32.MaxValue;
                }
            }

            void TestUnchecked()
            {
                unchecked
                {
                    int uncheckedNumber = Int32.MaxValue;
                }
            }
            TestChecked();
            TestUnchecked();
            #endregion
            Console.ReadLine();
        }
    }
}
