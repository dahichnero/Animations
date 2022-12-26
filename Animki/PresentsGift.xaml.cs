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
using System.Windows.Shapes;

namespace Animki
{
    /// <summary>
    /// Логика взаимодействия для PresentsGift.xaml
    /// </summary>
    public partial class PresentsGift : Window
    {
        public PresentsGift()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string sss = "";
            closed.Source = opened.Source;
            int res=rnd.Next(1, 4);
            switch (res)
            {
                case 1: sss = "Желаем всегда быть самыми счастливыми!";
                    break;
                case 2: sss="Желаем всегда выходить сухими из воды!";
                    break;
                case 3:
                    sss = "Желаем всегда достигать свои цели!";
                    break;
            }
            MessageBox.Show(sss, "Ваше пожелание!");
            PictureWindow pictureWindow = new PictureWindow();
            pictureWindow.Show();
            this.Close();
        }
    }
}
