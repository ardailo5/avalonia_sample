using Avalonia.Controls;
using Avalonia.Interactivity;

namespace test;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    public void OnButtonClick(object? sender, RoutedEventArgs e)
    {
        string username = Tb_Uname.Text ?? string.Empty;
        string password = Tb_Pword.Text ?? string.Empty;
        
        Lbl_Uname.Text = $"Username is {username}";
        Lbl_Pword.Text = $"Password is {password}";
        
    }
}