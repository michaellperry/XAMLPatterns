using UpdateControls.Fields;

namespace XAMLPatterns.ShadowTypes.Models
{
    public class Room
    {
        private Independent<string> _name = new Independent<string>();

        public string Name
        {
            get { return _name; }
            set { _name.Value = value; }
        }
    }
}
