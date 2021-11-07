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
using Registro_Con_Login.UI.Registros;

namespace Registro_Con_Login
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            rUsuario usuarios = new rUsuario();
            usuarios.Show();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            rRoles roles = new rRoles();
            roles.Show();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            rPermisos permisos = new rPermisos();
            permisos.Show();
        }
    }
}
