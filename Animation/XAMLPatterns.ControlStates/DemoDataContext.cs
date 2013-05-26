using System;
using System.ComponentModel;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace XAMLPatterns.ControlStates
{
    public class DemoDataContext : INotifyDataErrorInfo
    {
        public string InvalidUnfocused
        {
            get { return "Invalid Unfocused"; }
        }

        public string InvalidFocused
        {
            get { return "Invalid Focused"; }
        }

        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        public System.Collections.IEnumerable GetErrors(string propertyName)
        {
            if (propertyName == "InvalidUnfocused")
                yield return "Invalid";
            else if (propertyName == "InvalidFocused")
                yield return "Invalid";
        }

        public bool HasErrors
        {
            get { return true; }
        }
    }
}
