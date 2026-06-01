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

namespace WPF_3
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
        private void ButtonToAdd(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtName1.Text) && (!lstBx.Items.Contains(txtName1.Text)))
            {
                {
                    lstBx.Items.Add(txtName1.Text);
                    txtName1.Clear();
                }
            }
        }

        private void ButtonToRemove(object sender, RoutedEventArgs e)
        {
            lstBx.Items.Remove(txtName1.Text);
        }

        private void ButtonToClear(object sender, RoutedEventArgs e)
        {
            lstBx.Items.Clear();
        }
    }
}