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

namespace SleepChamp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    
    private bool IsTextNumeric(string text)
    {
        return int.TryParse(text, out _);
    }
    
    private void TimerLengthText_PreviewTextInput(object sender, TextCompositionEventArgs e)
    {
        e.Handled = !IsTextNumeric(e.Text);
    }


    private void Button_OnClick(object sender, RoutedEventArgs e)
    {
        var textValue = TimerLengthText.Text;
        Console.WriteLine($"Start button clicked! TextBox value: {textValue}");
    }
}