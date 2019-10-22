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
        Add Control Templates
*/
/*TODO  Aftertoughts
        Add randomizer for multiple RP dice rolling texts
*/
namespace DiceRollApp {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        DiceRoll DiceRoller = new DiceRoll();

        //Debug Variables

        public MainWindow() {
            InitializeComponent();
            tblkRollHistory.Text = "I'm working!!!";
            //Debug Below This Line
            tbxRPText.Text = "You roll X number of Y dice with a modifier +/- Z.\n" +
                             "The outcome of the roll totals N...";
            InitializeSelectionBoxTest();
        }

        #region Intialization
        private void InitializeSelectionBoxTest() {
            for (int i = 1; i < 100; i++) {
                lbxNumberOfDice.Items.Add(i);
            }
            tblkDebugText.Text = $"SelectedIndex: {lbxNumberOfDice.SelectedIndex}\n" +
                                 $"SelectedValue: {lbxNumberOfDice.SelectedItem}";
        }
        #endregion

        #region Button Events
        private void BtnExit_Click(object sender, RoutedEventArgs e) {
            Environment.Exit(0);
        }

        #endregion

        private void LbxNumberOfDice_PreviewMouseWheel(object sender, MouseWheelEventArgs e) {
            if (e.Delta > 0) {
                if (lbxNumberOfDice.SelectedIndex >= 0) {
                    lbxNumberOfDice.SelectedIndex = lbxNumberOfDice.SelectedIndex + 1;
                    lbxNumberOfDice.ScrollIntoView(lbxNumberOfDice.SelectedIndex + 1);
                }
            }
            if (e.Delta < 0) {
                if (lbxNumberOfDice.SelectedIndex <= (lbxNumberOfDice.Items.Count - 1)) {
                    if (lbxNumberOfDice.SelectedIndex == 0) {
                        lbxNumberOfDice.ScrollIntoView(lbxNumberOfDice.SelectedIndex);
                    }
                    else {
                        lbxNumberOfDice.SelectedIndex = lbxNumberOfDice.SelectedIndex - 1;
                        lbxNumberOfDice.ScrollIntoView(lbxNumberOfDice.SelectedIndex + 1);
                    }
                }
            }
            e.Handled = true;
        }

        //TODO  Comment All Methods Below This Line (Debug Methods Only)
        private void BtnTest_Click(object sender, RoutedEventArgs e) {
            tblkDebugText.Text = $"SelectedIndex: {lbxNumberOfDice.SelectedIndex}\n" +
                                 $"SelectedValue: {lbxNumberOfDice.SelectedItem}";
            //TODO change
            DiceRoller.RollDice((int)lbxNumberOfDice.SelectedItem, 6, '+', 0);
            tbxRPText.FontSize = 20;
            tbxRPText.Text = $"Number of Dice      : {DiceRoller.NumberOfDice}\n" +
                             $"Number of Dice Sides: {DiceRoller.NumberOfSides}\n" +
                             $"Modifier            : {DiceRoller.Modifier}\n" +
                             $"Modifier Amount     : {DiceRoller.ModifierAmount}\n" +
                             $"Total               : {DiceRoller.FinalResult}";
        }
    }
}
