using Microsoft.Extensions.DependencyInjection;
using DependencyInjection.ViewModels;
using System;
using System.Windows;

namespace DependencyInjection
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly IServiceProvider _serviceProvider;

        public App()
        {
            ServiceCollection collection = new ServiceCollection();
            ConfigureServices(collection);
            _serviceProvider = collection.BuildServiceProvider();
        }

        private static void ConfigureServices(ServiceCollection collection)
        {
            collection.AddScoped<MainWindow>();
            collection.AddScoped<IMainWindowViewModel, MainWindowViewModel>();
        }

        public void OnStartup(object sender, StartupEventArgs e)
        {
            MainWindow mainWindow = _serviceProvider.GetRequiredService<MainWindow>();
            mainWindow.Show();
        }
    }
}
