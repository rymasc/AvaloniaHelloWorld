using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using AvaloniaHelloWorld.Models;

namespace AvaloniaHelloWorld{
    public class MainWindow : Window{
        public MainWindow(){
            InitializeComponent();
            this.DataContext = new HelloViewModel() { Greeting = "Enter a Name and click the button" };
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent(){
            AvaloniaXamlLoader.Load(this);
        }

        public void OnButtonClicked(object sender, RoutedEventArgs args) {
            HelloViewModel context = this.DataContext as HelloViewModel;
            context.Greeting = $"Hello {context.Name}";

        }
    }
}
