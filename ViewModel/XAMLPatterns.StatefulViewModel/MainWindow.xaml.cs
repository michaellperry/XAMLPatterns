using System.Windows;
using System.Windows.Controls;

namespace XAMLPatterns.StatefulViewModel
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateSalutation();
        }

        private void GreetingTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateSalutation();
        }

        private void UpdateSalutation()
        {
            SalutationTextBlock.Text =
                string.Format("{0}, {1}!",
                    GreetingTextBox.Text,
                    NameTextBox.Text);
        }
    }
}
