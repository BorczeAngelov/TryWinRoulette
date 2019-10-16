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

        // Using a DependencyProperty as the backing store for BasicStatistics.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty BasicStatisticsProperty =
            DependencyProperty.Register("BasicStatistics", typeof(IBasicStatistics), typeof(Statistics), new PropertyMetadata(null));

    }
}
