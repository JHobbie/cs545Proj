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
            playerMovement.SetBotRight("C: " + saveData.chosenCard.definition);
        }
        else if (saveData.questionSlot == 1){
            playerMovement.SetBotRight("C: " + saveData.wrongCard1.definition);
        }
        else{
            playerMovement.SetBotRight("C: " + saveData.wrongCard2.definition);
        }
    }
}
