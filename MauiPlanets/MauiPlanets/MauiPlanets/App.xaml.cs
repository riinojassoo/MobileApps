using MauiPlanets.Views;

namespace MauiPlanets
{
    public partial class App : Application
    {
        const int WindowWidth = 540;
        const int WindowHeight = 1200;
        //teha iseseisvalt vaate automaatne avanemine
        public App()
        {
            InitializeComponent();

            MainPage = new StartPage();
        }
    }
}
