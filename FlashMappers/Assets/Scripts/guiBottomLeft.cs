﻿using System.Collections;
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
            GUI.Box(new Rect(0, Screen.height/3 * 2 + 12, Screen.width/3 + 60, Screen.height/3 - 12), "B: " + saveData.chosenCard.definition);
        }
        else if(saveData.questionSlot == 1){
            GUI.Box(new Rect(0, Screen.height/3 * 2 + 12, Screen.width/3 + 60, Screen.height/3 - 12), "B: " + saveData.wrongCard2.definition);
        }
        else{
             GUI.Box(new Rect(0, Screen.height/3 * 2 + 12, Screen.width/3 + 60, Screen.height/3 - 12), "B: " + saveData.wrongCard1.definition);
        }
    }
}
