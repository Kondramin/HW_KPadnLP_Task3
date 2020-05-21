using FigureLib;
using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;


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

        private void RadButTriatgle_Click(object sender, RoutedEventArgs e)
        {
            TBTopDX.IsEnabled = false;
            TBTopDY.IsEnabled = false;
            TBTopDX.Text = null;
            TBTopDY.Text = null;
        }

        private void RadButQuadrangle_Click(object sender, RoutedEventArgs e)
        {
            TBTopDX.IsEnabled = true;
            TBTopDY.IsEnabled = true;
        }


        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void ButCancel_Click(object sender, RoutedEventArgs e)
        {
            WinCreateFigure.Close();
        }

        private void ButSafe_Click(object sender, RoutedEventArgs e)
        {
            //Проверки на null
            if (RAdButTriatgle.IsChecked.Value)
            {
                Triangle triangle = new Triangle(new Top(Int32.Parse(TBTopAX.Text), Int32.Parse(TBTopAY.Text)),
                                                 new Top(Int32.Parse(TBTopAX.Text), Int32.Parse(TBTopAY.Text)),
                                                 new Top(Int32.Parse(TBTopAX.Text), Int32.Parse(TBTopAY.Text)),
                                                 System.Drawing.Color.FromName(TBColorFig.Text));
                FigureLib.Figure.FigureList.Add(triangle);
            }
            if (RadButQuadrangle.IsChecked.Value)
            {
                Quadrangle quadrangle = new Quadrangle(new Top(Int32.Parse(TBTopAX.Text), Int32.Parse(TBTopAY.Text)), 
                                                       new Top(Int32.Parse(TBTopAX.Text), Int32.Parse(TBTopAY.Text)), 
                                                       new Top(Int32.Parse(TBTopAX.Text), Int32.Parse(TBTopAY.Text)), 
                                                       new Top(Int32.Parse(TBTopDX.Text), Int32.Parse(TBTopDY.Text)), 
                                                       System.Drawing.Color.FromName(TBColorFig.Text));

                FigureLib.Figure.FigureList.Add(quadrangle);
            }
            WinCreateFigure.Close();
        }
    }
}
