using GalaSoft.MvvmLight;

namespace XAMLPatterns.VisualStateBinding.ViewModels
{
    public class ViewModelLocator : ViewModelBase
    {
        public MainViewModel Main
        {
            get { return new MainViewModel(); }
        }
    }
}
