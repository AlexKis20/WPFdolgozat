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

namespace _1.feladat
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

        private void bt_szamol_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(tbx_szamtaniK,out double ) && double.TryParse(tbx_mertaniK,out double ))
            {
                double szam1 = double.Parse(tbx_szam1.Text);
                double szam2 = double.Parse(tbx_szam2.Text);
                double mertaniK = (szam1 + szam2) / 2;
                double szamtaniK = Math.Sqrt(szam1 * szam2);
                tbx_szamtaniK.Text = szamtaniK.ToString();
                tbx_mertaniK.Text = mertaniK.ToString();
            }
            
                
               
                
            
                
        }
    }
}
