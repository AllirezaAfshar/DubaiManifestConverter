using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
using Verifier.Exceptions;
using Verifier.Template;
using Verifier.Utility;
using NavigationEventArgs = FirstFloor.ModernUI.Windows.Navigation.NavigationEventArgs;

namespace Verifier.UserControl
{
    /// <summary>
    /// Interaction logic for uPublicKey.xaml
    /// </summary>
    public partial class uPublicKey : DetailsPage
    {
        public uPublicKey()
        {
            InitializeComponent();
            BitmapImageHelper.SetSource(imgBarcode);
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                SaveFileDialog dialog = new System.Windows.Forms.SaveFileDialog { Filter = @"XML files (*.xml)|*.xml|All files (*.*)|*.*" };
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

        }
    }
}
