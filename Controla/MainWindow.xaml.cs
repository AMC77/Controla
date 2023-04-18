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

namespace Controla
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
        private void Window_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed) DragMove();
        }
        private void BtnMinimizarVentana_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
        private void BtnCerrarVentana_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void TxtUser_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void BtnInicio_Click(object sender, RoutedEventArgs e)
        {
            var nombre =txtUser.Text;

            if (nombre == "a")
            {
                Administrador administrador = new Administrador();

                administrador.Show();
                this.Close();
            }
            if (nombre == "b")
            {
                Usuario usuario = new Usuario();
                usuario.Show();
                this.Close();
            }
        }

        private void txtUser_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
