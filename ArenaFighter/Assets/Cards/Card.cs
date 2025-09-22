using UnityEngine;

public class Card
{
    public string suit; // Hearts,Diamonds,Clubs,Spades
    public int value; // 1-11
    public string rank; // 2-10, J,Q,K,A

    // Add image reference variable 

    public Card(string cardSuit, string cardRank)
    {
        this.suit = cardSuit;
        this.rank = cardRank;
        this.value = calculateValue(cardRank);
    }

    int calculateValue(string cardRank)
    {
        if (cardRank == "J" || cardRank == "Q" || cardRank == "K")
        {
            return 10;
        }
        if (cardRank == "A")
        {
            return 11;
        }
        else
        {
            return int.Parse(cardRank);
        }
    }
    
}
