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
            GUI.Box(new Rect(Screen.width/3 * 2 - 60 , 0, Screen.width/3 + 60, Screen.height/3 - 12), "A: " + saveData.chosenCard.definition);
        }
        else if (saveData.questionSlot == 2){
            GUI.Box(new Rect(Screen.width/3 * 2 - 60 , 0, Screen.width/3 + 60, Screen.height/3 - 12), "A: " + saveData.wrongCard1.definition);
        }
        else{
            GUI.Box(new Rect(Screen.width/3 * 2 - 60 , 0, Screen.width/3 + 60, Screen.height/3 - 12), "A: " + saveData.wrongCard2.definition);
        }

    }
}
