using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static setOfCards;

//This is code to display a question in a UI panel 
public class qPanel : MonoBehaviour {

    public GameObject questionPanel;
    public Text questionText;
    public Text choiceText;
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

    private setOfCards cardSet = saveData.loadedCards;

    void DisplayQ (){
        questionPanel.SetActive(true);
        questionText.text = cardSet.allCards[1].word;
        choiceText.text = carSet.allcards[1].definition;
        //questionText.text = "question";
        //choiceText.text = "choices";
    }

    
    
}
