using System;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    public List<Card> cardDeck = new List<Card>();
    private string[] suits = { "Hearts", "Diamonds", "Spades", "Clubs" };
    private string[] ranks = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };

    void Start()
    {
        createDeck();
    }

    void createDeck()
    {
        foreach (string suit in suits)
        {
            foreach (string rank in ranks)
            {
                Card newCard = new Card(suit, rank);
                cardDeck.Add(newCard);
            }
        }
        shuffle(cardDeck);
    }

    void shuffle(List<Card> deck)
    {
        System.Random random = new System.Random();
        for (int i = deck.Count - 1; i > 0; i--)
        {
            int j = random.Next(0, i + 1);

            Card temp = deck[i];
            deck[i] = deck[j];
            deck[j] = temp;
        }
    }

    public Card draw()
    {
        if (cardDeck.Count == 0)
        {
            return null;
        }
        else
        {
            Card drawnCard = cardDeck[0];
            cardDeck.RemoveAt(0);
            return drawnCard;
        }
    }
}
