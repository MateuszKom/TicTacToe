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

namespace Tictactoe
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool IsPlayer1Turn { get; set; }
        public int Counter { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            NewGame();
        }

        public void NewGame()
        {
            IsPlayer1Turn = false;
            Counter = 0;
            ButtonR0C0.Content = string.Empty;
            ButtonR1C0.Content = string.Empty;
            ButtonR2C0.Content = string.Empty;
            ButtonR0C1.Content = string.Empty;
            ButtonR1C1.Content = string.Empty;
            ButtonR2C1.Content = string.Empty;
            ButtonR0C2.Content = string.Empty;
            ButtonR1C2.Content = string.Empty;
            ButtonR2C2.Content = string.Empty;

            ButtonR0C0.Background = Brushes.White;
            ButtonR1C0.Background = Brushes.White;
            ButtonR2C0.Background = Brushes.White;
            ButtonR0C1.Background = Brushes.White;
            ButtonR1C1.Background = Brushes.White;
            ButtonR2C1.Background = Brushes.White;
            ButtonR0C2.Background = Brushes.White;
            ButtonR1C2.Background = Brushes.White;
            ButtonR2C2.Background = Brushes.White;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (IsPlayer1Turn)
            {
                IsPlayer1Turn = false;
            }
            else
            {
                IsPlayer1Turn = true;
            }
            var button = sender as Button;
            button.Content = IsPlayer1Turn ? "O" : "X";

            Counter++;
            if (Counter > 9)
            {
                NewGame();
                return;
            }

            if (ChceckIfPlayerWon())
            {
                Counter = 9;
            }

        }

        private bool ChceckIfPlayerWon()
        {
            if (ButtonR0C0.Content.ToString() != string.Empty && ButtonR0C0.Content == ButtonR1C0.Content && ButtonR1C0.Content == ButtonR2C0.Content)
            {
                ButtonR0C0.Content = Brushes.Green;
                ButtonR1C0.Content = Brushes.Green;
                ButtonR2C0.Content = Brushes.Green;
                return true;
            }
            if (ButtonR0C1.Content.ToString() != string.Empty && ButtonR0C1.Content == ButtonR1C1.Content && ButtonR1C1.Content == ButtonR2C1.Content)
            {
                ButtonR0C1.Content = Brushes.Green;
                ButtonR1C1.Content = Brushes.Green;
                ButtonR2C1.Content = Brushes.Green;
                return true;
            }
            if (ButtonR0C2.Content.ToString() != string.Empty && ButtonR0C2.Content == ButtonR1C2.Content && ButtonR1C2.Content == ButtonR2C2.Content)
            {
                ButtonR0C2.Content = Brushes.Green;
                ButtonR1C2.Content = Brushes.Green;
                ButtonR2C2.Content = Brushes.Green;
                return true;
            }
            if (ButtonR0C0.Content.ToString() != string.Empty && ButtonR0C0.Content == ButtonR0C1.Content && ButtonR0C1.Content == ButtonR0C2.Content)
            {
                ButtonR0C0.Content = Brushes.Green;
                ButtonR0C1.Content = Brushes.Green;
                ButtonR0C2.Content = Brushes.Green;
                return true;
            }
            if (ButtonR1C0.Content.ToString() != string.Empty && ButtonR1C0.Content == ButtonR1C1.Content && ButtonR1C1.Content == ButtonR1C2.Content)
            {
                ButtonR0C0.Content = Brushes.Green;
                ButtonR1C1.Content = Brushes.Green;
                ButtonR1C2.Content = Brushes.Green;
                return true;
            }
            if (ButtonR2C0.Content.ToString() != string.Empty && ButtonR2C0.Content == ButtonR2C1.Content && ButtonR2C1.Content == ButtonR2C2.Content)
            {
                ButtonR2C0.Content = Brushes.Green;
                ButtonR2C1.Content = Brushes.Green;
                ButtonR2C2.Content = Brushes.Green;
                return true;
            }
            if (ButtonR0C0.Content.ToString() != string.Empty && ButtonR0C0.Content == ButtonR1C1.Content && ButtonR1C1.Content == ButtonR2C2.Content)
            {
                ButtonR0C0.Content = Brushes.Green;
                ButtonR1C1.Content = Brushes.Green;
                ButtonR2C2.Content = Brushes.Green;
                return true;
            }
            if (ButtonR0C2.Content.ToString() != string.Empty && ButtonR0C2.Content == ButtonR1C1.Content && ButtonR1C1.Content == ButtonR2C0.Content)
            {
                ButtonR0C2.Content = Brushes.Green;
                ButtonR1C1.Content = Brushes.Green;
                ButtonR2C0.Content = Brushes.Green;
                return true;
            }
            return false;
        }
    }
}
