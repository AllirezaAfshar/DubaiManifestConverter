using System;
using System.Collections.Generic;
using System.Linq;
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
using FirstFloor.ModernUI.Windows.Controls;
using Verifier.Template;
using Verifier.Utility;
using NavigationEventArgs = FirstFloor.ModernUI.Windows.Navigation.NavigationEventArgs;

namespace Verifier.UI.Pages
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : DetailsPage
    {
        public Login()
        {
            InitializeComponent();
        }

        public override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            ModernWindow window = Application.Current.MainWindow as ModernWindow;
            window.Width = 400;
            window.Height = 300;
        }

        private void BtnLogin_OnClick(object sender, RoutedEventArgs e)
        {
            ((App)Application.Current).ContainerName = txtUsername.Text;
            if (new AccessControlHelper().Verify())
            {
                ModernWindow window = Application.Current.MainWindow as ModernWindow;
                window.ContentSource = new Uri(@"/Verifier;component/UI\Template\Main.xaml", UriKind.Relative);
            }
            else
            {
                MessageBox.Show("اطلاعات وارد شده معتبر نمی باشند، لطفا اطلاعات را دوباره بررسی کرده سپس اقدام نمایید. در صورتی که قبلا در سامانه ثبت نام نکرده اید روی دکمه ی ثبت نام کلید کنید.",
                    "خطا در ورود کاربر", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
            }
        }

        private void BtnRegister_OnClick(object sender, RoutedEventArgs e)
        {
            ModernWindow window = Application.Current.MainWindow as ModernWindow;
            window.ContentSource = new Uri(@"/Verifier;component/UI\Pages\Register.xaml", UriKind.Relative);
        }
    }
}
