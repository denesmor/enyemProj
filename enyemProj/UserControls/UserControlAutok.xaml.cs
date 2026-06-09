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

namespace enyemProj.UserControls
{
    /// <summary>
    /// Interaction logic for UserControlAutok.xaml
    /// </summary>
    public partial class UserControlAutok : UserControl
    {
        public UserControlAutok()
        {
            InitializeComponent();
            feladatPanel.Children.Add(new UserControlAutok());
        }




        private void kilepesMenu_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Ez a funkció jelenleg nem elérhető.");
        }

        private void autoMENU_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();

            
        }

        private void felhasznaloMENU_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            feladatPanel.Children.Clear();
            feladatPanel.Children.Add(new UserControls.UserControlFelhasznalo());
        }

        private void vasarloMENU_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            feladatPanel.Children.Clear();
            feladatPanel.Children.Add(new UserControls.UserControlVasarlo());
        }

        private void rolunkMENU_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            feladatPanel.Children.Clear();
            feladatPanel.Children.Add(new UserControls.UserControlRolunk());
        }
    }
}
