using UpdateControls.Fields;

namespace XAMLPatterns.DesignModeModels.Models
{
    public class Speaker
    {
        private Independent<string> _name = new Independent<string>();

        public string Name
        {
            get { return _name; }
            set { _name.Value = value; }
        }
    }
}
