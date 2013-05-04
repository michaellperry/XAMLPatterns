using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using XAMLPatterns.ViewModelFirst.ViewModels;
using XAMLPatterns.ViewModelFirst.Windows;

namespace XAMLPatterns.ViewModelFirst.Views
{
    /// <summary>
    /// Interaction logic for ConferenceView.xaml
    /// </summary>
    public partial class ConferenceView : UserControl
    {
        public ConferenceView()
        {
            InitializeComponent();
        }

        private void ListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var viewModel = DataContext as ConferenceViewModel;
            var sessionViewModel = viewModel.CreateSelectedSessionViewModel();

            if (sessionViewModel != null)
            {
                SessionWindow sessionWindow = new SessionWindow();
                sessionWindow.Show(sessionViewModel);
            }
        }
    }
}
