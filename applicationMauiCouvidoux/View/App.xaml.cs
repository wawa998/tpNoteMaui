using applicationMauiCouvidoux.View;

namespace applicationMauiCouvidoux
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
