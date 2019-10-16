using System.Windows;
using System.Windows.Controls;

namespace Twr_Windows_UI.Component
{
    /// <summary>
    /// Interaction logic for RollTemplate.xaml
    /// </summary>
    public partial class RollTemplate : UserControl
    {
        private const double DefaultCustomWidthAndHeight = 25;

        public RollTemplate()
        {
            InitializeComponent();
        }

        public double CustomWidthAndHeight
        {
            get { return (double)GetValue(CustomWidthAndHeightProperty); }
            set { SetValue(CustomWidthAndHeightProperty, value); }
        }

        public static readonly DependencyProperty CustomWidthAndHeightProperty =
            DependencyProperty.Register("CustomWidthAndHeight", typeof(double), typeof(RollTemplate), new PropertyMetadata(DefaultCustomWidthAndHeight));
    }
}
