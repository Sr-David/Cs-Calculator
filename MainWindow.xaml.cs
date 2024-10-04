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

namespace Calculadora
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
    
        bool tocaOperar = false;
        double resultado = 0;
        double num1 = 0;
        double num2 = 0;
        string tipoOperacion = "";
        bool punto = false;
        bool acabado = false;

        public MainWindow()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button numeroBoton = sender as Button;
            string contenidoBoton = numeroBoton.Content.ToString();

            if (acabado == true)
            {
                MainText.Text = "0";
                acabado = false;
            }



            // Manejar el texto primncipal
            if (MainText.Text == "0")
            {
                MainText.Text = contenidoBoton;
                if (contenidoBoton == ",")
                {
                    MainText.Text = "0,";
                    punto = true;
                }


            }
            else
            {
                if (MainText.Text.Length < 18)
                {
                    if(contenidoBoton == ",")
                    {

                        if (punto == false)
                        {
                            MainText.Text += ",";
                            punto = true;
                        }


                    }
                    else
                    {
                        
                        MainText.Text += contenidoBoton;
                    }

                }
            }
        }





        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            

            if (e.Key >= Key.D0 && e.Key <= Key.D9)
            {
                int numero = e.Key - Key.D0;
                Button_Click(GetButtonByNumber(numero), null);
            }
            else if (e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9)
            {
                int numero = e.Key - Key.NumPad0;
                Button_Click(GetButtonByNumber(numero), null);
            }
            else if (e.Key == Key.Back)
            {
                if (MainText.Text.Length > 1)
                {
                    MainText.Text = MainText.Text.Substring(0, MainText.Text.Length - 1);
                }
                else
                {
                    MainText.Text = "0";
                    punto = false;
                }
            }
            else if (e.Key == Key.Escape)
            {

                MainText.Text = "0";
                SecondaryText.Text = "";
                num1 = 0;
                num2 = 0;
                resultado = 0;
                tocaOperar = false;
                punto = false;
                acabado = false;
            }else if(e.Key == Key.Enter)
            {
                   
                Igual_Click(equal,null);

            }
            else if (e.Key == Key.Add)
            {

                operacion(sumar, null);

            }
            else if (e.Key == Key.Subtract)
            {
                operacion(restar, null);
            }
            else if (e.Key == Key.Multiply)
            {
                operacion(multiply, null);
            }
            else if (e.Key == Key.Divide)
            {
                operacion(dividir, null);
            }
            else if (e.Key == Key.Decimal)
            {
                Button_Click(comma, null);
            }
            else if (e.Key == Key.OemComma)
            {
                Button_Click(comma, null);
            }
            else if (e.Key == Key.OemPeriod)
            {
                Button_Click(comma, null);
            }
            else if (e.Key == Key.OemPlus)
            {
                operacion(sumar, null);
            }
            else if (e.Key == Key.OemMinus)
            {
                operacion(restar, null);
            }
           
            else if (e.Key == Key.OemPeriod)
            {
                Button_Click(comma, null);
            }
            
            else if (e.Key == Key.OemPlus)
            {
                operacion(sumar, null);
            }
            else if (e.Key == Key.OemMinus)
            {
                operacion(restar, null);
            }
           
       
        }

        private Button GetButtonByNumber(int numero)
        {
            switch (numero)
            {
                case 0:
                    return Button0;
                case 1:
                    return Button1;
                case 2:
                    return Button2;
                case 3:
                    return Button3;
                case 4:
                    return Button4;
                case 5:
                    return Button5;
                case 6:
                    return Button6;
                case 7:
                    return Button7;
                case 8:
                    return Button8;
                case 9:
                    return Button9;
                default:
                    return null;
            }
        }

        private void operacion(object sender, RoutedEventArgs e)
        {

        

            tipoOperacion = (sender as Button).Content.ToString();
            
            if(tocaOperar == false)
            {
                num1 = double.Parse(MainText.Text);
                tocaOperar = true;
            }
            else
            {
                num2 = double.Parse(MainText.Text);
                CalcularResultado();
            }
            SecondaryText.Text += MainText.Text + " " + tipoOperacion + " ";

            MainText.Text = "0";




        }

        private void CalcularResultado()
        {

            switch (tipoOperacion)
            {
                case "+":
                    resultado = num1 + num2;
                    break;
                case "-":
                    resultado = num1 - num2;
                    break;
                case "x":
                    resultado = num1 * num2;
                    break;
                case "÷":
                    resultado = num1 / num2;
                    break;
            }

            num1 = resultado;
            num2 = 0;
            Console.WriteLine(resultado);


        }

        private void Igual_Click(object sender, RoutedEventArgs e)
        {


            num2 = double.Parse(MainText.Text);
            CalcularResultado();
            MainText.Text = resultado.ToString();
            SecondaryText.Text = "";
            tocaOperar = false;
            punto = false;
            acabado = true;


        }
    }
}





