using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Black_jack
{
    class Program
    {
        static void Main(string[] args)
        {
            Casino casino = new Casino();
            casino.Play();
        }


    }

    class Casino
    {
        private Player _player = new Player();
        private CasinoDealer _casinoDealer = new CasinoDealer();
        private List<Card> _card = new List<Card>();
        public void Play()
        {
            const string CommandGetCard = "1";
            const string CommandNotTakeCard = "2";
            const string CommandExitGame = "3";

            bool isWork = true;

            while (isWork)
            {
                switch (Console.ReadLine())
                {
                    case CommandGetCard:

                        break;

                    case CommandNotTakeCard:

                        break;

                    case CommandExitGame:
                        isWork = false;
                        break;

                    default:
                        Console.WriteLine("");
                        break;
                }
            }
        }


    }

    class Player
    {
        List<Card> _hand = new List<Card>();

        public void TakeCard(Card card) /*добрать карту */
        {
            _hand.Add(card);
        }

        public void BringBackCard(List<Card> cards)//возврат карт
        {
            for (int i = 0; i < _hand.Count; i++)
            {
                cards.Add(_hand[i]);
                _hand.RemoveAt(i);
            }
        }

        public void ShowHandInfo()//вывод информации о картах игрока
        {
            foreach (Card card in _hand)
            {
                card.ShowInfo();
            }
        }

    }

    class CasinoDealer
    {
        private List<Card> _hand = new List<Card>();
        private CardDeck _deck = new CardDeck();



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

        public int AccruePoints(Card[] card)  /*логика очков за карты */
        {
            int cardPoint = 0;

            return cardPoint;
        }

        public void ShowInfo() /*вывод карт со значением*/
        {
            Console.WriteLine($"Масть карты {_cardSuit}, значение карты {_cardSuit}");
        }
    }

    class CardDeck
    {
        private static Random random = new Random();

        private List<Card> _deck = new List<Card>();


        public CardDeck()
        {
            FillDeck();
        }

        private void FillDeck()
        {
            List<string> _cardsValue = new List<string> { "T", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "D", "K" };
            List<string> _cardsSuit = new List<string> { "♣", "♠", "♥", "♦" };

            for (int i = 0; i < _cardsValue.Count; i++)
            {
                for (int j = 0; j < _cardsSuit.Count; j++)
                {
                    Card card = new Card(_cardsValue[i], _cardsSuit[j]);
                    _deck.Add(card);
                }
            }

            Shuffle(_deck);
        }

        public void Shuffle(List<Card> cards)
        {
            for (int i = 0; i < _deck.Count; i++)
            {
                int indexCard = random.Next(_deck.Count);
                (_deck[i], _deck[indexCard]) = (_deck[indexCard], _deck[i]);

            }
        }



    }

}
