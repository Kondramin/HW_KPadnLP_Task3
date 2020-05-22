using FigureLib;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows;
using System.Windows.Controls;
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
            Show(FigureLib.Figure.FigureList);
        }
        public void Show(List<FigureLib.Figure> figures)
        {   
            foreach(FigureLib.Figure fig in figures)
            {
                var TTBInfo = new TextBlock;
                TTBInfo.Foreground = new SolidColorBrush(ToMediaColor(fig.ColorFigure));
                
                
                TTBInfo.Text += fig.Name;
                TTBInfo.Text += "\n";
                foreach(var top in fig.Tops)
                {
                    TTBInfo.Text += Convert.ToString(top.X);
                    TTBInfo.Text += " ";
                    TTBInfo.Text += Convert.ToString(top.Y);
                    TTBInfo.Text += "\n";
                }
                TTBInfo.Text += fig.ColorFigure.Name;
                TTBInfo.Text += "\n";
                TBInfo.Text += TTBInfo.Text;
            }
        }



        public System.Windows.Media.Color ToMediaColor(System.Drawing.Color color)
        {
            return System.Windows.Media.Color.FromArgb(color.A, color.R, color.G, color.B);
        }
    }
}
