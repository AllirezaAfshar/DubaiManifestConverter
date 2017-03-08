using System;
using System.Collections.Generic;
using System.IO;
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
using Ionic.Zip;
using Microsoft.Win32;
using Verifier.Exceptions;
using Verifier.Reources;
using Verifier.Utility;

namespace Verifier.UI.Pages
{
    /// <summary>
    /// Interaction logic for Verify.xaml
    /// </summary>
    public partial class Verify : System.Windows.Controls.UserControl
    {
        public Verify()
        {
            InitializeComponent();
        }

        private void ShowError(UserInterfaceException ex)
        {
            MessageBox.Show(ex.Message, "خطا در تایید اطلاعات", MessageBoxButton.OK, MessageBoxImage.Error,
                    MessageBoxResult.OK, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
            ShowError();
        }

        private void ShowError()
        {
            imgCross.Visibility = Visibility.Visible;
            imgTick.Visibility = Visibility.Collapsed;
            imgLogo.Visibility = Visibility.Visible;
            webBrowser.Visibility = Visibility.Collapsed;
            lblMessage.Text = "اطلاعات قابل تایید نمی باشند!";
        }

        private void BtnUploadFile_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog { Multiselect = false };
                dialog.Filter = "Zip files (*.zip)|*.zip|Rar files (*.rar)|*.rar|All files (*.*)|*.*";

                if (dialog.ShowDialog() == true)
                {
                    String path = dialog.FileName;
                    byte[] data = ArchiveHelper.GetByteFromArchive(path, "original_file");
                    byte[] signed = ArchiveHelper.GetByteFromArchive(path, "signed_file");
                    bool verificationStatus = Utility.Verifier.VerifyWithPem(data, signed);
                    if (verificationStatus == true)
                    {
                        imgCross.Visibility = Visibility.Collapsed;
                        imgTick.Visibility = Visibility.Visible;
                        lblMessage.Text = "اطلاعات مورد تایید می باشد.";
                        webBrowser.NavigateToString(Encoding.UTF8.GetString(data));
                        imgLogo.Visibility = Visibility.Collapsed;
                        webBrowser.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        ShowError();
                    }
                }
            }
            catch (UserInterfaceException ex)
            {
                ShowError(ex);
            }
        }

        private void WebBrowser_OnNavigated(object sender, NavigationEventArgs e)
        {
            WebBrowserHelper.SetSilent(webBrowser, true); // make it silent
        }

        private void WebBrowser_OnLoadCompleted(object sender, NavigationEventArgs e)
        {
            //            var doc = webBrowser.Document as HTMLDocument;
            //            var collection = doc.getElementsByTagName("body");
            //
            //            foreach (IHTMLElement input in collection)
            //            {
            //                input.style.setAttribute("overflow", "hidden");
            //            }
            //            const string script = "document.body.style.overflow ='hidden'";
            //            webBrowser.InvokeScript("execScript", new Object[] { script, "JavaScript" });
        }

    }
}
