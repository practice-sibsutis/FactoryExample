
using SimpleFactoryPatternExample.Models;
using System.IO;

namespace SimpleFactoryPatternExample.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public CityEvent cityEvent;

        public MainWindowViewModel()
        {
            cityEvent = new CityEvent { Header = "asdasd" };
        }
    }
}