using System.Collections.Generic;
using System.Reflection;
using System.Resources;
using System.Windows.Media;

namespace InstrumentIndustry.ViewModels;

public class MainViewModel
{

    public List<MenuItemsData> ItemsList
    {
        get
        {
            return new List<MenuItemsData>
            {
                new MenuItemsData(){ Icon = GetImageFromResource("Сотрудники"), MenuText="Сотрудники" },
                new MenuItemsData(){ Icon = GetImageFromResource("Результаты"), MenuText="Результаты" },
                new MenuItemsData(){ Icon = GetImageFromResource("Отчеты"), MenuText="Отчеты" }
            };
        }
    }

    private ImageSource GetImageFromResource(string resourceName)
    {
        var assembly = Assembly.GetExecutingAssembly();
        var resourceManager = new ResourceManager("InstrumentIndustry.Properties.Resources", assembly);

        // Assuming that your resources are Bitmaps, you may need to adapt this part
        var imageBytes = (byte[])resourceManager.GetObject(resourceName);
        var imageSourceConverter = new ImageSourceConverter();
        return (ImageSource)imageSourceConverter.ConvertFrom(imageBytes);
    }

    public class MenuItemsData
    {
        public ImageSource Icon { get; set; }
        public bool IsItemSelected { get; set; }
        public string MenuText { get; set; }
    }

}