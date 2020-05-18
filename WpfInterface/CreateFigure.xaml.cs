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
using System.Text.RegularExpressions;

namespace WpfInterface
{
    /// <summary>
    /// Логика взаимодействия для CreateFigure.xaml
    /// </summary>
    public partial class CreateFigure : Window
    {
        public CreateFigure()
        {
            InitializeComponent();
        }

        private void ButTriatgle_Click(object sender, RoutedEventArgs e)
        {
            TBTopDX.IsEnabled = false;
            TBTopDY.IsEnabled = false;
            TBTopDX.Text = null;
            TBTopDY.Text = null;
        }

        private void ButQuadrangle_Click(object sender, RoutedEventArgs e)
        {
            TBTopDX.IsEnabled = true;
            TBTopDY.IsEnabled = true;
        }
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

       
    }
}
