using UpdateControls.Fields;

namespace XAMLPatterns.ThemeTransitions.Models
{
    public class NumberSelection
    {
        private Independent<int> _selectedNumber = new Independent<int>();

        public int SelectedNumber
        {
            get { return _selectedNumber; }
            set { _selectedNumber.Value = value; }
        }
    }
}
