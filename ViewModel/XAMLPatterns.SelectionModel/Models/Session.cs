using UpdateControls.Fields;

namespace XAMLPatterns.SelectionModel.Models
{
    public class Session
    {
        private int _id;
        private Independent<string> _title = new Independent<string>();
        private Independent<string> _speaker = new Independent<string>();

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Title
        {
            get { return _title; }
            set { _title.Value = value; }
        }

        public string Speaker
        {
            get { return _speaker; }
            set { _speaker.Value = value; }
        }
    }
}
