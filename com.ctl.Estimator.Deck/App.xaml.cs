using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using com.ctl.Estimator.Deck.Views;
using com.ctl.Estimator.Deck.Services;

namespace com.ctl.Estimator.Deck
{
    public partial class App : Application
    {

        static DeckDataBase database;

        public static DeckDataBase Database
        {
            get
            {
                if (database == null)
                {
                    database = new DeckDataBase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Notes.db3"));
                }
                return database;
            }
        }



        public App()
        {
            InitializeComponent();

            //DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
            //MainPage = new NavigationPage(new NotesPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
