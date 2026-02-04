using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class Calculator
    {
        // Сложение двух чисел
        public static double Sum(double a, double b)
        {
            return a + b;
        }
        // Вычитание двух чисел
        public static double Substract(double a, double b)
        {
            return a - b;
        }
        // Умножение двух чисел
        public static double Multiply(double a, double b)
        {
            return a * b;
        }
        // Деление двух чисел
        public static double Divide(double a, double b)
        {
            return a / b;
        }
    }

}
