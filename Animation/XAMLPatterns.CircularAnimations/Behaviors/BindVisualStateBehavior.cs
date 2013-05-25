using System.Windows;
using System.Windows.Interactivity;
using Microsoft.Expression.Interactivity;

namespace XAMLPatterns.CircularAnimations.Behaviors
{
	public class BindVisualStateBehavior : Behavior<FrameworkElement>
	{
		public static DependencyProperty StateNameProperty = DependencyProperty.Register(
			"StateName",
			typeof(string),
			typeof(BindVisualStateBehavior),
			new PropertyMetadata(VisualStatePropertyChanged));
		private bool _initialized = false;

		public string StateName
		{
			get { return (string)GetValue(StateNameProperty); }
			set { SetValue(StateNameProperty, value); }
		}

		public void UpdateVisualState(string visualState)
		{
			if (AssociatedObject != null)
			{
				FrameworkElement stateTarget;
				if (VisualStateUtilities.TryFindNearestStatefulControl(AssociatedObject, out stateTarget))
				{
					bool useTransitions = _initialized;
					VisualStateUtilities.GoToState(stateTarget, visualState, useTransitions);
					_initialized = true;
				}
			}
		}

        protected override void OnAttached()
        {
            UpdateVisualState(StateName);
            base.OnAttached();
        }

		private static void VisualStatePropertyChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
		{
			((BindVisualStateBehavior)obj).UpdateVisualState((string)args.NewValue);
		}
	}
}