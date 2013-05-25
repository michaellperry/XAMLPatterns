using UpdateControls.XAML;
using XAMLPatterns.ThemeTransitions.Models;

namespace XAMLPatterns.ThemeTransitions.ViewModels
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
