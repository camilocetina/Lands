using System;


namespace Lands
{
    using views;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;
    public partial class App : Application
    {
        #region Contructor
        public App()
        {
            InitializeComponent();

            this.MainPage = new NavigationPage( new LoginPage());
        }

        #endregion
        #region metodos

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        } 
        #endregion
    }
}
