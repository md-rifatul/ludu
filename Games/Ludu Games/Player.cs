using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Ludu_Games
{
    public class Player
    {

        private string Name { get; set; }
        private string Colore {  get; set; }

        public string Id {  get; set; }


        public Player() { }

        public Player(string name, string colore)
        {
            Name = name;
            Colore = colore;
        }

        public void Toss()
        {
            Id = new RandomNumber().Genarate();
            Pirnt();

        }
        




        public void Pirnt()
        {
            string board = new Board().PrintBoard();

            char[] ssArray = board.ToCharArray();



            for (int i = 0; i < ssArray.Length; i++)
            {

                if (ssArray[i] >= '0' && ssArray[i] <= '9' || ssArray[i] >= 'a' && ssArray[i] <= 't')
                {
                    Console.Write(' ');
                }
                else
                {
                    Console.Write(ssArray[i]);
                }


            }
        }


    }
}
