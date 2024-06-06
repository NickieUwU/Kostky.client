using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Shapes;

namespace Kostky.server
{
    public static class Dice
    {
        public static void Throw(Ellipse el1, Ellipse el2, Ellipse el3, Ellipse el4, Ellipse el5, Ellipse el6, Ellipse el7)
        {
            try
            {
                Random random = new();
                switch (random.Next(0, 5))
                {
                    case 0:
                        el1.Visibility = Visibility.Hidden;
                        el2.Visibility = Visibility.Hidden;
                        el3.Visibility = Visibility.Hidden;
                        el4.Visibility = Visibility.Hidden;
                        el5.Visibility = Visibility.Hidden;
                        el6.Visibility = Visibility.Hidden;
                        el7.Visibility = Visibility.Visible;
                        break;
                    case 1:
                        el1.Visibility = Visibility.Hidden;
                        el2.Visibility = Visibility.Hidden;
                        el3.Visibility = Visibility.Visible;
                        el4.Visibility = Visibility.Visible;
                        el5.Visibility = Visibility.Hidden;
                        el6.Visibility = Visibility.Hidden;
                        el7.Visibility = Visibility.Hidden;
                        break;
                    case 2:
                        el1.Visibility = Visibility.Hidden;
                        el2.Visibility = Visibility.Hidden;
                        el3.Visibility = Visibility.Visible;
                        el4.Visibility = Visibility.Visible;
                        el5.Visibility = Visibility.Hidden;
                        el6.Visibility = Visibility.Hidden;
                        el7.Visibility = Visibility.Visible;
                        break;

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
