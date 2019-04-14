using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guiBottomLeft : MonoBehaviour
{
    // Start is called before the first frame update
    /*
    int randomNum;
    int randomAnswer1;
    int randomAnswer2;
    */
    private flashCard displayedCard;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnGUI(){
        if(saveData.questionSlot == 2){
            playerMovement.SetBotLeft("B: " + saveData.chosenCard.definition);
        }
        else if(saveData.questionSlot == 1){
            playerMovement.SetBotLeft("B: " + saveData.wrongCard2.definition);
        }
        else{
            playerMovement.SetBotLeft("B: " + saveData.wrongCard1.definition);
        }
    }
}
