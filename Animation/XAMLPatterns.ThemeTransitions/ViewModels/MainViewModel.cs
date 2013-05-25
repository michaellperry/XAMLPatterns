using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using UpdateControls.XAML;
using XAMLPatterns.ThemeTransitions.Models;

namespace XAMLPatterns.ThemeTransitions.ViewModels
{
    public class MainViewModel
    {
        private readonly Document _document;
        private readonly NumberSelection _selection;
        
        public MainViewModel(Document document, NumberSelection selection)
        {
            _document = document;
            _selection = selection;
        }

        public IEnumerable<int> Numbers
        {
            get
            {
                return
                    from n in _document.Numbers
                    orderby n
                    select n;
            }
        }

        public int SelectedNumber
        {
            get { return _selection.SelectedNumber; }
            set { _selection.SelectedNumber = value; }
        }

        public ICommand NewNumber
        {
            get
            {
                return MakeCommand
                    .Do(delegate
                    {
                        _document.NewNumber();
                    });
            }
        }

        public ICommand DeleteNumber
        {
            get
            {
                return MakeCommand
                    .When(() => _document.Numbers.Contains(_selection.SelectedNumber))
                    .Do(delegate
                    {
                        _document.DeleteNumber(_selection.SelectedNumber);
                        _selection.SelectedNumber = 0;
                    });
            }
        }
    }
}
