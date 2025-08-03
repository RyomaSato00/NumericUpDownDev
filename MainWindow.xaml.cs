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

using NumericUpDownDev.ViewModels;

namespace NumericUpDownDev;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private readonly MainWindowViewModel _mainWindowViewModel;

    public MainWindow()
    {
        InitializeComponent();

        _mainWindowViewModel = new MainWindowViewModel();

        DataContext = _mainWindowViewModel;

        Closing += MainWindow_Closing;
        Loaded += MainWindow_Loaded;
    }

    private void MainWindow_Loaded(object sender, RoutedEventArgs e)
    {

    }

    private void MainWindow_Closing(object? sender, System.ComponentModel.CancelEventArgs e)
    {

    }
}
