using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program44
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- 4. Таблица успеваемости ---\n");

            // Объявляем массивы для хранения данных студентов
            string[] names = new string[3];
            int[] courses = new int[3];
            double[] grades = new double[3];

            // Заполнение данных о студентах
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Студент {i + 1} — ФИО: ");
                names[i] = Console.ReadLine()?.Trim() ?? "Неизвестный";

                // Метод для чтения положительного целого числа
                courses[i] = ReadPositiveInt($"Студент {i + 1} — курс: ");

                // Метод для чтения двойного значения
                grades[i] = ReadDouble($"Студент {i + 1} — средний балл: ");
                Console.WriteLine();
            }

            // Форматирование и вывод таблицы
            Console.WriteLine(new string('-', 38));
            Console.WriteLine("{0,-20} {1,5} {2,8:F2}", "ФИО", "Курс", "Балл");
            Console.WriteLine(new string('-', 38));

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("{0,-20} {1,5} {2,8:F2}", names[i], courses[i], grades[i]);
            }

            Console.WriteLine(new string('-', 38));
            Console.WriteLine();
        }

        // Метод для чтения положительного целого числа
        static int ReadPositiveInt(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out int result) && result > 0)
                {
                    return result;
                }
                Console.WriteLine("Пожалуйста, введите положительное число.");
            }
        }

        // Метод для чтения двойного значения
        static double ReadDouble(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                if (double.TryParse(Console.ReadLine(), out double result))
                {
                    return result;
                }
                Console.WriteLine("Пожалуйста, введите корректное числовое значение.");
            }
        }
    }
}

