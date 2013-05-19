using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Interactivity;

namespace XAMLPatterns.TargetedriggerActions.Behaviors
{
    public class ClickBehavior : TargetedTriggerAction<UIElement>
    {
        public static DependencyProperty CountProperty = DependencyProperty.Register(
            "Count",
            typeof(int),
            typeof(ClickBehavior));

        public int Count
        {
            get { return (int)GetValue(CountProperty); }
            set { SetValue(CountProperty, value); }
        }

        protected override void Invoke(object parameter)
        {
            var target = Target as ButtonBase;
            var count = Count;

            if (target != null)
            {
                for (int i = 0; i < count; ++i)
                    target.Command.Execute(null);
            }
        }
    }
}
