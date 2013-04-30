using UpdateControls.XAML;
using XAMLPatterns.StatelessViewModel.Models;

namespace XAMLPatterns.StatelessViewModel.ViewModels
{
    public class ViewModelLocator : ViewModelLocatorBase
    {
        private Model _model;

        public ViewModelLocator()
        {
            _model = new Model();
        }

        public object Main
        {
            get { return ViewModel(() => new MainViewModel(_model)); }
        }

        public object Other
        {
            get { return ViewModel(() => new OtherViewModel(_model)); }
        }
    }
}
