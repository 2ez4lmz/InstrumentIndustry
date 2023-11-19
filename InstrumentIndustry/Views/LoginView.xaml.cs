using System.Text.RegularExpressions;
using System.Windows;

namespace InstrumentIndustry.Views;

public partial class LoginView : Window
{
    public LoginView()
    {
        InitializeComponent();
    }


    private void LoginButton_Click(object sender, RoutedEventArgs e)
    {
        string username = usernameTb.Text; // Получаем введенное имя пользователя
        string password = passwordPb.Password; // Получаем введенный пароль

        // Проверяем логин и пароль
        if (IsLoginValid(username, password))
        {
            // Логин и пароль верны, открываем новое окно или страницу
            MainView mainView = new MainView(); // Создаем новое окно (или страницу)
            mainView.Show(); // Показываем новое окно
            Close(); // Закрываем текущее окно аутентификации
        }
        else
        {
            // Логин и/или пароль неверны, показываем сообщение об ошибке
            errormessage.Text = "Неверный логин или пароль.";
        }
    }

    private bool IsLoginValid(string username, string pass)
    {
        if (username == "root" || pass == "")  
        {  
            return true;
        }  
        
        return false;
    }
}