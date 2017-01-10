using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barricades.Model
{
    class Game
    {
        public Board board;

        public Dice dice;

        private List<Player> players;

        public Player playerInTurn;

        private const int NUMBER_OF_PLAYERS = 4;

        public Game()
        {
            board = new Board();
            dice = new Dice();
        }

        public void startGame()
        {
            board.generate();
            generatePlayers();
        }

        public void generatePlayers()
        {
            players = new List<Player>();
            for (int i = 0; i < NUMBER_OF_PLAYERS; i++)
            {
                players.Add(new Player(i, board.FirstSquares[i]));
                board.FirstSquares[i].number = i + 1;
            }
            playerInTurn = players[0];
        }

        public void switchTurn()
        {
                playerInTurn = players[playerInTurn.playerNumber + 1 % NUMBER_OF_PLAYERS - 1];
        }

        public bool gameOver()
        {
            return board.finishOccupied();
        }

    }
}
