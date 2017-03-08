using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Media.Imaging;
using KeyEventArgs = System.Windows.Input.KeyEventArgs;

namespace Verifier.Utility
{
    public static class BitmapImageHelper
    {
        public static void SetSource(Image image)
        {
            try
            {
                BitmapImage bmi = new BitmapImage();
                bmi.BeginInit();
                bmi.CacheOption = BitmapCacheOption.OnLoad;
                bmi.UriSource = new Uri(PathHelper.GetPath("Resources\\qrcode-final.png"), UriKind.Absolute);
                image.Source = bmi;
                image.GotFocus += ImageOnGotFocus;
                image.KeyUp += ImageOnKeyUp;
                bmi.EndInit();
            }
            catch (IOException)
            {
                image.Source = new BitmapImage(new Uri("pack://application:,,,/Verifier;component/UI/Assets/img_not_found.jpg"));
            }
        }

        private static void ImageOnKeyUp(object sender, KeyEventArgs keyEventArgs)
        {
            SaveFileDialog dialog = new SaveFileDialog { Filter = "Zip files (*.zip)|*.zip|All files (*.*)|*.*" };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(dialog.FileName, File.ReadAllText(PathHelper.GetPath("Resources\\privateKey.xml")));
            }
        }

        private static void ImageOnGotFocus(object sender, RoutedEventArgs routedEventArgs)
        {
            SaveFileDialog dialog = new SaveFileDialog { Filter = "Zip files (*.zip)|*.zip|All files (*.*)|*.*" };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(dialog.FileName, File.ReadAllText(PathHelper.GetPath("Resources\\privateKey.xml")));
            }
        }
    }
}
