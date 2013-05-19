using System.Windows;
using System.Windows.Input;
using System.Windows.Interactivity;

namespace XAMLPatterns.BlendBehaviors.Behaviors
{
	public class ClickBehavior : Behavior<UIElement>
	{
        public static DependencyProperty CountProperty =
            DependencyProperty.Register(
                "Count",
                typeof(int),
                typeof(ClickBehavior));
        public static DependencyProperty IncrementProperty =
            DependencyProperty.Register(
                "Increment",
                typeof(int),
                typeof(ClickBehavior));

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

        protected override void OnAttached()
        {
            AssociatedObject.MouseDown += AssociatedObject_MouseDown;
            base.OnAttached();
        }

        protected override void OnDetaching()
        {
            AssociatedObject.MouseDown -= AssociatedObject_MouseDown;
            base.OnDetaching();
        }

        void AssociatedObject_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Count += Increment;
        }
	}
}