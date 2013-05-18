using UpdateControls.XAML;
using XAMLPatterns.DependentCommand.Models;

namespace XAMLPatterns.DependentCommand.ViewModels
{
    public class ViewModelLocator : ViewModelLocatorBase
    {
        private InstallationModel _installation = new InstallationModel();

        public object Main
        {
            get { return ViewModel(() => new MainViewModel(_installation)); }
        }
    }
}
