using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_4
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
        private void HandleChecked(Object Sender, RoutedEventArgs e)
        {
            RadioButton rb = Sender as RadioButton;
            tb3.Text = "You are : " + rb.Content;
        }
        private void HandleChecked1(Object Sender, RoutedEventArgs e)
        {
            RadioButton rb = Sender as RadioButton;
            tb4.Text = "You are : " + rb.Content;
        }
    }


}