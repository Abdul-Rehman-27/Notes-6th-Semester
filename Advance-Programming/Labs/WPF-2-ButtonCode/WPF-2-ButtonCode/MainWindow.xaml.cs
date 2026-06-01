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

namespace WPF_2_ButtonCode
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Button b1 = new Button();
            b1.Content = "Click Me";
            b1.Name = "b1";
            b1.Height = 30;
            b1.Width = 100;
            b1.Click += b1_Click; // Assign the btn1 a event handler 
            myGrid.Children.Add(b1);

            // Textblock (Label)
            Label lbl1 = new Label();
            lbl1.Content = "I am a Label";
            myGrid.Children.Add(lbl1);
        }

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button clicked!");

        }
    }
}