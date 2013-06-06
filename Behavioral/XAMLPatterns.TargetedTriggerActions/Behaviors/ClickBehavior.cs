using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Interactivity;

namespace XAMLPatterns.TargetedriggerActions.Behaviors
{
    public class MultipleClickBehavior : TargetedTriggerAction<UIElement>
    {
        //
        // XAML Patterns (6.8):
        //
        // Dependency properties to control how the behavior responds.
        //
        public static DependencyProperty TimesProperty =
            DependencyProperty.Register(
                "Times",
                typeof(int),
                typeof(MultipleClickBehavior));

        public int Times
        {
            get { return (int)GetValue(TimesProperty); }
            set { SetValue(TimesProperty, value); }
        }

        //
        // XAML Patterns (6.7):
        //
        // Respond to the event by interacting with a different element.
        //
        protected override void Invoke(object parameter)
        {
            var button = Target as ButtonBase;
            if (button != null)
            {
                var command = button.Command;
                if (command != null && command.CanExecute(null))
                {
                    for (int i = 0; i < Times; ++i)
                    {
                        command.Execute(null);
                    }
                }
            }
        }
    }
}
