using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Game
{
    class Player
    {
        public enum PlayerTypeEnum { Computer, Human }
        public PlayerTypeEnum PlayerType;
        public GameLogic.Pieces PlayerPiece;
    }
}
