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
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Ionic.Zip;
using Verifier.Exceptions;
using Verifier.Reources;
using Verifier.Template;
using Verifier.Utility;
using MessageBox = System.Windows.MessageBox;
using MessageBoxOptions = System.Windows.MessageBoxOptions;
using NavigationEventArgs = FirstFloor.ModernUI.Windows.Navigation.NavigationEventArgs;
using OpenFileDialog = Microsoft.Win32.OpenFileDialog;
using Path = System.IO.Path;
using SaveFileDialog = Microsoft.Win32.SaveFileDialog;

namespace Verifier.UI.Pages
{
    /// <summary>
    /// Interaction logic for Sign.xaml
    /// </summary>
    public sealed partial class Sign : DetailsPage
    {
        public Sign()
        {
            InitializeComponent();
            this.IsProtected = true;
        }

        public override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            
        }

        private void btnSignFile_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog openDialog = new OpenFileDialog
                {
                    Multiselect = false,
                    Filter = "All files (*.*)|*.*"
                };

                if (openDialog.ShowDialog() == true)
                {
                    string extension = Path.GetExtension(openDialog.FileName);
                    string fileName = Path.GetFileName(openDialog.FileName);
                    SaveFileDialog saveDialog = new SaveFileDialog
                    {
                        Filter = "All files (*.*)|*.*",
                    };
                    if (!String.IsNullOrWhiteSpace(extension))
                    {
                        if (!String.IsNullOrWhiteSpace(fileName))
                        {
                            saveDialog.FileName = fileName.Replace(extension, ".zip");
                        }
                    }

                    if (saveDialog.ShowDialog() == true)
                    {
                        Signer.SignFile(openDialog.FileName, saveDialog.FileName);
                    }
                }
            }
            catch (UserInterfaceException ex)
            {
                ShowError(ex);
            }

        }

        protected override void ShowError()
        {
            imgCross.Visibility = Visibility.Visible;
            imgTick.Visibility = Visibility.Collapsed;
            imgLogo.Visibility = Visibility.Visible;
            lblMessage.Text = "اطلاعات قابل تایید نمی باشند!";
        }

        protected override void ShowError(UserInterfaceException ex)
        {
            MessageBox.Show(ex.Message, "خطا در تایید اطلاعات", MessageBoxButton.OK, MessageBoxImage.Error,
                    MessageBoxResult.OK, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
            ShowError();
        }

        
    }
}
