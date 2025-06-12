using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Result;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    //public MainWindow()
    //{
    //    InitializeComponent();

    //    string result = GetDataAsync().Result;

    //    MessageBox.Show(result);
    //}
    //public async Task<string> GetDataAsync()
    //{
    //    await Task.Delay(2000);

    //    return "Download completed";
    //}
    public MainWindow()
    {
        InitializeComponent();

        LoadDataAsync();
    }
    private async void LoadDataAsync()
    {
        try
        {
            string result = await GetDataAsync();
            MessageBox.Show(result);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Warning: {ex.Message}");
        }
    }

    private async Task<string> GetDataAsync()
    {
        await Task.Delay(2000).ConfigureAwait(false);

        return "Download completed";
    }
}