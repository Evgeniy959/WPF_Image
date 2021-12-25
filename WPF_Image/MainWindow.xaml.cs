using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Microsoft.Win32;

namespace WPF_Image
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_OpenImage_OnClick(object sender, RoutedEventArgs e)
        {
            var path = new Uri(OpenFileDialog());
            Image.Source = new BitmapImage(path);
        }

        private string OpenFileDialog()
        {
            var openFileDialog = new OpenFileDialog();
            
            return openFileDialog.ShowDialog() == true ? openFileDialog.FileName : string.Empty;
        }

        private void Button_ChangeColor(object sender, RoutedEventArgs e)
        {
            var name = (sender as Button)?.Name;

            Canvas.DefaultDrawingAttributes.Color = name switch
            {
                "Button_ColorBlack" => Colors.Black,
                "Button_ColorRed" => Colors.Red,
                _ => Canvas.DefaultDrawingAttributes.Color
            };
        }
    }
}