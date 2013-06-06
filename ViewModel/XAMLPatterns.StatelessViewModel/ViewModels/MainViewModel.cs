using XAMLPatterns.StatelessViewModel.Models;

namespace XAMLPatterns.StatelessViewModel.ViewModels
{
    public class MainViewModel
    {
        //
        // XAML Patterns (4.4):
        //
        // The only kind of field in a stateless view model is a
        // readonly reference to the model.
        //
        private readonly Model _model;

        public MainViewModel(Model model)
        {
            _model = model;
        }

        //
        // XAML Patterns (4.4):
        //
        // All properties are computed and passed through to the model.
        //
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
