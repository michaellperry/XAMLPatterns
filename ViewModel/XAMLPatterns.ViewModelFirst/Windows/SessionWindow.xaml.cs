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
using System.Windows.Shapes;
using XAMLPatterns.ViewModelFirst.ViewModels;
using GalaSoft.MvvmLight.Messaging;
using XAMLPatterns.ViewModelFirst.Messages;

namespace XAMLPatterns.ViewModelFirst.Windows
{
    /// <summary>
    /// Interaction logic for SessionWindow.xaml
    /// </summary>
    public partial class SessionWindow : Window
    {
        private int _sessionId;

        public SessionWindow()
        {
            InitializeComponent();
        }

        public void Show(SessionViewModel sessionViewModel)
        {
            SessionContent.Content = sessionViewModel;
            _sessionId = sessionViewModel.Id;
            this.Title = sessionViewModel.Title;
            Messenger.Default.Register<SessionTitleChanged>(this, message =>
            {
                if (message.SessionId == _sessionId)
                    this.Title = message.NewTitle;
            });
            Show();
        }

        private void Window_Unloaded(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Unregister(this);
        }
    }
}
