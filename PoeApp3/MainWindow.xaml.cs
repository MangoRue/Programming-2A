using System;
using System.Collections.Generic;
using System.Configuration;
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

namespace PoeApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
   
        Configuration AppConfig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }
        private void RecipeButton_Click(object sender, RoutedEventArgs e)
        {
            
            Main.Content = new AddRecipe();

        }

        private void RecipeButton2_Click(object sender, RoutedEventArgs e)
        {

            Main.Content = new AddRecipe();
            Recipe2.Content = "Your recipe has successfully been Added";

        }

        private void AdjustButton_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Adjust();
        }

        private void DisplayButton_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Display();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
