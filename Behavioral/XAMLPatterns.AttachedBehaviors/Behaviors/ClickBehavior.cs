using System.Windows;
using System.Windows.Input;

namespace XAMLPatterns.AttachedBehaviors.Behaviors
{
    public static class ClickBehavior
    {
        public static DependencyProperty CommandProperty =
            DependencyProperty.RegisterAttached(
                "Command",
                typeof(ICommand),
                typeof(ClickBehavior),
                new PropertyMetadata(CommandPropertyChanged));

        public static ICommand GetCommand(DependencyObject obj)
        {
            return obj.GetValue(CommandProperty) as ICommand;
        }

        public static void SetCommand(DependencyObject obj, ICommand value)
        {
            obj.SetValue(CommandProperty, value);
        }

        private static void CommandPropertyChanged(
            DependencyObject d,
            DependencyPropertyChangedEventArgs e)
        {
            var uiElement = d as UIElement;
            if (uiElement != null)
            {
                uiElement.MouseDown += UIElement_MouseDown;
            }
        }

        private static void UIElement_MouseDown(
            object sender,
            MouseButtonEventArgs e)
        {
            var command = GetCommand((DependencyObject)sender);
            if (command != null && command.CanExecute(null))
                command.Execute(null);
        }
    }
}
