using System.Windows;
using System.Windows.Input;
using System.Windows.Interactivity;

namespace XAMLPatterns.TriggerActions.Behaviors
{
    public class IncrementBehavior : TriggerAction<UIElement>
    {
        //
        // XAML Patterns (6.7):
        //
        // Dependency properties to control how the behavior responds.
        //
        public static DependencyProperty CountProperty =
            DependencyProperty.Register(
                "Count",
                typeof(int),
                typeof(IncrementBehavior));
        public static DependencyProperty IncrementProperty =
            DependencyProperty.Register(
                "Increment",
                typeof(int),
                typeof(IncrementBehavior));

        public int Count
        {
            get { return (int)GetValue(CountProperty); }
            set { SetValue(CountProperty, value); }
        }

        public int Increment
        {
            get { return (int)GetValue(IncrementProperty); }
            set { SetValue(IncrementProperty, value); }
        }

        //
        // XAML Patterns (6.7):
        //
        // Invoke the response. The designer chooses the event that will
        // cause the behavior to be invoked.
        //
        protected override void Invoke(object parameter)
        {
            Count += Increment;
        }
    }
}
