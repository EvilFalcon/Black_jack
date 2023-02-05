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
        public Card(string cardSuit,string cardValue)
        {
            _cardSuit=cardSuit;
            _cardValue=cardValue;
        }
        
    }

    class CardDeck
    {
        private int _amountCard = 52;
        private int _amountCardDeck = 5;

        List<Card> _cardsDesk;



    }

    class player
    {

    }

    class CasinoDealer
    {

    }
}
