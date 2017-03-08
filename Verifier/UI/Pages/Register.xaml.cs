using System;
using System.Windows;
using FirstFloor.ModernUI.Windows.Controls;
using Verifier.Template;
using Verifier.Utility;

namespace Verifier.UI.Pages
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : DetailsPage
    {
        public Register()
        {
            InitializeComponent();
        }

        private void BtnRegister_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                ((App)Application.Current).ContainerName = txtUsername.Text;
                RSACryptoKeyHelper.Generate();
                if (new AccessControlHelper().Verify())
                {
                    BarcodeHelper.GenerateQr(new FileMapper().GetPublicKeyContent());
                    ModernWindow window = Application.Current.MainWindow as ModernWindow;
                    window.ContentSource = new Uri(@"/Verifier;component/UI\Template\Main.xaml", UriKind.Relative);
                    return;
                }
            }
            catch (Exception)
            {
                
            }
            MessageBox.Show("اطلاعات وارد شده معتبر نمی باشد، در صورتی که قبلا با این نام کاربری ثبت نام کرده اید ابتدا باید نام رمزعبور مربوطه را وارد کرده و دوباره امتحان کنید",
                "خطا در ثبت نام کاربر", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
        }

        private void BtnLogin_OnClick(object sender, RoutedEventArgs e)
        {
            RedirectToLogin();
        }
    }
}
