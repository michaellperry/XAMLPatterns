using GalaSoft.MvvmLight;

namespace XAMLPatterns.CircularAnimations.ViewModels
{
    public class ViewModelLocator : ViewModelBase
    {
        public MainViewModel Main
        {
            get { return new MainViewModel(); }
        }
    }
}
