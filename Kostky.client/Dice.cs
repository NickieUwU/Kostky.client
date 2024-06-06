using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Media3D;
using System.Windows.Shapes;

namespace Kostky.server
{
    public static class Dice
    {
        public static void MakeCube(Canvas canvas)
        {
            Rectangle rectangle = new()
            {
                Width = 250,
                Height = 250,
                Fill = Brushes.White,
                Stroke = Brushes.Black
            };
            Canvas.SetLeft(rectangle, 270);
            Canvas.SetTop(rectangle, 70);
            canvas.Children.Add(rectangle);
        }
        public static void MakeDots(Canvas canvas) 
        { 
            for(int i = 0; i < 7; i++)
            {
                Ellipse ellipse = new()
                {
                    Width = 50,
                    Height = 50,
                    Fill = Brushes.Black,
                    Stroke = Brushes.Black,
                    Name = $"El{i}"
                };
                switch (i)
                {
                    case 0:
                        Canvas.SetLeft(ellipse, 290);
                        Canvas.SetTop(ellipse, 90);
                        break;
                    case 1:
                        Canvas.SetLeft(ellipse, 290);
                        Canvas.SetTop(ellipse, 170);
                        break;
                    case 2:
                        Canvas.SetLeft(ellipse, 290);
                        Canvas.SetBottom(ellipse, 110);
                        break;
                    case 3:
                        Canvas.SetRight(ellipse, 290);
                        Canvas.SetTop(ellipse, 90);
                        break;
                    case 4:
                        Canvas.SetRight(ellipse, 290);
                        Canvas.SetTop(ellipse, 170);
                        break;
                    case 5:
                        Canvas.SetRight(ellipse, 290);
                        Canvas.SetBottom(ellipse, 110);
                        break;
                    case 6:
                        Canvas.SetLeft(ellipse, 365);
                        Canvas.SetTop(ellipse, 170);
                        break;
                }
                canvas.Children.Add(ellipse);
            }
        }
    }
}
