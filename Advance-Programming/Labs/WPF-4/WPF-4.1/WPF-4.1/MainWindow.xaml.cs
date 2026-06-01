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

namespace WPF_4._1
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

        private void cb1(object sender, SelectionChangedEventArgs e)
        {
            //ComboBox cb = sender as ComboBox;
            //cbt1.Text = cb.SelectedItem.ToString();
            if (sender is ComboBox cb && cb.SelectedItem is ComboBoxItem item)
            {
                cbt1.Text = item.Content.ToString();
            }
        }

        private void cb2(object sender, SelectionChangedEventArgs e)
        {
            //ComboBox cb = sender as ComboBox;
            //cbt2.Text = cb.SelectedItem.ToString();
            if (sender is ComboBox cb && cb.SelectedItem is ComboBoxItem item)
            {
                cbt2.Text = item.Content.ToString();
            }
        }
    }
}