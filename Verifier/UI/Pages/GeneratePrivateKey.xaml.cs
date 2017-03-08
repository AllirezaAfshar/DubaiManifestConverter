using System;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using Ionic.Zip;
using Verifier.Exceptions;
using Verifier.Template;
using Verifier.Utility;
using MessageBox = System.Windows.MessageBox;
using MessageBoxOptions = System.Windows.MessageBoxOptions;

namespace Verifier.UI.Pages
{
    /// <summary>
    /// Interaction logic for GeneratePrivateKey.xaml
    /// </summary>
    public sealed partial class GeneratePrivateKey : DetailsPage
    {
        public GeneratePrivateKey()
        {
            InitializeComponent();
            this.IsProtected = true;
        }

        private void saveFile()
        {
//            SaveFileDialog dialog = new SaveFileDialog();
//            dialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
//            if (dialog.ShowDialog() == true)
//            {
//
//                File.WriteAllText(dialog.FileName, Utils.Printer.GetResult(), Encoding.ASCII);
//            }
        }

        private void BtnGenerateKey_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                IsLoading();
                RSACryptoKeyHelper.Generate();
                BarcodeHelper.GenerateQr(new FileMapper().GetPublicKeyContent());
                ShowSuccessMessage("کلید خصوصی و عمومی شما با موفقیت ایجاد گردید، بعد از بستن این پیام صفحه ای باز می شود که از شما محل ذخیره ی کلیدها را خواهد گرفت. " +
                                   "لطفا به دقت از این فایل ها استفاده نمایید زیرا به منزله اطلاعات شخصی شما می باشند.");
                SaveFileDialog dialog = new SaveFileDialog { Filter = @"XML files (*.xml)|*.xml|All files (*.*)|*.*" };
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    new FileMapper().SavePublicKeyToPath(dialog.FileName);
                }
            }
            catch (UserInterfaceException ex)
            {
                ShowError(ex);
            }
            catch (Exception ex)
            {
                // TODO: Remove Line Below Like Never Existed.
                ShowError();
            }
            finally
            {
                IsLoaded();
            }

        }

        /// <summary>
        /// فایل فشرده شده حاوی کلید عمومی/کلید خصوصی را در دیسک ذخیره می کند
        /// </summary>
        /// <param name="fileName"></param>
        private void Compress(string fileName)
        {
            try
            {
                string path = Path.GetDirectoryName(fileName);
                if (path != null)
                {
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                }
                using (ZipFile zip = new ZipFile())
                {
                    zip.AddEntry("public_file.xml", File.ReadAllText(PathHelper.GetPath("Resources\\publicKey.xml")),
                        System.Text.Encoding.ASCII);
                    zip.AddEntry("private_file.xml", File.ReadAllText(PathHelper.GetPath("Resources\\privateKey.xml")),
                        System.Text.Encoding.ASCII);
                    zip.Save(fileName);
                }
            }
            catch (Exception)
            {
                throw new UserInterfaceException("امکان ذخیره فایل فشرده شده ی کلید عمومی وجود ندارد، لطفا با بخش پشتیبانی تماس بگیرید.");
            }
        }

        

        protected  override void ShowError(UserInterfaceException ex)
        {
            MessageBox.Show(ex.Message, "خطا در ایجاد کلید", MessageBoxButton.OK, MessageBoxImage.Error,
                    MessageBoxResult.OK, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
            ShowError();
        }

        protected override void ShowError()
        {
            imgCross.Visibility = Visibility.Visible;
            imgTick.Visibility = Visibility.Collapsed;
            imgLogo.Visibility = Visibility.Visible;
            lblMessage.Text = "ایجاد کلید امکان پذیر نمی باشد.";
        }
    }
}
