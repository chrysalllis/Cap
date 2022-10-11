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

namespace ABoBa
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        string[] papchaFile = new string[]
        {
            "MyImage/cap1.png", "MyImage/cap2.png"
        };
        string[] papchaIsTry = new string[]
        {
            "PH1","PH2","PH123"
        };
        
        
        int capchIntn;
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            capchIntn = random.Next(0, papchaFile.Length);
            Uri uri = new Uri(papchaFile[capchIntn], UriKind.RelativeOrAbsolute);
            BitmapImage bitmapImage = new BitmapImage(uri);
            imageCapcha.Source = bitmapImage;

        }

        private void btGo_Click(object sender, RoutedEventArgs e)
        {
            if (tbCapch.Text == papchaIsTry[capchIntn])
                MessageBox.Show("Капча верна");
            else
                MessageBox.Show("Капча не верна");
        }

        private void btRefresh_Click(object sender, RoutedEventArgs e)
        {
            MainWindow_Loaded(sender,e);
        }
    }
}
