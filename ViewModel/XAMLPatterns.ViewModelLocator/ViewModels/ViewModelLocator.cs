using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using XAMLPatterns.ViewModelLocator.Models;

namespace XAMLPatterns.ViewModelLocator.ViewModels
{
    public class ViewModelLocator : ViewModelBase
    {
        private SimpleIoc _container = new SimpleIoc();

        public ViewModelLocator()
        {
            _container.Register<IConferenceService, ConferenceService>();
            _container.Register<ConferenceViewModel>();
            _container.Register<SessionViewModel>();
        }

        //
        // XAML Patterns (4.7):
        //
        // Each property of the view model locator is a different view model.
        //
        public ConferenceViewModel Conference
        {
            get { return _container.GetInstance<ConferenceViewModel>(); }
        }

        public SessionViewModel Session
        {
            get { return _container.GetInstance<SessionViewModel>(); }
        }
    }
}
