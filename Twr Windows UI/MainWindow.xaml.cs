using System;
using System.Windows;

namespace Twr_Windows_UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly MainWindowVM _mainWindowVM;

        public MainWindow()
        {
            InitializeComponent();
            _mainWindowVM = new MainWindowVM();
            this.DataContext = _mainWindowVM;
        }

        private void OnGenerateRouletteRollsClick(object sender, RoutedEventArgs e)
        {
            _mainWindowVM.GenerateRolls();
            _mainWindowVM.GenerateBasicStatistics();
        }        
    }
}
