using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace XAMLPatterns.ImplicitDataTemplates.WinRT.Selectors
{
    //
    // XAML Patterns (3.10):
    //
    // Define a data template selector that selects a template
    // based on the type of the item.
    //
    public class ImplicitDataTemplateSelector : DataTemplateSelector
    {
        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
        {
            string key = item.GetType().Name;
            FrameworkElement element = container as FrameworkElement;
            while (element != null)
            {
                if (element.Resources.ContainsKey(key))
                    return element.Resources[key] as DataTemplate;
                element = VisualTreeHelper.GetParent(element) as FrameworkElement;
            }
            return Application.Current.Resources[key] as DataTemplate;
        }
    }
}
