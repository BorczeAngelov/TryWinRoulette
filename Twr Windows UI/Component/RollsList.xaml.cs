using System.Windows;
using System.Windows.Controls;
using TryWinRoulette.Engine.Interface;

namespace Twr_Windows_UI.Component
{
    /// <summary>
    /// Interaction logic for RollsList.xaml
    /// </summary>
    public partial class RollsList : UserControl
    {
        public RollsList()
        {
            InitializeComponent();
        }

        public IRouletteRolls RouletteRolls
        {
            get { return (IRouletteRolls)GetValue(RouletteRollsProperty); }
            set { SetValue(RouletteRollsProperty, value); }
        }

        public static readonly DependencyProperty RouletteRollsProperty =
            DependencyProperty.Register("RouletteRolls", typeof(IRouletteRolls), typeof(RollsList));
    }
}
