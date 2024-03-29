using System.Collections.ObjectModel;
using applicationMauiCouvidoux.Model;
using applicationMauiCouvidoux.View;

namespace applicationMauiCouvidoux
{
    public partial class App : Application
    {
        private ObservableCollection<Monster> testeur = new ObservableCollection<Monster>();
        public App()
        {
            InitializeComponent();
            if (appData.list.Count == 0)
            {
                test();
            }
            MainPage = new AppShell();
        }

        private async void test()
        {
            testeur = await MonsterService.LoadData();
            appData.list = testeur;
        }
    }
}
