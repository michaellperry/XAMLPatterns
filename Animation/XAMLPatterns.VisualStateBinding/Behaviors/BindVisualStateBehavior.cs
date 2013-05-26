using System.Windows;
using System.Windows.Interactivity;
using Microsoft.Expression.Interactivity;

namespace XAMLPatterns.VisualStateBinding.Behaviors
{
	public class BindVisualStateBehavior : Behavior<FrameworkElement>
	{
		public static DependencyProperty StateNameProperty = DependencyProperty.Register(
			"StateName",
			typeof(string),
			typeof(BindVisualStateBehavior),
			new PropertyMetadata(StateNamePropertyChanged));

		public string StateName
		{
			get { return (string)GetValue(StateNameProperty); }
			set { SetValue(StateNameProperty, value); }
		}

		private static void StateNamePropertyChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
		{
			((BindVisualStateBehavior)obj).UpdateVisualState(
                (string)args.NewValue,
                useTransitions: true);
		}

        protected override void OnAttached()
        {
            UpdateVisualState(
                StateName,
                useTransitions: false);
            base.OnAttached();
        }

		private void UpdateVisualState(
            string visualState,
            bool useTransitions)
		{
			if (AssociatedObject != null)
			{
				FrameworkElement stateTarget;
				if (VisualStateUtilities.TryFindNearestStatefulControl(
                    AssociatedObject, out stateTarget))
				{
					VisualStateUtilities.GoToState(
                        stateTarget,
                        visualState,
                        useTransitions);
				}
			}
		}
	}
}