using System.Windows;

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
