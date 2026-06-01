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

namespace Combobox_ViaTags
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

        private void cmb1_selectionChanged(object sender, SelectionChangedEventArgs e)
        {
            tb1.Text = cmb1.SelectedItem.ToString();
        }

        private void cmb2_selectionChanged(object sender, SelectionChangedEventArgs e)
        {
            tb2.Text= cmb2.SelectedItem.ToString();
        }
    }
}