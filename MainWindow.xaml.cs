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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button numeroBoton = sender as Button;
            Console.WriteLine(numeroBoton.Content.ToString());
            if(MainText.Text == "0")
            {
                MainText.Text = numeroBoton.Content.ToString();
            }
            else
            {
                if(MainText.Text.Length < 18)
                {

                    MainText.Text += numeroBoton.Content.ToString();
                }
            }

        }



        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            // Verificar si la tecla presionada es el número 1


            if (e.Key == Key.D1 || e.Key == Key.NumPad1)
            {
                // Llamar al manejador de eventos del botón 1
                Button_Click(Button1, null);
            }
            else if (e.Key == Key.D2 || e.Key == Key.NumPad2)
            {
                // Llamar al manejador de eventos del botón 2
                Button_Click(Button2, null);
            }
            else if (e.Key == Key.D3 || e.Key == Key.NumPad3)
            {
                // Llamar al manejador de eventos del botón 2
                Button_Click(Button3, null);
            }
            else if (e.Key == Key.D4 || e.Key == Key.NumPad4)
            {
                // Llamar al manejador de eventos del botón 2
                Button_Click(Button4, null);
            }
            else if (e.Key == Key.D5 || e.Key == Key.NumPad5)
            {
                // Llamar al manejador de eventos del botón 2
                Button_Click(Button5, null);
            }
            else if (e.Key == Key.D6 || e.Key == Key.NumPad6)
            {
                // Llamar al manejador de eventos del botón 2
                Button_Click(Button6, null);
            }
            else if (e.Key == Key.D7 || e.Key == Key.NumPad7)
            {
                // Llamar al manejador de eventos del botón 2
                Button_Click(Button7, null);
            }
            else if (e.Key == Key.D8 || e.Key == Key.NumPad8)
            {
                // Llamar al manejador de eventos del botón 2
                Button_Click(Button8, null);
            }
            else if (e.Key == Key.D9 || e.Key == Key.NumPad9)
            {
                // Llamar al manejador de eventos del botón 2
                Button_Click(Button9, null);
            }
            else if (e.Key == Key.D0 || e.Key == Key.NumPad0)
            {
                // Llamar al manejador de eventos del botón 2
                Button_Click(Button0, null);
            }
            else if (e.Key == Key.Back)
            {
                Console.WriteLine("Borrando");
                if (MainText.Text.Length > 1)
                {
                    MainText.Text = MainText.Text.Substring(0, MainText.Text.Length - 1);
                }
                else
                {
                    MainText.Text = "0";
                }


            }
            // Puedes agregar más verificaciones para otras teclas y botones
        }



    }
}



