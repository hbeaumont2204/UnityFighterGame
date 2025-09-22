using UnityEngine;
using System;
using System.Collections.Generic;

public class Game : MonoBehaviour
{
    // Add variable for player chips (money)

    Deck deck;
    int dealerChips = 500;
    int playerChips = 500;

    Hand playerHand;
    Hand dealerHand;


    void startGame()
    {
        
    }

    void hit(Hand currentHand)
    {
        currentHand.addCard(deck.cardDeck[0]);
         if (checkBust(currentHand))
        {
            // Lose state
        }
    }

    bool checkBust(Hand currentHand)
    {
        return currentHand.bust;
    }

    void dealerTurn()
    {
        while (dealerHand.score < 17)
        {
            hit(dealerHand);
        }
    }

    // Buttons
    void hitButton()
    {
        hit(playerHand);
    }

    void stand()
    {
        dealerTurn();
    }

    void doubleDown()
    {
        // Add later
    }
    
}
