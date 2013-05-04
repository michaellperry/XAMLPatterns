using XAMLPatterns.StatelessViewModel.Models;

namespace XAMLPatterns.StatelessViewModel.ViewModels
{
    public class MainViewModel
    {
        private readonly Model _model;

        public MainViewModel(Model model)
        {
            _model = model;
        }

        public string Name
        {
            get { return _model.Name; }
            set { _model.Name = value; }
        }

        public string Greeting
        {
            get { return _model.Greeting; }
            set { _model.Greeting = value; }
        }
    }
}
