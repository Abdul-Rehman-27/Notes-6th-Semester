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

namespace CheckBox_InputField
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


        private void handleChecked(object sender, RoutedEventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (cb.Name == "checkBox1")
            {
                textBox1.Text = "2 State checkbox is checked";
            }else
            {
                textBox2.Text = "3 State checkbox is checked";
            }

        }

        private void handleUnchecked(object sender, RoutedEventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (cb.Name == "checkBox1")
            {
                textBox1.Text = "2 State checkbox is unchecked";
            }
            else
            {
                textBox2.Text = "3 State checkbox is unchecked";
            }
        }

        private void handleThreeState(object sender, RoutedEventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            textBox2.Text = "2 State checkbox is in intdeterminate";
        }
    }
}