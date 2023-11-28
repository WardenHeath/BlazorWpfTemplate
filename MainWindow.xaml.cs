using System.Windows;
using BlazorStrap;
using Microsoft.Extensions.DependencyInjection;

namespace MagstimEMGTestApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var serviceCollection = new ServiceCollection();
            serviceCollection.AddWpfBlazorWebView();
            serviceCollection.AddBlazorWebViewDeveloperTools();
            serviceCollection.AddBlazorStrap();
            Resources.Add("services", serviceCollection.BuildServiceProvider());
            WindowState = WindowState.Maximized;
        }
    }
}
