namespace CursoXamarinForms.ViewModels
{
    class MainViewModel
    {
        public LoginViewModel Login { get; set; }
        public MainViewModel()
        {
            this.Login = new LoginViewModel();
        }
    }
}
