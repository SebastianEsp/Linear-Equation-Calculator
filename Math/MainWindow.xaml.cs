using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Math
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Calc calc = new Calc();
        public MainWindow()
        {
            InitializeComponent();
        }

        #region Function
        private void txtBox_function_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btn_Calc_Click(object sender, RoutedEventArgs e)
        {
            string[] function = calc.function(txtBox_function.Text);
            txtBox_a.Text = function[2];
            txtBox_b.Text = function[7];
        }
        #endregion

        #region Points1
        private void txtBox_Points1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void btn_CalcPoints2_Click(object sender, RoutedEventArgs e)
        {
            string[] points = calc.getPoints(txtBox_Points1.Text);
            txtBox_x1.Text = points[1];
            txtBox_y1.Text = points[2];
        }
        #endregion

        #region Points2
        private void txtBox_Points2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btn_CalcPoints1_Click(object sender, RoutedEventArgs e)
        {
            string[] points = calc.getPoints(txtBox_Points2.Text);
            txtBox_x2.Text = points[1];
            txtBox_y2.Text = points[2];
        }
        #endregion

        #region Calc A
        private void txtBox_a_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btn_a_Click(object sender, RoutedEventArgs e)
        {
            string result = calc.A(Double.Parse(txtBox_y2.Text), Double.Parse(txtBox_y1.Text), Double.Parse(txtBox_x2.Text), Double.Parse(txtBox_x1.Text)).ToString();
            txtBox_a.Text = result;
        }

        #endregion 

        #region Calc B
        private void txtBox_b_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void btn_b_Click(object sender, RoutedEventArgs e)
        {
            string result = calc.B(Double.Parse(txtBox_y1.Text), Double.Parse(txtBox_a.Text), Double.Parse(txtBox_x1.Text)).ToString();
            txtBox_b.Text = result;
        }
        #endregion

        #region Calc Fx
        private void txtBox_Result_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btn_CalcFx_Click(object sender, RoutedEventArgs e)
        {
            string function = calc.getResult(txtBox_Result.Text);
            txtBox_Result.Text = "f(" + function + ")=" + calc.Y(Double.Parse(txtBox_a.Text), Double.Parse(function), Double.Parse(txtBox_b.Text)).ToString();
        }
        #endregion
    }
}
