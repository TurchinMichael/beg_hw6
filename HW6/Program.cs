using System;

namespace HW6
{
    class Program
    {
        static void Main(string[] args)
        {
            #region сколько чисел больше 0 ввел пользователь
            print($"\nВы ввели {HowManyNumbersBiggerZero(printInputInt("Сколько чисел вы хотите ввести:"))} чисел больше 0");
            #endregion

            #region найти точку пересечения двух прямых
            print("\nДля нахождения пересечания двух прямых, введите координаты:"); // для того, чтобы не нагромождать текстом
            double 
                k1 = printInputInt("\nкоординаты x первой прямой")/*5*/, 
                b1 = printInputInt("\nкоординаты y первой прямой")/*2*/, 
                k2 = printInputInt("\nкоординаты x второй прямой")/*9*/, 
                b2 = printInputInt("\nкоординаты y второй прямой")/*4*/;

            double x = (-b1 + b2) / (k1 - k2); // найдено после решения системы уравнений
            double y = k2 * x + b2; // использовано второе уравнение

            print($"\nТочка пересечения заданных прямых:\nx = {x}, y = {y}");
            #endregion
        }

        /// <summary>
        /// удобство вывода без лишнего текста
        /// </summary>
        /// <param name="mes">текст для вывода в консоль</param>
        static void print(string mes)
        {
            Console.WriteLine(mes);
        }

        /// </summary>
        /// отображение сообщения, прием из консоли значения, перевод полученного значения в число
        /// <param name="mes">сообщение перед запросом числа</param>
        /// <returns>число, введенное пользователем в консоли</returns>
        static int printInputInt(string mes)
        {
            Console.WriteLine(mes);
            int.TryParse(Console.ReadLine(), out int userNumber);
            return userNumber;
        }

        /// <summary>
        /// Ввод заданного количества чисел с консоли оператора, и проверка количества введенных цифр выше нуля
        /// </summary>
        /// <param name="numbers">количество запросов чисел с консоли оператора</param>
        /// <returns>количество чисел выше 0</returns>
        static int HowManyNumbersBiggerZero(int numbers)
        {
            int count = 0;

            for (int i = 0; i < numbers; i++)
            {
                count += printInputInt($"\nВведите число {i + 1}") > 0 ? 1 : 0;
            }
            return count;
        }
    }
}