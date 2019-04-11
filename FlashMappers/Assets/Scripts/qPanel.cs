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
    //public static bool isAnswered = false;

    // Start is called before the first frame update
    //public static setOfCards cardSet = saveData.loadedCards.allCards;
    void Start(){
        //questionPanel = GameObject.Find("QuestionPanel");
        //questionPanel.SetActive(false);
        
    }

    // Update is called once per frame
    void Update(){
        //check for current scene, then run DisplayQ
    }

    public static void DisplayQ (){
        //questionPanel.SetActive(true);
        //questionPanel.
        //questionText.text = cardSet.allCards[0].word;
        //choiceText.text = cardSet.allCards[0].definition;
        //if(questionPanel.GetComponent<UnityEngine.UI.Text>().text == null){
        //    Debug.Log("why");
        //}
        //choiceText.text = "choices";
        //Debug.Log("hi");
        /* the console says "hi" when the player stops, but when I try to display
        the text from the flashcard it gives a NullReferenceError. */
        
    }

    
    
}
