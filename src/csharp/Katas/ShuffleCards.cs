using System;
using System.Linq;

namespace Katas
{
    public class ShuffleCards : IRunTests
    {
        public int[] ShuffleDeckOfCards()
        {
            int[] cardsArray = Enumerable.Range(1, 52 + 1).ToArray();

            Random random = new Random();
            for (int i = 0; i < cardsArray.Count(); i++)
            {
                int switchIndex = random.Next(0, 52);

                var temp = cardsArray[i];
                cardsArray[i] = cardsArray[switchIndex];
                cardsArray[switchIndex] = temp;
            }

            return cardsArray;
        }

        public void RunTests()
        {
            var cards = ShuffleDeckOfCards();
            Console.WriteLine($"DeckOfCards: [{string.Join(",", cards)}]");
        }
    }
}
