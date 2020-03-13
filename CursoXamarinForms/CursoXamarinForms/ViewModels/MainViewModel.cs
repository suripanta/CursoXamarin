namespace CursoXamarinForms.ViewModels
{
    class MainViewModel
    {
        public LoginViewModel Login { get; set; }
        public LandsViewModel Lands { get; set; }
        public MainViewModel()
        {
            this.Login = new LoginViewModel();
        }


        #region Singleton
        private static MainViewModel instance;
        public static MainViewModel GetInstance()
        {
            if (instance == null)
                return new MainViewModel();
            else
                return instance;
        }
        #endregion
    }
}
