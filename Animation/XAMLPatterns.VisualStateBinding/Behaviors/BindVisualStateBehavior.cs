using System.Windows;
using System.Windows.Interactivity;
using Microsoft.Expression.Interactivity;

namespace XAMLPatterns.VisualStateBinding.Behaviors
{
	public class BindVisualStateBehavior : Behavior<FrameworkElement>
	{
        //
        // XAML Patterns (7.2):
        //
        // Dependency property "StateName" that you can bind in Blend.
        // Bind this to the enumeration that controls the visual state.
        //
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

        //
        // XAML Patterns (7.2):
        //
        // When the StateName property changes, switch to the
        // new visual state, and play transition animations.
        //
        private static void StateNamePropertyChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
		{
			((BindVisualStateBehavior)obj).UpdateVisualState(
                (string)args.NewValue,
                useTransitions: true);
		}

        //
        // XAML Patterns (7.2):
        //
        // When the behavior is first attached, go to the visual state,
        // but don't play any animations.
        //
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