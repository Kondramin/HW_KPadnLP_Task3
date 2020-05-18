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

namespace WpfInterface
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }
       

        private void ButAddFig_Click(object sender, RoutedEventArgs e)
        {
            CreateFigure createFigure = new CreateFigure();
            createFigure.Owner = this;
            createFigure.Show();
        }


        private void ButClear_Click(object sender, RoutedEventArgs e)
        {
            TBInfo.Text = null;
        }
    }
}
