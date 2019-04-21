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
        saveData.chosenCard = saveData.loadedCards.allCards[rnd.Next(0, saveData.loadedCards.allCards.Count)];
        while (saveData.chosenCard.seenYet == true && saveData.numCardsLeft > 0)
        {
            Debug.Log("Picking another card");
            saveData.chosenCard = saveData.loadedCards.allCards[rnd.Next(0, saveData.loadedCards.allCards.Count)];
            Debug.Log(saveData.chosenCard);
            Debug.Log(saveData.numCardsLeft);
        }
        if (saveData.numCardsLeft <= 0)
        {
            for( int i = 0; i < saveData.loadedCards.allCards.Count; i++){
                saveData.loadedCards.allCards[i].seenYet = false;
                Debug.Log("Ending Game");
            }
            Serializer.Save<setOfCards>(Serializer.GetSavePath(saveData.loadedCards.setName), saveData.loadedCards);
            SceneManager.LoadScene("winScreen", LoadSceneMode.Single);
        }
        saveData.questionSlot = rnd.Next(1, 4);
        saveData.wrongCard1 = saveData.loadedCards.allCards[rnd.Next(0, saveData.loadedCards.allCards.Count)];
        while (saveData.wrongCard1 == saveData.chosenCard)
        {
            saveData.wrongCard1 = saveData.loadedCards.allCards[rnd.Next(0, saveData.loadedCards.allCards.Count)];
        }
        saveData.wrongCard2 = saveData.loadedCards.allCards[rnd.Next(0, saveData.loadedCards.allCards.Count)];
        while (saveData.wrongCard2 == saveData.chosenCard)
        {
            saveData.wrongCard2 = saveData.loadedCards.allCards[rnd.Next(0, saveData.loadedCards.allCards.Count)];
        }
        if (saveData.questionSlot == 2)
        {
            playerMovement.SetBotLeft("B: " + saveData.chosenCard.definition);
            playerMovement.SetBotRight("C: " + saveData.wrongCard2.definition);
            playerMovement.SetTopRight("A: " + saveData.wrongCard1.definition);
        }
        else if (saveData.questionSlot == 1)
        {
            playerMovement.SetBotLeft("B: " + saveData.wrongCard2.definition);
            playerMovement.SetBotRight("C: " + saveData.wrongCard1.definition);
            playerMovement.SetTopRight("A: " + saveData.chosenCard.definition);
        }
        else
        {
            playerMovement.SetBotLeft("B: " + saveData.wrongCard1.definition);
            playerMovement.SetBotRight("C: " + saveData.chosenCard.definition);
            playerMovement.SetTopRight("A: " + saveData.wrongCard2.definition);
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
