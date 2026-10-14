using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Interactivity;
using System.Threading.Tasks;

namespace AvaloniaImageScanningDemo
{
    public partial class MessageWindow : Window
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageWindow"/> class.
        /// </summary>
        public MessageWindow(string messageText)
        {
            InitializeComponent();

            text.Text = messageText;
        }



        public async Task ShowDialog()
        {
            if (Application.Current?.ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                Window mainWindow = desktop.MainWindow;

                await base.ShowDialog(mainWindow);
            }
        }

        private void buttonOk_Click(object? sender, RoutedEventArgs e)
        {
            Close(true);
        }

    }
}
