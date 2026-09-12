using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace test;

public partial class Dash : Window
{
    public Dash()
    {
        InitializeComponent();
        container.Children.Add(new UserControl4());
    }

    public void FirstPanel(object sender, RoutedEventArgs e)
    {
        container.Children.Clear();
        container.Children.Add(new UserControl1());
    }
    
    public void SecondPanel(object sender, RoutedEventArgs e)
    {
        container.Children.Clear();
        container.Children.Add(new UserControl2());
    }
    
    public void ThirdPanel(object sender, RoutedEventArgs e)
    {
        container.Children.Clear();
        container.Children.Add(new UserControl3());
    }
    
    public void LogOut(object sender, RoutedEventArgs e)
    {
        var login = new MainWindow();
        login.Show();
        this.Close();
    }
    
}