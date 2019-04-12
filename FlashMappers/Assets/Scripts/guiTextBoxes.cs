using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guiTextBoxes : MonoBehaviour
{
    // Start is called before the first frame update

    public guiBottomLeft bLeft;
    public guiBottomRight bRight;

    public guiTopRight tRight;

    public guiTopLeft tLeft;

    void Start()
    {
        saveData.numCardsLeft = saveData.loadedCards.allCards.Count;
        bLeft = GetComponent<guiBottomLeft>();
        bRight = GetComponent<guiBottomRight>();
        tRight = GetComponent<guiTopRight>();
        tLeft = GetComponent<guiTopLeft>();

        bLeft.enabled = false;
        bRight.enabled = false;
        tRight.enabled = false;
        tLeft.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void turnOn()
    {
        //Generate Random Question
        //GEt answer
        //Select which box answer goes in
        //After answer selected fill in boxes from A-C
        System.Random rnd = new System.Random();
        saveData.chosenCard = saveData.loadedCards.allCards[rnd.Next(1, saveData.loadedCards.allCards.Count)];
        while (saveData.chosenCard.seenYet == true)
        {
            saveData.chosenCard = saveData.loadedCards.allCards[rnd.Next(1, saveData.loadedCards.allCards.Count)];
        }
        saveData.questionSlot = rnd.Next(1, 4);
        saveData.wrongCard1 = saveData.loadedCards.allCards[rnd.Next(1, saveData.loadedCards.allCards.Count)];
        while (saveData.wrongCard1 == saveData.chosenCard)
        {
            saveData.wrongCard1 = saveData.loadedCards.allCards[rnd.Next(1, saveData.loadedCards.allCards.Count)];
        }
        saveData.wrongCard2 = saveData.loadedCards.allCards[rnd.Next(1, saveData.loadedCards.allCards.Count)];
        while (saveData.wrongCard2 == saveData.chosenCard)
        {
            saveData.wrongCard2 = saveData.loadedCards.allCards[rnd.Next(1, saveData.loadedCards.allCards.Count)];
        }
        Camera.main.GetComponent<guiBottomLeft>().enabled = true;
        Camera.main.GetComponent<guiBottomRight>().enabled = true;
        Camera.main.GetComponent<guiTopRight>().enabled = true;
        Camera.main.GetComponent<guiTopLeft>().enabled = true;
    }

    public static void turnOff()
    {
        Camera.main.GetComponent<guiBottomLeft>().enabled = false;
        Camera.main.GetComponent<guiBottomRight>().enabled = false;
        Camera.main.GetComponent<guiTopRight>().enabled = false;
        Camera.main.GetComponent<guiTopLeft>().enabled = false;
    }
}
