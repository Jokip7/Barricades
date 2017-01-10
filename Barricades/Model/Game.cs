using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barricades.Model
{
    class Game
    {
        private Board board;

        private Dice dice;

        private List<Player> players;

        private Player playerInTurn;

        private const int NUMBER_OF_PLAYERS = 4;

        public Game()
        {
            board = new Board();
            dice = new Dice();
        }

        public void startGame()
        {
            board.generate();
            playGame();
        }

        public void generatePlayers()
        {
            players = new List<Player>();
            for (int i = 0; i < NUMBER_OF_PLAYERS; i++)
            {
                players.Add(new Player(i));
            }
        }

        public void playGame()
        {
            while (!gameOver())
            {
                playTurn();
            }
        }

        public void playTurn()
        {
            switchTurn();


        }

        private void switchTurn()
        {
            if (playerInTurn == null)
                playerInTurn = players[0];
            else
                playerInTurn = players[playerInTurn.playerNumber + 1 % NUMBER_OF_PLAYERS];
        }

        private bool gameOver()
        {
            return board.finishOccupied();
        }

    }
}
