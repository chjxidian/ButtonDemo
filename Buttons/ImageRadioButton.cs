using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Buttons
{
    public class ImageRadioButton : RadioButton
    {
        ResourceDictionary rs = new ResourceDictionary();
        public ImageRadioButton()
        {
            rs.Source = new Uri("/Buttons;component/Themes/RadioImageButton.xaml", UriKind.Relative);
            var style = rs["ImageRadioButtonStyle"] as Style;
            this.Style = style;
        }

        static ImageRadioButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ImageRadioButton), new FrameworkPropertyMetadata(typeof(ImageRadioButton)));
        }

        //         public static readonly DependencyProperty TextProperty = DependencyProperty.Register("ImageRadioButton", typeof(string), typeof(FrameworkElement));

        public string ImageSource
        {
            get { return (string)GetValue(ImageSourceProperty); }
            set { SetValue(ImageSourceProperty, value); }
        }

        public static readonly DependencyProperty ImageSourceProperty =
    DependencyProperty.Register("ImageSource", typeof(string), typeof(ImageRadioButton), new PropertyMetadata("/Buttons;component/Images/DefaultImageRadioSource.png", new PropertyChangedCallback(OnImageSourcePropertyChanged)));

        //         public static readonly DependencyProperty ImageSourceProperty =
        //     DependencyProperty.Register("ImageSource", typeof(string), typeof(ImageRadioButton), new PropertyMetadata("defaultValue", new PropertyChangedCallback(OnImageSourcePropertyChanged)));


        private static void OnImageSourcePropertyChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs)
        {
            string path = dependencyPropertyChangedEventArgs.NewValue as string;
            // dependencyPropertyChangedEventArgs.OldValue;
            // (dependencyObject as ImageRadioButton).Style. = path;
        }

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public static readonly DependencyProperty TextProperty =
    DependencyProperty.Register("Text", typeof(string), typeof(ImageRadioButton), new PropertyMetadata("ImageRadioButtonText", new PropertyChangedCallback(OnTextPropertyChanged)));

        private static void OnTextPropertyChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs)
        {

        }

    }
}
