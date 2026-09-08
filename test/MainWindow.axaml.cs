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
        var dash = new Dash();
        string username = Tb_Uname.Text ?? string.Empty;
        string password = Tb_Pword.Text ?? string.Empty;
        
        if (username == "admin" && password == "admin")
        {
           dash.Show();
           this.Close();
        }
        else
        {
            Lbl_ErrorMsg.Text = $"Incorrect username or password!";
        }

    }
}