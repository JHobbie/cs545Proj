using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//This is code to display a question in a UI panel 
public class qPanel : MonoBehaviour {

    public GameObject questionPanel;
    public Text questionText;
    public Text choiceText;

    // Start is called before the first frame update
    void Start(){
        //questionPanel = GameObject.find("QuestionPanel");
        questionPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update(){
        //check for current scene, then run DisplayQ
    }

    void DisplayQ (){
        questionPanel.SetActive(true);
        questionText.text = "question";
        choiceText.text = "3 choices";
    }
    
}
