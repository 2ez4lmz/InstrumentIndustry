using System;
using System.Windows;

namespace InstrumentIndustry.Views;

public partial class MainView : Window
{
    public MainView()
    {
        InitializeComponent();

        //this is to set default page on application startup such as dashboard...etc..
        frame.Navigate(new Uri("Views\\EmployeeView.xaml", UriKind.RelativeOrAbsolute));
    }

    private void SideMenuControl_SelectionChanged(object sender, EventArgs e)
    {
        switch (MenuList.SelectedIndex)
        {
            case 0:
                frame.Navigate(new Uri("Views\\EmployeeView.xaml", UriKind.RelativeOrAbsolute));
                break;
            case 1:
                frame.Navigate(new Uri("Views\\CertificationResultView.xaml", UriKind.RelativeOrAbsolute));
                break;
            case 2:
                frame.Navigate(new Uri("Views\\ReportView.xaml", UriKind.RelativeOrAbsolute));
                break;
        }
    }
}