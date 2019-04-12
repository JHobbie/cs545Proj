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
        else if (saveData.questionSlot == 1){
            GUI.Box(new Rect(Screen.width/3 * 2 - 60, Screen.height/3 * 2 + 12, Screen.width/3 + 60, Screen.height/3 - 12), "C: " + saveData.wrongCard1.definition);
        }
        else{
             GUI.Box(new Rect(Screen.width/3 * 2 - 60, Screen.height/3 * 2 + 12, Screen.width/3 + 60, Screen.height/3 - 12), "C: " + saveData.wrongCard2.definition);
        }
    }
}
