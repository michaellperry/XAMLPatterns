using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XAMLPatterns.ViewModelFirst.ViewModels
{
    public class BreakoutSessionViewModel : SessionViewModel
    {
        public BreakoutSessionViewModel(int sessionId)
            : base(sessionId)
        {

        }

        public string Speaker
        {
            get { return _speaker; }
            set
            {
                if (value == _speaker)
                    return;

                RaisePropertyChanging(() => this.Speaker);
                _speaker = value;
                RaisePropertyChanged(() => this.Speaker);
            }
        }
    }
}
