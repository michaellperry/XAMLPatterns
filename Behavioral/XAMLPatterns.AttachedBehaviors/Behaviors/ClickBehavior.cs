using System.Windows;
using System.Windows.Input;

namespace XAMLPatterns.AttachedBehaviors.Behaviors
{
    public static class ClickBehavior
    {
        //
        // XAML Patterns (6.5):
        //
        // Attached property to give us a hook to access a control.
        //
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

        //
        // XAML Patterns (6.5):
        //
        // When the attached property "changes", it has been attached.
        // Register for the mouse down event.
        //
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

        //
        // XAML Patterns (6.5):
        //
        // Get the command that has been bound to the property, and execute it.
        //
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
