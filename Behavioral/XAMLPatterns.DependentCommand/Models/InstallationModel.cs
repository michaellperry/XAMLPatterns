using UpdateControls.Fields;

namespace XAMLPatterns.DependentCommand.Models
{
    public class InstallationModel
    {
        private Independent<string> _location = new Independent<string>();
        private Independent<bool> _agree = new Independent<bool>();

        public string Location
        {
            get { return _location; }
            set { _location.Value = value; }
        }

        public bool Agree
        {
            get { return _agree; }
            set { _agree.Value = value; }
        }
    }
}
