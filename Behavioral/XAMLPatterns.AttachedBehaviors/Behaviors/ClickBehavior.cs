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
            var component = d as UIElement;
            if (component != null)
            {
                if (e.OldValue == null && e.NewValue != null)
                {
                    component.MouseDown += UIElement_MouseDown;
                }
                if (e.OldValue != null && e.NewValue == null)
                {
                    component.MouseDown -= UIElement_MouseDown;
                }
            }
        }

        private static void UIElement_MouseDown(
            object sender,
            MouseButtonEventArgs e)
        {
            var component = sender as UIElement;
            if (component != null)
            {
                var command = GetCommand(component);
                if (command != null && command.CanExecute(null))
                {
                    command.Execute(null);
                }
            }
        }
    }
}
