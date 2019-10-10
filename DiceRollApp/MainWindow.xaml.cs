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

namespace DiceRollApp {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        private int turnCount = 0;
        private string rollResults;
        private string rollModifiers;

        public MainWindow() {
            InitializeComponent();
            tblkRollHistory.Text = "I'm working!!!";
        }

        private void BtnTest_Click(object sender, RoutedEventArgs e) {
            tblkRollHistory.Text = tblkRollHistory.Text; //TODO change this!!!!!
        }
    }
}
