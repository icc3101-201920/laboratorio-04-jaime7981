using Laboratorio_3_OOP_201902.Cards;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Laboratorio_3_OOP_201902
{
    public class Game
    {
        //Atributos
        private Player[] players;
        private Player activePlayer;
        private List<Deck> decks;
        private Board boardGame;
        private bool endGame;

        //Constructor
        public Game()
        {

        }

        //Propiedades
        public Player[] Players
        {
            get
            {
                return this.players;
            }
        }
        public Player ActivePlayer
        {
            get
            {
                return this.activePlayer;
            }
            set
            {
                activePlayer = value;
            }
        }
        public List<Deck> Decks
        {
            get
            {
                return this.decks;
            }
        }
        public Board BoardGame
        {
            get
            {
                return this.boardGame;
            }
        }
        public bool EndGame
        {
            get
            {
                return this.endGame;
            }
            set
            {
                endGame = value;
            }
        }

        //Metodos
        public bool CheckIfEndGame()
        {
            if (players[0].LifePoints == 0 || players[1].LifePoints == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int GetWinner()
        {
            if (players[0].LifePoints == 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public void Play()
        {
            throw new NotImplementedException();
        }

        public void ReadDecks()
        {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + @"\Files\Decks.txt";
            StreamReader reader = new StreamReader(path);
            List<string> ListPlayerOne = new List<string>();
            List<string> ListPlayerTwo = new List<string>();

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                while (line != "END")
                {
                    if (line != "START")
                    {
                        ListPlayerOne.Add("line");
                        Console.WriteLine("line");
                    }
                }
                while (line != "END")
                {
                    if (line != "START")
                    {
                        ListPlayerTwo.Add("line");
                        Console.WriteLine("line");
                    }
                }
            }
        }
    }
}
