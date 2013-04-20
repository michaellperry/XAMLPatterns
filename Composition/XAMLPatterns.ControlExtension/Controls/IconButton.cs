using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace XAMLPatterns.ControlExtension.Controls
{
    public class IconButton : Button
    {
        static IconButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(IconButton), new FrameworkPropertyMetadata(typeof(IconButton)));
        }

        /// <summary>
        /// The <see cref="Icon" /> dependency property's name.
        /// </summary>
        public const string IconPropertyName = "Icon";

        /// <summary>
        /// Gets or sets the value of the <see cref="Icon" />
        /// property. This is a dependency property.
        /// </summary>
        public FrameworkElement Icon
        {
            get
            {
                return (FrameworkElement)GetValue(IconProperty);
            }
            set
            {
                SetValue(IconProperty, value);
            }
        }

        /// <summary>
        /// Identifies the <see cref="Icon" /> dependency property.
        /// </summary>
        public static readonly DependencyProperty IconProperty = DependencyProperty.Register(
            IconPropertyName,
            typeof(FrameworkElement),
            typeof(IconButton));
    }
}
