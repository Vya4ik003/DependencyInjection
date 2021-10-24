namespace DependencyInjection.ViewModels
{
    public class MainWindowViewModel : IMainWindowViewModel
    {
        public string Text { get; set; }
        public int Number { get; set; }

        public MainWindowViewModel()
        {
            Text = "Привет!";
            Number = 17;
        }
    }
}
