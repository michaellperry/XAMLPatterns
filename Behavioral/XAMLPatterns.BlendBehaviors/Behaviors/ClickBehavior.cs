using System.Windows;
using System.Windows.Input;
using System.Windows.Interactivity;

namespace XAMLPatterns.BlendBehaviors.Behaviors
{
	public class ClickBehavior : Behavior<UIElement>
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

        private void AssociatedObject_MouseDown(object sender, MouseButtonEventArgs e)
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