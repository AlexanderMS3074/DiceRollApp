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

/*TODO  GUI
        Add interfaces for:
        - Number of Dice
        - Dice Sides
        - Modifier
        - Modifier Amount
        Reskin Buttons and Scrollbar
*/
/*TODO  Aftertoughts
        Add randomizer for multiple RP dice rolling texts
*/
namespace DiceRollApp {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        DiceRoll DiceRoll = new DiceRoll();

        public MainWindow() {
            InitializeComponent();
            tblkRollHistory.Text = "I'm working!!!";
        }

        private void LblRPText_Initialized(object sender, EventArgs e) {
            lblRPText.Content = "You roll X number of Y dice with a modifier +/- Z.\n" + 
                                "The outcome of the roll totals N...";
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e) {
            Environment.Exit(0);
        }

//TODO  Comment All Methods Below This Line (Debug Methods Only)
        private void BtnTest_Click(object sender, RoutedEventArgs e) {
            tblkRollHistory.Text = tblkRollHistory.Text;
        }
    }
}
