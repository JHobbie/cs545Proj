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
        if(playerMovement.fromLeft){
            GUI.Box(new Rect(Screen.width/3 * 2 - 60 , 0, Screen.width/3 + 60, Screen.height/3 - 12), "A: " + saveData.loadedCards.allCards[0].definition);
        }
        else if(playerMovement.fromRight){
            GUI.Box(new Rect(Screen.width/3 * 2 - 60 , 0, Screen.width/3 + 60, Screen.height/3 - 12), "A: " + saveData.loadedCards.allCards[0].definition);

        }
        else if(playerMovement.fromTop){
            GUI.Box(new Rect(Screen.width/3 * 2 - 60 , 0, Screen.width/3 + 60, Screen.height/3 - 12), "C: " + saveData.loadedCards.allCards[0].definition);
        }
        else if(playerMovement.fromBottom){
            GUI.Box(new Rect(Screen.width/3 * 2 - 60 , 0, Screen.width/3 + 60, Screen.height/3 - 12), "B: " + saveData.loadedCards.allCards[0].definition);
        }
        else{
            return;
        }

    }
}
