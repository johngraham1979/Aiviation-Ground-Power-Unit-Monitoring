using System.Windows;

namespace AXARemote.Control
{
    public class Button : System.Windows.Controls.Button
    {
        public static readonly DependencyProperty IsOnProperty
            = DependencyProperty.Register(
                "IsOn",
                typeof(bool),
                typeof(Button),
                new PropertyMetadata(false)
            );

        public bool IsOn
        {
            get => (bool) GetValue(IsOnProperty);
            set => SetValue(IsOnProperty, value);
        }
    }
}