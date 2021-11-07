using Registro_Con_Login.BLL;
using Registro_Con_Login.UI.Registros;
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
using System.Windows.Shapes;

namespace Registro_Con_Login.UI
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        //Usuario default: admin
        //Contraseña default: 1234
        public Login()
        {
            InitializeComponent();
        }

        private void IniciarSesionButton_Click(object sender, RoutedEventArgs e)
        {
            if (usuarioTextBox.Text == "admin" && passwordTextBox.Text == "1234")
            {
                MainWindow first = new MainWindow();
                first.Show();
                this.Hide();
            }
            else if (UsuariosBLL.ExisteUsuario(usuarioTextBox.Text, passwordTextBox.Text))
            {
                MainWindow first = new MainWindow();
                first.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("El usuario o la contraseña ingresado es incorrecto.");
                usuarioTextBox.Clear();
                passwordTextBox.Clear();
            }
        }

        private void RegistrarseButton_Click(object sender, RoutedEventArgs e)
        {
            rUsuario usuarios = new rUsuario();
            usuarios.Show();
        }
    }
}
