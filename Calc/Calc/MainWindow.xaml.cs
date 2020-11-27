using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        long number1 = 0;
        long number2 = 0;
        string operation = ""; //skapar en operation som ska hålla ha koll på ifall en operation används eller inte som +,-,/,* osv
        // operation ska också hålla koll på vilken "operation" då som ska användas som ett + - osv
        public MainWindow()
        {
            InitializeComponent(); // ???
        }



        private void btnPlus_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            operation = "+"; //bestämmer att operation ett + och därmed ska leda till casen med ett + vilket då är addition
            resultWindow.Text = "0"; // nollställer bara fönstret till en 0:a
        }
        private void btnMultiplication_Click(object sender, RoutedEventArgs e)
        {
            operation = "*";
            resultWindow.Text = "0";
        }

        private void btnDivision_Click(object sender, RoutedEventArgs e)
        {
            operation = "/";
            resultWindow.Text = "0";

        }
        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            operation = "-";
            resultWindow.Text = "0";
        }
        private void squareRoot_Click(object sender, RoutedEventArgs e)
        {
            operation = "squareroot";
            
        }
        private void PowerTo_Click(object sender, RoutedEventArgs e)
        {
            operation = "x^2";
        
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        { // denna nollställer nummrerna, den gör det typ, ifall man ska göra multipla operationer så skiter den ner sig men annars funkar den 
            resultWindow.Text = "0";
            number1 = 0;
            number2 = 0;
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            // denna if och else satsen bestämmer ifall ingen operation tilläggs så ska den fortsätta med att lägga till nummer så tex
            // 20
            // 201
            {
                number1 = (number1 * 10);
                resultWindow.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10);
                resultWindow.Text = number2.ToString();
            }
        }
        private void btn1_Click(object sender, System.Windows.RoutedEventArgs e) // vet faktiskt inte vad allt detta betyder jag vet bara att man behöver används den för att skicka och ta emot objekt eller något liknande
        {
            if (operation == "")
            // denna if och else satsen bestämmer ifall ingen operation tilläggs så ska den fortsätta med att lägga till nummer så tex
            // 20
            // 201
            {
                number1 = (number1 * 10) + 1;
                resultWindow.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 1;
                resultWindow.Text = number2.ToString();
            }

        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")

            {
                number1 = (number1 * 10) + 2;
                resultWindow.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 2;
                resultWindow.Text = number2.ToString();
            }

        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")

            {
                number1 = (number1 * 10) + 3;
                resultWindow.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 3;
                resultWindow.Text = number2.ToString();
            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")

            {
                number1 = (number1 * 10) + 4;
                resultWindow.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 4;
                resultWindow.Text = number2.ToString();
            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")

            {
                number1 = (number1 * 10) + 5;
                resultWindow.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 5;
                resultWindow.Text = number2.ToString();
            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")

            {
                number1 = (number1 * 10) + 6;
                resultWindow.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 6;
                resultWindow.Text = number2.ToString();
            }
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")

            {
                number1 = (number1 * 10) + 7;
                resultWindow.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 7;
                resultWindow.Text = number2.ToString();
            }
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")

            {
                number1 = (number1 * 10) + 8;
                resultWindow.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 8;
                resultWindow.Text = number2.ToString();
            }
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")

            {
                number1 = (number1 * 10) + 9;
                resultWindow.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 9;
                resultWindow.Text = number2.ToString();
            }
        }
        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            switch (operation) // denna switchen är baserad på operation som bestäms beroende på vilken knapp man har tryckt på och därmed då ifall man klickar på + knappen så kommer man till + casen
            {
                case "+": 
                    resultWindow.Text = (number1 + number2).ToString();
                    break;
                case "-":
                    resultWindow.Text = (number1 - number2).ToString();
                    break;
                case "*":
                    resultWindow.Text = (number1 * number2).ToString();
                    break;
                case "/":
                    resultWindow.Text = (number1 / number2).ToString();
                    break;
                case "squareroot":
                    resultWindow.Text = (Math.Sqrt(number1)).ToString();
                    break;
                case "x^2":
                    resultWindow.Text = (number1 * number1).ToString();
                    break;
                    


            }
        }


    }






}
