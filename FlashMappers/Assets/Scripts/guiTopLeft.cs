using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guiTopLeft : MonoBehaviour
{
    // Start is called before the first frame update
    private string parsedString;
    void Start()
    {
        parsedString = guiTextBoxes.stringCut(saveData.chosenCard.word);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnGUI(){

        if(playerMovement.fromLeft){
            GUI.Box(new Rect(0, 0, Screen.width/3 + 60, Screen.height/3 - 12), "Question: " + parsedString);
        }
        else if(playerMovement.fromRight){
            GUI.Box(new Rect(0, 0, Screen.width/3 + 60, Screen.height/3 - 12), "Question: " + parsedString);

        }
        else if(playerMovement.fromTop){
            GUI.Box(new Rect(0, 0, Screen.width/3 + 60, Screen.height/3 - 12), "Question: " + parsedString);
        }
        else if(playerMovement.fromBottom){
            GUI.Box(new Rect(0, 0, Screen.width/3 + 60, Screen.height/3 - 12), "Question: " + parsedString);
        }
        else{
            return;
        }

    }


}
