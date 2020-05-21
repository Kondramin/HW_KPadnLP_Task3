using FigureLib;
using System.Collections.Generic;
using System.Drawing;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Media;

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

        private void ButShowlits_Click(object sender, RoutedEventArgs e)
        {
            TBInfo.Text=FigureLib.Figure.FigureList[0].Name;
        }
        public void Show(List<FigureLib.Figure> figures)
        {
            foreach(FigureLib.Figure fig in figures)
            {   
                TBInfo.Foreground = new SolidColorBrush(ToMediaColor(fig.ColorFigure));
                TBInfo.Text +=fig.Name;
                foreach(var top in fig.Tops)
                {
                    TBInfo.Text = top.X;
                    TBInfo.Text = top.Y;
                }
                TBInfo.Text = fig.ColorFigure.ToString;
            }
        }



        public System.Windows.Media.Color ToMediaColor(System.Drawing.Color color)
        {
            return System.Windows.Media.Color.FromArgb(color.A, color.R, color.G, color.B);
        }
    }
}
