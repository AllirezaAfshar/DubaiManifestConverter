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
using Verifier.Template;
using Verifier.Utility;
using NavigationEventArgs = FirstFloor.ModernUI.Windows.Navigation.NavigationEventArgs;

namespace Verifier.UI.Pages
{
    /// <summary>
    /// Interaction logic for VerifyDocument.xaml
    /// </summary>
    public partial class VerifyDocument : DetailsPage
    {
        public VerifyDocument()
        {
            InitializeComponent();
        }


        protected override void ShowError(UserInterfaceException ex)
        {
            MessageBox.Show(ex.Message, "خطا در تایید اطلاعات", MessageBoxButton.OK, MessageBoxImage.Error,
                    MessageBoxResult.OK, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
            ShowError();
        }

        protected override void ShowError()
        {
            imgCross.Visibility = Visibility.Visible;
            imgTick.Visibility = Visibility.Collapsed;
            imgLogo.Visibility = Visibility.Visible;
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
                    bool verificationStatus = Utility.Verifier.VerifyWithNet(data, signed);
                    if (verificationStatus == true)
                    {
                        imgCross.Visibility = Visibility.Collapsed;
                        imgTick.Visibility = Visibility.Visible;
                        lblMessage.Text = "اطلاعات مورد تایید می باشد.";
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

    
    }
}
