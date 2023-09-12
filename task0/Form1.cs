using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task0
{
    //13
    //Реализовать функцию возведения в квадрат частного двух целых чисел
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            int number1, number2;

            do
            {
                
                number1 = random.Next(-50, 51); //диапазона [-50, 50]
                number2 = random.Next(-50, 51);//диапазона [-50, 50]

                // Проверяем корректность сгенерированных чисел
                if (IsValidNumber(number1) && IsValidNumber(number2) && number2 != 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Повторите генерацию.Сгенерированы некорректные числа ;)");
                }
            } while (true);

            //Вычисляем квадрат частного двух чисел
            double result = SquareOfQuotient(number1, number2);

            MessageBox.Show($"Первое число: {number1}\nВторое число: {number2}\nКвадрат суммы: {result}");
        }

        //Функция проверки корректности числа
        static bool IsValidNumber(int number)
        {
            // В данном примере считаем число корректным, если оно не равно 0
            return number != 0;
        }

        // Функция вычисления квадрата частного двух целых чисел
        static double SquareOfQuotient(int num1, int num2)
        {
            double quotient = (double)num1 / num2; //для точного деления
            double square = quotient * quotient;
            return square;
        }
    }
    
}