using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Game
{
    class GameLogic
    {
        // Let's instance this class, so we can use it wherever we like
        private static GameLogic _instance;
        public static GameLogic Instance = _instance ?? (_instance = new GameLogic());

        // Setup our players, static here as it's just an example.
        private readonly List<Player> _players = new List<Player>()
        {
            new Player()
            {
                PlayerPiece = Pieces.X,
                PlayerType = Player.PlayerTypeEnum.Human
            },
            new Player()
            {
                PlayerType = Player.PlayerTypeEnum.Computer,
                PlayerPiece = Pieces.O
            }
        };

        // Game logic memory, such as board positions, what player is going, etc
        public enum Pieces { NoBody, X, O }
        private const int Columns = 3;
        private const int Rows = 3;

        private readonly int[,] _board = new int[Rows,Columns];

        // Event raised for our form to render the game board again.
        public delegate void OnBoardUpdated();
        public event OnBoardUpdated BoardUpdated;

        // Game settings
        public enum AIPlayStyle { Random, AlwaysWins, NeverWins }
        public AIPlayStyle GameDifficulty = AIPlayStyle.Random; //Random by default

        // For the AI, it will compute the next move
        public void ComputerPlay()
        {
            var computerPlayer = _players.First(x => x.PlayerType == Player.PlayerTypeEnum.Computer);

            if (GameDifficulty == AIPlayStyle.Random)
            {
                // Obtain a list of unplaced positions in the game board, and select one at random to be played
                var unclaimedBoardPositions = GetUnclaimedBoardPositions();

                // Error checking
                if (unclaimedBoardPositions.Count().Equals(0) )
                    throw new Exception("No more moves to make, unable to place down a piece");

                // Pick a random position
                var rand = new Random();
                var chosenPosition = unclaimedBoardPositions.ElementAt(rand.Next(unclaimedBoardPositions.Count()));

                // Make our move
                MakeMove(computerPlayer, chosenPosition);
            }

            if (GameDifficulty == AIPlayStyle.AlwaysWins)
            {
                var chosenPosition = GetNextBestMove();
            }
        }

        // Gets the next best move that the AI can make
        // this method is only invoked if AlwaysWins is selected as the computers strategy
        private int GetNextBestMove()
        {
            return 0;
        }

        // Returns the human player
        public Player GetHumanPlayer() => _players.Where(x => x.PlayerType == Player.PlayerTypeEnum.Human).DefaultIfEmpty(null).FirstOrDefault();

        private List<int> GetUnclaimedBoardPositions()
        {
            var positions = new List<int>();

            for (var i = 0; i <= _board.Length; i++)
            {
                if ( !IsOccupied(i) )
                    positions.Add(i);
            }

            return positions;
        }

        public void MakeMove(Player player, int position)
        {
            /*
             * Position values start at zero, and end at eight
             * Zero being the top left, one being top middle, and so on.
             */


            // Raise our event
            BoardUpdated?.Invoke();
        }

        // Checks if an int position is occupied
        private bool IsOccupied(int position)
        {
            var p = GetPointFromPosition(position);
            return IsOccupied(p.X, p.Y);
        }

        // Checks if a point position is occupied
        private bool IsOccupied(int x, int y)
        {
            return _board[x, y] == 0;
        }

        private int GetPieceNumber(Pieces piece)
        {
            if (piece == Pieces.X)
                return 1;
            else
                return 2;
        }

        private Point GetPointFromPosition(int position)
        {
            var p = new Point();
            p.X = position / Columns;
            p.Y = position % Rows;
            return p;
        }
    }
}