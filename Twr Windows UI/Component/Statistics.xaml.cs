using System.Windows;
using System.Windows.Controls;
using TryWinRoulette.Engine.Interface;

namespace Twr_Windows_UI.Component
{
    /// <summary>
    /// Interaction logic for Statistics.xaml
    /// </summary>
    public partial class Statistics : UserControl
    {
        public Statistics()
        {
            InitializeComponent();
        }

        public IBasicStatistics BasicStatistics
        {
            get { return (IBasicStatistics)GetValue(BasicStatisticsProperty); }
            set { SetValue(BasicStatisticsProperty, value); }
        }
        
        public static readonly DependencyProperty BasicStatisticsProperty =
            DependencyProperty.Register("BasicStatistics", typeof(IBasicStatistics), typeof(Statistics));

    }
}
