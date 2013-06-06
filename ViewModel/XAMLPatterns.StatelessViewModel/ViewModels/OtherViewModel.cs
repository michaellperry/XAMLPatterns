using XAMLPatterns.StatelessViewModel.Models;

namespace XAMLPatterns.StatelessViewModel.ViewModels
{
    public class OtherViewModel
    {
        private readonly Model _model;

        public OtherViewModel(Model model)
        {
            _model = model;            
        }

        //
        // XAML Patterns (4.4):
        //
        // A computed property can access multiple properties
        // of the model. Salutation depends upon both Greeting
        // and Name.
        //
        public string Salutation
        {
            get
            {
                return string.Format("{0}, {1}!",
                    _model.Greeting, _model.Name);
            }
        }
    }
}