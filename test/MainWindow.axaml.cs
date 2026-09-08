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

        if (username == "admin" && password == "admin")
        {
            Lbl_Uname.Text = $"Username {username} is correct!";
            Lbl_Pword.Text = $"Password {password} is correct!";
        }
        else
        {
            Lbl_Uname.Text = $"Incorrect username or password!";
        }

    }
}