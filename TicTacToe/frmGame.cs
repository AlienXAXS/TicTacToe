using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class FrmGame : Form
    {
        public FrmGame()
        {
            InitializeComponent();

            // Listen to our events
            Game.GameLogic.Instance.BoardUpdated += () =>
            {
                // Re-Render the board here

            };
        }

        private void btnClick(object sender, EventArgs e)
        {
            // Ensure that the button being passed into this method is indeed a button, not something else random
            // while not stricly needed, it's good practice to check these things.
            if (sender is Button button)
            {
                // Get the button index position, based off the tag
                int buttonPosition = int.Parse(button.Tag.ToString());

                // Pass our move to the game logic
                Game.GameLogic.Instance.MakeMove(Game.GameLogic.Instance.GetHumanPlayer(), buttonPosition);
            }
        }

        private void FrmGame_Load(object sender, EventArgs e)
        {

        }
    }
}
