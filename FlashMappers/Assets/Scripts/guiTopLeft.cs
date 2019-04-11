using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guiTopLeft : MonoBehaviour
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
            GUI.Box(new Rect(0, 0, Screen.width/3 + 60, Screen.height/3 - 12), "Question: " + saveData.loadedCards.allCards[0].word);
        }
        else if(playerMovement.fromRight){
            GUI.Box(new Rect(0, 0, Screen.width/3 + 60, Screen.height/3 - 12), "Question: " + saveData.loadedCards.allCards[0].word);

        }
        else if(playerMovement.fromTop){
            GUI.Box(new Rect(0, 0, Screen.width/3 + 60, Screen.height/3 - 12), "Question: " + saveData.loadedCards.allCards[0].word);
        }
        else if(playerMovement.fromBottom){
            GUI.Box(new Rect(0, 0, Screen.width/3 + 60, Screen.height/3 - 12), "Question: " + saveData.loadedCards.allCards[0].word);
        }
        else{
            return;
        }

    }
}
