using System;
using System.Windows;
using System.Windows.Controls;
using FirstFloor.ModernUI.Windows;
using FirstFloor.ModernUI.Windows.Controls;
using FirstFloor.ModernUI.Windows.Navigation;
using Verifier.Exceptions;
using Verifier.Utility;

namespace Verifier.Template
{
    public class DetailsPage : System.Windows.Controls.UserControl, IContent
    {
        protected virtual bool IsProtected { get; set; }

        public DetailsPage()
        {
            this.IsProtected = false;
        }

        protected virtual void ShowSuccessMessage(String message)
        {
            MessageBox.Show(message, "عملیات موفقیت آمیز", MessageBoxButton.OK, MessageBoxImage.Information,
                    MessageBoxResult.OK, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
        }

        protected virtual void ShowError(UserInterfaceException ex)
        {
            MessageBox.Show(ex.Message, "خطا", MessageBoxButton.OK, MessageBoxImage.Error,
                    MessageBoxResult.OK, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
        }

        protected virtual void ShowError()
        {
            MessageBox.Show("خطای نامشخص رخ داده است، لطفا با بخش پشتیبانی تماس بگیرید.", "خطا", MessageBoxButton.OK, MessageBoxImage.Error,
                    MessageBoxResult.OK, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
        }

        public virtual void OnFragmentNavigation(FragmentNavigationEventArgs e)
        {
            // Do Nothing !
        }

        public virtual void OnNavigatedFrom(NavigationEventArgs e)
        {
            // Do Nothing !
        }

        public virtual void OnNavigatedTo(NavigationEventArgs e)
        {
            if (IsProtected)
            {
                this.Visibility = Visibility.Hidden;
                if (new AccessControlHelper().Verify())
                {
                    this.Visibility = Visibility.Visible;
                }
                else
                {
                    RedirectToLogin();
                }
            }
        }

        public virtual void OnNavigatingFrom(NavigatingCancelEventArgs e)
        {
            // Do Nothing !
        }


        public virtual void IsLoading()
        {
            ((ModernFrame)this.Parent).IsLoadingContent = true;
            ((Panel)((ModernFrame)this.Parent).Parent).IsEnabled = false;
        }

        public virtual void IsLoaded()
        {
            ((ModernFrame)this.Parent).IsLoadingContent = false;
            ((Panel)((ModernFrame)this.Parent).Parent).IsEnabled = true;
        }

        protected virtual void RedirectToLogin()
        {
            ModernWindow window = Application.Current.MainWindow as ModernWindow;
            window.ContentSource = new Uri(@"/Verifier;component/UI\Pages\Login.xaml", UriKind.Relative);
        }

    }
}
