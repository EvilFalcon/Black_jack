using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_jack
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Card
    {
        private string _cardSuit;
        private string _cardValue;

        public Card(string cardSuit, string cardValue)
        {
            _cardSuit = cardSuit;
            _cardValue = cardValue;
        }

    }

    class CardDeck
    {
        private int _amountCardsSuit = 4;
        private int _amountCardsValue = 13;
        private List<Card> _deck;

        private List<string> _cardsSuit = new List<string> { "♣", "♠", "♥", "♦" };
        private List<string> _cardsValue = new List<string> { "T", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "D", "K" };



        private void CreateDeck()
        {

            for (int i = 0; i < _amountCardsValue; i++)
            {
                for (int j = 0; j < _amountCardsSuit; i++)
                {
                    Card card = new Card(_cardsValue[i], _cardsSuit[j]);
                    _deck.Add(card);

                }

            }
        }

        public List<Card> Deck { get; private set;}
    }

    class player
    {

    }

    class CasinoDealer
    {


    }
}
