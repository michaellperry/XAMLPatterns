using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace XAMLPatterns.ImplicitDataTemplates.SL.Selectors
{
    public class ImplicitDataTemplateControl : ContentControl
    {
        //
        // XAML Patterns (3.10):
        //
        // When the content changes, select a data template based on its type.
        //
        protected override void OnContentChanged(object oldContent, object newContent)
        {
            ContentTemplate = SelectTemplateCore(newContent, this);

            base.OnContentChanged(oldContent, newContent);
        }

        protected DataTemplate SelectTemplateCore(object item, DependencyObject container)
        {
            string key = item.GetType().Name;
            FrameworkElement element = container as FrameworkElement;
            while (element != null)
            {
                DataTemplate template = element.Resources[key] as DataTemplate;
                if (template != null)
                    return template;
                element = VisualTreeHelper.GetParent(element) as FrameworkElement;
            }
            return Application.Current.Resources[key] as DataTemplate;
        }
    }
}
