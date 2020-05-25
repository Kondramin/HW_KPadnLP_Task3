using FigureLib;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
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
            StPInfo.Children.Clear();
        }

        private void ButShowlits_Click(object sender, RoutedEventArgs e)
        {
            Show(FigureLib.Figure.FigureList);
        }
        public void Show(List<FigureLib.Figure> figures)
        {
            foreach (FigureLib.Figure fig in figures)
            {
                var TBInfo = new TextBlock();
                TBInfo.Foreground = new SolidColorBrush(ToMediaColor(fig.ColorFigure));


                TBInfo.Text += fig.Name + "\n";
                foreach (var top in fig.Tops)
                {
                    TBInfo.Text += Convert.ToString(top.X) + " ";
                    TBInfo.Text += Convert.ToString(top.Y) + "\n";
                }
                TBInfo.Text += "Perimeter = " + Convert.ToString(fig.Perimeter()) + "\n";
                TBInfo.Text += "Area = " + Convert.ToString(fig.Area()) + "\n";
                TBInfo.Text += "Color of figure: " + fig.ColorFigure.Name + "\n";

                StPInfo.Children.Add(TBInfo);
            }
        }



        public System.Windows.Media.Color ToMediaColor(System.Drawing.Color color)
        {
            return System.Windows.Media.Color.FromArgb(color.A, color.R, color.G, color.B);
        }

        private void ButSafeData_Click(object sender, RoutedEventArgs e)
        {
            FigureLib.Figure.SerializeAndSave(FigureLib.Figure.FigureList);
            var TBlock = new TextBlock();
            TBlock.Text = "Done";
            StPInfo.Children.Add(TBlock);
        }

        private void ButRewAndSafeData_Click(object sender, RoutedEventArgs e)
        {
            FigureLib.Figure.SerializeAndRewritingSave(FigureLib.Figure.FigureList);
            var TBlock = new TextBlock();
            TBlock.Text = "Done";
            StPInfo.Children.Add(TBlock);
        }

        private void ButReadData_Click(object sender, RoutedEventArgs e)
        {
            FigureLib.Figure.FigureList = FigureLib.Figure.ReadAndDeserialize();
            var TBlock = new TextBlock();
            TBlock.Text = "Done";
            StPInfo.Children.Add(TBlock);
        }

        private void ButSortList_Click(object sender, RoutedEventArgs e)
        {
            SortList(FigureLib.Figure.FigureList);
        }
        public void SortList(List<FigureLib.Figure> figures)
        {
            Comp cp = new Comp();
            FigureLib.Figure.FigureList.Sort(cp.Compare);
            var TBlock = new TextBlock();
            TBlock.Text = "Done";
            StPInfo.Children.Add(TBlock);
        }

        private void ButSecondQuarterChek_Click(object sender, RoutedEventArgs e)
        {
            FigureLib.Figure.SecondQuarterChek(FigureLib.Figure.FigureList);
            var TBlock = new TextBlock();
            TBlock.Text = "Done";
            StPInfo.Children.Add(TBlock);
        }
    }
}
