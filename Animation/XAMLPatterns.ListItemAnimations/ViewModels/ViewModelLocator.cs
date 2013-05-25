using UpdateControls.XAML;
using XAMLPatterns.ListItemAnimations.Models;

namespace XAMLPatterns.ListItemAnimations.ViewModels
{
    public class ViewModelLocator : ViewModelLocatorBase
    {
        private Document _document = new Document();
        private NumberSelection _selection = new NumberSelection();

        public ViewModelLocator()
        {
            _document.NewNumber();
            _document.NewNumber();
            _document.NewNumber();
        }

        public object Main
        {
            get { return ViewModel(() => new MainViewModel(_document, _selection)); }
        }
    }
}
