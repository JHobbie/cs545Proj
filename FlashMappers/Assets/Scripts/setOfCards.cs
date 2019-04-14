using System;
using System.Collections.Generic;
[Serializable]
public class flashCard
{
    public string word;
    public string definition;
    public bool seenYet = false;

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
    public override string ToString()
    {
        return "Flashcard: \nWord: " + this.word + " \nDefinition: " + this.definition + " \n Seen Yet: " + this.seenYet;
    }

}
[Serializable]
public class setOfCards
{
    public string setName;
    public List<flashCard> allCards;
    public List<flashCard> frequentlyFailed;
    public bool allSeen;
    public setOfCards()
    {
        setName = "NamelessSet";
        allCards = new List<flashCard>();
        frequentlyFailed = new List<flashCard>();
        allSeen = false;
    }
    public setOfCards(string setName)
    {
        this.setName = setName;
        allCards = new List<flashCard>();
        frequentlyFailed = new List<flashCard>();
        allSeen = false;
    }
    public void addCard(flashCard addedCard){
        allCards.Add(addedCard);
    }

}
