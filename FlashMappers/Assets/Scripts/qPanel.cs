using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static setOfCards;

//This is code to display a question in a UI panel 
public class qPanel : MonoBehaviour {

    public static GameObject questionPanel;
    public static Text questionText;
    public static Text choiceText;
    public static bool isAnswered = false;

    // Start is called before the first frame update
    void Start(){
        //questionPanel = GameObject.find("QuestionPanel");
        questionPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update(){
        //check for current scene, then run DisplayQ
    }

    private static setOfCards cardSet = saveData.loadedCards;

    public static void DisplayQ (){
        questionPanel.SetActive(true);
        questionText.text = cardSet.allCards[1].word;
        choiceText.text = cardSet.allCards[1].definition;
        //questionText.text = "question";
        //choiceText.text = "choices";
        Debug.Log("we made it.");
    }

    
    
}
