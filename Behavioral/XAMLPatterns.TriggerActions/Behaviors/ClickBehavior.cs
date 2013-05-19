using System.Windows;
using System.Windows.Input;
using System.Windows.Interactivity;

namespace XAMLPatterns.TriggerActions.Behaviors
{
    public class ClickBehavior : TriggerAction<UIElement>
    {
        public static DependencyProperty CommandProperty = DependencyProperty.Register(
            "Command",
            typeof(ICommand),
            typeof(ClickBehavior));
        public static DependencyProperty CountProperty = DependencyProperty.Register(
            "Count",
            typeof(int),
            typeof(ClickBehavior));

        public ICommand Command
        {
            get { return (ICommand)GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }

        public int Count
        {
            get { return (int)GetValue(CountProperty); }
            set { SetValue(CountProperty, value); }
        }

        protected override void Invoke(object parameter)
        {
            var command = Command;
            var count = Count;

            if (command != null)
            {
                for (int i = 0; i < count; ++i)
                    command.Execute(null);
            }
        }
    }
}
