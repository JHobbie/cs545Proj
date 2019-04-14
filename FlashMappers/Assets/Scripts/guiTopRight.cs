using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guiTopRight : MonoBehaviour
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
        if(saveData.questionSlot == 1){
            playerMovement.SetTopRight("A: " + saveData.chosenCard.definition);
        }
        else if (saveData.questionSlot == 2){
            playerMovement.SetTopRight("A: " + saveData.wrongCard1.definition);
        }
        else{
            playerMovement.SetTopRight("A: " + saveData.wrongCard2.definition);
        }

    }
}
