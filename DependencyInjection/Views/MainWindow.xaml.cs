using System.Windows;
using DependencyInjection.ViewModels;

namespace DependencyInjection
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(IMainWindowViewModel _viewModel)
        {
            InitializeComponent();
            DataContext = _viewModel;
        }
    }
}
