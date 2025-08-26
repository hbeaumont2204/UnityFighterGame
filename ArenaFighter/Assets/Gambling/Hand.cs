using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UIElements.Experimental;

public class Hand
{
    public List<Card> cards;
    public int score;
    public int aces;
    public bool bust;
    public Hand()
    {
        this.cards = new List<Card>();
        this.score = 0;
        this.aces = 0;
        this.bust = false;
    }

    public void addCard(Card newCard)
    {
        cards.Add(newCard);
        score += newCard.value;
        if (newCard.rank == "A")
        {
            aces++;
        }
        isBust();
    }

    public void isBust()
    {
        if (score > 21 && aces == 0)
        {
            bust = true;
        }
        else if (score > 21 && aces > 0)
        {
            score -= 10;
            aces--;
        }
    }
}
