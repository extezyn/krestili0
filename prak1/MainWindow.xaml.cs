using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
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

namespace prak1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {



























































































































      
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        int slovo_pacana=0;
        int sigma=0;
        Button[] button;
        public MainWindow()
        {
            InitializeComponent();

            button = new Button[9]{  _1, _2, _3, _4, _5, _6, _7, _8,_9 };

            
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            sigma = 0;
            _1.IsEnabled = true;
            _2.IsEnabled = true;
            _3.IsEnabled = true;
            _4.IsEnabled = true;
            _5.IsEnabled = true;
            _6.IsEnabled = true;
            _7.IsEnabled = true;
            _8.IsEnabled = true;
            _9.IsEnabled = true;
            _1.Content = " ";
            _2.Content = " ";
            _3.Content = " ";
            _4.Content = " ";
            _5.Content = " ";
            _6.Content = " ";
            _7.Content = " ";
            _8.Content = " ";
            _9.Content = " ";
            slovo_pacana++;
        }

        private void _1_Click(object sender, RoutedEventArgs e)
        {
            sigma++;
            Random r = new Random();
            int rand = r.Next(0, 9);
            if (sigma < 5 && slovo_pacana % 2 == 1)
            {
                
                    (sender as Button).Content = "x";
                    (sender as Button).IsEnabled = false;
                    while (button[rand].IsEnabled == false )
                    {
                        rand = r.Next(0, 9);
                    }
                    button[rand].Content = "0";
                    button[rand].IsEnabled = false;
                }
                else if(sigma < 5 && slovo_pacana % 2 == 0)
                {
                    (sender as Button).Content = "0";
                    (sender as Button).IsEnabled = false;
                    while (button[rand].IsEnabled == false)
                    {
                        rand = r.Next(0, 9);
                    }
                    button[rand].Content = "x";
                    button[rand].IsEnabled = false;
                }
              else if (sigma == 5 && slovo_pacana % 2 == 0) 
            {
                (sender as Button).Content = "0";
                (sender as Button).IsEnabled = false;
            }

            
            Win();
        }

       

        public void Win()
        {
            if(_1.Content == "x" && _2.Content == "x" && _3.Content == "x" || _4.Content == "x" && _5.Content == "x" && _6.Content == "x" ||  _7.Content == "x" && _8.Content == "x" && _9.Content == "x" || _1.Content == "x" && _4.Content == "x" && _7.Content == "x" || _2.Content == "x" && _5.Content == "x" && _8.Content == "x" || _3.Content == "x" && _6.Content == "x" && _9.Content == "x"  || _1.Content == "x" && _5.Content == "x" && _9.Content == "x" || _3.Content == "x" && _5.Content == "x" && _7.Content == "x" ) 
            {
                MessageBox.Show("Победили кресты");
                _1.IsEnabled = false;
                _2.IsEnabled = false;
                _3.IsEnabled = false;
                _4.IsEnabled = false;
                _5.IsEnabled = false;
                _6.IsEnabled = false;
                _7.IsEnabled = false;
                _8.IsEnabled = false;
                _9.IsEnabled = false;
            }

           else if (_1.Content == "0" && _2.Content == "0" && _3.Content == "0" || _4.Content == "0" && _5.Content == "0" && _6.Content == "0" || _7.Content == "0" && _8.Content == "0" && _9.Content == "0" || _1.Content == "0" && _4.Content == "0" && _7.Content == "0" || _2.Content == "0" && _5.Content == "0" && _8.Content == "0" || _3.Content == "0" && _6.Content == "0" && _9.Content == "0" || _1.Content == "0" && _5.Content == "0" && _9.Content == "0" || _3.Content == "0" && _5.Content == "0" && _7.Content == "0")
            {
                MessageBox.Show("Победили нули");
                _1.IsEnabled = false;
                _2.IsEnabled = false;
                _3.IsEnabled = false;
                _4.IsEnabled = false;
                _5.IsEnabled = false;
                _6.IsEnabled = false;
                _7.IsEnabled = false;
                _8.IsEnabled = false;
                _9.IsEnabled = false;
            }

            else if (sigma == 5)
                MessageBox.Show("Ничья");

            
        }

    }
}
