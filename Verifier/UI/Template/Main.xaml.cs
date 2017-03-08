using System;
using System.Windows;
using System.Windows.Media.Imaging;
using FirstFloor.ModernUI.Presentation;
using FirstFloor.ModernUI.Windows.Controls;
using FirstFloor.ModernUI.Windows.Navigation;
using Verifier.Template;

namespace Verifier.UI.Template
{
    /// <summary>
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main : DetailsPage
    {
        public Main()
        {
            InitializeComponent();
            ModernTab modernTab = new ModernTab()
            {
                Layout = TabLayout.List,
                FlowDirection = FlowDirection.RightToLeft,
                SelectedSource = new Uri(@"/Verifier;component/UI\Pages\Verify.xaml", UriKind.Relative)
            };
            modernTab.Links.Add(new Link()
            {
                DisplayName = "بررسی صحت پروانه",
                ImageSource = new BitmapImage(new Uri(@"/Verifier;component/Assets/lightbulb.png", UriKind.Relative)),
                Source = new Uri(@"/Verifier;component/UI\Pages\Verify.xaml", UriKind.Relative)
            });
            modernTab.Links.Add(new Link()
            {
                DisplayName = "بررسی صحت سایر اسناد",
                ImageSource = new BitmapImage(new Uri(@"/Verifier;component/Assets/upload_page.png", UriKind.Relative)),
                Source = new Uri(@"/Verifier;component/UI\Pages\VerifyDocument.xaml", UriKind.Relative)
            });
            modernTab.Links.Add(new Link()
            {
                DisplayName = "رمزنمودن سایر اسناد",
                ImageSource = new BitmapImage(new Uri(@"/Verifier;component/Assets/world.png", UriKind.Relative)),
                Source = new Uri(@"/Verifier;component/UI\Pages\Sign.xaml", UriKind.Relative)
            });
            modernTab.Links.Add(new Link()
            {
                DisplayName = "ایجاد کلید خصوصی",
                ImageSource = new BitmapImage(new Uri(@"/Verifier;component/Assets/truck.png", UriKind.Relative)),
                Source = new Uri(@"/Verifier;component/UI\Pages\GeneratePrivateKey.xaml", UriKind.Relative)
            });
            this.AddChild(modernTab);
        }

        public override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            ModernWindow window = Application.Current.MainWindow as ModernWindow;
            window.Width = 1170;
            window.Height = 600;
        }
    }
}
