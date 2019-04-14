using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class guiTextBoxes : MonoBehaviour
{
    // Start is called before the first frame update


    void Start()
    {
        saveData.numCardsLeft = saveData.loadedCards.allCards.Count;
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
        while (saveData.chosenCard.seenYet == true && saveData.numCardsLeft > 0)
        {
            saveData.chosenCard = saveData.loadedCards.allCards[rnd.Next(1, saveData.loadedCards.allCards.Count)];
        }
        if (saveData.numCardsLeft <= 0)
        {
            SceneManager.LoadScene("mainMenu", LoadSceneMode.Single);
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
    }

    public static void turnOff()
    {
        playerMovement.SetTopLeft("");
        playerMovement.SetTopRight("");
        playerMovement.SetBotLeft("");
        playerMovement.SetBotRight("");
    }
}
