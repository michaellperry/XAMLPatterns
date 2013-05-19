using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Interactivity;

namespace XAMLPatterns.TargetedriggerActions.Behaviors
{
    public class MultipleClickBehavior : TargetedTriggerAction<UIElement>
    {
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
