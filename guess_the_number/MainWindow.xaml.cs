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

namespace guess_the_number
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

        
        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
             Random _random = new Random();
             var rand_numb = _random.Next(15);
             var splitNumbeS = Input_number.Text.Split(",");
             if (splitNumbeS.Length > 5)
             {
                 MessageBox.Show("Нельзя вводить больше пяти чисел");
                 return;
             }
             bool luck = false;
             int count = 0;
             foreach (var number in splitNumbeS)
             {
                 if (rand_numb == Convert.ToInt32(number))
                 {
                     luck = true;
                 }
                 
             }

             if (luck == true)
             {
                 MessageBox.Show($"Вы угадали число!!! Число было {rand_numb}");
                 count++;
                 
                 
             }
             else
             {
                 MessageBox.Show($"к сожелению вы не угадали!!! Число было {rand_numb}");
                 
             }
        }
    }
}