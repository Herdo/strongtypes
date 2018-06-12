namespace Herdo.StrongTypes.UniversalWindows
{
    using Windows.UI.Xaml;

    public sealed partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
            Loaded += MainPage_Loaded;
        }

        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            var ci = new CustomerInfo();
            ContentTextBlock.Text = ci.GetMembershipDetails();
        }
    }
}
