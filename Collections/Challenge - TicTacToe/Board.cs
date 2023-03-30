using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Challenge___TicTacToe
{
    internal class Board
    {
        private char[,] _board;
        private char _currentPlayer;
        public Board() {
            _board = new char[,] { { '1', '2', '3' }, { '4', '5', '6' }, { '7', '8', '9' } };
            _currentPlayer = 'X';
        }

        public void NextTurn() 
        {
            if (_currentPlayer == 'X')
                _currentPlayer = 'O';
            else
                _currentPlayer = 'X';
        }

        public bool FillBox(char box) {
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {
                    if (_board[i, j] == box)
                    {
                        _board[i, j] = _currentPlayer;
                        return true;
                    }                    
                }  
            }
            return false;
            
        }

        public bool GameIsWon()
        {
            if (_board[0, 0] == _board[1, 1] && _board[1, 1] == _board[2, 2])
                return true;
            if (_board[0, 2] == _board[1, 1] && _board[1, 1] == _board[2, 0])
                return true;

            for (int i = 0; i < 3; i++)
            {
                if (_board[i, 0] == _board[i, 1] && _board[i, 2] == _board[i, 0])
                    return true;
                if (_board[0, i] == _board[1, i] && _board[1, i] == _board[2, i])
                    return true;
            }
            return false;
        }

        public void PrintBoard() {
            Console.WriteLine("{0}|{1}|{2}", _board[0,0], _board[0,1], _board[0,2]);
            Console.WriteLine("------");
            Console.WriteLine("{0}|{1}|{2}", _board[1, 0], _board[1, 1], _board[1, 2]);
            Console.WriteLine("------"); 
            Console.WriteLine("{0}|{1}|{2}", _board[2, 0], _board[2, 1], _board[2, 2]);
        }

        public bool BoardIsComplete()
        {
            foreach (char box in _board)
            {
                if (char.IsDigit(box))
                    return false;
            }
            return true;
        }

        public void Play()
        {
            Console.Clear();
            while (!GameIsWon() && !BoardIsComplete())
            {
                PrintBoard();
                Console.WriteLine("\nCurrent player {0}", _currentPlayer);
                Console.WriteLine("Enter the number of space to fill:");
                if (char.TryParse(Console.ReadLine(), out char box))
                {
                    if (FillBox(box))
                    {
                        NextTurn();
                    }
                    else
                        Console.WriteLine("Unavailable space");
                }
                else
                    Console.WriteLine("Invalid space");
                Console.Clear();
            }
            if (GameIsWon())
            {
                NextTurn();
                Console.WriteLine("Winner is {0}, Congratulations!", _currentPlayer);
            }
            else
                Console.WriteLine("Draw!");
        }

        // TODO: make this function to actually works
        public bool GameIsWinnable() { return false; }
    }
}
