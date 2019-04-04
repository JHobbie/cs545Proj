using System;
using System.Collections.Generic;
public class flashCard
{
    private string word;
    private string definition;
    private bool seenYet;

    // Constructor that takes no arguments:
    public flashCard()
    {
        word = "";
        definition = "";
        seenYet = false;
    }
    public flashCard(string word, string definition)
    {
        this.word = word;
        this.definition = definition;
        seenYet = false;
    }

}
public class setOfCards
{
    private string setName;
    private List<flashCard> allCards;
    private List<flashCard> frequentlyFailed;
    public setOfCards(string setName)
    {
        this.setName = setName;
        allCards = new List<flashCard>();
        frequentlyFailed = new List<flashCard>();
    }
    public void addCard(flashCard addedCard){
        allCards.Add(addedCard);
    }

}
