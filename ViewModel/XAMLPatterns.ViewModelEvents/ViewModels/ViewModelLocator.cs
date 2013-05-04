using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;

namespace XAMLPatterns.ViewModelEvents.ViewModels
{
    public class ViewModelLocator : ViewModelBase
    {
        private SimpleIoc _container = new SimpleIoc();

        public ViewModelLocator()
        {
            _container.Register<MainViewModel>();
        }

        public MainViewModel Main
        {
            get { return _container.GetInstance<MainViewModel>(); }
        }
    }
}
