using System.Windows;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;

namespace XAMLPatterns.ViewModelServices.ViewModels
{
    public class ViewModelLocator : ViewModelBase
    {
        private SimpleIoc _container = new SimpleIoc();

        public ViewModelLocator()
        {
            _container.Register<MainViewModel>();
        }

        public static ViewModelLocator Current
        {
            get { return (ViewModelLocator)Application.Current.Resources["Locator"]; }
        }

        public void Register<T>(T component)
            where T: class
        {
            _container.Register<T>(() => component);
        }

        public void Unregister<T>()
            where T: class
        {
            _container.Unregister<T>();
        }

        public T GetInstance<T>()
        {
            return _container.GetInstance<T>();
        }

        public MainViewModel Main
        {
            get { return _container.GetInstance<MainViewModel>(); }
        }
    }
}
