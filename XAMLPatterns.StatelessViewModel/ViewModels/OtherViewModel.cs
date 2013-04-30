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

        public string Salutation
        {
            get { return string.Format("{0}, {1}!", _model.Greeting, _model.Name); }
        }
    }
}
