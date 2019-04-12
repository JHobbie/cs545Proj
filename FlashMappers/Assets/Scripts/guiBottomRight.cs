using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guiBottomRight : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnGUI(){
        if(saveData.questionSlot == 3){
            GUI.Box(new Rect(Screen.width/3 * 2 - 60, Screen.height/3 * 2 + 12, Screen.width/3 + 60, Screen.height/3 - 12), "C: " + saveData.chosenCard.definition);
        }
        else{
            System.Random rnd = new System.Random();
            flashCard displayedCard = saveData.loadedCards.allCards[rnd.Next(1,saveData.loadedCards.allCards.Count)];
            while(displayedCard == saveData.chosenCard){
                displayedCard = saveData.loadedCards.allCards[rnd.Next(1,saveData.loadedCards.allCards.Count)];
            }
            GUI.Box(new Rect(Screen.width/3 * 2 - 60, Screen.height/3 * 2 + 12, Screen.width/3 + 60, Screen.height/3 - 12), "C: " + displayedCard.definition);
        }
    }
}
