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

namespace kleurenpsychologie
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

        private void pxlPng_MouseEnter(object sender, MouseEventArgs e)
        {
            mainWindow.Background = new SolidColorBrush(Colors.Black);
        }

        private void pxlPng_MouseLeave(object sender, MouseEventArgs e)
        {
            mainWindow.Background = new SolidColorBrush(Colors.LightGray);
        }

        private void yellowPng_MouseEnter(object sender, MouseEventArgs e)
        {
            mainWindow.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFFF00"));
        }

        private void yellowPng_MouseLeave(object sender, MouseEventArgs e)
        {
            mainWindow.Background = new SolidColorBrush(Colors.LightGray);
        }

        private void redPng_MouseEnter(object sender, MouseEventArgs e)
        {
            mainWindow.Background = new SolidColorBrush(Colors.Red);
        }

        private void redPng_MouseLeave(object sender, MouseEventArgs e)
        {
            mainWindow.Background = new SolidColorBrush(Colors.LightGray);
        }

        private void greenPng_MouseEnter(object sender, MouseEventArgs e)
        {
            mainWindow.Background = new SolidColorBrush(Colors.Green);
        }

        private void greenPng_MouseLeave(object sender, MouseEventArgs e)
        {
            mainWindow.Background = new SolidColorBrush(Colors.LightGray);
        }

        private void bluePng_MouseEnter(object sender, MouseEventArgs e)
        {
            mainWindow.Background = new SolidColorBrush(Colors.Blue);
        }

        private void bluePng_MouseLeave(object sender, MouseEventArgs e)
        {
            mainWindow.Background = new SolidColorBrush(Colors.LightGray);
        }

        private void bluePng_MouseDown(object sender, MouseButtonEventArgs e)
        {
            colorCode.Text = "Blauw: #0000FF";
            information.Text = "Blauw is de kleur van intelligentie";
        }

        private void greenPng_MouseDown(object sender, MouseButtonEventArgs e)
        {
            colorCode.Text = "Groen: #008000";
            information.Text = "Groen is de kleur van genezing";
        }

        private void redPng_MouseDown(object sender, MouseButtonEventArgs e)
        {
            colorCode.Text = "Rood: #FF0000";
            information.Text = "Rood is de kleur van warmte";
        }

        private void yellowPng_MouseDown(object sender, MouseButtonEventArgs e)
        {
            colorCode.Text = "Geel: #FFFF00";
            information.Text = "Geel is de kleur van levenslust";
        }
    }
}