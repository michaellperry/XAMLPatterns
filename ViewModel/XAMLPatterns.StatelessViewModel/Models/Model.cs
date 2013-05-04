using UpdateControls.Fields;

namespace XAMLPatterns.StatelessViewModel.Models
{
    public class Model
    {
        private Independent<string> _name = new Independent<string>("World");
        private Independent<string> _greeting = new Independent<string>("Hello");

        public string Greeting
        {
            get { return _greeting; }
            set { _greeting.Value = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name.Value = value; }
        }
    }
}
